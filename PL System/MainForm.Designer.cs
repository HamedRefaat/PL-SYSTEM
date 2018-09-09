namespace PLSystems
{
    partial class MainForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm1));
            this.spliter = new System.Windows.Forms.Panel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFirstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ramoveAndAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sysShowTimer = new System.Windows.Forms.Timer(this.components);
            this.convShowTimer = new System.Windows.Forms.Timer(this.components);
            this.askShowTimer = new System.Windows.Forms.Timer(this.components);
            this.configShowTimer = new System.Windows.Forms.Timer(this.components);
            this.exitBtn = new System.Windows.Forms.Button();
            this.questionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.askBtn = new System.Windows.Forms.Button();
            this.helpDescLabel = new System.Windows.Forms.Label();
            this.equRadioBtn = new System.Windows.Forms.RadioButton();
            this.conRadioBtn = new System.Windows.Forms.RadioButton();
            this.logConRadio = new System.Windows.Forms.RadioButton();
            this.answerBtn = new System.Windows.Forms.Button();
            this.convPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.convBtn = new System.Windows.Forms.Button();
            this.toPLDash1Link = new System.Windows.Forms.LinkLabel();
            this.toPLDash2Link = new System.Windows.Forms.LinkLabel();
            this.toPLDash3Link = new System.Windows.Forms.LinkLabel();
            this.sysPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sysBtn = new System.Windows.Forms.Button();
            this.PLlink = new System.Windows.Forms.LinkLabel();
            this.PLDash1Link = new System.Windows.Forms.LinkLabel();
            this.PLDash2Link = new System.Windows.Forms.LinkLabel();
            this.PLDash3Link = new System.Windows.Forms.LinkLabel();
            this.sidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.configPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.autoValCheckBox = new System.Windows.Forms.CheckBox();
            this.autoCapCheckBox = new System.Windows.Forms.CheckBox();
            this.holder = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.or = new System.Windows.Forms.Button();
            this.and = new System.Windows.Forms.Button();
            this.equivalance = new System.Windows.Forms.Button();
            this.implies = new System.Windows.Forms.Button();
            this.not = new System.Windows.Forms.Button();
            this.opsPanel = new System.Windows.Forms.Panel();
            this.wideBtn = new System.Windows.Forms.Button();
            this.fullBtn = new System.Windows.Forms.Button();
            this.tallBtn = new System.Windows.Forms.Button();
            this.solveBtn = new System.Windows.Forms.Button();
            this.upBtn = new System.Windows.Forms.Button();
            this.downBtn = new System.Windows.Forms.Button();
            this.quesLabel = new System.Windows.Forms.Label();
            this.contextMenu.SuspendLayout();
            this.questionPanel.SuspendLayout();
            this.convPanel.SuspendLayout();
            this.sysPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.configPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.opsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // spliter
            // 
            this.spliter.BackColor = System.Drawing.Color.Cyan;
            this.spliter.Dock = System.Windows.Forms.DockStyle.Top;
            this.spliter.Location = new System.Drawing.Point(0, 56);
            this.spliter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spliter.Name = "spliter";
            this.spliter.Size = new System.Drawing.Size(1116, 1);
            this.spliter.TabIndex = 2;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFirstToolStripMenuItem,
            this.addLastToolStripMenuItem,
            this.addAtToolStripMenuItem,
            this.ramoveAndAddToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(166, 114);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenu_Opening);
            // 
            // addFirstToolStripMenuItem
            // 
            this.addFirstToolStripMenuItem.Name = "addFirstToolStripMenuItem";
            this.addFirstToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addFirstToolStripMenuItem.Text = "Add At First";
            this.addFirstToolStripMenuItem.Click += new System.EventHandler(this.AddFirstMenuItem_Click);
            // 
            // addLastToolStripMenuItem
            // 
            this.addLastToolStripMenuItem.Name = "addLastToolStripMenuItem";
            this.addLastToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addLastToolStripMenuItem.Text = "Add At Last";
            this.addLastToolStripMenuItem.Click += new System.EventHandler(this.AddLastMenuItem_Click);
            // 
            // addAtToolStripMenuItem
            // 
            this.addAtToolStripMenuItem.Name = "addAtToolStripMenuItem";
            this.addAtToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addAtToolStripMenuItem.Text = "Add At Curser";
            this.addAtToolStripMenuItem.Click += new System.EventHandler(this.AddAtMenuItem_Click);
            // 
            // ramoveAndAddToolStripMenuItem
            // 
            this.ramoveAndAddToolStripMenuItem.Name = "ramoveAndAddToolStripMenuItem";
            this.ramoveAndAddToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ramoveAndAddToolStripMenuItem.Text = "Ramove and Add";
            this.ramoveAndAddToolStripMenuItem.Click += new System.EventHandler(this.RamoveAndAddMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // sysShowTimer
            // 
            this.sysShowTimer.Interval = 1;
            this.sysShowTimer.Tick += new System.EventHandler(this.SysShow_Tick);
            // 
            // convShowTimer
            // 
            this.convShowTimer.Interval = 2;
            this.convShowTimer.Tick += new System.EventHandler(this.ConvShow_Tick);
            // 
            // askShowTimer
            // 
            this.askShowTimer.Interval = 2;
            this.askShowTimer.Tick += new System.EventHandler(this.AskShowTimer_Tick);
            // 
            // configShowTimer
            // 
            this.configShowTimer.Interval = 2;
            this.configShowTimer.Tick += new System.EventHandler(this.ConfigShowTimer_Tick);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.exitBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitBtn.Location = new System.Drawing.Point(736, 4);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(183, 44);
            this.exitBtn.TabIndex = 22;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // questionPanel
            // 
            this.questionPanel.BackColor = System.Drawing.Color.Transparent;
            this.questionPanel.Controls.Add(this.askBtn);
            this.questionPanel.Controls.Add(this.helpDescLabel);
            this.questionPanel.Controls.Add(this.equRadioBtn);
            this.questionPanel.Controls.Add(this.conRadioBtn);
            this.questionPanel.Controls.Add(this.logConRadio);
            this.questionPanel.Controls.Add(this.answerBtn);
            this.questionPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.questionPanel.Location = new System.Drawing.Point(366, 0);
            this.questionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(183, 50);
            this.questionPanel.TabIndex = 23;
            // 
            // askBtn
            // 
            this.askBtn.BackColor = System.Drawing.Color.Transparent;
            this.askBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.askBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.askBtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.askBtn.FlatAppearance.BorderSize = 0;
            this.askBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.askBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.askBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.askBtn.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.askBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.askBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.askBtn.Location = new System.Drawing.Point(4, 4);
            this.askBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.askBtn.Name = "askBtn";
            this.askBtn.Size = new System.Drawing.Size(183, 44);
            this.askBtn.TabIndex = 21;
            this.askBtn.Text = "Check";
            this.askBtn.UseVisualStyleBackColor = false;
            this.askBtn.Click += new System.EventHandler(this.AskBtn_Click);
            // 
            // helpDescLabel
            // 
            this.helpDescLabel.AutoSize = true;
            this.helpDescLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.helpDescLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.helpDescLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.helpDescLabel.Location = new System.Drawing.Point(195, 0);
            this.helpDescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.helpDescLabel.Name = "helpDescLabel";
            this.helpDescLabel.Size = new System.Drawing.Size(264, 26);
            this.helpDescLabel.TabIndex = 23;
            this.helpDescLabel.Text = "Enter a comma separ-\r\nated statements, select a question then click Answer.";
            // 
            // equRadioBtn
            // 
            this.equRadioBtn.AutoSize = true;
            this.equRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.equRadioBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.equRadioBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.equRadioBtn.Location = new System.Drawing.Point(467, 4);
            this.equRadioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.equRadioBtn.Name = "equRadioBtn";
            this.equRadioBtn.Size = new System.Drawing.Size(106, 17);
            this.equRadioBtn.TabIndex = 25;
            this.equRadioBtn.Text = "Is Equivalance";
            this.equRadioBtn.UseVisualStyleBackColor = true;
            this.equRadioBtn.CheckedChanged += new System.EventHandler(this.equRadioBtn_CheckedChanged);
            // 
            // conRadioBtn
            // 
            this.conRadioBtn.AutoSize = true;
            this.conRadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.conRadioBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.conRadioBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.conRadioBtn.Location = new System.Drawing.Point(467, 29);
            this.conRadioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.conRadioBtn.Name = "conRadioBtn";
            this.conRadioBtn.Size = new System.Drawing.Size(99, 17);
            this.conRadioBtn.TabIndex = 26;
            this.conRadioBtn.Text = "Is Consistent";
            this.conRadioBtn.UseVisualStyleBackColor = true;
            // 
            // logConRadio
            // 
            this.logConRadio.AutoSize = true;
            this.logConRadio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.logConRadio.ForeColor = System.Drawing.Color.DarkRed;
            this.logConRadio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logConRadio.Location = new System.Drawing.Point(581, 4);
            this.logConRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logConRadio.Name = "logConRadio";
            this.logConRadio.Size = new System.Drawing.Size(114, 17);
            this.logConRadio.TabIndex = 27;
            this.logConRadio.Text = "Is Consequence";
            this.logConRadio.UseVisualStyleBackColor = true;
            // 
            // answerBtn
            // 
            this.answerBtn.BackgroundImage = global::PLSystems.Properties.Resources.ButtonsBG;
            this.answerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answerBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.answerBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.answerBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.answerBtn.Location = new System.Drawing.Point(581, 25);
            this.answerBtn.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.answerBtn.Name = "answerBtn";
            this.answerBtn.Size = new System.Drawing.Size(0, 0);
            this.answerBtn.TabIndex = 24;
            this.answerBtn.Text = "Answer";
            this.answerBtn.Click += new System.EventHandler(this.AnswerBtn_Click);
            // 
            // convPanel
            // 
            this.convPanel.BackColor = System.Drawing.Color.Transparent;
            this.convPanel.Controls.Add(this.convBtn);
            this.convPanel.Controls.Add(this.toPLDash1Link);
            this.convPanel.Controls.Add(this.toPLDash2Link);
            this.convPanel.Controls.Add(this.toPLDash3Link);
            this.convPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.convPanel.Location = new System.Drawing.Point(183, 0);
            this.convPanel.Margin = new System.Windows.Forms.Padding(0);
            this.convPanel.Name = "convPanel";
            this.convPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.convPanel.Size = new System.Drawing.Size(183, 50);
            this.convPanel.TabIndex = 19;
            // 
            // convBtn
            // 
            this.convBtn.BackColor = System.Drawing.Color.Transparent;
            this.convBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.convBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.convBtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.convBtn.FlatAppearance.BorderSize = 0;
            this.convBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.convBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.convBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convBtn.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.convBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.convBtn.Location = new System.Drawing.Point(4, 4);
            this.convBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convBtn.Name = "convBtn";
            this.convBtn.Size = new System.Drawing.Size(183, 44);
            this.convBtn.TabIndex = 20;
            this.convBtn.Text = "Convert To";
            this.convBtn.UseVisualStyleBackColor = false;
            this.convBtn.Click += new System.EventHandler(this.ConvBtn_Click);
            // 
            // toPLDash1Link
            // 
            this.toPLDash1Link.AutoSize = true;
            this.toPLDash1Link.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.toPLDash1Link.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toPLDash1Link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toPLDash1Link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toPLDash1Link.Location = new System.Drawing.Point(200, 0);
            this.toPLDash1Link.Margin = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.toPLDash1Link.Name = "toPLDash1Link";
            this.toPLDash1Link.Size = new System.Drawing.Size(93, 19);
            this.toPLDash1Link.TabIndex = 22;
            this.toPLDash1Link.TabStop = true;
            this.toPLDash1Link.Text = "To PL Dash 1";
            this.toPLDash1Link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toPLDash1Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ToPL_Dash1_Click);
            // 
            // toPLDash2Link
            // 
            this.toPLDash2Link.AutoSize = true;
            this.toPLDash2Link.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.toPLDash2Link.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toPLDash2Link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toPLDash2Link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toPLDash2Link.Location = new System.Drawing.Point(200, 19);
            this.toPLDash2Link.Margin = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.toPLDash2Link.Name = "toPLDash2Link";
            this.toPLDash2Link.Size = new System.Drawing.Size(93, 19);
            this.toPLDash2Link.TabIndex = 23;
            this.toPLDash2Link.TabStop = true;
            this.toPLDash2Link.Text = "To PL Dash 2";
            this.toPLDash2Link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toPLDash2Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ToPL_Dash2_Click);
            // 
            // toPLDash3Link
            // 
            this.toPLDash3Link.AutoSize = true;
            this.toPLDash3Link.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.toPLDash3Link.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toPLDash3Link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toPLDash3Link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toPLDash3Link.Location = new System.Drawing.Point(302, 0);
            this.toPLDash3Link.Margin = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.toPLDash3Link.Name = "toPLDash3Link";
            this.toPLDash3Link.Size = new System.Drawing.Size(93, 19);
            this.toPLDash3Link.TabIndex = 24;
            this.toPLDash3Link.TabStop = true;
            this.toPLDash3Link.Text = "To PL Dash 3";
            this.toPLDash3Link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toPLDash3Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ToPL_Dash3_Click);
            // 
            // sysPanel
            // 
            this.sysPanel.BackColor = System.Drawing.Color.Transparent;
            this.sysPanel.Controls.Add(this.sysBtn);
            this.sysPanel.Controls.Add(this.PLlink);
            this.sysPanel.Controls.Add(this.PLDash1Link);
            this.sysPanel.Controls.Add(this.PLDash2Link);
            this.sysPanel.Controls.Add(this.PLDash3Link);
            this.sysPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sysPanel.Location = new System.Drawing.Point(0, 0);
            this.sysPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sysPanel.Name = "sysPanel";
            this.sysPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.sysPanel.Size = new System.Drawing.Size(183, 50);
            this.sysPanel.TabIndex = 18;
            // 
            // sysBtn
            // 
            this.sysBtn.BackColor = System.Drawing.Color.Transparent;
            this.sysBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sysBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sysBtn.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.sysBtn.FlatAppearance.BorderSize = 0;
            this.sysBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.sysBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sysBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sysBtn.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sysBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.sysBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sysBtn.Location = new System.Drawing.Point(4, 4);
            this.sysBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sysBtn.Name = "sysBtn";
            this.sysBtn.Size = new System.Drawing.Size(183, 44);
            this.sysBtn.TabIndex = 20;
            this.sysBtn.Text = "System";
            this.sysBtn.UseVisualStyleBackColor = false;
            this.sysBtn.Click += new System.EventHandler(this.SysBtn_Click);
            // 
            // PLlink
            // 
            this.PLlink.AutoSize = true;
            this.PLlink.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PLlink.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PLlink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.PLlink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PLlink.Location = new System.Drawing.Point(200, 0);
            this.PLlink.Margin = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.PLlink.Name = "PLlink";
            this.PLlink.Size = new System.Drawing.Size(27, 19);
            this.PLlink.TabIndex = 21;
            this.PLlink.TabStop = true;
            this.PLlink.Text = "PL";
            this.PLlink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PLlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AsPL_Click);
            // 
            // PLDash1Link
            // 
            this.PLDash1Link.AutoSize = true;
            this.PLDash1Link.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PLDash1Link.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PLDash1Link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.PLDash1Link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PLDash1Link.Location = new System.Drawing.Point(200, 19);
            this.PLDash1Link.Margin = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.PLDash1Link.Name = "PLDash1Link";
            this.PLDash1Link.Size = new System.Drawing.Size(73, 19);
            this.PLDash1Link.TabIndex = 22;
            this.PLDash1Link.TabStop = true;
            this.PLDash1Link.Text = "PL Dash 1";
            this.PLDash1Link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PLDash1Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AsPLDash1_Click);
            // 
            // PLDash2Link
            // 
            this.PLDash2Link.AutoSize = true;
            this.PLDash2Link.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PLDash2Link.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PLDash2Link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.PLDash2Link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PLDash2Link.Location = new System.Drawing.Point(282, 0);
            this.PLDash2Link.Margin = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.PLDash2Link.Name = "PLDash2Link";
            this.PLDash2Link.Size = new System.Drawing.Size(73, 19);
            this.PLDash2Link.TabIndex = 23;
            this.PLDash2Link.TabStop = true;
            this.PLDash2Link.Text = "PL Dash 2";
            this.PLDash2Link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PLDash2Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AsPLDash2_Click);
            // 
            // PLDash3Link
            // 
            this.PLDash3Link.AutoSize = true;
            this.PLDash3Link.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PLDash3Link.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PLDash3Link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.PLDash3Link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PLDash3Link.Location = new System.Drawing.Point(282, 19);
            this.PLDash3Link.Margin = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.PLDash3Link.Name = "PLDash3Link";
            this.PLDash3Link.Size = new System.Drawing.Size(73, 19);
            this.PLDash3Link.TabIndex = 24;
            this.PLDash3Link.TabStop = true;
            this.PLDash3Link.Text = "PL Dash 3";
            this.PLDash3Link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PLDash3Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AsPLDash3_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.AutoSize = true;
            this.sidePanel.BackColor = System.Drawing.Color.Transparent;
            this.sidePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sidePanel.Controls.Add(this.sysPanel);
            this.sidePanel.Controls.Add(this.convPanel);
            this.sidePanel.Controls.Add(this.questionPanel);
            this.sidePanel.Controls.Add(this.configPanel);
            this.sidePanel.Controls.Add(this.exitBtn);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sidePanel.Size = new System.Drawing.Size(1116, 56);
            this.sidePanel.TabIndex = 17;
            this.sidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidePanel_Paint);
            // 
            // configPanel
            // 
            this.configPanel.BackColor = System.Drawing.Color.Transparent;
            this.configPanel.Controls.Add(this.button1);
            this.configPanel.Controls.Add(this.autoValCheckBox);
            this.configPanel.Controls.Add(this.autoCapCheckBox);
            this.configPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.configPanel.Location = new System.Drawing.Point(549, 0);
            this.configPanel.Margin = new System.Windows.Forms.Padding(0);
            this.configPanel.Name = "configPanel";
            this.configPanel.Size = new System.Drawing.Size(183, 50);
            this.configPanel.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 45);
            this.button1.TabIndex = 25;
            this.button1.Text = "Check result";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // autoValCheckBox
            // 
            this.autoValCheckBox.AutoSize = true;
            this.autoValCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.autoValCheckBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.autoValCheckBox.ForeColor = System.Drawing.Color.DarkRed;
            this.autoValCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.autoValCheckBox.Location = new System.Drawing.Point(194, 4);
            this.autoValCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.autoValCheckBox.Name = "autoValCheckBox";
            this.autoValCheckBox.Size = new System.Drawing.Size(105, 17);
            this.autoValCheckBox.TabIndex = 23;
            this.autoValCheckBox.Text = "AutoValidating";
            this.autoValCheckBox.UseVisualStyleBackColor = false;
            this.autoValCheckBox.CheckedChanged += new System.EventHandler(this.autoValCheckBox_CheckedChanged);
            // 
            // autoCapCheckBox
            // 
            this.autoCapCheckBox.AutoSize = true;
            this.autoCapCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.autoCapCheckBox.Checked = true;
            this.autoCapCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoCapCheckBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.autoCapCheckBox.ForeColor = System.Drawing.Color.DarkRed;
            this.autoCapCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.autoCapCheckBox.Location = new System.Drawing.Point(194, 29);
            this.autoCapCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.autoCapCheckBox.Name = "autoCapCheckBox";
            this.autoCapCheckBox.Size = new System.Drawing.Size(117, 17);
            this.autoCapCheckBox.TabIndex = 22;
            this.autoCapCheckBox.Text = "AutoCapitalizing";
            this.autoCapCheckBox.UseVisualStyleBackColor = false;
            this.autoCapCheckBox.CheckedChanged += new System.EventHandler(this.AutoCapCheckBox_CheckedChanged);
            // 
            // holder
            // 
            this.holder.AutoScroll = true;
            this.holder.BackColor = System.Drawing.Color.Transparent;
            this.holder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.holder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.holder.Location = new System.Drawing.Point(0, 393);
            this.holder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.holder.MinimumSize = new System.Drawing.Size(450, 250);
            this.holder.Name = "holder";
            this.holder.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.holder.Size = new System.Drawing.Size(1116, 344);
            this.holder.TabIndex = 1;
            this.holder.Paint += new System.Windows.Forms.PaintEventHandler(this.holder_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logLabel);
            this.panel1.Controls.Add(this.inputBox);
            this.panel1.Controls.Add(this.quesLabel);
            this.panel1.Controls.Add(this.opsPanel);
            this.panel1.Controls.Add(this.downBtn);
            this.panel1.Controls.Add(this.wideBtn);
            this.panel1.Controls.Add(this.upBtn);
            this.panel1.Controls.Add(this.fullBtn);
            this.panel1.Controls.Add(this.tallBtn);
            this.panel1.Controls.Add(this.solveBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 129);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.BackColor = System.Drawing.Color.Transparent;
            this.logLabel.ContextMenuStrip = this.contextMenu;
            this.logLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logLabel.Font = new System.Drawing.Font("Kozuka Mincho Pro H", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.logLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logLabel.Location = new System.Drawing.Point(0, 92);
            this.logLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logLabel.MinimumSize = new System.Drawing.Size(315, 0);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(315, 37);
            this.logLabel.TabIndex = 9;
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.White;
            this.inputBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.ForeColor = System.Drawing.Color.DarkRed;
            this.inputBox.Location = new System.Drawing.Point(2, 8);
            this.inputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputBox.MinimumSize = new System.Drawing.Size(801, 30);
            this.inputBox.Multiline = false;
            this.inputBox.Name = "inputBox";
            this.inputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.inputBox.Size = new System.Drawing.Size(801, 30);
            this.inputBox.TabIndex = 0;
            this.inputBox.Text = "";
            this.inputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            this.inputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputBox_KeyPress);
            this.inputBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyUp);
            // 
            // or
            // 
            this.or.BackColor = System.Drawing.Color.Transparent;
            this.or.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.or.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.or.ForeColor = System.Drawing.Color.DarkBlue;
            this.or.ImageIndex = 0;
            this.or.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.or.Location = new System.Drawing.Point(256, 0);
            this.or.Margin = new System.Windows.Forms.Padding(0);
            this.or.Name = "or";
            this.or.Size = new System.Drawing.Size(60, 35);
            this.or.TabIndex = 4;
            this.or.Text = "˅";
            this.or.UseVisualStyleBackColor = false;
            this.or.Click += new System.EventHandler(this.Op_Click);
            // 
            // and
            // 
            this.and.BackColor = System.Drawing.Color.Transparent;
            this.and.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.and.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.and.ForeColor = System.Drawing.Color.DarkBlue;
            this.and.ImageIndex = 0;
            this.and.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.and.Location = new System.Drawing.Point(193, 0);
            this.and.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.and.Name = "and";
            this.and.Size = new System.Drawing.Size(60, 35);
            this.and.TabIndex = 3;
            this.and.Text = "^";
            this.and.UseVisualStyleBackColor = false;
            this.and.Click += new System.EventHandler(this.Op_Click);
            // 
            // equivalance
            // 
            this.equivalance.BackColor = System.Drawing.Color.Transparent;
            this.equivalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equivalance.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equivalance.ForeColor = System.Drawing.Color.DarkBlue;
            this.equivalance.ImageIndex = 0;
            this.equivalance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.equivalance.Location = new System.Drawing.Point(129, 0);
            this.equivalance.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.equivalance.Name = "equivalance";
            this.equivalance.Size = new System.Drawing.Size(60, 35);
            this.equivalance.TabIndex = 2;
            this.equivalance.Text = "↔";
            this.equivalance.UseVisualStyleBackColor = false;
            this.equivalance.Click += new System.EventHandler(this.Op_Click);
            // 
            // implies
            // 
            this.implies.BackColor = System.Drawing.Color.Transparent;
            this.implies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.implies.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.implies.ForeColor = System.Drawing.Color.DarkBlue;
            this.implies.ImageIndex = 0;
            this.implies.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.implies.Location = new System.Drawing.Point(65, 0);
            this.implies.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.implies.Name = "implies";
            this.implies.Size = new System.Drawing.Size(60, 35);
            this.implies.TabIndex = 1;
            this.implies.Text = "→";
            this.implies.UseVisualStyleBackColor = false;
            this.implies.Click += new System.EventHandler(this.Op_Click);
            // 
            // not
            // 
            this.not.BackColor = System.Drawing.Color.Transparent;
            this.not.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.not.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.not.ForeColor = System.Drawing.Color.DarkBlue;
            this.not.ImageIndex = 0;
            this.not.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.not.Location = new System.Drawing.Point(0, 0);
            this.not.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.not.Name = "not";
            this.not.Size = new System.Drawing.Size(60, 35);
            this.not.TabIndex = 0;
            this.not.Text = "¬";
            this.not.UseVisualStyleBackColor = false;
            this.not.Click += new System.EventHandler(this.Op_Click);
            // 
            // opsPanel
            // 
            this.opsPanel.AutoSize = true;
            this.opsPanel.BackColor = System.Drawing.Color.Transparent;
            this.opsPanel.Controls.Add(this.not);
            this.opsPanel.Controls.Add(this.implies);
            this.opsPanel.Controls.Add(this.equivalance);
            this.opsPanel.Controls.Add(this.and);
            this.opsPanel.Controls.Add(this.or);
            this.opsPanel.Location = new System.Drawing.Point(4, 39);
            this.opsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.opsPanel.Name = "opsPanel";
            this.opsPanel.Size = new System.Drawing.Size(318, 35);
            this.opsPanel.TabIndex = 5;
            // 
            // wideBtn
            // 
            this.wideBtn.BackColor = System.Drawing.Color.Transparent;
            this.wideBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wideBtn.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wideBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.wideBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wideBtn.Location = new System.Drawing.Point(805, 51);
            this.wideBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wideBtn.Name = "wideBtn";
            this.wideBtn.Size = new System.Drawing.Size(72, 35);
            this.wideBtn.TabIndex = 19;
            this.wideBtn.Text = "Wide";
            this.wideBtn.UseVisualStyleBackColor = false;
            this.wideBtn.Click += new System.EventHandler(this.WideBtn_Click);
            // 
            // fullBtn
            // 
            this.fullBtn.BackColor = System.Drawing.Color.Transparent;
            this.fullBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fullBtn.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.fullBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fullBtn.Location = new System.Drawing.Point(967, 51);
            this.fullBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fullBtn.Name = "fullBtn";
            this.fullBtn.Size = new System.Drawing.Size(72, 35);
            this.fullBtn.TabIndex = 21;
            this.fullBtn.Text = "Full";
            this.fullBtn.UseVisualStyleBackColor = false;
            this.fullBtn.Click += new System.EventHandler(this.FullBtn_Click);
            // 
            // tallBtn
            // 
            this.tallBtn.BackColor = System.Drawing.Color.Transparent;
            this.tallBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tallBtn.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.tallBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tallBtn.Location = new System.Drawing.Point(886, 51);
            this.tallBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tallBtn.Name = "tallBtn";
            this.tallBtn.Size = new System.Drawing.Size(72, 35);
            this.tallBtn.TabIndex = 20;
            this.tallBtn.Text = "Tall";
            this.tallBtn.UseVisualStyleBackColor = false;
            this.tallBtn.Click += new System.EventHandler(this.TallBtn_Click);
            // 
            // solveBtn
            // 
            this.solveBtn.BackColor = System.Drawing.Color.Transparent;
            this.solveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.solveBtn.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.solveBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.solveBtn.Location = new System.Drawing.Point(807, 8);
            this.solveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(222, 35);
            this.solveBtn.TabIndex = 18;
            this.solveBtn.Text = "Solve In PL";
            this.solveBtn.UseVisualStyleBackColor = false;
            this.solveBtn.Click += new System.EventHandler(this.SolveBtn_Click);
            // 
            // upBtn
            // 
            this.upBtn.BackColor = System.Drawing.Color.Transparent;
            this.upBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upBtn.Enabled = false;
            this.upBtn.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.upBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.upBtn.Location = new System.Drawing.Point(654, 51);
            this.upBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(75, 35);
            this.upBtn.TabIndex = 24;
            this.upBtn.Text = "Up";
            this.upBtn.UseVisualStyleBackColor = false;
            this.upBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // downBtn
            // 
            this.downBtn.BackColor = System.Drawing.Color.Transparent;
            this.downBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downBtn.Enabled = false;
            this.downBtn.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.downBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.downBtn.Location = new System.Drawing.Point(726, 51);
            this.downBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(75, 35);
            this.downBtn.TabIndex = 25;
            this.downBtn.Text = "Down";
            this.downBtn.UseVisualStyleBackColor = false;
            this.downBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // quesLabel
            // 
            this.quesLabel.AutoSize = true;
            this.quesLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.quesLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.quesLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.quesLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.quesLabel.Location = new System.Drawing.Point(5, 10);
            this.quesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quesLabel.MinimumSize = new System.Drawing.Size(96, 26);
            this.quesLabel.Name = "quesLabel";
            this.quesLabel.Size = new System.Drawing.Size(96, 26);
            this.quesLabel.TabIndex = 26;
            this.quesLabel.Text = "Question";
            this.quesLabel.Visible = false;
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1116, 737);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.holder);
            this.Controls.Add(this.spliter);
            this.Controls.Add(this.sidePanel);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1036, 720);
            this.Name = "MainForm1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = "WLM";
            this.Text = " Propositional Logic";
            this.Theme = resources.GetString("$this.Theme");
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.Frame_FirstShown);
            this.ResizeBegin += new System.EventHandler(this.Frame_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Frame_ResizeEnd);
            this.contextMenu.ResumeLayout(false);
            this.questionPanel.ResumeLayout(false);
            this.questionPanel.PerformLayout();
            this.convPanel.ResumeLayout(false);
            this.convPanel.PerformLayout();
            this.sysPanel.ResumeLayout(false);
            this.sysPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.configPanel.ResumeLayout(false);
            this.configPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.opsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel spliter;
        private System.Windows.Forms.Timer sysShowTimer;
        private System.Windows.Forms.Timer convShowTimer;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem addFirstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ramoveAndAddToolStripMenuItem;
        private System.Windows.Forms.Timer askShowTimer;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.Timer configShowTimer;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.FlowLayoutPanel questionPanel;
        private System.Windows.Forms.Button askBtn;
        private System.Windows.Forms.Label helpDescLabel;
        private System.Windows.Forms.RadioButton equRadioBtn;
        private System.Windows.Forms.RadioButton conRadioBtn;
        private System.Windows.Forms.RadioButton logConRadio;
        private System.Windows.Forms.Button answerBtn;
        private System.Windows.Forms.FlowLayoutPanel convPanel;
        private System.Windows.Forms.Button convBtn;
        private System.Windows.Forms.LinkLabel toPLDash1Link;
        private System.Windows.Forms.LinkLabel toPLDash2Link;
        private System.Windows.Forms.LinkLabel toPLDash3Link;
        private System.Windows.Forms.FlowLayoutPanel sysPanel;
        private System.Windows.Forms.Button sysBtn;
        private System.Windows.Forms.LinkLabel PLlink;
        private System.Windows.Forms.LinkLabel PLDash1Link;
        private System.Windows.Forms.LinkLabel PLDash2Link;
        private System.Windows.Forms.LinkLabel PLDash3Link;
        private System.Windows.Forms.Panel holder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel configPanel;
        private System.Windows.Forms.CheckBox autoValCheckBox;
        private System.Windows.Forms.CheckBox autoCapCheckBox;
        private System.Windows.Forms.FlowLayoutPanel sidePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.Label quesLabel;
        private System.Windows.Forms.Panel opsPanel;
        private System.Windows.Forms.Button not;
        private System.Windows.Forms.Button implies;
        private System.Windows.Forms.Button equivalance;
        private System.Windows.Forms.Button and;
        private System.Windows.Forms.Button or;
        private System.Windows.Forms.Button downBtn;
        private System.Windows.Forms.Button wideBtn;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.Button fullBtn;
        private System.Windows.Forms.Button tallBtn;
        private System.Windows.Forms.Button solveBtn;
    }
}