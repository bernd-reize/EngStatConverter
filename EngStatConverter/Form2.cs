using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

// please use more comments :D
namespace EngStatConverter
{
    public partial class DataSelection : Form
    {
        List<string> selectionList = new List<string>();

        public DataSelection()
        {
            InitializeComponent();
        }

        string CSVFilename;

        private void DataSelection_Load(object sender, EventArgs e)
        {
            BuildTreeView();
        }

        private void BuildTreeView()
        {
            treeView1.Nodes.Clear();
            TreeNode node;
            int CharCount = charCountTrb.Value;

            using (var stream = File.OpenRead(CSVFilename))
            using (var reader = new StreamReader(stream))
            {
                var data = CsvParser.ParseHeadAndTail(reader, ',', '"');
                var header = data.Item1;
                var lines = data.Item2;
                node = treeView1.Nodes.Add(header[0]);

                string Start;
                string Item = header[0];
                string ItemStart;
                string NextItem;
                string NextItemStart;

                Start = Item.Substring(0, Item.Length > CharCount ? CharCount : Item.Length);
                
                for (var i = 1; i < header.Count; i++)
                {
                    Item = header[i];
                    ItemStart = Item.Substring(0, Item.Length > CharCount ? CharCount : Item.Length);

                    if (i < header.Count - 1)
                    {
                        NextItem = header[i + 1];
                        NextItemStart = NextItem.Substring(0, NextItem.Length > CharCount ? CharCount : NextItem.Length);
                    }
                    else
                    {
                        NextItem = "";
                        NextItemStart = "";
                    }

                    if (Item.Substring(0, Item.Length > CharCount ? CharCount : Item.Length) == Start)
                        node.Nodes.Add(Item);
                    else
                    {
                        if (NextItemStart == ItemStart)
                        {
                            node = treeView1.Nodes.Add(Item.Substring(0, Item.Length > CharCount ? CharCount : Item.Length));
                            node.Nodes.Add(Item);
                        }
                        else
                        {
                            node = treeView1.Nodes.Add(Item);

                        }
                        Start = Item.Substring(0, Item.Length > CharCount ? CharCount : Item.Length);
                    }
                }

                if (selectionList.Count > 0)
                    SetCheckStatus();

                SearchTreeView(false, SearchTb.Text);
            }
        }

        public void SetFilename(string Filename)
        {
            CSVFilename = Filename;
        }

        public List<string> GetSelectionList()
        {
            return selectionList;
        }

        public void SetSelectionList(List<string> list)
        {
            selectionList = list;
            
        }

        private void CreateSelectionList()
        {
            selectionList.Clear();
            foreach (TreeNode node in treeView1.Nodes)
            {
                if (node.Checked && node.Nodes.Count == 0)
                {
                    selectionList.Add(node.Text);
                }
                foreach (TreeNode SubNode in node.Nodes)
                    if (SubNode.Checked)
                        selectionList.Add(SubNode.Text);

            }
        }

        private void SetCheckStatus()
        {
            foreach (TreeNode item in treeView1.Nodes)
            {
                if (selectionList.Contains(item.Text))
                    item.Checked = true;
                else
                    item.Checked = false;
                if (item.Nodes.Count > 0)
                    foreach (TreeNode subItem in item.Nodes)
                        if (selectionList.Contains(subItem.Text))
                            subItem.Checked = true;

            }
            SetCheckStatusParentNode();
        }

        private void SetCheckStatusParentNode()
        {
            bool allChecked;
            foreach (TreeNode item in treeView1.Nodes)
                if (item.Nodes.Count > 0)
                {
                    allChecked = true;
                    foreach (TreeNode subNode in item.Nodes)
                        if (subNode.Checked == false)
                            allChecked = false;
                    item.Checked = allChecked;
                }
                     
                

        }

        private void CheckSubItems(TreeNode treeNode, bool nodeChecked)
        { 
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    CheckSubItems(node, nodeChecked);
                }
            }
        }

        private void SearchTreeView(bool select, string SearchPattern)
        { 
            
            foreach (TreeNode node in treeView1.Nodes)
            {
                if ((SearchPattern != "") && RegExMatch(node.Text, SearchPattern))
                    node.ForeColor = System.Drawing.Color.Red;
                else
                    node.ForeColor = System.Drawing.Color.Black;
                if (node.Nodes.Count > 0)
                    foreach (TreeNode subNode in node.Nodes)
                        if ((SearchPattern != "") && RegExMatch(subNode.Text, SearchPattern))
                        {
                            subNode.ForeColor = System.Drawing.Color.Red;
                            subNode.Checked = select;
                            subNode.Parent.Expand();
                        }
                        else
                            subNode.ForeColor = System.Drawing.Color.Black;
            }
        }

        private string WildcardToRegex(string pattern)
        {
            try
            {
                return "^" + Regex.Escape(pattern)
                                  .Replace(@"\*", ".*")
                                  .Replace(@"\?", ".")
                           + "$";
            }
            catch
            {
                return pattern;
            }
        }

        private bool RegExMatch(string input, string pattern)
        {
            while (pattern.Contains("**"))
                pattern = pattern.Replace("**", "*");

            if (pattern.StartsWith("*"))
                pattern = pattern.Remove(0, 1);
            
            try
            {
                Regex r = new Regex((RegExCb.Checked ? pattern : WildcardToRegex(pattern)), RegexOptions.IgnoreCase);
                return r.Match(input).Success;
            }
            catch
            {
                return false;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveToFileBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(CSVFilename) + ".esc";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                CreateSelectionList();
                System.IO.File.WriteAllLines(saveFileDialog1.FileName, selectionList);
            }
        }

        private void LoadFromFileBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Selection Files|*.esc";
            openFileDialog1.ShowDialog();
            if (File.Exists(openFileDialog1.FileName))
            {
                selectionList.Clear();
                string[] temp = System.IO.File.ReadAllLines(openFileDialog1.FileName);
                foreach (string line in temp)
                    selectionList.Add(line);
                SetCheckStatus();
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            CreateSelectionList();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchTreeView(false, SearchTb.Text);
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    CheckSubItems(e.Node, e.Node.Checked);
                }
            }
        }

        private void charCountTrb_ValueChanged(object sender, EventArgs e)
        {
            BuildTreeView();
            GroupingLb.Text = charCountTrb.Value + " char grouping";
        }

        private void SelectAllFsBtn_Click(object sender, EventArgs e)
        {
            SearchTreeView(true, "MetaVol [a-z0-9]+(_[a-z0-9]{3})?(_(?!_daily|prj|bck))? (Read|Write) (KiB[^ %])");
        }

        private void GroupingLb_Click(object sender, EventArgs e)
        {

        }

        private void SelectAllFsIOPsBtn_Click(object sender, EventArgs e)
        {
            SearchTreeView(true, "MetaVol [a-z0-9]+(_[a-z0-9]{3})?(_(?!_daily|prj|bck))? (Read|Write) (Ops[^ %])");
        }
    }
}
