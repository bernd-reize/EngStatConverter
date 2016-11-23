namespace EngStatConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Log = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showValuesCB = new System.Windows.Forms.CheckBox();
            this.ExportNewCSVBtn = new System.Windows.Forms.Button();
            this.StartConversionBtn = new System.Windows.Forms.Button();
            this.SelectColumnsBtn = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.ChooseSourceFileBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listView1
            // 
            this.listView1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 53);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(660, 282);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Log
            // 
            this.Log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Log.Location = new System.Drawing.Point(0, 353);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log.Size = new System.Drawing.Size(684, 116);
            this.Log.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showValuesCB);
            this.panel1.Controls.Add(this.ExportNewCSVBtn);
            this.panel1.Controls.Add(this.StartConversionBtn);
            this.panel1.Controls.Add(this.SelectColumnsBtn);
            this.panel1.Controls.Add(this.Status);
            this.panel1.Controls.Add(this.ChooseSourceFileBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 47);
            this.panel1.TabIndex = 1;
            // 
            // showValuesCB
            // 
            this.showValuesCB.AutoSize = true;
            this.showValuesCB.Checked = true;
            this.showValuesCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showValuesCB.Location = new System.Drawing.Point(492, 17);
            this.showValuesCB.Name = "showValuesCB";
            this.showValuesCB.Size = new System.Drawing.Size(88, 17);
            this.showValuesCB.TabIndex = 6;
            this.showValuesCB.Text = "Show Values";
            this.showValuesCB.UseVisualStyleBackColor = true;
            // 
            // ExportNewCSVBtn
            // 
            this.ExportNewCSVBtn.Location = new System.Drawing.Point(356, 12);
            this.ExportNewCSVBtn.Name = "ExportNewCSVBtn";
            this.ExportNewCSVBtn.Size = new System.Drawing.Size(111, 23);
            this.ExportNewCSVBtn.TabIndex = 5;
            this.ExportNewCSVBtn.Text = "Export new CSV";
            this.ExportNewCSVBtn.UseVisualStyleBackColor = true;
            this.ExportNewCSVBtn.Click += new System.EventHandler(this.ExportNewCSVBtn_Click);
            // 
            // StartConversionBtn
            // 
            this.StartConversionBtn.Location = new System.Drawing.Point(235, 12);
            this.StartConversionBtn.Name = "StartConversionBtn";
            this.StartConversionBtn.Size = new System.Drawing.Size(111, 23);
            this.StartConversionBtn.TabIndex = 4;
            this.StartConversionBtn.Text = "Start Conversion";
            this.StartConversionBtn.UseVisualStyleBackColor = true;
            this.StartConversionBtn.Click += new System.EventHandler(this.StartConversionBtn_Click);
            // 
            // SelectColumnsBtn
            // 
            this.SelectColumnsBtn.Location = new System.Drawing.Point(126, 12);
            this.SelectColumnsBtn.Name = "SelectColumnsBtn";
            this.SelectColumnsBtn.Size = new System.Drawing.Size(99, 23);
            this.SelectColumnsBtn.TabIndex = 3;
            this.SelectColumnsBtn.Text = "Select Columns";
            this.SelectColumnsBtn.UseVisualStyleBackColor = true;
            this.SelectColumnsBtn.Click += new System.EventHandler(this.SelectColumnsBtn_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(614, 17);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(16, 13);
            this.Status.TabIndex = 2;
            this.Status.Text = "...";
            // 
            // ChooseSourceFileBtn
            // 
            this.ChooseSourceFileBtn.Location = new System.Drawing.Point(12, 12);
            this.ChooseSourceFileBtn.Name = "ChooseSourceFileBtn";
            this.ChooseSourceFileBtn.Size = new System.Drawing.Size(104, 23);
            this.ChooseSourceFileBtn.TabIndex = 1;
            this.ChooseSourceFileBtn.Text = "Choose Sourcefile";
            this.ChooseSourceFileBtn.UseVisualStyleBackColor = true;
            this.ChooseSourceFileBtn.Click += new System.EventHandler(this.ChooseSourceFileBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "csv|*.csv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Form1";
            this.Text = "Eng Stats Converter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox Log;

        private System.Windows.Forms.Button ChooseSourceFileBtn;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button SelectColumnsBtn;
        private System.Windows.Forms.Button StartConversionBtn;
        private System.Windows.Forms.Button ExportNewCSVBtn;
        private System.Windows.Forms.CheckBox showValuesCB;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

