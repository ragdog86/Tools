﻿namespace CasparCGConfigurator
{
    partial class MainForm
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
            System.Windows.Forms.Label datapathLabel;
            System.Windows.Forms.Label logpathLabel;
            System.Windows.Forms.Label mediapathLabel;
            System.Windows.Forms.Label templatepathLabel;
            System.Windows.Forms.Label autodeinterlaceLabel;
            System.Windows.Forms.Label autotranscodeLabel;
            System.Windows.Forms.Label blendmodesLabel;
            System.Windows.Forms.Label channelgridLabel;
            System.Windows.Forms.Label loglevelLabel;
            System.Windows.Forms.Label pipelinetokensLabel;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PathsTabPage = new System.Windows.Forms.TabPage();
            this.datapathTextBox = new System.Windows.Forms.TextBox();
            this.pathsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logpathTextBox = new System.Windows.Forms.TextBox();
            this.mediapathTextBox = new System.Windows.Forms.TextBox();
            this.templatepathTextBox = new System.Windows.Forms.TextBox();
            this.ChannelsTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AdvancedTabPage = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.configurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autodeinterlaceCheckBox = new System.Windows.Forms.CheckBox();
            this.autotranscodeCheckBox = new System.Windows.Forms.CheckBox();
            this.blendmodesCheckBox = new System.Windows.Forms.CheckBox();
            this.channelgridCheckBox = new System.Windows.Forms.CheckBox();
            this.pipelinetokensTextBox = new System.Windows.Forms.TextBox();
            this.channelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            datapathLabel = new System.Windows.Forms.Label();
            logpathLabel = new System.Windows.Forms.Label();
            mediapathLabel = new System.Windows.Forms.Label();
            templatepathLabel = new System.Windows.Forms.Label();
            autodeinterlaceLabel = new System.Windows.Forms.Label();
            autotranscodeLabel = new System.Windows.Forms.Label();
            blendmodesLabel = new System.Windows.Forms.Label();
            channelgridLabel = new System.Windows.Forms.Label();
            loglevelLabel = new System.Windows.Forms.Label();
            pipelinetokensLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.PathsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pathsBindingSource)).BeginInit();
            this.ChannelsTabPage.SuspendLayout();
            this.AdvancedTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datapathLabel
            // 
            datapathLabel.AutoSize = true;
            datapathLabel.Location = new System.Drawing.Point(24, 23);
            datapathLabel.Name = "datapathLabel";
            datapathLabel.Size = new System.Drawing.Size(58, 13);
            datapathLabel.TabIndex = 0;
            datapathLabel.Text = "Data Path:";
            // 
            // logpathLabel
            // 
            logpathLabel.AutoSize = true;
            logpathLabel.Location = new System.Drawing.Point(24, 49);
            logpathLabel.Name = "logpathLabel";
            logpathLabel.Size = new System.Drawing.Size(53, 13);
            logpathLabel.TabIndex = 2;
            logpathLabel.Text = "Log Path:";
            // 
            // mediapathLabel
            // 
            mediapathLabel.AutoSize = true;
            mediapathLabel.Location = new System.Drawing.Point(24, 75);
            mediapathLabel.Name = "mediapathLabel";
            mediapathLabel.Size = new System.Drawing.Size(64, 13);
            mediapathLabel.TabIndex = 4;
            mediapathLabel.Text = "Media Path:";
            // 
            // templatepathLabel
            // 
            templatepathLabel.AutoSize = true;
            templatepathLabel.Location = new System.Drawing.Point(24, 101);
            templatepathLabel.Name = "templatepathLabel";
            templatepathLabel.Size = new System.Drawing.Size(79, 13);
            templatepathLabel.TabIndex = 6;
            templatepathLabel.Text = "Template Path:";
            // 
            // autodeinterlaceLabel
            // 
            autodeinterlaceLabel.AutoSize = true;
            autodeinterlaceLabel.Location = new System.Drawing.Point(24, 23);
            autodeinterlaceLabel.Name = "autodeinterlaceLabel";
            autodeinterlaceLabel.Size = new System.Drawing.Size(89, 13);
            autodeinterlaceLabel.TabIndex = 0;
            autodeinterlaceLabel.Text = "Auto Deinterlace:";
            // 
            // autotranscodeLabel
            // 
            autotranscodeLabel.AutoSize = true;
            autotranscodeLabel.Location = new System.Drawing.Point(24, 53);
            autotranscodeLabel.Name = "autotranscodeLabel";
            autotranscodeLabel.Size = new System.Drawing.Size(86, 13);
            autotranscodeLabel.TabIndex = 2;
            autotranscodeLabel.Text = "Auto Transcode:";
            // 
            // blendmodesLabel
            // 
            blendmodesLabel.AutoSize = true;
            blendmodesLabel.Location = new System.Drawing.Point(24, 83);
            blendmodesLabel.Name = "blendmodesLabel";
            blendmodesLabel.Size = new System.Drawing.Size(72, 13);
            blendmodesLabel.TabIndex = 4;
            blendmodesLabel.Text = "Blend Modes:";
            // 
            // channelgridLabel
            // 
            channelgridLabel.AutoSize = true;
            channelgridLabel.Location = new System.Drawing.Point(24, 113);
            channelgridLabel.Name = "channelgridLabel";
            channelgridLabel.Size = new System.Drawing.Size(71, 13);
            channelgridLabel.TabIndex = 6;
            channelgridLabel.Text = "Channel Grid:";
            // 
            // loglevelLabel
            // 
            loglevelLabel.AutoSize = true;
            loglevelLabel.Location = new System.Drawing.Point(24, 141);
            loglevelLabel.Name = "loglevelLabel";
            loglevelLabel.Size = new System.Drawing.Size(57, 13);
            loglevelLabel.TabIndex = 8;
            loglevelLabel.Text = "Log Level:";
            // 
            // pipelinetokensLabel
            // 
            pipelinetokensLabel.AutoSize = true;
            pipelinetokensLabel.Location = new System.Drawing.Point(24, 167);
            pipelinetokensLabel.Name = "pipelinetokensLabel";
            pipelinetokensLabel.Size = new System.Drawing.Size(86, 13);
            pipelinetokensLabel.TabIndex = 10;
            pipelinetokensLabel.Text = "Pipeline Tokens:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.showXMLToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(95, 6);
            // 
            // showXMLToolStripMenuItem
            // 
            this.showXMLToolStripMenuItem.Name = "showXMLToolStripMenuItem";
            this.showXMLToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.showXMLToolStripMenuItem.Text = "Save";
            this.showXMLToolStripMenuItem.Click += new System.EventHandler(this.showXMLToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PathsTabPage);
            this.tabControl1.Controls.Add(this.ChannelsTabPage);
            this.tabControl1.Controls.Add(this.AdvancedTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(734, 366);
            this.tabControl1.TabIndex = 2;
            // 
            // PathsTabPage
            // 
            this.PathsTabPage.Controls.Add(datapathLabel);
            this.PathsTabPage.Controls.Add(this.datapathTextBox);
            this.PathsTabPage.Controls.Add(logpathLabel);
            this.PathsTabPage.Controls.Add(this.logpathTextBox);
            this.PathsTabPage.Controls.Add(mediapathLabel);
            this.PathsTabPage.Controls.Add(this.mediapathTextBox);
            this.PathsTabPage.Controls.Add(templatepathLabel);
            this.PathsTabPage.Controls.Add(this.templatepathTextBox);
            this.PathsTabPage.Location = new System.Drawing.Point(4, 22);
            this.PathsTabPage.Name = "PathsTabPage";
            this.PathsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PathsTabPage.Size = new System.Drawing.Size(726, 340);
            this.PathsTabPage.TabIndex = 0;
            this.PathsTabPage.Text = "Paths";
            this.PathsTabPage.UseVisualStyleBackColor = true;
            // 
            // datapathTextBox
            // 
            this.datapathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pathsBindingSource, "datapath", true));
            this.datapathTextBox.Location = new System.Drawing.Point(109, 20);
            this.datapathTextBox.Name = "datapathTextBox";
            this.datapathTextBox.Size = new System.Drawing.Size(100, 20);
            this.datapathTextBox.TabIndex = 1;
            // 
            // pathsBindingSource
            // 
            this.pathsBindingSource.DataSource = typeof(CasparCGConfigurator.paths);
            // 
            // logpathTextBox
            // 
            this.logpathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pathsBindingSource, "logpath", true));
            this.logpathTextBox.Location = new System.Drawing.Point(109, 46);
            this.logpathTextBox.Name = "logpathTextBox";
            this.logpathTextBox.Size = new System.Drawing.Size(100, 20);
            this.logpathTextBox.TabIndex = 3;
            // 
            // mediapathTextBox
            // 
            this.mediapathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pathsBindingSource, "mediapath", true));
            this.mediapathTextBox.Location = new System.Drawing.Point(109, 72);
            this.mediapathTextBox.Name = "mediapathTextBox";
            this.mediapathTextBox.Size = new System.Drawing.Size(100, 20);
            this.mediapathTextBox.TabIndex = 5;
            // 
            // templatepathTextBox
            // 
            this.templatepathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pathsBindingSource, "templatepath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.templatepathTextBox.Location = new System.Drawing.Point(109, 98);
            this.templatepathTextBox.Name = "templatepathTextBox";
            this.templatepathTextBox.Size = new System.Drawing.Size(100, 20);
            this.templatepathTextBox.TabIndex = 7;
            // 
            // ChannelsTabPage
            // 
            this.ChannelsTabPage.AutoScroll = true;
            this.ChannelsTabPage.Controls.Add(this.button1);
            this.ChannelsTabPage.Controls.Add(this.panel1);
            this.ChannelsTabPage.Controls.Add(this.label7);
            this.ChannelsTabPage.Controls.Add(this.label8);
            this.ChannelsTabPage.Controls.Add(this.label6);
            this.ChannelsTabPage.Controls.Add(this.label5);
            this.ChannelsTabPage.Controls.Add(this.label4);
            this.ChannelsTabPage.Controls.Add(this.label3);
            this.ChannelsTabPage.Controls.Add(this.label2);
            this.ChannelsTabPage.Controls.Add(this.button7);
            this.ChannelsTabPage.Controls.Add(this.button6);
            this.ChannelsTabPage.Controls.Add(this.label1);
            this.ChannelsTabPage.Controls.Add(this.comboBox1);
            this.ChannelsTabPage.Controls.Add(this.button5);
            this.ChannelsTabPage.Controls.Add(this.button4);
            this.ChannelsTabPage.Controls.Add(this.listBox2);
            this.ChannelsTabPage.Controls.Add(this.button3);
            this.ChannelsTabPage.Controls.Add(this.listBox1);
            this.ChannelsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ChannelsTabPage.Name = "ChannelsTabPage";
            this.ChannelsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ChannelsTabPage.Size = new System.Drawing.Size(726, 340);
            this.ChannelsTabPage.TabIndex = 1;
            this.ChannelsTabPage.Text = "Channels";
            this.ChannelsTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(457, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 240);
            this.panel1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Step 4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Output Options";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(286, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Step 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Step 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Step 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Channel Outputs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose Channel";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(425, 228);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(113, 228);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Channel Format";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PAL",
            "NTSC",
            "1080i5000",
            "576p2500",
            "720p2500",
            "720p5000",
            "720p5994",
            "720p6000",
            "1080i5000",
            "1080i5994",
            "1080i6000",
            "1080p2500",
            "1080p2997",
            "1080p3000",
            "1080p5000"});
            this.comboBox1.Location = new System.Drawing.Point(145, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(291, 257);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Add Screen";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(291, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Add Decklink";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(291, 49);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(159, 173);
            this.listBox2.TabIndex = 2;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Add Channel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "videomode";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 173);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AdvancedTabPage
            // 
            this.AdvancedTabPage.AutoScroll = true;
            this.AdvancedTabPage.Controls.Add(this.comboBox2);
            this.AdvancedTabPage.Controls.Add(autodeinterlaceLabel);
            this.AdvancedTabPage.Controls.Add(this.autodeinterlaceCheckBox);
            this.AdvancedTabPage.Controls.Add(autotranscodeLabel);
            this.AdvancedTabPage.Controls.Add(this.autotranscodeCheckBox);
            this.AdvancedTabPage.Controls.Add(blendmodesLabel);
            this.AdvancedTabPage.Controls.Add(this.blendmodesCheckBox);
            this.AdvancedTabPage.Controls.Add(channelgridLabel);
            this.AdvancedTabPage.Controls.Add(this.channelgridCheckBox);
            this.AdvancedTabPage.Controls.Add(loglevelLabel);
            this.AdvancedTabPage.Controls.Add(pipelinetokensLabel);
            this.AdvancedTabPage.Controls.Add(this.pipelinetokensTextBox);
            this.AdvancedTabPage.Location = new System.Drawing.Point(4, 22);
            this.AdvancedTabPage.Name = "AdvancedTabPage";
            this.AdvancedTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdvancedTabPage.Size = new System.Drawing.Size(726, 340);
            this.AdvancedTabPage.TabIndex = 2;
            this.AdvancedTabPage.Text = "Advanced";
            this.AdvancedTabPage.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.configurationBindingSource, "loglevel", true));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "trace",
            "debug",
            "info",
            "warning",
            "error"});
            this.comboBox2.Location = new System.Drawing.Point(113, 137);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // configurationBindingSource
            // 
            this.configurationBindingSource.DataSource = typeof(CasparCGConfigurator.configuration);
            // 
            // autodeinterlaceCheckBox
            // 
            this.autodeinterlaceCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.configurationBindingSource, "autodeinterlace", true));
            this.autodeinterlaceCheckBox.Location = new System.Drawing.Point(113, 18);
            this.autodeinterlaceCheckBox.Name = "autodeinterlaceCheckBox";
            this.autodeinterlaceCheckBox.Size = new System.Drawing.Size(104, 24);
            this.autodeinterlaceCheckBox.TabIndex = 1;
            this.autodeinterlaceCheckBox.UseVisualStyleBackColor = true;
            // 
            // autotranscodeCheckBox
            // 
            this.autotranscodeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.configurationBindingSource, "autotranscode", true));
            this.autotranscodeCheckBox.Location = new System.Drawing.Point(113, 48);
            this.autotranscodeCheckBox.Name = "autotranscodeCheckBox";
            this.autotranscodeCheckBox.Size = new System.Drawing.Size(104, 24);
            this.autotranscodeCheckBox.TabIndex = 3;
            this.autotranscodeCheckBox.UseVisualStyleBackColor = true;
            // 
            // blendmodesCheckBox
            // 
            this.blendmodesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.configurationBindingSource, "blendmodes", true));
            this.blendmodesCheckBox.Location = new System.Drawing.Point(113, 78);
            this.blendmodesCheckBox.Name = "blendmodesCheckBox";
            this.blendmodesCheckBox.Size = new System.Drawing.Size(104, 24);
            this.blendmodesCheckBox.TabIndex = 5;
            this.blendmodesCheckBox.UseVisualStyleBackColor = true;
            // 
            // channelgridCheckBox
            // 
            this.channelgridCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.configurationBindingSource, "channelgrid", true));
            this.channelgridCheckBox.Location = new System.Drawing.Point(113, 108);
            this.channelgridCheckBox.Name = "channelgridCheckBox";
            this.channelgridCheckBox.Size = new System.Drawing.Size(104, 24);
            this.channelgridCheckBox.TabIndex = 7;
            this.channelgridCheckBox.UseVisualStyleBackColor = true;
            // 
            // pipelinetokensTextBox
            // 
            this.pipelinetokensTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.configurationBindingSource, "pipelinetokens", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.pipelinetokensTextBox.Location = new System.Drawing.Point(113, 164);
            this.pipelinetokensTextBox.Name = "pipelinetokensTextBox";
            this.pipelinetokensTextBox.Size = new System.Drawing.Size(104, 20);
            this.pipelinetokensTextBox.TabIndex = 11;
            // 
            // channelBindingSource
            // 
            this.channelBindingSource.DataSource = typeof(CasparCGConfigurator.channel);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add System Audio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 390);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CasparCG Configurator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.PathsTabPage.ResumeLayout(false);
            this.PathsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pathsBindingSource)).EndInit();
            this.ChannelsTabPage.ResumeLayout(false);
            this.ChannelsTabPage.PerformLayout();
            this.AdvancedTabPage.ResumeLayout(false);
            this.AdvancedTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PathsTabPage;
        private System.Windows.Forms.TabPage ChannelsTabPage;
        private System.Windows.Forms.TabPage AdvancedTabPage;
        private System.Windows.Forms.TextBox datapathTextBox;
        private System.Windows.Forms.BindingSource pathsBindingSource;
        private System.Windows.Forms.TextBox logpathTextBox;
        private System.Windows.Forms.TextBox mediapathTextBox;
        private System.Windows.Forms.TextBox templatepathTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource channelBindingSource;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showXMLToolStripMenuItem;
        private System.Windows.Forms.CheckBox autodeinterlaceCheckBox;
        private System.Windows.Forms.BindingSource configurationBindingSource;
        private System.Windows.Forms.CheckBox autotranscodeCheckBox;
        private System.Windows.Forms.CheckBox blendmodesCheckBox;
        private System.Windows.Forms.CheckBox channelgridCheckBox;
        private System.Windows.Forms.TextBox pipelinetokensTextBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

