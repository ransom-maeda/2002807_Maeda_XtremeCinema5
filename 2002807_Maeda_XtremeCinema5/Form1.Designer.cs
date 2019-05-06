namespace _2002807_Maeda_XtremeCinema5
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.movieTitle = new System.Windows.Forms.TextBox();
            this.boxFormat = new System.Windows.Forms.GroupBox();
            this.bd = new System.Windows.Forms.RadioButton();
            this.dvd = new System.Windows.Forms.RadioButton();
            this.memberToggle = new System.Windows.Forms.CheckBox();
            this.newRelease = new System.Windows.Forms.CheckBox();
            this.amountDueOutput = new System.Windows.Forms.TextBox();
            this.labelAmountDue = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearForNextItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderCompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorChange = new System.Windows.Forms.ColorDialog();
            this.fontChange = new System.Windows.Forms.FontDialog();
            this.boxFormat.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(59, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Movie Title";
            // 
            // movieTitle
            // 
            this.movieTitle.Location = new System.Drawing.Point(77, 28);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(100, 20);
            this.movieTitle.TabIndex = 1;
            // 
            // boxFormat
            // 
            this.boxFormat.Controls.Add(this.bd);
            this.boxFormat.Controls.Add(this.dvd);
            this.boxFormat.Location = new System.Drawing.Point(15, 59);
            this.boxFormat.Name = "boxFormat";
            this.boxFormat.Size = new System.Drawing.Size(200, 80);
            this.boxFormat.TabIndex = 2;
            this.boxFormat.TabStop = false;
            this.boxFormat.Text = "Movie Format";
            // 
            // bd
            // 
            this.bd.AutoSize = true;
            this.bd.Location = new System.Drawing.Point(7, 52);
            this.bd.Name = "bd";
            this.bd.Size = new System.Drawing.Size(40, 17);
            this.bd.TabIndex = 1;
            this.bd.TabStop = true;
            this.bd.Text = "BD";
            this.bd.UseVisualStyleBackColor = true;
            // 
            // dvd
            // 
            this.dvd.AutoSize = true;
            this.dvd.Location = new System.Drawing.Point(7, 20);
            this.dvd.Name = "dvd";
            this.dvd.Size = new System.Drawing.Size(48, 17);
            this.dvd.TabIndex = 0;
            this.dvd.TabStop = true;
            this.dvd.Text = "DVD";
            this.dvd.UseVisualStyleBackColor = true;
            // 
            // memberToggle
            // 
            this.memberToggle.AutoSize = true;
            this.memberToggle.Location = new System.Drawing.Point(15, 146);
            this.memberToggle.Name = "memberToggle";
            this.memberToggle.Size = new System.Drawing.Size(64, 17);
            this.memberToggle.TabIndex = 3;
            this.memberToggle.Text = "Member";
            this.memberToggle.UseVisualStyleBackColor = true;
            // 
            // newRelease
            // 
            this.newRelease.AutoSize = true;
            this.newRelease.Location = new System.Drawing.Point(15, 169);
            this.newRelease.Name = "newRelease";
            this.newRelease.Size = new System.Drawing.Size(90, 17);
            this.newRelease.TabIndex = 4;
            this.newRelease.Text = "New Release";
            this.newRelease.UseVisualStyleBackColor = true;
            // 
            // amountDueOutput
            // 
            this.amountDueOutput.Location = new System.Drawing.Point(84, 192);
            this.amountDueOutput.Name = "amountDueOutput";
            this.amountDueOutput.Size = new System.Drawing.Size(100, 20);
            this.amountDueOutput.TabIndex = 6;
            // 
            // labelAmountDue
            // 
            this.labelAmountDue.AutoSize = true;
            this.labelAmountDue.Location = new System.Drawing.Point(12, 195);
            this.labelAmountDue.Name = "labelAmountDue";
            this.labelAmountDue.Size = new System.Drawing.Size(66, 13);
            this.labelAmountDue.TabIndex = 5;
            this.labelAmountDue.Text = "Amount Due";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 7;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.summaryToolStripMenuItem.Text = "&Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearForNextItemToolStripMenuItem,
            this.orderCompleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.colorToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculateToolStripMenuItem.Text = "C&alculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // clearForNextItemToolStripMenuItem
            // 
            this.clearForNextItemToolStripMenuItem.Name = "clearForNextItemToolStripMenuItem";
            this.clearForNextItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearForNextItemToolStripMenuItem.Text = "Clear for &Next Item";
            this.clearForNextItemToolStripMenuItem.Click += new System.EventHandler(this.clearForNextItemToolStripMenuItem_Click);
            // 
            // orderCompleteToolStripMenuItem
            // 
            this.orderCompleteToolStripMenuItem.Name = "orderCompleteToolStripMenuItem";
            this.orderCompleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orderCompleteToolStripMenuItem.Text = "&Order Complete";
            this.orderCompleteToolStripMenuItem.Click += new System.EventHandler(this.orderCompleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "&Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amountDueOutput);
            this.Controls.Add(this.labelAmountDue);
            this.Controls.Add(this.newRelease);
            this.Controls.Add(this.memberToggle);
            this.Controls.Add(this.boxFormat);
            this.Controls.Add(this.movieTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Xtreme Cinema Unit 5";
            this.boxFormat.ResumeLayout(false);
            this.boxFormat.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox movieTitle;
        private System.Windows.Forms.GroupBox boxFormat;
        private System.Windows.Forms.RadioButton bd;
        private System.Windows.Forms.RadioButton dvd;
        private System.Windows.Forms.CheckBox memberToggle;
        private System.Windows.Forms.CheckBox newRelease;
        private System.Windows.Forms.TextBox amountDueOutput;
        private System.Windows.Forms.Label labelAmountDue;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearForNextItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderCompleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorChange;
        private System.Windows.Forms.FontDialog fontChange;
    }
}

