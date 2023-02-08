namespace SampleTextEditiorL4DC
{
    partial class frmDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocument));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnufile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnunew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuopen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuclose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuexit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuedit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuundo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuredo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnucopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnucut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.findAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabdisplay = new System.Windows.Forms.TabControl();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ofdopen = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chboAutogenerate = new System.Windows.Forms.CheckBox();
            this.btnreplace = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.txtreplace = new System.Windows.Forms.TextBox();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.lblreplace = new System.Windows.Forms.Label();
            this.lblfind = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LBLFONTSTYLE = new System.Windows.Forms.ToolStripLabel();
            this.CBOfONTSTYLE = new System.Windows.Forms.ToolStripComboBox();
            this.lblfontsize = new System.Windows.Forms.ToolStripLabel();
            this.cbofontsize = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnufile,
            this.mnuedit,
            this.changeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnufile
            // 
            this.mnufile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnunew,
            this.mnuopen,
            this.mnusave,
            this.toolStripMenuItem1,
            this.mnuclose,
            this.mnuexit});
            this.mnufile.Name = "mnufile";
            this.mnufile.Size = new System.Drawing.Size(44, 24);
            this.mnufile.Text = "&File";
            this.mnufile.Click += new System.EventHandler(this.mnufile_Click);
            // 
            // mnunew
            // 
            this.mnunew.Name = "mnunew";
            this.mnunew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnunew.Size = new System.Drawing.Size(167, 24);
            this.mnunew.Text = "&New";
            this.mnunew.Click += new System.EventHandler(this.mnunew_Click);
            // 
            // mnuopen
            // 
            this.mnuopen.Name = "mnuopen";
            this.mnuopen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuopen.Size = new System.Drawing.Size(167, 24);
            this.mnuopen.Text = "&Open";
            this.mnuopen.Click += new System.EventHandler(this.mnuopen_Click);
            // 
            // mnusave
            // 
            this.mnusave.Name = "mnusave";
            this.mnusave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnusave.Size = new System.Drawing.Size(167, 24);
            this.mnusave.Text = "&Save";
            this.mnusave.Click += new System.EventHandler(this.mnusave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 6);
            // 
            // mnuclose
            // 
            this.mnuclose.Name = "mnuclose";
            this.mnuclose.Size = new System.Drawing.Size(167, 24);
            this.mnuclose.Text = "Close";
            this.mnuclose.Click += new System.EventHandler(this.mnuclose_Click);
            // 
            // mnuexit
            // 
            this.mnuexit.Name = "mnuexit";
            this.mnuexit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.mnuexit.Size = new System.Drawing.Size(167, 24);
            this.mnuexit.Text = "E&xit";
            this.mnuexit.Click += new System.EventHandler(this.mnuexit_Click);
            // 
            // mnuedit
            // 
            this.mnuedit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuundo,
            this.mnuredo,
            this.mnucopy,
            this.mnucut,
            this.mnuPaste,
            this.toolStripMenuItem2,
            this.findAndReplaceToolStripMenuItem});
            this.mnuedit.Name = "mnuedit";
            this.mnuedit.Size = new System.Drawing.Size(47, 24);
            this.mnuedit.Text = "E&dit";
            // 
            // mnuundo
            // 
            this.mnuundo.Name = "mnuundo";
            this.mnuundo.Size = new System.Drawing.Size(192, 24);
            this.mnuundo.Text = "&Undo";
            this.mnuundo.Click += new System.EventHandler(this.mnuundo_Click);
            // 
            // mnuredo
            // 
            this.mnuredo.Name = "mnuredo";
            this.mnuredo.Size = new System.Drawing.Size(192, 24);
            this.mnuredo.Text = "&Redo";
            this.mnuredo.Click += new System.EventHandler(this.mnuredo_Click);
            // 
            // mnucopy
            // 
            this.mnucopy.Name = "mnucopy";
            this.mnucopy.Size = new System.Drawing.Size(192, 24);
            this.mnucopy.Text = "&Copy";
            this.mnucopy.Click += new System.EventHandler(this.mnucopy_Click);
            // 
            // mnucut
            // 
            this.mnucut.Name = "mnucut";
            this.mnucut.Size = new System.Drawing.Size(192, 24);
            this.mnucut.Text = "Cu&t";
            this.mnucut.Click += new System.EventHandler(this.mnucut_Click);
            // 
            // mnuPaste
            // 
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.Size = new System.Drawing.Size(192, 24);
            this.mnuPaste.Text = "&Paste";
            this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 6);
            // 
            // findAndReplaceToolStripMenuItem
            // 
            this.findAndReplaceToolStripMenuItem.Name = "findAndReplaceToolStripMenuItem";
            this.findAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.findAndReplaceToolStripMenuItem.Text = "Find and Replace";
            this.findAndReplaceToolStripMenuItem.Click += new System.EventHandler(this.findAndReplaceToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem});
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.changeToolStripMenuItem.Text = "Format";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.cToolStripMenuItem.Text = "Ccoding";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // tabdisplay
            // 
            this.tabdisplay.Location = new System.Drawing.Point(0, 70);
            this.tabdisplay.Name = "tabdisplay";
            this.tabdisplay.SelectedIndex = 0;
            this.tabdisplay.Size = new System.Drawing.Size(938, 271);
            this.tabdisplay.TabIndex = 2;
            this.tabdisplay.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabdisplay_DrawItem);
            // 
            // ofdopen
            // 
            this.ofdopen.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 99);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(938, 242);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // chboAutogenerate
            // 
            this.chboAutogenerate.AutoSize = true;
            this.chboAutogenerate.Location = new System.Drawing.Point(321, 0);
            this.chboAutogenerate.Name = "chboAutogenerate";
            this.chboAutogenerate.Size = new System.Drawing.Size(123, 21);
            this.chboAutogenerate.TabIndex = 4;
            this.chboAutogenerate.Text = "Auto Generate";
            this.chboAutogenerate.UseVisualStyleBackColor = true;
            // 
            // btnreplace
            // 
            this.btnreplace.Location = new System.Drawing.Point(357, 421);
            this.btnreplace.Name = "btnreplace";
            this.btnreplace.Size = new System.Drawing.Size(70, 23);
            this.btnreplace.TabIndex = 11;
            this.btnreplace.Text = "Replace";
            this.btnreplace.UseVisualStyleBackColor = true;
            this.btnreplace.Click += new System.EventHandler(this.btnreplace_Click);
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(357, 350);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 23);
            this.btnfind.TabIndex = 10;
            this.btnfind.Text = "Find ";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // txtreplace
            // 
            this.txtreplace.Location = new System.Drawing.Point(135, 422);
            this.txtreplace.Name = "txtreplace";
            this.txtreplace.Size = new System.Drawing.Size(138, 22);
            this.txtreplace.TabIndex = 9;
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(135, 347);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(138, 22);
            this.txtfind.TabIndex = 8;
            // 
            // lblreplace
            // 
            this.lblreplace.AutoSize = true;
            this.lblreplace.Location = new System.Drawing.Point(9, 427);
            this.lblreplace.Name = "lblreplace";
            this.lblreplace.Size = new System.Drawing.Size(88, 17);
            this.lblreplace.TabIndex = 7;
            this.lblreplace.Text = "Replace with";
            // 
            // lblfind
            // 
            this.lblfind.AutoSize = true;
            this.lblfind.Location = new System.Drawing.Point(9, 350);
            this.lblfind.Name = "lblfind";
            this.lblfind.Size = new System.Drawing.Size(35, 17);
            this.lblfind.TabIndex = 6;
            this.lblfind.Text = "Find";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.LBLFONTSTYLE,
            this.CBOfONTSTYLE,
            this.lblfontsize,
            this.cbofontsize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(938, 28);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 25);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 25);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 25);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 25);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 25);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 25);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // LBLFONTSTYLE
            // 
            this.LBLFONTSTYLE.Name = "LBLFONTSTYLE";
            this.LBLFONTSTYLE.Size = new System.Drawing.Size(72, 25);
            this.LBLFONTSTYLE.Text = "Font style";
            this.LBLFONTSTYLE.Click += new System.EventHandler(this.cbofontstyle_Click);
            // 
            // CBOfONTSTYLE
            // 
            this.CBOfONTSTYLE.Name = "CBOfONTSTYLE";
            this.CBOfONTSTYLE.Size = new System.Drawing.Size(121, 28);
            this.CBOfONTSTYLE.SelectedIndexChanged += new System.EventHandler(this.CBOfONTSTYLE_SelectedIndexChanged);
            this.CBOfONTSTYLE.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // lblfontsize
            // 
            this.lblfontsize.Name = "lblfontsize";
            this.lblfontsize.Size = new System.Drawing.Size(67, 25);
            this.lblfontsize.Text = "Font size";
            // 
            // cbofontsize
            // 
            this.cbofontsize.Items.AddRange(new object[] {
            "6",
            "8",
            "10",
            "11",
            "12",
            "14",
            "16",
            "20"});
            this.cbofontsize.Name = "cbofontsize";
            this.cbofontsize.Size = new System.Drawing.Size(121, 28);
            this.cbofontsize.SelectedIndexChanged += new System.EventHandler(this.cbofontsize_SelectedIndexChanged);
            // 
            // frmDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 455);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnreplace);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtreplace);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.lblreplace);
            this.Controls.Add(this.lblfind);
            this.Controls.Add(this.chboAutogenerate);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tabdisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDocument";
            this.Text = "Document File";
            this.Load += new System.EventHandler(this.frmDocument_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnufile;
        private System.Windows.Forms.ToolStripMenuItem mnunew;
        private System.Windows.Forms.ToolStripMenuItem mnuopen;
        private System.Windows.Forms.ToolStripMenuItem mnusave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuexit;
        private System.Windows.Forms.ToolStripMenuItem mnuedit;
        private System.Windows.Forms.ToolStripMenuItem mnuundo;
        private System.Windows.Forms.ToolStripMenuItem mnuredo;
        private System.Windows.Forms.ToolStripMenuItem mnucopy;
        private System.Windows.Forms.ToolStripMenuItem mnucut;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
        private System.Windows.Forms.TabControl tabdisplay;
        private System.Windows.Forms.ToolStripMenuItem mnuclose;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.OpenFileDialog ofdopen;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem findAndReplaceToolStripMenuItem;
        private System.Windows.Forms.CheckBox chboAutogenerate;
        private System.Windows.Forms.Button btnreplace;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.TextBox txtreplace;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Label lblreplace;
        private System.Windows.Forms.Label lblfind;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LBLFONTSTYLE;
        private System.Windows.Forms.ToolStripComboBox CBOfONTSTYLE;
        private System.Windows.Forms.ToolStripLabel lblfontsize;
        private System.Windows.Forms.ToolStripComboBox cbofontsize;
    }
}