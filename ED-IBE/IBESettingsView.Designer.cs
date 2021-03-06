﻿namespace IBE
{
    partial class IBESettingsView
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IBESettingsView));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gbTesseract = new System.Windows.Forms.GroupBox();
            this.txtOCRTraineddataFile = new System.Windows.Forms.TextBox();
            this.cmdSelectTraineddataFile = new System.Windows.Forms.ButtonExt();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cmdFilter = new System.Windows.Forms.ButtonExt();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.txtGUIColorCutoffLevel = new System.Windows.Forms.TextBoxInt32();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label52 = new System.Windows.Forms.Label();
            this.cbCheckNextScreenshotForOne = new System.Windows.Forms.CheckBox();
            this.lblPixelAmount = new System.Windows.Forms.Label();
            this.txtOCRPixelAmount = new System.Windows.Forms.TextBoxInt32();
            this.lblPixelThreshold = new System.Windows.Forms.Label();
            this.txtOCRPixelThreshold = new System.Windows.Forms.TextBoxDouble();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cbAutoAdd_LoadGame = new System.Windows.Forms.CheckBox();
            this.cbAutoAdd_MissionAbandoned = new System.Windows.Forms.CheckBox();
            this.cbAutoAdd_MissionFailed = new System.Windows.Forms.CheckBox();
            this.cbAutoAdd_MissionCompleted = new System.Windows.Forms.CheckBox();
            this.cbAutoAdd_MissionAccepted = new System.Windows.Forms.CheckBox();
            this.cbAutoAdd_Liftoff = new System.Windows.Forms.CheckBox();
            this.cbAutoAdd_Touchdown = new System.Windows.Forms.CheckBox();
            this.cbAutoAdd_Scan = new System.Windows.Forms.CheckBox();
            this.cbAutoAdd_ReplaceVisited = new System.Windows.Forms.CheckBox();
            this.cbAutoAdd_Marketdata = new System.Windows.Forms.CheckBox();
            this.cbAutoAdd_Visited = new System.Windows.Forms.CheckBox();
            this.label49 = new System.Windows.Forms.Label();
            this.cbAutoAdd_JumpedTo = new System.Windows.Forms.CheckBox();
            this.label48 = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.cbAutoActivateSystemTab = new System.Windows.Forms.CheckBox();
            this.cbAutoActivateOCRTab = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.ButtonExt();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label25 = new System.Windows.Forms.Label();
            this.cmbVisitedFilter = new System.Windows.Forms.ComboBoxInt32();
            this.txtSQLConnectionPort = new System.Windows.Forms.TextBoxInt32();
            this.cmdChangeSQLPort = new System.Windows.Forms.ButtonExt();
            this.label7 = new System.Windows.Forms.Label();
            this.gbVNCTest = new System.Windows.Forms.GroupBox();
            this.cbActivateVNC = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbNoDistanceToStarConsider = new System.Windows.Forms.RadioButton();
            this.rbNoDistanceToStarIgnore = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbNoLandingPadSizeConsider = new System.Windows.Forms.RadioButton();
            this.rbNoLandingPadSizeIgnore = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDataInterface = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtGamePath = new System.Windows.Forms.TextBox();
            this.cmdGamePath = new System.Windows.Forms.ButtonExt();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtJournalPath = new System.Windows.Forms.TextBox();
            this.cmdJournalPath = new System.Windows.Forms.ButtonExt();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.cbAutoMinimize = new System.Windows.Forms.CheckBox();
            this.groupBox6.SuspendLayout();
            this.gbTesseract.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.gbVNCTest.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbDataInterface.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.gbTesseract);
            this.groupBox6.Controls.Add(this.groupBox9);
            this.groupBox6.Controls.Add(this.groupBox11);
            this.groupBox6.Location = new System.Drawing.Point(6, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(91, 46);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "OCR-Settings";
            this.groupBox6.Visible = false;
            // 
            // gbTesseract
            // 
            this.gbTesseract.Controls.Add(this.txtOCRTraineddataFile);
            this.gbTesseract.Controls.Add(this.cmdSelectTraineddataFile);
            this.gbTesseract.Controls.Add(this.label12);
            this.gbTesseract.Location = new System.Drawing.Point(11, 16);
            this.gbTesseract.Name = "gbTesseract";
            this.gbTesseract.Size = new System.Drawing.Size(583, 68);
            this.gbTesseract.TabIndex = 16;
            this.gbTesseract.TabStop = false;
            this.gbTesseract.Text = "Tesseract Setting";
            // 
            // txtOCRTraineddataFile
            // 
            this.txtOCRTraineddataFile.Location = new System.Drawing.Point(102, 32);
            this.txtOCRTraineddataFile.Name = "txtOCRTraineddataFile";
            this.txtOCRTraineddataFile.ReadOnly = true;
            this.txtOCRTraineddataFile.Size = new System.Drawing.Size(197, 20);
            this.txtOCRTraineddataFile.TabIndex = 13;
            this.txtOCRTraineddataFile.Tag = "OCRTraineddataFile;big";
            // 
            // cmdSelectTraineddataFile
            // 
            this.cmdSelectTraineddataFile.DisabledTextColor = System.Drawing.Color.DimGray;
            this.cmdSelectTraineddataFile.Location = new System.Drawing.Point(346, 30);
            this.cmdSelectTraineddataFile.Name = "cmdSelectTraineddataFile";
            this.cmdSelectTraineddataFile.Size = new System.Drawing.Size(176, 23);
            this.cmdSelectTraineddataFile.TabIndex = 8;
            this.cmdSelectTraineddataFile.Text = "Select";
            this.cmdSelectTraineddataFile.UseVisualStyleBackColor = true;
            this.cmdSelectTraineddataFile.Click += new System.EventHandler(this.cmdSelectTraineddataFile_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(122, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "\"traineddata\"-File for TesseractOCR";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cmdFilter);
            this.groupBox9.Controls.Add(this.label50);
            this.groupBox9.Controls.Add(this.label51);
            this.groupBox9.Controls.Add(this.txtGUIColorCutoffLevel);
            this.groupBox9.Location = new System.Drawing.Point(11, 237);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(583, 150);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "UI Color Cutoff Level";
            // 
            // cmdFilter
            // 
            this.cmdFilter.DisabledTextColor = System.Drawing.Color.DimGray;
            this.cmdFilter.Location = new System.Drawing.Point(350, 107);
            this.cmdFilter.Name = "cmdFilter";
            this.cmdFilter.Size = new System.Drawing.Size(176, 23);
            this.cmdFilter.TabIndex = 18;
            this.cmdFilter.Text = "Filter-Test";
            this.cmdFilter.UseVisualStyleBackColor = true;
            this.cmdFilter.Click += new System.EventHandler(this.cmdFilter_Click);
            // 
            // label50
            // 
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(18, 19);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(526, 85);
            this.label50.TabIndex = 15;
            this.label50.Text = resources.GetString("label50.Text");
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(18, 110);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(215, 13);
            this.label51.TabIndex = 14;
            this.label51.Text = "UI Color Cutoff Level (0 to 255, default=150)";
            // 
            // txtGUIColorCutoffLevel
            // 
            this.txtGUIColorCutoffLevel.Location = new System.Drawing.Point(239, 107);
            this.txtGUIColorCutoffLevel.MaxValue = 255;
            this.txtGUIColorCutoffLevel.MinValue = 0;
            this.txtGUIColorCutoffLevel.Name = "txtGUIColorCutoffLevel";
            this.txtGUIColorCutoffLevel.Size = new System.Drawing.Size(37, 20);
            this.txtGUIColorCutoffLevel.TabIndex = 13;
            this.txtGUIColorCutoffLevel.Tag = "GUIColorCutoffLevelValue;150";
            this.txtGUIColorCutoffLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGUIColorCutoffLevel_KeyDown);
            this.txtGUIColorCutoffLevel.Leave += new System.EventHandler(this.txtGUIColorCutoffLevel_Leave);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label52);
            this.groupBox11.Controls.Add(this.cbCheckNextScreenshotForOne);
            this.groupBox11.Controls.Add(this.lblPixelAmount);
            this.groupBox11.Controls.Add(this.txtOCRPixelAmount);
            this.groupBox11.Controls.Add(this.lblPixelThreshold);
            this.groupBox11.Controls.Add(this.txtOCRPixelThreshold);
            this.groupBox11.Location = new System.Drawing.Point(11, 90);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(583, 141);
            this.groupBox11.TabIndex = 14;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "OCR Performance Improvement";
            // 
            // label52
            // 
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(18, 17);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(554, 71);
            this.label52.TabIndex = 19;
            this.label52.Text = resources.GetString("label52.Text");
            // 
            // cbCheckNextScreenshotForOne
            // 
            this.cbCheckNextScreenshotForOne.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbCheckNextScreenshotForOne.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.cbCheckNextScreenshotForOne.Location = new System.Drawing.Point(350, 97);
            this.cbCheckNextScreenshotForOne.Name = "cbCheckNextScreenshotForOne";
            this.cbCheckNextScreenshotForOne.Size = new System.Drawing.Size(176, 23);
            this.cbCheckNextScreenshotForOne.TabIndex = 18;
            this.cbCheckNextScreenshotForOne.Tag = "CheckNextScreenshotForOne;false";
            this.cbCheckNextScreenshotForOne.Text = "check next screenshot for a \"1\"";
            this.cbCheckNextScreenshotForOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCheckNextScreenshotForOne.UseVisualStyleBackColor = true;
            // 
            // lblPixelAmount
            // 
            this.lblPixelAmount.AutoSize = true;
            this.lblPixelAmount.Location = new System.Drawing.Point(18, 118);
            this.lblPixelAmount.Name = "lblPixelAmount";
            this.lblPixelAmount.Size = new System.Drawing.Size(179, 13);
            this.lblPixelAmount.TabIndex = 16;
            this.lblPixelAmount.Text = "dark pixel amount (default=22, 0=off)";
            // 
            // txtOCRPixelAmount
            // 
            this.txtOCRPixelAmount.Location = new System.Drawing.Point(212, 115);
            this.txtOCRPixelAmount.MaxValue = null;
            this.txtOCRPixelAmount.MinValue = null;
            this.txtOCRPixelAmount.Name = "txtOCRPixelAmount";
            this.txtOCRPixelAmount.Size = new System.Drawing.Size(37, 20);
            this.txtOCRPixelAmount.TabIndex = 15;
            this.txtOCRPixelAmount.Tag = "OCRPixelAmountValue;22";
            this.txtOCRPixelAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOCRPixelAmount_KeyDown);
            this.txtOCRPixelAmount.Leave += new System.EventHandler(this.txtOCRPixelAmount_Leave);
            // 
            // lblPixelThreshold
            // 
            this.lblPixelThreshold.AutoSize = true;
            this.lblPixelThreshold.Location = new System.Drawing.Point(18, 91);
            this.lblPixelThreshold.Name = "lblPixelThreshold";
            this.lblPixelThreshold.Size = new System.Drawing.Size(160, 13);
            this.lblPixelThreshold.TabIndex = 14;
            this.lblPixelThreshold.Text = "dark pixel threshold (default=0.6)";
            // 
            // txtOCRPixelThreshold
            // 
            this.txtOCRPixelThreshold.Digits = 2;
            this.txtOCRPixelThreshold.Location = new System.Drawing.Point(212, 88);
            this.txtOCRPixelThreshold.MaxValue = 1D;
            this.txtOCRPixelThreshold.MinValue = 0.01D;
            this.txtOCRPixelThreshold.Name = "txtOCRPixelThreshold";
            this.txtOCRPixelThreshold.Size = new System.Drawing.Size(37, 20);
            this.txtOCRPixelThreshold.TabIndex = 13;
            this.txtOCRPixelThreshold.Tag = "OCRPixelThresholdValue;0.6";
            this.txtOCRPixelThreshold.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOCRPixelThreshold_KeyDown);
            this.txtOCRPixelThreshold.Leave += new System.EventHandler(this.txtOCRPixelThreshold_Leave);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cbAutoAdd_LoadGame);
            this.groupBox10.Controls.Add(this.cbAutoAdd_MissionAbandoned);
            this.groupBox10.Controls.Add(this.cbAutoAdd_MissionFailed);
            this.groupBox10.Controls.Add(this.cbAutoAdd_MissionCompleted);
            this.groupBox10.Controls.Add(this.cbAutoAdd_MissionAccepted);
            this.groupBox10.Controls.Add(this.cbAutoAdd_Liftoff);
            this.groupBox10.Controls.Add(this.cbAutoAdd_Touchdown);
            this.groupBox10.Controls.Add(this.cbAutoAdd_Scan);
            this.groupBox10.Controls.Add(this.cbAutoAdd_ReplaceVisited);
            this.groupBox10.Controls.Add(this.cbAutoAdd_Marketdata);
            this.groupBox10.Controls.Add(this.cbAutoAdd_Visited);
            this.groupBox10.Controls.Add(this.label49);
            this.groupBox10.Controls.Add(this.cbAutoAdd_JumpedTo);
            this.groupBox10.Location = new System.Drawing.Point(12, 188);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(385, 392);
            this.groupBox10.TabIndex = 12;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Commander\'s Log";
            // 
            // cbAutoAdd_LoadGame
            // 
            this.cbAutoAdd_LoadGame.AutoSize = true;
            this.cbAutoAdd_LoadGame.Location = new System.Drawing.Point(31, 295);
            this.cbAutoAdd_LoadGame.Name = "cbAutoAdd_LoadGame";
            this.cbAutoAdd_LoadGame.Size = new System.Drawing.Size(119, 17);
            this.cbAutoAdd_LoadGame.TabIndex = 12;
            this.cbAutoAdd_LoadGame.Tag = "AutoAdd_LoadGame;true";
            this.cbAutoAdd_LoadGame.Text = "\"LoadGame\"-Event";
            this.cbAutoAdd_LoadGame.UseVisualStyleBackColor = true;
            this.cbAutoAdd_LoadGame.CheckedChanged += new System.EventHandler(this.ComboBox_CheckedChanged);
            // 
            // cbAutoAdd_MissionAbandoned
            // 
            this.cbAutoAdd_MissionAbandoned.AutoSize = true;
            this.cbAutoAdd_MissionAbandoned.Location = new System.Drawing.Point(31, 272);
            this.cbAutoAdd_MissionAbandoned.Name = "cbAutoAdd_MissionAbandoned";
            this.cbAutoAdd_MissionAbandoned.Size = new System.Drawing.Size(157, 17);
            this.cbAutoAdd_MissionAbandoned.TabIndex = 11;
            this.cbAutoAdd_MissionAbandoned.Tag = "AutoAdd_MissionAbandoned;true";
            this.cbAutoAdd_MissionAbandoned.Text = "\"MissionAbandoned\"-Event";
            this.cbAutoAdd_MissionAbandoned.UseVisualStyleBackColor = true;
            this.cbAutoAdd_MissionAbandoned.CheckedChanged += new System.EventHandler(this.ComboBox_CheckedChanged);
            // 
            // cbAutoAdd_MissionFailed
            // 
            this.cbAutoAdd_MissionFailed.AutoSize = true;
            this.cbAutoAdd_MissionFailed.Location = new System.Drawing.Point(31, 249);
            this.cbAutoAdd_MissionFailed.Name = "cbAutoAdd_MissionFailed";
            this.cbAutoAdd_MissionFailed.Size = new System.Drawing.Size(130, 17);
            this.cbAutoAdd_MissionFailed.TabIndex = 10;
            this.cbAutoAdd_MissionFailed.Tag = "AutoAdd_MissionFailed;true";
            this.cbAutoAdd_MissionFailed.Text = "\"MissionFailed\"-Event";
            this.cbAutoAdd_MissionFailed.UseVisualStyleBackColor = true;
            this.cbAutoAdd_MissionFailed.CheckedChanged += new System.EventHandler(this.ComboBox_CheckedChanged);
            // 
            // cbAutoAdd_MissionCompleted
            // 
            this.cbAutoAdd_MissionCompleted.AutoSize = true;
            this.cbAutoAdd_MissionCompleted.Location = new System.Drawing.Point(31, 226);
            this.cbAutoAdd_MissionCompleted.Name = "cbAutoAdd_MissionCompleted";
            this.cbAutoAdd_MissionCompleted.Size = new System.Drawing.Size(152, 17);
            this.cbAutoAdd_MissionCompleted.TabIndex = 9;
            this.cbAutoAdd_MissionCompleted.Tag = "AutoAdd_MissionCompleted;true";
            this.cbAutoAdd_MissionCompleted.Text = "\"MissionCompleted\"-Event";
            this.cbAutoAdd_MissionCompleted.UseVisualStyleBackColor = true;
            this.cbAutoAdd_MissionCompleted.CheckedChanged += new System.EventHandler(this.ComboBox_CheckedChanged);
            // 
            // cbAutoAdd_MissionAccepted
            // 
            this.cbAutoAdd_MissionAccepted.AutoSize = true;
            this.cbAutoAdd_MissionAccepted.Location = new System.Drawing.Point(31, 203);
            this.cbAutoAdd_MissionAccepted.Name = "cbAutoAdd_MissionAccepted";
            this.cbAutoAdd_MissionAccepted.Size = new System.Drawing.Size(148, 17);
            this.cbAutoAdd_MissionAccepted.TabIndex = 8;
            this.cbAutoAdd_MissionAccepted.Tag = "AutoAdd_MissionAccepted;true";
            this.cbAutoAdd_MissionAccepted.Text = "\"MissionAccepted\"-Event";
            this.cbAutoAdd_MissionAccepted.UseVisualStyleBackColor = true;
            this.cbAutoAdd_MissionAccepted.CheckedChanged += new System.EventHandler(this.ComboBox_CheckedChanged);
            // 
            // cbAutoAdd_Liftoff
            // 
            this.cbAutoAdd_Liftoff.AutoSize = true;
            this.cbAutoAdd_Liftoff.Location = new System.Drawing.Point(32, 180);
            this.cbAutoAdd_Liftoff.Name = "cbAutoAdd_Liftoff";
            this.cbAutoAdd_Liftoff.Size = new System.Drawing.Size(93, 17);
            this.cbAutoAdd_Liftoff.TabIndex = 7;
            this.cbAutoAdd_Liftoff.Tag = "AutoAdd_Liftoff;true";
            this.cbAutoAdd_Liftoff.Text = "\"Liftoff\"-Event";
            this.cbAutoAdd_Liftoff.UseVisualStyleBackColor = true;
            this.cbAutoAdd_Liftoff.CheckedChanged += new System.EventHandler(this.ComboBox_CheckedChanged);
            // 
            // cbAutoAdd_Touchdown
            // 
            this.cbAutoAdd_Touchdown.AutoSize = true;
            this.cbAutoAdd_Touchdown.Location = new System.Drawing.Point(32, 157);
            this.cbAutoAdd_Touchdown.Name = "cbAutoAdd_Touchdown";
            this.cbAutoAdd_Touchdown.Size = new System.Drawing.Size(124, 17);
            this.cbAutoAdd_Touchdown.TabIndex = 6;
            this.cbAutoAdd_Touchdown.Tag = "AutoAdd_Touchdown;true";
            this.cbAutoAdd_Touchdown.Text = "\"Touchdown\"-Event";
            this.cbAutoAdd_Touchdown.UseVisualStyleBackColor = true;
            this.cbAutoAdd_Touchdown.CheckedChanged += new System.EventHandler(this.ComboBox_CheckedChanged);
            // 
            // cbAutoAdd_Scan
            // 
            this.cbAutoAdd_Scan.AutoSize = true;
            this.cbAutoAdd_Scan.Location = new System.Drawing.Point(32, 134);
            this.cbAutoAdd_Scan.Name = "cbAutoAdd_Scan";
            this.cbAutoAdd_Scan.Size = new System.Drawing.Size(92, 17);
            this.cbAutoAdd_Scan.TabIndex = 5;
            this.cbAutoAdd_Scan.Tag = "AutoAdd_Scan;true";
            this.cbAutoAdd_Scan.Text = "\"Scan\"-Event";
            this.cbAutoAdd_Scan.UseVisualStyleBackColor = true;
            this.cbAutoAdd_Scan.CheckedChanged += new System.EventHandler(this.ComboBox_CheckedChanged);
            // 
            // cbAutoAdd_ReplaceVisited
            // 
            this.cbAutoAdd_ReplaceVisited.AutoSize = true;
            this.cbAutoAdd_ReplaceVisited.Location = new System.Drawing.Point(60, 111);
            this.cbAutoAdd_ReplaceVisited.Name = "cbAutoAdd_ReplaceVisited";
            this.cbAutoAdd_ReplaceVisited.Size = new System.Drawing.Size(292, 17);
            this.cbAutoAdd_ReplaceVisited.TabIndex = 4;
            this.cbAutoAdd_ReplaceVisited.Tag = "AutoAdd_ReplaceVisited;true";
            this.cbAutoAdd_ReplaceVisited.Text = "replace previous \"Visited\" with  \"Market Data Collected\"";
            this.cbAutoAdd_ReplaceVisited.UseVisualStyleBackColor = true;
            this.cbAutoAdd_ReplaceVisited.CheckedChanged += new System.EventHandler(this.ComboBox_CheckedChanged);
            // 
            // cbAutoAdd_Marketdata
            // 
            this.cbAutoAdd_Marketdata.AutoSize = true;
            this.cbAutoAdd_Marketdata.Location = new System.Drawing.Point(32, 90);
            this.cbAutoAdd_Marketdata.Name = "cbAutoAdd_Marketdata";
            this.cbAutoAdd_Marketdata.Size = new System.Drawing.Size(173, 17);
            this.cbAutoAdd_Marketdata.TabIndex = 3;
            this.cbAutoAdd_Marketdata.Tag = "AutoAdd_Marketdata;true";
            this.cbAutoAdd_Marketdata.Text = "\"Market Data Collected\"-Event";
            this.cbAutoAdd_Marketdata.UseVisualStyleBackColor = true;
            this.cbAutoAdd_Marketdata.CheckedChanged += new System.EventHandler(this.ComboBox_CheckedChanged);
            // 
            // cbAutoAdd_Visited
            // 
            this.cbAutoAdd_Visited.AutoSize = true;
            this.cbAutoAdd_Visited.Location = new System.Drawing.Point(32, 67);
            this.cbAutoAdd_Visited.Name = "cbAutoAdd_Visited";
            this.cbAutoAdd_Visited.Size = new System.Drawing.Size(98, 17);
            this.cbAutoAdd_Visited.TabIndex = 2;
            this.cbAutoAdd_Visited.Tag = "AutoAdd_Visited;true";
            this.cbAutoAdd_Visited.Text = "\"Visited\"-Event";
            this.cbAutoAdd_Visited.UseVisualStyleBackColor = true;
            this.cbAutoAdd_Visited.CheckedChanged += new System.EventHandler(this.ComboBox_CheckedChanged);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(29, 22);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(195, 13);
            this.label49.TabIndex = 1;
            this.label49.Text = "generate following events automatically:";
            // 
            // cbAutoAdd_JumpedTo
            // 
            this.cbAutoAdd_JumpedTo.AutoSize = true;
            this.cbAutoAdd_JumpedTo.Location = new System.Drawing.Point(32, 44);
            this.cbAutoAdd_JumpedTo.Name = "cbAutoAdd_JumpedTo";
            this.cbAutoAdd_JumpedTo.Size = new System.Drawing.Size(116, 17);
            this.cbAutoAdd_JumpedTo.TabIndex = 0;
            this.cbAutoAdd_JumpedTo.Tag = "AutoAdd_JumpedTo;true";
            this.cbAutoAdd_JumpedTo.Text = "\"Jumped to\"-Event";
            this.cbAutoAdd_JumpedTo.UseVisualStyleBackColor = true;
            this.cbAutoAdd_JumpedTo.CheckedChanged += new System.EventHandler(this.ComboBox_CheckedChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(29, 80);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(255, 13);
            this.label48.TabIndex = 1;
            this.label48.Text = "Select the language of your Elite Dangerous version.";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(290, 77);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(75, 21);
            this.cmbLanguage.TabIndex = 0;
            this.cmbLanguage.Tag = "Language;eng";
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.Combobox_SelectedIndexChanged);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.cbAutoActivateSystemTab);
            this.groupBox12.Controls.Add(this.cbAutoActivateOCRTab);
            this.groupBox12.Controls.Add(this.button6);
            this.groupBox12.Location = new System.Drawing.Point(403, 329);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(501, 251);
            this.groupBox12.TabIndex = 14;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Other";
            // 
            // cbAutoActivateSystemTab
            // 
            this.cbAutoActivateSystemTab.AutoSize = true;
            this.cbAutoActivateSystemTab.Location = new System.Drawing.Point(32, 50);
            this.cbAutoActivateSystemTab.Name = "cbAutoActivateSystemTab";
            this.cbAutoActivateSystemTab.Size = new System.Drawing.Size(312, 17);
            this.cbAutoActivateSystemTab.TabIndex = 5;
            this.cbAutoActivateSystemTab.Tag = "AutoActivateSystemTab;true";
            this.cbAutoActivateSystemTab.Text = "automatically activate the \"System Data\" tab after hyperjump";
            this.cbAutoActivateSystemTab.UseVisualStyleBackColor = true;
            this.cbAutoActivateSystemTab.Visible = false;
            this.cbAutoActivateSystemTab.CheckedChanged += new System.EventHandler(this.ComboBox_CheckedChanged);
            // 
            // cbAutoActivateOCRTab
            // 
            this.cbAutoActivateOCRTab.AutoSize = true;
            this.cbAutoActivateOCRTab.Location = new System.Drawing.Point(32, 27);
            this.cbAutoActivateOCRTab.Name = "cbAutoActivateOCRTab";
            this.cbAutoActivateOCRTab.Size = new System.Drawing.Size(325, 17);
            this.cbAutoActivateOCRTab.TabIndex = 3;
            this.cbAutoActivateOCRTab.Tag = "AutoActivateOCRTab;true";
            this.cbAutoActivateOCRTab.Text = "Automatically activate the OCR-Tab when the recognition starts";
            this.cbAutoActivateOCRTab.UseVisualStyleBackColor = true;
            this.cbAutoActivateOCRTab.Visible = false;
            this.cbAutoActivateOCRTab.CheckedChanged += new System.EventHandler(this.ComboBox_CheckedChanged);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.DisabledTextColor = System.Drawing.Color.DimGray;
            this.button6.Location = new System.Drawing.Point(11, 186);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(226, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Edit Commodity Price Warn levels";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.cmdWarnLevels_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(12, 19);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 13);
            this.label25.TabIndex = 64;
            this.label25.Text = "Filter Setting";
            this.toolTip1.SetToolTip(this.label25, "Here you can select, if you want to see in all analysis");
            // 
            // cmbVisitedFilter
            // 
            this.cmbVisitedFilter.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.cmbVisitedFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVisitedFilter.FormattingEnabled = true;
            this.cmbVisitedFilter.Location = new System.Drawing.Point(83, 14);
            this.cmbVisitedFilter.MaxValue = null;
            this.cmbVisitedFilter.MinValue = null;
            this.cmbVisitedFilter.Name = "cmbVisitedFilter";
            this.cmbVisitedFilter.Size = new System.Drawing.Size(192, 21);
            this.cmbVisitedFilter.TabIndex = 63;
            this.cmbVisitedFilter.Tag = "VisitedFilter;0";
            this.toolTip1.SetToolTip(this.cmbVisitedFilter, "Here you can select, if you want to see in all analysis\r\n- all stations (independ" +
        "ent if you\'ve visted them or not)\r\n- only stations in systems you\'ve visited \r\n-" +
        " only stations you\'ve directly visted");
            this.cmbVisitedFilter.SelectedIndexChanged += new System.EventHandler(this.Combobox_SelectedIndexChanged);
            // 
            // txtSQLConnectionPort
            // 
            this.txtSQLConnectionPort.Location = new System.Drawing.Point(133, 114);
            this.txtSQLConnectionPort.MaxValue = null;
            this.txtSQLConnectionPort.MinValue = null;
            this.txtSQLConnectionPort.Name = "txtSQLConnectionPort";
            this.txtSQLConnectionPort.Size = new System.Drawing.Size(63, 20);
            this.txtSQLConnectionPort.TabIndex = 17;
            this.txtSQLConnectionPort.Tag = "OCRPixelAmountValue;22";
            this.toolTip1.SetToolTip(this.txtSQLConnectionPort, "connection port for the mysql-server (restart required)");
            this.txtSQLConnectionPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSQLConnectionPort_KeyPress);
            // 
            // cmdChangeSQLPort
            // 
            this.cmdChangeSQLPort.DisabledTextColor = System.Drawing.Color.DimGray;
            this.cmdChangeSQLPort.Location = new System.Drawing.Point(202, 112);
            this.cmdChangeSQLPort.Name = "cmdChangeSQLPort";
            this.cmdChangeSQLPort.Size = new System.Drawing.Size(55, 23);
            this.cmdChangeSQLPort.TabIndex = 19;
            this.cmdChangeSQLPort.Text = "Set";
            this.toolTip1.SetToolTip(this.cmdChangeSQLPort, "To resolve conflicts with other tools you can change ");
            this.cmdChangeSQLPort.UseVisualStyleBackColor = true;
            this.cmdChangeSQLPort.Click += new System.EventHandler(this.cmdChangeSQLPort_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "MySQL using Port :";
            this.toolTip1.SetToolTip(this.label7, "To resolve conflicts with other tools you can change ");
            // 
            // gbVNCTest
            // 
            this.gbVNCTest.Controls.Add(this.cbActivateVNC);
            this.gbVNCTest.Location = new System.Drawing.Point(414, 544);
            this.gbVNCTest.Name = "gbVNCTest";
            this.gbVNCTest.Size = new System.Drawing.Size(97, 17);
            this.gbVNCTest.TabIndex = 72;
            this.gbVNCTest.TabStop = false;
            this.gbVNCTest.Text = "NVC-Server";
            this.toolTip1.SetToolTip(this.gbVNCTest, "To resolve conflicts with other tools you can change \r\nthe port for the sql-commu" +
        "nication. Restart is required!");
            this.gbVNCTest.Visible = false;
            // 
            // cbActivateVNC
            // 
            this.cbActivateVNC.AutoSize = true;
            this.cbActivateVNC.Location = new System.Drawing.Point(41, 56);
            this.cbActivateVNC.Name = "cbActivateVNC";
            this.cbActivateVNC.Size = new System.Drawing.Size(65, 17);
            this.cbActivateVNC.TabIndex = 1;
            this.cbActivateVNC.Tag = "ActivateVNC;false";
            this.cbActivateVNC.Text = "Activate";
            this.toolTip1.SetToolTip(this.cbActivateVNC, "If you switch this you should restart IBE to take effect.");
            this.cbActivateVNC.UseVisualStyleBackColor = true;
            this.cbActivateVNC.CheckedChanged += new System.EventHandler(this.ComboBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox13);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbVisitedFilter);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Location = new System.Drawing.Point(403, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 169);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datafilter";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.radioButton1);
            this.groupBox13.Controls.Add(this.radioButton2);
            this.groupBox13.Location = new System.Drawing.Point(299, 116);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(197, 45);
            this.groupBox13.TabIndex = 68;
            this.groupBox13.TabStop = false;
            this.groupBox13.Tag = "NoLocation;consider";
            this.groupBox13.Text = "Stations Without Location";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "consider";
            this.radioButton1.Text = "Consider";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rbInterface_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(117, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Tag = "ignore";
            this.radioButton2.Text = "Ignore";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.rbInterface_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbNoDistanceToStarConsider);
            this.groupBox7.Controls.Add(this.rbNoDistanceToStarIgnore);
            this.groupBox7.Location = new System.Drawing.Point(299, 65);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(197, 45);
            this.groupBox7.TabIndex = 67;
            this.groupBox7.TabStop = false;
            this.groupBox7.Tag = "NoDistanceToStar;consider";
            this.groupBox7.Text = "Stations Without Distance-To-Star";
            // 
            // rbNoDistanceToStarConsider
            // 
            this.rbNoDistanceToStarConsider.AutoSize = true;
            this.rbNoDistanceToStarConsider.Checked = true;
            this.rbNoDistanceToStarConsider.Location = new System.Drawing.Point(23, 19);
            this.rbNoDistanceToStarConsider.Name = "rbNoDistanceToStarConsider";
            this.rbNoDistanceToStarConsider.Size = new System.Drawing.Size(66, 17);
            this.rbNoDistanceToStarConsider.TabIndex = 3;
            this.rbNoDistanceToStarConsider.TabStop = true;
            this.rbNoDistanceToStarConsider.Tag = "consider";
            this.rbNoDistanceToStarConsider.Text = "Consider";
            this.rbNoDistanceToStarConsider.UseVisualStyleBackColor = true;
            this.rbNoDistanceToStarConsider.CheckedChanged += new System.EventHandler(this.rbInterface_CheckedChanged);
            // 
            // rbNoDistanceToStarIgnore
            // 
            this.rbNoDistanceToStarIgnore.AutoSize = true;
            this.rbNoDistanceToStarIgnore.Location = new System.Drawing.Point(117, 19);
            this.rbNoDistanceToStarIgnore.Name = "rbNoDistanceToStarIgnore";
            this.rbNoDistanceToStarIgnore.Size = new System.Drawing.Size(55, 17);
            this.rbNoDistanceToStarIgnore.TabIndex = 2;
            this.rbNoDistanceToStarIgnore.Tag = "ignore";
            this.rbNoDistanceToStarIgnore.Text = "Ignore";
            this.rbNoDistanceToStarIgnore.UseVisualStyleBackColor = true;
            this.rbNoDistanceToStarIgnore.CheckedChanged += new System.EventHandler(this.rbInterface_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbNoLandingPadSizeConsider);
            this.groupBox5.Controls.Add(this.rbNoLandingPadSizeIgnore);
            this.groupBox5.Location = new System.Drawing.Point(299, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(197, 45);
            this.groupBox5.TabIndex = 66;
            this.groupBox5.TabStop = false;
            this.groupBox5.Tag = "NoLandingPadSize;consider";
            this.groupBox5.Text = "Stations Without Landingpad - Sizes";
            // 
            // rbNoLandingPadSizeConsider
            // 
            this.rbNoLandingPadSizeConsider.AutoSize = true;
            this.rbNoLandingPadSizeConsider.Checked = true;
            this.rbNoLandingPadSizeConsider.Location = new System.Drawing.Point(23, 19);
            this.rbNoLandingPadSizeConsider.Name = "rbNoLandingPadSizeConsider";
            this.rbNoLandingPadSizeConsider.Size = new System.Drawing.Size(66, 17);
            this.rbNoLandingPadSizeConsider.TabIndex = 1;
            this.rbNoLandingPadSizeConsider.TabStop = true;
            this.rbNoLandingPadSizeConsider.Tag = "consider";
            this.rbNoLandingPadSizeConsider.Text = "Consider";
            this.rbNoLandingPadSizeConsider.UseVisualStyleBackColor = true;
            this.rbNoLandingPadSizeConsider.CheckedChanged += new System.EventHandler(this.rbInterface_CheckedChanged);
            // 
            // rbNoLandingPadSizeIgnore
            // 
            this.rbNoLandingPadSizeIgnore.AutoSize = true;
            this.rbNoLandingPadSizeIgnore.Location = new System.Drawing.Point(117, 19);
            this.rbNoLandingPadSizeIgnore.Name = "rbNoLandingPadSizeIgnore";
            this.rbNoLandingPadSizeIgnore.Size = new System.Drawing.Size(55, 17);
            this.rbNoLandingPadSizeIgnore.TabIndex = 0;
            this.rbNoLandingPadSizeIgnore.Tag = "ignore";
            this.rbNoLandingPadSizeIgnore.Text = "Ignore";
            this.rbNoLandingPadSizeIgnore.UseVisualStyleBackColor = true;
            this.rbNoLandingPadSizeIgnore.CheckedChanged += new System.EventHandler(this.rbInterface_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 92);
            this.label1.TabIndex = 65;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // gbDataInterface
            // 
            this.gbDataInterface.Controls.Add(this.groupBox6);
            this.gbDataInterface.Location = new System.Drawing.Point(517, 544);
            this.gbDataInterface.Name = "gbDataInterface";
            this.gbDataInterface.Size = new System.Drawing.Size(100, 18);
            this.gbDataInterface.TabIndex = 68;
            this.gbDataInterface.TabStop = false;
            this.gbDataInterface.Text = "Data Interface";
            this.gbDataInterface.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtGamePath);
            this.groupBox3.Controls.Add(this.cmdGamePath);
            this.groupBox3.Location = new System.Drawing.Point(405, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 65);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Active Game Path (for analysing ED-logfiles)";
            // 
            // txtGamePath
            // 
            this.txtGamePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGamePath.Location = new System.Drawing.Point(12, 14);
            this.txtGamePath.Name = "txtGamePath";
            this.txtGamePath.ReadOnly = true;
            this.txtGamePath.Size = new System.Drawing.Size(473, 20);
            this.txtGamePath.TabIndex = 68;
            this.txtGamePath.Tag = "GamePath;";
            // 
            // cmdGamePath
            // 
            this.cmdGamePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGamePath.DisabledTextColor = System.Drawing.Color.DimGray;
            this.cmdGamePath.Location = new System.Drawing.Point(383, 36);
            this.cmdGamePath.Name = "cmdGamePath";
            this.cmdGamePath.Size = new System.Drawing.Size(102, 23);
            this.cmdGamePath.TabIndex = 67;
            this.cmdGamePath.Text = "Select";
            this.cmdGamePath.UseVisualStyleBackColor = true;
            this.cmdGamePath.Click += new System.EventHandler(this.cmdGamePath_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtJournalPath);
            this.groupBox2.Controls.Add(this.cmdJournalPath);
            this.groupBox2.Location = new System.Drawing.Point(405, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 65);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Active Journal Path ";
            // 
            // txtJournalPath
            // 
            this.txtJournalPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJournalPath.Location = new System.Drawing.Point(12, 14);
            this.txtJournalPath.Name = "txtJournalPath";
            this.txtJournalPath.ReadOnly = true;
            this.txtJournalPath.Size = new System.Drawing.Size(473, 20);
            this.txtJournalPath.TabIndex = 68;
            this.txtJournalPath.Tag = "JournalPath;";
            // 
            // cmdJournalPath
            // 
            this.cmdJournalPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdJournalPath.DisabledTextColor = System.Drawing.Color.DimGray;
            this.cmdJournalPath.Location = new System.Drawing.Point(383, 36);
            this.cmdJournalPath.Name = "cmdJournalPath";
            this.cmdJournalPath.Size = new System.Drawing.Size(102, 23);
            this.cmdJournalPath.TabIndex = 67;
            this.cmdJournalPath.Text = "Select";
            this.cmdJournalPath.UseVisualStyleBackColor = true;
            this.cmdJournalPath.Click += new System.EventHandler(this.cmdJournalPath_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.cmdChangeSQLPort);
            this.groupBox14.Controls.Add(this.label48);
            this.groupBox14.Controls.Add(this.label7);
            this.groupBox14.Controls.Add(this.cmbLanguage);
            this.groupBox14.Controls.Add(this.txtSQLConnectionPort);
            this.groupBox14.Controls.Add(this.cbAutoMinimize);
            this.groupBox14.Location = new System.Drawing.Point(12, 12);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(385, 170);
            this.groupBox14.TabIndex = 73;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "General";
            // 
            // cbAutoMinimize
            // 
            this.cbAutoMinimize.AutoSize = true;
            this.cbAutoMinimize.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAutoMinimize.Location = new System.Drawing.Point(32, 42);
            this.cbAutoMinimize.Name = "cbAutoMinimize";
            this.cbAutoMinimize.Size = new System.Drawing.Size(192, 17);
            this.cbAutoMinimize.TabIndex = 1;
            this.cbAutoMinimize.Tag = "AutoMinimize;false";
            this.cbAutoMinimize.Text = "auto-minimize splashscreen on start";
            this.cbAutoMinimize.UseVisualStyleBackColor = true;
            this.cbAutoMinimize.CheckedChanged += new System.EventHandler(this.ComboBox_CheckedChanged);
            // 
            // IBESettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(911, 586);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbVNCTest);
            this.Controls.Add(this.gbDataInterface);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(927, 624);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(927, 624);
            this.Name = "IBESettingsView";
            this.Load += new System.EventHandler(this.IBESettings_Load);
            this.groupBox6.ResumeLayout(false);
            this.gbTesseract.ResumeLayout(false);
            this.gbTesseract.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.gbVNCTest.ResumeLayout(false);
            this.gbVNCTest.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbDataInterface.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ButtonExt cmdFilter;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBoxInt32 txtGUIColorCutoffLevel;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label52;
        internal System.Windows.Forms.CheckBox cbCheckNextScreenshotForOne;
        private System.Windows.Forms.Label lblPixelAmount;
        private System.Windows.Forms.TextBoxInt32 txtOCRPixelAmount;
        private System.Windows.Forms.Label lblPixelThreshold;
        private System.Windows.Forms.TextBoxDouble txtOCRPixelThreshold;
        private System.Windows.Forms.TextBox txtOCRTraineddataFile;
        private System.Windows.Forms.ButtonExt cmdSelectTraineddataFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox cbAutoAdd_ReplaceVisited;
        private System.Windows.Forms.CheckBox cbAutoAdd_Marketdata;
        private System.Windows.Forms.CheckBox cbAutoAdd_Visited;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.CheckBox cbAutoAdd_JumpedTo;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox cbAutoActivateSystemTab;
        private System.Windows.Forms.CheckBox cbAutoActivateOCRTab;
        private System.Windows.Forms.ButtonExt button6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBoxInt32 cmbVisitedFilter;
        private System.Windows.Forms.GroupBox gbTesseract;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDataInterface;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtGamePath;
        private System.Windows.Forms.ButtonExt cmdGamePath;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbNoDistanceToStarConsider;
        private System.Windows.Forms.RadioButton rbNoDistanceToStarIgnore;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbNoLandingPadSizeConsider;
        private System.Windows.Forms.RadioButton rbNoLandingPadSizeIgnore;
        private System.Windows.Forms.ButtonExt cmdChangeSQLPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBoxInt32 txtSQLConnectionPort;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox gbVNCTest;
        private System.Windows.Forms.CheckBox cbActivateVNC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtJournalPath;
        private System.Windows.Forms.ButtonExt cmdJournalPath;
        private System.Windows.Forms.CheckBox cbAutoAdd_Scan;
        private System.Windows.Forms.CheckBox cbAutoAdd_Liftoff;
        private System.Windows.Forms.CheckBox cbAutoAdd_Touchdown;
        private System.Windows.Forms.CheckBox cbAutoAdd_MissionAccepted;
        private System.Windows.Forms.CheckBox cbAutoAdd_MissionAbandoned;
        private System.Windows.Forms.CheckBox cbAutoAdd_MissionFailed;
        private System.Windows.Forms.CheckBox cbAutoAdd_MissionCompleted;
        private System.Windows.Forms.CheckBox cbAutoAdd_LoadGame;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.CheckBox cbAutoMinimize;
    }
}