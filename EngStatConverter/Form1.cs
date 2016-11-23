using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace EngStatConverter
{

    public partial class Form1 : Form
    {
        string NewLine = System.Environment.NewLine;
        
        private List<string> SelectionList = new List<string>();
        private List<int> SelectionIndexList = new List<int>();
        private List<string> rows = new List<string>();
        private string headerLine;

        public Form1()
        {
            InitializeComponent();
            SelectionList.Clear();
        }

        public void SetSelection (List<string> List)
        {
            SelectionList = List;
        }

        private void WriteLog(string entry)
        {
            Log.Text += DateTime.Now.ToString() + ":" + entry + NewLine;
            Log.SelectionStart = Log.TextLength;
            Log.ScrollToCaret();
            Log.Refresh();
        }

        private void ChooseSourceFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (File.Exists(openFileDialog1.FileName))
                Log.Text = Log.Text + "CSV File: " + openFileDialog1.FileName + NewLine;
        }

        private void SelectColumnsBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(openFileDialog1.FileName))
            {
                DataSelection SelectionForm = new DataSelection();

                if (SelectionList.Count > 0)
                    SelectionForm.SetSelectionList(SelectionList);

                SelectionForm.SetFilename(openFileDialog1.FileName);
                SelectionForm.ShowDialog();

                SelectionList = SelectionForm.GetSelectionList();

                foreach (string line in SelectionList)
                {
                    Log.Text = Log.Text + line + NewLine;
                }

            }
            else MessageBox.Show("No valid CSV File choosen");
        }

        private void StartConversionBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(openFileDialog1.FileName))
                if (SelectionList.Count > 0)
                {
                    WriteLog("Start Processing");
                    listView1.BeginUpdate();
                    listView1.ListViewItemSorter = null;
                    listView1.Clear();
                    rows.Clear();
                    using (var stream = File.OpenRead(openFileDialog1.FileName))
                    using (var reader = new StreamReader(stream))
                    {
                        var data = CsvParser.ParseHeadAndTail(reader, ',', '"');
                        var header = data.Item1;
                        var lines = data.Item2;

                        SelectionIndexList.Clear();

                        for (int i = 0; i < header.Count; i++)
                            if (SelectionList.Contains(header[i]))
                                SelectionIndexList.Add(i);

                        WriteLog("Colums to scan: " + header.Count.ToString());

                        listView1.View = View.Details;
                        listView1.GridLines = true;
                        listView1.FullRowSelect = true;

                        string[] arr = new string[SelectionList.Count+1];

                        ListViewItem itm;
                        headerLine = "";

                        for (var i = 0; i < SelectionIndexList.Count; i++)
                        {
                            if (showValuesCB.Checked)
                                listView1.Columns.Add(header[SelectionIndexList[i]], 100);
                            headerLine += "\"" + header[SelectionIndexList[i]] + "\",";
                        }

                        string tempLine;

                        foreach (var line in lines)
                        {
                            tempLine = "";
                            for (int i = 0; i < SelectionIndexList.Count; i++)
                                if (line.Count > SelectionIndexList[i])
                                    if (!string.IsNullOrEmpty(line[SelectionIndexList[i]]))
                                    {
                                        arr[i] = line[SelectionIndexList[i]];
                                        tempLine += "\"" + line[SelectionIndexList[i]] + "\",";
                                    }
                                    else
                                    {
                                        arr[i] = "";
                                        tempLine += "\"" + "0" + "\",";
                                    }
                                else
                                    arr[i] = "";
                                itm = new ListViewItem(arr);

                            if (showValuesCB.Checked)
                                listView1.Items.Add(itm);
                            rows.Add(tempLine);
                        }
                    }
                    listView1.EndUpdate(); ;
                    WriteLog("Processing finished");
                    Log.ScrollToCaret();
                }
                else MessageBox.Show("No Columns selected");
            else MessageBox.Show("No valid CSV File choosen");
        }

        private void ExportNewCSVBtn_Click(object sender, EventArgs e)
        {
            if (rows.Count > 0)
            {
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    string[] AllLines = new string[rows.Count + 1];
                    int i = 0;

                    AllLines[0] = headerLine.Remove(headerLine.Length - 1);

                    foreach (string row in rows)
                    {
                        i++;
                        AllLines[i] = row.Remove(row.Length - 1);
                    }
                    System.IO.File.WriteAllLines(saveFileDialog1.FileName, AllLines);

                }
            }
            else
                MessageBox.Show("Click 'Select Columns' and 'Start Conversion' first");

        }
    }

    public static class CsvParser
    {
        private static Tuple<T, IEnumerable<T>> HeadAndTail<T>(this IEnumerable<T> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            var en = source.GetEnumerator();
            en.MoveNext();
            return Tuple.Create(en.Current, EnumerateTail(en));
        }

        private static IEnumerable<T> EnumerateTail<T>(IEnumerator<T> en)
        {
            while (en.MoveNext()) yield return en.Current;
        }

        public static IEnumerable<IList<string>> Parse(string content, char delimiter, char qualifier)
        {
            using (var reader = new StringReader(content))
                return Parse(reader, delimiter, qualifier);
        }

        public static Tuple<IList<string>, IEnumerable<IList<string>>> ParseHeadAndTail(TextReader reader, char delimiter, char qualifier)
        {
            return HeadAndTail(Parse(reader, delimiter, qualifier));
        }

        public static IEnumerable<IList<string>> Parse(TextReader reader, char delimiter, char qualifier)
        {
            var inQuote = false;
            var record = new List<string>();
            var sb = new StringBuilder();

            while (reader.Peek() != -1)
            {
                var readChar = (char)reader.Read();

                if (readChar == '\n' || (readChar == '\r' && (char)reader.Peek() == '\n'))
                {
                    // If it's a \r\n combo consume the \n part and throw it away.
                    if (readChar == '\r')
                        reader.Read();

                    if (inQuote)
                    {
                        if (readChar == '\r')
                            sb.Append('\r');
                        sb.Append('\n');
                    }
                    else
                    {
                        if (record.Count > 0 || sb.Length > 0)
                        {
                            record.Add(sb.ToString());
                            sb.Clear();
                        }

                        if (record.Count > 0)
                            yield return record;

                        record = new List<string>(record.Count);
                    }
                }
                else if (sb.Length == 0 && !inQuote)
                {
                    if (readChar == qualifier)
                        inQuote = true;
                    else if (readChar == delimiter)
                    {
                        record.Add(sb.ToString());
                        sb.Clear();
                    }
                    else if (char.IsWhiteSpace(readChar))
                    {
                        // Ignore leading whitespace
                    }
                    else
                        sb.Append(readChar);
                }
                else if (readChar == delimiter)
                {
                    if (inQuote)
                        sb.Append(delimiter);
                    else
                    {
                        record.Add(sb.ToString());
                        sb.Clear();
                    }
                }
                else if (readChar == qualifier)
                {
                    if (inQuote)
                    {
                        if ((char)reader.Peek() == qualifier)
                        {
                            reader.Read();
                            sb.Append(qualifier);
                        }
                        else
                            inQuote = false;
                    }
                    else
                        sb.Append(readChar);
                }
                else
                    sb.Append(readChar);
            }

            if (record.Count > 0 || sb.Length > 0)
                record.Add(sb.ToString());

            if (record.Count > 0)
                yield return record;
        }
    }

}
