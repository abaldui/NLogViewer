namespace NLogViewer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.formSkinMain = new FlatUI.FormSkin();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatTabControlMain = new FlatUI.FlatTabControl();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.dataGridViewDatas = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flatTextBoxDetails = new FlatUI.FlatTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flatCheckBoxIsFatal = new FlatUI.FlatCheckBox();
            this.flatCheckBoxIsError = new FlatUI.FlatCheckBox();
            this.flatCheckBoxIsWarn = new FlatUI.FlatCheckBox();
            this.flatCheckBoxIsInfo = new FlatUI.FlatCheckBox();
            this.flatCheckBoxIsDebug = new FlatUI.FlatCheckBox();
            this.tabPageDiagram = new System.Windows.Forms.TabPage();
            this.tabPageSolving = new System.Windows.Forms.TabPage();
            this.flatStatusBarMain = new FlatUI.FlatStatusBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flatTextBoxPath = new FlatUI.FlatTextBox();
            this.flatButtonPath = new FlatUI.FlatButton();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.flatCheckBoxIsGroup = new FlatUI.FlatCheckBox();
            this.formSkinMain.SuspendLayout();
            this.flatTabControlMain.SuspendLayout();
            this.tabPageDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatas)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkinMain
            // 
            this.formSkinMain.BackColor = System.Drawing.Color.White;
            this.formSkinMain.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkinMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkinMain.Controls.Add(this.flatClose1);
            this.formSkinMain.Controls.Add(this.flatTabControlMain);
            this.formSkinMain.Controls.Add(this.flatStatusBarMain);
            this.formSkinMain.Controls.Add(this.panel1);
            this.formSkinMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkinMain.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkinMain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkinMain.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkinMain.HeaderMaximize = false;
            this.formSkinMain.Location = new System.Drawing.Point(0, 0);
            this.formSkinMain.Name = "formSkinMain";
            this.formSkinMain.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.formSkinMain.Size = new System.Drawing.Size(1280, 1024);
            this.formSkinMain.TabIndex = 0;
            this.formSkinMain.Text = "NLogViewer";
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(1250, 13);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 3;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatTabControlMain
            // 
            this.flatTabControlMain.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatTabControlMain.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControlMain.Controls.Add(this.tabPageDetails);
            this.flatTabControlMain.Controls.Add(this.tabPageDiagram);
            this.flatTabControlMain.Controls.Add(this.tabPageSolving);
            this.flatTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatTabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControlMain.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControlMain.Location = new System.Drawing.Point(0, 120);
            this.flatTabControlMain.Name = "flatTabControlMain";
            this.flatTabControlMain.SelectedIndex = 0;
            this.flatTabControlMain.Size = new System.Drawing.Size(1280, 881);
            this.flatTabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControlMain.TabIndex = 2;
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPageDetails.Controls.Add(this.dataGridViewDatas);
            this.tabPageDetails.Controls.Add(this.panel4);
            this.tabPageDetails.Controls.Add(this.flatTextBoxDetails);
            this.tabPageDetails.Controls.Add(this.panel3);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 44);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetails.Size = new System.Drawing.Size(1272, 833);
            this.tabPageDetails.TabIndex = 1;
            this.tabPageDetails.Text = "Детально";
            // 
            // dataGridViewDatas
            // 
            this.dataGridViewDatas.AllowUserToAddRows = false;
            this.dataGridViewDatas.AllowUserToDeleteRows = false;
            this.dataGridViewDatas.AllowUserToResizeRows = false;
            this.dataGridViewDatas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.dataGridViewDatas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDatas.Location = new System.Drawing.Point(3, 53);
            this.dataGridViewDatas.Name = "dataGridViewDatas";
            this.dataGridViewDatas.ReadOnly = true;
            this.dataGridViewDatas.RowHeadersVisible = false;
            this.dataGridViewDatas.Size = new System.Drawing.Size(1266, 558);
            this.dataGridViewDatas.TabIndex = 22;
            this.dataGridViewDatas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDatas_CellClick);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 611);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1266, 6);
            this.panel4.TabIndex = 25;
            // 
            // flatTextBoxDetails
            // 
            this.flatTextBoxDetails.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBoxDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flatTextBoxDetails.FocusOnHover = false;
            this.flatTextBoxDetails.Location = new System.Drawing.Point(3, 617);
            this.flatTextBoxDetails.MaxLength = 32767;
            this.flatTextBoxDetails.Multiline = true;
            this.flatTextBoxDetails.Name = "flatTextBoxDetails";
            this.flatTextBoxDetails.PlaceHolder = "";
            this.flatTextBoxDetails.ReadOnly = false;
            this.flatTextBoxDetails.Size = new System.Drawing.Size(1266, 213);
            this.flatTextBoxDetails.TabIndex = 0;
            this.flatTextBoxDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBoxDetails.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBoxDetails.UseSystemPasswordChar = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flatCheckBoxIsGroup);
            this.panel3.Controls.Add(this.flatCheckBoxIsFatal);
            this.panel3.Controls.Add(this.flatCheckBoxIsError);
            this.panel3.Controls.Add(this.flatCheckBoxIsWarn);
            this.panel3.Controls.Add(this.flatCheckBoxIsInfo);
            this.panel3.Controls.Add(this.flatCheckBoxIsDebug);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1266, 50);
            this.panel3.TabIndex = 24;
            // 
            // flatCheckBoxIsFatal
            // 
            this.flatCheckBoxIsFatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatCheckBoxIsFatal.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatCheckBoxIsFatal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatCheckBoxIsFatal.Checked = false;
            this.flatCheckBoxIsFatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatCheckBoxIsFatal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatCheckBoxIsFatal.Location = new System.Drawing.Point(329, 12);
            this.flatCheckBoxIsFatal.Name = "flatCheckBoxIsFatal";
            this.flatCheckBoxIsFatal.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.flatCheckBoxIsFatal.Size = new System.Drawing.Size(65, 22);
            this.flatCheckBoxIsFatal.TabIndex = 4;
            this.flatCheckBoxIsFatal.Text = "FATAL";
            this.flatCheckBoxIsFatal.CheckedChanged += new FlatUI.FlatCheckBox.CheckedChangedEventHandler(this.FlatCheckBoxIsFatal_CheckedChanged);
            // 
            // flatCheckBoxIsError
            // 
            this.flatCheckBoxIsError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatCheckBoxIsError.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatCheckBoxIsError.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatCheckBoxIsError.Checked = false;
            this.flatCheckBoxIsError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatCheckBoxIsError.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatCheckBoxIsError.Location = new System.Drawing.Point(248, 12);
            this.flatCheckBoxIsError.Name = "flatCheckBoxIsError";
            this.flatCheckBoxIsError.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.flatCheckBoxIsError.Size = new System.Drawing.Size(75, 22);
            this.flatCheckBoxIsError.TabIndex = 3;
            this.flatCheckBoxIsError.Text = "ERROR";
            this.flatCheckBoxIsError.CheckedChanged += new FlatUI.FlatCheckBox.CheckedChangedEventHandler(this.FlatCheckBoxIsError_CheckedChanged);
            // 
            // flatCheckBoxIsWarn
            // 
            this.flatCheckBoxIsWarn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatCheckBoxIsWarn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatCheckBoxIsWarn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatCheckBoxIsWarn.Checked = false;
            this.flatCheckBoxIsWarn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatCheckBoxIsWarn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatCheckBoxIsWarn.Location = new System.Drawing.Point(167, 12);
            this.flatCheckBoxIsWarn.Name = "flatCheckBoxIsWarn";
            this.flatCheckBoxIsWarn.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.flatCheckBoxIsWarn.Size = new System.Drawing.Size(75, 22);
            this.flatCheckBoxIsWarn.TabIndex = 2;
            this.flatCheckBoxIsWarn.Text = "WARN";
            this.flatCheckBoxIsWarn.CheckedChanged += new FlatUI.FlatCheckBox.CheckedChangedEventHandler(this.FlatCheckBoxIsWarn_CheckedChanged);
            // 
            // flatCheckBoxIsInfo
            // 
            this.flatCheckBoxIsInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatCheckBoxIsInfo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatCheckBoxIsInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatCheckBoxIsInfo.Checked = false;
            this.flatCheckBoxIsInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatCheckBoxIsInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatCheckBoxIsInfo.Location = new System.Drawing.Point(86, 12);
            this.flatCheckBoxIsInfo.Name = "flatCheckBoxIsInfo";
            this.flatCheckBoxIsInfo.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.flatCheckBoxIsInfo.Size = new System.Drawing.Size(75, 22);
            this.flatCheckBoxIsInfo.TabIndex = 1;
            this.flatCheckBoxIsInfo.Text = "INFO";
            this.flatCheckBoxIsInfo.CheckedChanged += new FlatUI.FlatCheckBox.CheckedChangedEventHandler(this.FlatCheckBoxIsInfo_CheckedChanged);
            // 
            // flatCheckBoxIsDebug
            // 
            this.flatCheckBoxIsDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatCheckBoxIsDebug.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatCheckBoxIsDebug.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatCheckBoxIsDebug.Checked = false;
            this.flatCheckBoxIsDebug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatCheckBoxIsDebug.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatCheckBoxIsDebug.Location = new System.Drawing.Point(5, 12);
            this.flatCheckBoxIsDebug.Name = "flatCheckBoxIsDebug";
            this.flatCheckBoxIsDebug.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.flatCheckBoxIsDebug.Size = new System.Drawing.Size(75, 22);
            this.flatCheckBoxIsDebug.TabIndex = 0;
            this.flatCheckBoxIsDebug.Text = "DEBUG";
            this.flatCheckBoxIsDebug.CheckedChanged += new FlatUI.FlatCheckBox.CheckedChangedEventHandler(this.FlatCheckBoxIsDebug_CheckedChanged);
            // 
            // tabPageDiagram
            // 
            this.tabPageDiagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPageDiagram.Location = new System.Drawing.Point(4, 44);
            this.tabPageDiagram.Name = "tabPageDiagram";
            this.tabPageDiagram.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDiagram.Size = new System.Drawing.Size(1272, 833);
            this.tabPageDiagram.TabIndex = 4;
            this.tabPageDiagram.Text = "Диаграмма";
            // 
            // tabPageSolving
            // 
            this.tabPageSolving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPageSolving.Location = new System.Drawing.Point(4, 44);
            this.tabPageSolving.Name = "tabPageSolving";
            this.tabPageSolving.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSolving.Size = new System.Drawing.Size(1272, 833);
            this.tabPageSolving.TabIndex = 3;
            this.tabPageSolving.Text = "Решения";
            // 
            // flatStatusBarMain
            // 
            this.flatStatusBarMain.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatStatusBarMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flatStatusBarMain.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatStatusBarMain.ForeColor = System.Drawing.Color.White;
            this.flatStatusBarMain.Location = new System.Drawing.Point(0, 1001);
            this.flatStatusBarMain.MyTextColor = null;
            this.flatStatusBarMain.Name = "flatStatusBarMain";
            this.flatStatusBarMain.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatStatusBarMain.ShowTimeDate = false;
            this.flatStatusBarMain.Size = new System.Drawing.Size(1280, 23);
            this.flatStatusBarMain.TabIndex = 1;
            this.flatStatusBarMain.TextColor = System.Drawing.Color.White;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.flatTextBoxPath);
            this.panel1.Controls.Add(this.flatButtonPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 70);
            this.panel1.TabIndex = 0;
            // 
            // flatTextBoxPath
            // 
            this.flatTextBoxPath.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBoxPath.FocusOnHover = false;
            this.flatTextBoxPath.Location = new System.Drawing.Point(12, 19);
            this.flatTextBoxPath.MaxLength = 32767;
            this.flatTextBoxPath.Multiline = false;
            this.flatTextBoxPath.Name = "flatTextBoxPath";
            this.flatTextBoxPath.PlaceHolder = "Путь к файлу";
            this.flatTextBoxPath.ReadOnly = false;
            this.flatTextBoxPath.Size = new System.Drawing.Size(1168, 29);
            this.flatTextBoxPath.TabIndex = 22;
            this.flatTextBoxPath.Text = "Путь к файлу";
            this.flatTextBoxPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBoxPath.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBoxPath.UseSystemPasswordChar = false;
            // 
            // flatButtonPath
            // 
            this.flatButtonPath.BackColor = System.Drawing.Color.Transparent;
            this.flatButtonPath.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButtonPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButtonPath.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButtonPath.Location = new System.Drawing.Point(1186, 19);
            this.flatButtonPath.Name = "flatButtonPath";
            this.flatButtonPath.Rounded = false;
            this.flatButtonPath.Size = new System.Drawing.Size(82, 32);
            this.flatButtonPath.TabIndex = 21;
            this.flatButtonPath.Text = "Выбрать";
            this.flatButtonPath.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButtonPath.Click += new System.EventHandler(this.FlatButtonPath_Click);
            // 
            // flatCheckBoxIsGroup
            // 
            this.flatCheckBoxIsGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatCheckBoxIsGroup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatCheckBoxIsGroup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatCheckBoxIsGroup.Checked = false;
            this.flatCheckBoxIsGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatCheckBoxIsGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatCheckBoxIsGroup.Location = new System.Drawing.Point(1135, 12);
            this.flatCheckBoxIsGroup.Name = "flatCheckBoxIsGroup";
            this.flatCheckBoxIsGroup.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.flatCheckBoxIsGroup.Size = new System.Drawing.Size(126, 22);
            this.flatCheckBoxIsGroup.TabIndex = 5;
            this.flatCheckBoxIsGroup.Text = "СГРУПИРОВАТЬ";
            this.flatCheckBoxIsGroup.CheckedChanged += new FlatUI.FlatCheckBox.CheckedChangedEventHandler(this.FlatCheckBoxIsGroup_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.formSkinMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 1024);
            this.MinimumSize = new System.Drawing.Size(1280, 1024);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Main_Load);
            this.formSkinMain.ResumeLayout(false);
            this.flatTabControlMain.ResumeLayout(false);
            this.tabPageDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkinMain;
        private System.Windows.Forms.Panel panel1;
        private FlatUI.FlatStatusBar flatStatusBarMain;
        private FlatUI.FlatButton flatButtonPath;
        private FlatUI.FlatTextBox flatTextBoxPath;
        private FlatUI.FlatTabControl flatTabControlMain;
        private System.Windows.Forms.TabPage tabPageDetails;
        private System.Windows.Forms.TabPage tabPageSolving;
        private FlatUI.FlatClose flatClose1;
        private System.Windows.Forms.DataGridView dataGridViewDatas;
        private FlatUI.FlatTextBox flatTextBoxDetails;
        private System.Windows.Forms.TabPage tabPageDiagram;
        private System.Windows.Forms.Panel panel3;
        private FlatUI.FlatCheckBox flatCheckBoxIsDebug;
        private FlatUI.FlatCheckBox flatCheckBoxIsWarn;
        private FlatUI.FlatCheckBox flatCheckBoxIsInfo;
        private FlatUI.FlatCheckBox flatCheckBoxIsFatal;
        private FlatUI.FlatCheckBox flatCheckBoxIsError;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private FlatUI.FlatCheckBox flatCheckBoxIsGroup;
    }
}

