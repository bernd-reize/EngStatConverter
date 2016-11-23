namespace EngStatConverter
{
    partial class DataSelection
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveToFileBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.LoadFromFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.RegExCb = new System.Windows.Forms.CheckBox();
            this.charCountTrb = new System.Windows.Forms.TrackBar();
            this.GroupingLb = new System.Windows.Forms.Label();
            this.SelectAllFsKiBBtn = new System.Windows.Forms.Button();
            this.SelectAllFsIOPsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.charCountTrb)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.CheckBoxes = true;
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(18, 63);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(744, 422);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(632, 15);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(61, 23);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(697, 15);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(64, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveToFileBtn
            // 
            this.SaveToFileBtn.Location = new System.Drawing.Point(490, 33);
            this.SaveToFileBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SaveToFileBtn.Name = "SaveToFileBtn";
            this.SaveToFileBtn.Size = new System.Drawing.Size(94, 23);
            this.SaveToFileBtn.TabIndex = 0;
            this.SaveToFileBtn.Text = "Save Template";
            this.SaveToFileBtn.UseVisualStyleBackColor = true;
            this.SaveToFileBtn.Click += new System.EventHandler(this.SaveToFileBtn_Click);
            // 
            // LoadFromFileBtn
            // 
            this.LoadFromFileBtn.Location = new System.Drawing.Point(490, 8);
            this.LoadFromFileBtn.Margin = new System.Windows.Forms.Padding(0);
            this.LoadFromFileBtn.Name = "LoadFromFileBtn";
            this.LoadFromFileBtn.Size = new System.Drawing.Size(94, 23);
            this.LoadFromFileBtn.TabIndex = 3;
            this.LoadFromFileBtn.Text = "Load Template";
            this.LoadFromFileBtn.UseVisualStyleBackColor = true;
            this.LoadFromFileBtn.Click += new System.EventHandler(this.LoadFromFileBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SearchTb
            // 
            this.SearchTb.Location = new System.Drawing.Point(18, 11);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(347, 20);
            this.SearchTb.TabIndex = 4;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(82, 34);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(53, 23);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegExCb
            // 
            this.RegExCb.AutoSize = true;
            this.RegExCb.Checked = true;
            this.RegExCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RegExCb.Location = new System.Drawing.Point(18, 38);
            this.RegExCb.Name = "RegExCb";
            this.RegExCb.Size = new System.Drawing.Size(58, 17);
            this.RegExCb.TabIndex = 6;
            this.RegExCb.Text = "RegEx";
            this.RegExCb.UseVisualStyleBackColor = true;
            // 
            // charCountTrb
            // 
            this.charCountTrb.Location = new System.Drawing.Point(371, 10);
            this.charCountTrb.Maximum = 15;
            this.charCountTrb.Minimum = 3;
            this.charCountTrb.Name = "charCountTrb";
            this.charCountTrb.Size = new System.Drawing.Size(104, 45);
            this.charCountTrb.TabIndex = 7;
            this.charCountTrb.Value = 8;
            this.charCountTrb.ValueChanged += new System.EventHandler(this.charCountTrb_ValueChanged);
            // 
            // GroupingLb
            // 
            this.GroupingLb.AutoSize = true;
            this.GroupingLb.Location = new System.Drawing.Point(382, 38);
            this.GroupingLb.Name = "GroupingLb";
            this.GroupingLb.Size = new System.Drawing.Size(81, 13);
            this.GroupingLb.TabIndex = 8;
            this.GroupingLb.Text = "8 char grouping";
            this.GroupingLb.Click += new System.EventHandler(this.GroupingLb_Click);
            // 
            // SelectAllFsKiBBtn
            // 
            this.SelectAllFsKiBBtn.Location = new System.Drawing.Point(167, 34);
            this.SelectAllFsKiBBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SelectAllFsKiBBtn.Name = "SelectAllFsKiBBtn";
            this.SelectAllFsKiBBtn.Size = new System.Drawing.Size(94, 23);
            this.SelectAllFsKiBBtn.TabIndex = 9;
            this.SelectAllFsKiBBtn.Text = "FS Throughput";
            this.SelectAllFsKiBBtn.UseVisualStyleBackColor = true;
            this.SelectAllFsKiBBtn.Click += new System.EventHandler(this.SelectAllFsBtn_Click);
            // 
            // SelectAllFsIOPsBtn
            // 
            this.SelectAllFsIOPsBtn.Location = new System.Drawing.Point(271, 34);
            this.SelectAllFsIOPsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SelectAllFsIOPsBtn.Name = "SelectAllFsIOPsBtn";
            this.SelectAllFsIOPsBtn.Size = new System.Drawing.Size(94, 23);
            this.SelectAllFsIOPsBtn.TabIndex = 10;
            this.SelectAllFsIOPsBtn.Text = "FS IOP/s";
            this.SelectAllFsIOPsBtn.UseVisualStyleBackColor = true;
            this.SelectAllFsIOPsBtn.Click += new System.EventHandler(this.SelectAllFsIOPsBtn_Click);
            // 
            // DataSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 497);
            this.ControlBox = false;
            this.Controls.Add(this.SelectAllFsIOPsBtn);
            this.Controls.Add(this.SelectAllFsKiBBtn);
            this.Controls.Add(this.GroupingLb);
            this.Controls.Add(this.charCountTrb);
            this.Controls.Add(this.RegExCb);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.LoadFromFileBtn);
            this.Controls.Add(this.SaveToFileBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.treeView1);
            this.Name = "DataSelection";
            this.Text = "Data Selection";
            this.Load += new System.EventHandler(this.DataSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.charCountTrb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveToFileBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button LoadFromFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox SearchTb;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.CheckBox RegExCb;
        private System.Windows.Forms.TrackBar charCountTrb;
        private System.Windows.Forms.Label GroupingLb;
        private System.Windows.Forms.Button SelectAllFsKiBBtn;
        private System.Windows.Forms.Button SelectAllFsIOPsBtn;
    }
}