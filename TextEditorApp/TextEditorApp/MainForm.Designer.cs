﻿namespace TextEditorApp
{
    partial class Idea
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Idea));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsCmbFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.tsLblUsername = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.rtbMainEditor = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLblWordCounted = new System.Windows.Forms.ToolStripLabel();
            this.tsBtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNewFile = new System.Windows.Forms.ToolStripButton();
            this.stBtnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.tsbBtnSave = new System.Windows.Forms.ToolStripButton();
            this.stBtnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.tsBtnBoldText = new System.Windows.Forms.ToolStripButton();
            this.tsBtnItalic = new System.Windows.Forms.ToolStripButton();
            this.tsBtnUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.tsmItemNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Checked = true;
            this.fileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItemNewFile,
            this.tsmItemOpenFile,
            this.toolStripSeparator1,
            this.tsMenuItemSave,
            this.tsMenuItemSaveAs,
            this.toolStripSeparator2,
            this.tsMenuItemLogout});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(217, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemUndo,
            this.tsMenuItemRedo,
            this.toolStripSeparator4,
            this.tsMenuItemCut,
            this.tsMenuItemCopy,
            this.tsMenuItemPaste});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnNewFile,
            this.stBtnOpenFile,
            this.tsbBtnSave,
            this.stBtnSaveAs,
            this.toolStripSeparator3,
            this.tsBtnBoldText,
            this.tsBtnItalic,
            this.tsBtnUnderline,
            this.tsCmbFontSize,
            this.tsLblUsername,
            this.toolStripButton8,
            this.toolStripSeparator6,
            this.tsLblWordCounted});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // tsCmbFontSize
            // 
            this.tsCmbFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsCmbFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.tsCmbFontSize.MaxLength = 2;
            this.tsCmbFontSize.Name = "tsCmbFontSize";
            this.tsCmbFontSize.Size = new System.Drawing.Size(121, 28);
            this.tsCmbFontSize.SelectedIndexChanged += new System.EventHandler(this.tsCmbFontSize_SelectedIndexChanged);
            // 
            // tsLblUsername
            // 
            this.tsLblUsername.Name = "tsLblUsername";
            this.tsLblUsername.Size = new System.Drawing.Size(108, 25);
            this.tsLblUsername.Text = "Username: jasa";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tsBtnCut,
            this.tsBtnCopy,
            this.tsBtnPaste,
            this.toolStripSeparator5,
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 56);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(45, 394);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // rtbMainEditor
            // 
            this.rtbMainEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMainEditor.Location = new System.Drawing.Point(48, 59);
            this.rtbMainEditor.Name = "rtbMainEditor";
            this.rtbMainEditor.Size = new System.Drawing.Size(740, 379);
            this.rtbMainEditor.TabIndex = 3;
            this.rtbMainEditor.Text = "";
            this.rtbMainEditor.TextChanged += new System.EventHandler(this.rtbMainEditor_TextChanged);
            this.rtbMainEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbMainEditor_KeyDown);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(193, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(42, 6);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 0);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(42, 20);
            this.toolStripLabel2.Text = "Tools";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // tsLblWordCounted
            // 
            this.tsLblWordCounted.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLblWordCounted.Margin = new System.Windows.Forms.Padding(0, 1, 9, 2);
            this.tsLblWordCounted.Name = "tsLblWordCounted";
            this.tsLblWordCounted.Size = new System.Drawing.Size(55, 25);
            this.tsLblWordCounted.Text = "0 word";
            this.tsLblWordCounted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsLblWordCounted.ToolTipText = "Word counted";
            // 
            // tsBtnCut
            // 
            this.tsBtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCut.Image = global::TextEditorApp.Properties.Resources.cut;
            this.tsBtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCut.Name = "tsBtnCut";
            this.tsBtnCut.Size = new System.Drawing.Size(42, 24);
            this.tsBtnCut.Text = "Cut";
            this.tsBtnCut.Click += new System.EventHandler(this.tsBtnCut_Click);
            // 
            // tsBtnCopy
            // 
            this.tsBtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCopy.Image = global::TextEditorApp.Properties.Resources.copy;
            this.tsBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCopy.Name = "tsBtnCopy";
            this.tsBtnCopy.Size = new System.Drawing.Size(42, 24);
            this.tsBtnCopy.Text = "Copy";
            this.tsBtnCopy.ToolTipText = "Copy";
            this.tsBtnCopy.Click += new System.EventHandler(this.tsBtnCopy_Click);
            // 
            // tsBtnPaste
            // 
            this.tsBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPaste.Image = global::TextEditorApp.Properties.Resources.paste;
            this.tsBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPaste.Name = "tsBtnPaste";
            this.tsBtnPaste.Size = new System.Drawing.Size(42, 24);
            this.tsBtnPaste.Text = "Paste";
            this.tsBtnPaste.Click += new System.EventHandler(this.tsBtnPaste_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::TextEditorApp.Properties.Resources.icons8_undo_48;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(42, 24);
            this.toolStripButton1.Text = "tsBtnUndo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::TextEditorApp.Properties.Resources.icons8_redo_48;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(42, 24);
            this.toolStripButton2.Text = "tsBtnRedo";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsBtnNewFile
            // 
            this.tsBtnNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNewFile.Image = global::TextEditorApp.Properties.Resources.new_file;
            this.tsBtnNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNewFile.Name = "tsBtnNewFile";
            this.tsBtnNewFile.Size = new System.Drawing.Size(29, 25);
            this.tsBtnNewFile.Text = "New FIle";
            this.tsBtnNewFile.ToolTipText = "New File";
            this.tsBtnNewFile.Click += new System.EventHandler(this.tsBtnNewFile_Click);
            // 
            // stBtnOpenFile
            // 
            this.stBtnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stBtnOpenFile.Image = global::TextEditorApp.Properties.Resources.open;
            this.stBtnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stBtnOpenFile.Name = "stBtnOpenFile";
            this.stBtnOpenFile.Size = new System.Drawing.Size(29, 25);
            this.stBtnOpenFile.Text = "Open File";
            this.stBtnOpenFile.Click += new System.EventHandler(this.stBtnOpenFile_Click);
            // 
            // tsbBtnSave
            // 
            this.tsbBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBtnSave.Image = global::TextEditorApp.Properties.Resources.save;
            this.tsbBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBtnSave.Name = "tsbBtnSave";
            this.tsbBtnSave.Size = new System.Drawing.Size(29, 25);
            this.tsbBtnSave.Text = "Save";
            this.tsbBtnSave.Click += new System.EventHandler(this.tsbBtnSave_Click);
            // 
            // stBtnSaveAs
            // 
            this.stBtnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stBtnSaveAs.Image = global::TextEditorApp.Properties.Resources.save_as;
            this.stBtnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stBtnSaveAs.Name = "stBtnSaveAs";
            this.stBtnSaveAs.Size = new System.Drawing.Size(29, 25);
            this.stBtnSaveAs.Text = "Save As";
            this.stBtnSaveAs.Click += new System.EventHandler(this.stBtnSaveAs_Click);
            // 
            // tsBtnBoldText
            // 
            this.tsBtnBoldText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnBoldText.Image = global::TextEditorApp.Properties.Resources.bold;
            this.tsBtnBoldText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBoldText.Name = "tsBtnBoldText";
            this.tsBtnBoldText.Size = new System.Drawing.Size(29, 25);
            this.tsBtnBoldText.Text = "Bold Text";
            this.tsBtnBoldText.Click += new System.EventHandler(this.tsBtnBoldText_Click);
            // 
            // tsBtnItalic
            // 
            this.tsBtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnItalic.Image = global::TextEditorApp.Properties.Resources.italic;
            this.tsBtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnItalic.Name = "tsBtnItalic";
            this.tsBtnItalic.Size = new System.Drawing.Size(29, 25);
            this.tsBtnItalic.Text = "Italic";
            this.tsBtnItalic.Click += new System.EventHandler(this.tsBtnItalic_Click);
            // 
            // tsBtnUnderline
            // 
            this.tsBtnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnUnderline.Image = global::TextEditorApp.Properties.Resources.underline;
            this.tsBtnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnUnderline.Name = "tsBtnUnderline";
            this.tsBtnUnderline.Size = new System.Drawing.Size(29, 25);
            this.tsBtnUnderline.Text = "Underline";
            this.tsBtnUnderline.Click += new System.EventHandler(this.tsBtnUnderline_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::TextEditorApp.Properties.Resources.icons8_help_48;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton8.Text = "toolStripButton8";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // tsmItemNewFile
            // 
            this.tsmItemNewFile.Image = global::TextEditorApp.Properties.Resources.new_file;
            this.tsmItemNewFile.Name = "tsmItemNewFile";
            this.tsmItemNewFile.Size = new System.Drawing.Size(220, 26);
            this.tsmItemNewFile.Tag = "";
            this.tsmItemNewFile.Text = "New           Ctrl + N";
            this.tsmItemNewFile.ToolTipText = "New File";
            this.tsmItemNewFile.Click += new System.EventHandler(this.tsmItemNewFile_Click);
            // 
            // tsmItemOpenFile
            // 
            this.tsmItemOpenFile.Image = global::TextEditorApp.Properties.Resources.open;
            this.tsmItemOpenFile.Name = "tsmItemOpenFile";
            this.tsmItemOpenFile.Size = new System.Drawing.Size(220, 26);
            this.tsmItemOpenFile.Text = "Open          Ctrl + O";
            this.tsmItemOpenFile.ToolTipText = "Open File";
            this.tsmItemOpenFile.Click += new System.EventHandler(this.tsmItemOpenFile_Click);
            // 
            // tsMenuItemSave
            // 
            this.tsMenuItemSave.Image = global::TextEditorApp.Properties.Resources.save;
            this.tsMenuItemSave.Name = "tsMenuItemSave";
            this.tsMenuItemSave.Size = new System.Drawing.Size(220, 26);
            this.tsMenuItemSave.Text = "Save           Ctrl + S";
            this.tsMenuItemSave.Click += new System.EventHandler(this.tsMenuItemSave_Click);
            // 
            // tsMenuItemSaveAs
            // 
            this.tsMenuItemSaveAs.Image = global::TextEditorApp.Properties.Resources.save_as;
            this.tsMenuItemSaveAs.Name = "tsMenuItemSaveAs";
            this.tsMenuItemSaveAs.Size = new System.Drawing.Size(220, 26);
            this.tsMenuItemSaveAs.Text = "Save As";
            this.tsMenuItemSaveAs.ToolTipText = "Save As";
            this.tsMenuItemSaveAs.Click += new System.EventHandler(this.tsMenuItemSaveAs_Click);
            // 
            // tsMenuItemLogout
            // 
            this.tsMenuItemLogout.Image = global::TextEditorApp.Properties.Resources.logout;
            this.tsMenuItemLogout.Name = "tsMenuItemLogout";
            this.tsMenuItemLogout.Size = new System.Drawing.Size(220, 26);
            this.tsMenuItemLogout.Text = "Logout";
            this.tsMenuItemLogout.Click += new System.EventHandler(this.tsMenuItemLogout_Click);
            // 
            // tsMenuItemUndo
            // 
            this.tsMenuItemUndo.Image = global::TextEditorApp.Properties.Resources.icons8_undo_48;
            this.tsMenuItemUndo.Name = "tsMenuItemUndo";
            this.tsMenuItemUndo.Size = new System.Drawing.Size(196, 26);
            this.tsMenuItemUndo.Text = "Undo    Ctrl + Z";
            this.tsMenuItemUndo.Click += new System.EventHandler(this.tsMenuItemUndo_Click);
            // 
            // tsMenuItemRedo
            // 
            this.tsMenuItemRedo.Image = global::TextEditorApp.Properties.Resources.icons8_redo_48;
            this.tsMenuItemRedo.Name = "tsMenuItemRedo";
            this.tsMenuItemRedo.Size = new System.Drawing.Size(196, 26);
            this.tsMenuItemRedo.Text = "Redo    Ctrl + Q";
            this.tsMenuItemRedo.Click += new System.EventHandler(this.tsMenuItemRedo_Click);
            // 
            // tsMenuItemCut
            // 
            this.tsMenuItemCut.Image = global::TextEditorApp.Properties.Resources.cut;
            this.tsMenuItemCut.Name = "tsMenuItemCut";
            this.tsMenuItemCut.Size = new System.Drawing.Size(196, 26);
            this.tsMenuItemCut.Text = "Cut        Ctrl + X";
            this.tsMenuItemCut.Click += new System.EventHandler(this.tsMenuItemCut_Click);
            // 
            // tsMenuItemCopy
            // 
            this.tsMenuItemCopy.Image = global::TextEditorApp.Properties.Resources.copy;
            this.tsMenuItemCopy.Name = "tsMenuItemCopy";
            this.tsMenuItemCopy.Size = new System.Drawing.Size(196, 26);
            this.tsMenuItemCopy.Text = "Copy     Ctrl + C";
            this.tsMenuItemCopy.Click += new System.EventHandler(this.tsMenuItemCopy_Click);
            // 
            // tsMenuItemPaste
            // 
            this.tsMenuItemPaste.Image = global::TextEditorApp.Properties.Resources.paste;
            this.tsMenuItemPaste.Name = "tsMenuItemPaste";
            this.tsMenuItemPaste.Size = new System.Drawing.Size(196, 26);
            this.tsMenuItemPaste.Text = "Paste     Ctrl + X";
            this.tsMenuItemPaste.Click += new System.EventHandler(this.tsMenuItemPaste_Click);
            // 
            // tsMenuItemAbout
            // 
            this.tsMenuItemAbout.Image = global::TextEditorApp.Properties.Resources.about;
            this.tsMenuItemAbout.Name = "tsMenuItemAbout";
            this.tsMenuItemAbout.Size = new System.Drawing.Size(133, 26);
            this.tsMenuItemAbout.Text = "About";
            this.tsMenuItemAbout.Click += new System.EventHandler(this.tsMenuItemAbout_Click);
            // 
            // Idea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbMainEditor);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Idea";
            this.Text = "Idea";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Idea_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Idea_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmItemNewFile;
        private System.Windows.Forms.ToolStripMenuItem tsmItemOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemPaste;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnNewFile;
        private System.Windows.Forms.ToolStripButton stBtnOpenFile;
        private System.Windows.Forms.ToolStripButton tsbBtnSave;
        private System.Windows.Forms.ToolStripButton stBtnSaveAs;
        private System.Windows.Forms.ToolStripButton tsBtnBoldText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnItalic;
        private System.Windows.Forms.ToolStripButton tsBtnUnderline;
        private System.Windows.Forms.ToolStripComboBox tsCmbFontSize;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripLabel tsLblUsername;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsBtnCut;
        private System.Windows.Forms.ToolStripButton tsBtnCopy;
        private System.Windows.Forms.ToolStripButton tsBtnPaste;
        private System.Windows.Forms.RichTextBox rtbMainEditor;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemUndo;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel tsLblWordCounted;
    }
}