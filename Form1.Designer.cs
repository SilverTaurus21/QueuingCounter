namespace countersystem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainerMAIN = new System.Windows.Forms.SplitContainer();
            this.BTN_RECALL = new System.Windows.Forms.Button();
            this.BTN_BREAK = new System.Windows.Forms.Button();
            this.BTN_TRIGGER_RESET = new System.Windows.Forms.Button();
            this.BTN_SETTINGS = new System.Windows.Forms.Button();
            this.BTN_CONNECTTV = new System.Windows.Forms.Button();
            this.tblMAIN = new System.Windows.Forms.TableLayoutPanel();
            this.panelCounterSection = new System.Windows.Forms.Panel();
            this.gb_counter2 = new System.Windows.Forms.GroupBox();
            this.gb_counter1 = new System.Windows.Forms.GroupBox();
            this.BTN_COUNTER1 = new System.Windows.Forms.Button();
            this.BTNC1_RECALL = new System.Windows.Forms.Button();
            this.BTN_COUNTER2 = new System.Windows.Forms.Button();
            this.BTNC2_RECALL = new System.Windows.Forms.Button();
            this.TXT_COUNTER1 = new System.Windows.Forms.Label();
            this.TXT_COUNTER2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.currentDateTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMAIN)).BeginInit();
            this.splitContainerMAIN.Panel1.SuspendLayout();
            this.splitContainerMAIN.Panel2.SuspendLayout();
            this.splitContainerMAIN.SuspendLayout();
            this.tblMAIN.SuspendLayout();
            this.panelCounterSection.SuspendLayout();
            this.gb_counter2.SuspendLayout();
            this.gb_counter1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMAIN
            // 
            this.splitContainerMAIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMAIN.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMAIN.Name = "splitContainerMAIN";
            // 
            // splitContainerMAIN.Panel1
            // 
            this.splitContainerMAIN.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainerMAIN.Panel1.Controls.Add(this.BTN_CONNECTTV);
            this.splitContainerMAIN.Panel1.Controls.Add(this.BTN_SETTINGS);
            this.splitContainerMAIN.Panel1.Controls.Add(this.BTN_TRIGGER_RESET);
            this.splitContainerMAIN.Panel1.Controls.Add(this.BTN_BREAK);
            this.splitContainerMAIN.Panel1.Controls.Add(this.BTN_RECALL);
            // 
            // splitContainerMAIN.Panel2
            // 
            this.splitContainerMAIN.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainerMAIN.Panel2.Controls.Add(this.tblMAIN);
            this.splitContainerMAIN.Size = new System.Drawing.Size(1354, 733);
            this.splitContainerMAIN.SplitterDistance = 286;
            this.splitContainerMAIN.TabIndex = 0;
            // 
            // BTN_RECALL
            // 
            this.BTN_RECALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RECALL.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RECALL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_RECALL.Image = ((System.Drawing.Image)(resources.GetObject("BTN_RECALL.Image")));
            this.BTN_RECALL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_RECALL.Location = new System.Drawing.Point(32, 73);
            this.BTN_RECALL.Name = "BTN_RECALL";
            this.BTN_RECALL.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTN_RECALL.Size = new System.Drawing.Size(229, 87);
            this.BTN_RECALL.TabIndex = 6;
            this.BTN_RECALL.Text = "              RE-CALL";
            this.BTN_RECALL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_RECALL.UseVisualStyleBackColor = true;
            this.BTN_RECALL.Click += new System.EventHandler(this.BTN_RECALL_Click);
            // 
            // BTN_BREAK
            // 
            this.BTN_BREAK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BREAK.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BREAK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_BREAK.Image = ((System.Drawing.Image)(resources.GetObject("BTN_BREAK.Image")));
            this.BTN_BREAK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_BREAK.Location = new System.Drawing.Point(32, 175);
            this.BTN_BREAK.Name = "BTN_BREAK";
            this.BTN_BREAK.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTN_BREAK.Size = new System.Drawing.Size(229, 87);
            this.BTN_BREAK.TabIndex = 7;
            this.BTN_BREAK.Text = "              BREAK";
            this.BTN_BREAK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_BREAK.UseVisualStyleBackColor = true;
            // 
            // BTN_TRIGGER_RESET
            // 
            this.BTN_TRIGGER_RESET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_TRIGGER_RESET.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_TRIGGER_RESET.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_TRIGGER_RESET.Image = ((System.Drawing.Image)(resources.GetObject("BTN_TRIGGER_RESET.Image")));
            this.BTN_TRIGGER_RESET.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_TRIGGER_RESET.Location = new System.Drawing.Point(32, 278);
            this.BTN_TRIGGER_RESET.Name = "BTN_TRIGGER_RESET";
            this.BTN_TRIGGER_RESET.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTN_TRIGGER_RESET.Size = new System.Drawing.Size(229, 87);
            this.BTN_TRIGGER_RESET.TabIndex = 8;
            this.BTN_TRIGGER_RESET.Text = "              RESET";
            this.BTN_TRIGGER_RESET.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_TRIGGER_RESET.UseVisualStyleBackColor = true;
            this.BTN_TRIGGER_RESET.Click += new System.EventHandler(this.BTN_TRIGGER_RESET_Click);
            // 
            // BTN_SETTINGS
            // 
            this.BTN_SETTINGS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SETTINGS.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SETTINGS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_SETTINGS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SETTINGS.Location = new System.Drawing.Point(21, 656);
            this.BTN_SETTINGS.Name = "BTN_SETTINGS";
            this.BTN_SETTINGS.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTN_SETTINGS.Size = new System.Drawing.Size(229, 38);
            this.BTN_SETTINGS.TabIndex = 10;
            this.BTN_SETTINGS.Text = "         settings";
            this.BTN_SETTINGS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SETTINGS.UseVisualStyleBackColor = true;
            // 
            // BTN_CONNECTTV
            // 
            this.BTN_CONNECTTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CONNECTTV.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CONNECTTV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_CONNECTTV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_CONNECTTV.Location = new System.Drawing.Point(21, 603);
            this.BTN_CONNECTTV.Name = "BTN_CONNECTTV";
            this.BTN_CONNECTTV.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTN_CONNECTTV.Size = new System.Drawing.Size(229, 38);
            this.BTN_CONNECTTV.TabIndex = 11;
            this.BTN_CONNECTTV.Text = "   2nd Monitor";
            this.BTN_CONNECTTV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_CONNECTTV.UseVisualStyleBackColor = true;
            this.BTN_CONNECTTV.Click += new System.EventHandler(this.BTN_CONNECTTV_Click);
            // 
            // tblMAIN
            // 
            this.tblMAIN.ColumnCount = 3;
            this.tblMAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.471816F));
            this.tblMAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.52818F));
            this.tblMAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tblMAIN.Controls.Add(this.panelCounterSection, 1, 0);
            this.tblMAIN.Cursor = System.Windows.Forms.Cursors.No;
            this.tblMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMAIN.Location = new System.Drawing.Point(0, 0);
            this.tblMAIN.Name = "tblMAIN";
            this.tblMAIN.RowCount = 2;
            this.tblMAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.32969F));
            this.tblMAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.67031F));
            this.tblMAIN.Size = new System.Drawing.Size(1062, 731);
            this.tblMAIN.TabIndex = 0;
            // 
            // panelCounterSection
            // 
            this.panelCounterSection.Controls.Add(this.currentDateTime);
            this.panelCounterSection.Controls.Add(this.label1);
            this.panelCounterSection.Controls.Add(this.BTNC2_RECALL);
            this.panelCounterSection.Controls.Add(this.BTN_COUNTER2);
            this.panelCounterSection.Controls.Add(this.BTNC1_RECALL);
            this.panelCounterSection.Controls.Add(this.BTN_COUNTER1);
            this.panelCounterSection.Controls.Add(this.gb_counter2);
            this.panelCounterSection.Controls.Add(this.gb_counter1);
            this.panelCounterSection.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelCounterSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCounterSection.Location = new System.Drawing.Point(68, 3);
            this.panelCounterSection.Name = "panelCounterSection";
            this.panelCounterSection.Size = new System.Drawing.Size(939, 647);
            this.panelCounterSection.TabIndex = 0;
            // 
            // gb_counter2
            // 
            this.gb_counter2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gb_counter2.Controls.Add(this.TXT_COUNTER2);
            this.gb_counter2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_counter2.Location = new System.Drawing.Point(497, 172);
            this.gb_counter2.Name = "gb_counter2";
            this.gb_counter2.Size = new System.Drawing.Size(401, 263);
            this.gb_counter2.TabIndex = 2;
            this.gb_counter2.TabStop = false;
            // 
            // gb_counter1
            // 
            this.gb_counter1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gb_counter1.Controls.Add(this.TXT_COUNTER1);
            this.gb_counter1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_counter1.Location = new System.Drawing.Point(25, 172);
            this.gb_counter1.Name = "gb_counter1";
            this.gb_counter1.Size = new System.Drawing.Size(401, 263);
            this.gb_counter1.TabIndex = 1;
            this.gb_counter1.TabStop = false;
            // 
            // BTN_COUNTER1
            // 
            this.BTN_COUNTER1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_COUNTER1.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_COUNTER1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_COUNTER1.Image = ((System.Drawing.Image)(resources.GetObject("BTN_COUNTER1.Image")));
            this.BTN_COUNTER1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_COUNTER1.Location = new System.Drawing.Point(104, 441);
            this.BTN_COUNTER1.Name = "BTN_COUNTER1";
            this.BTN_COUNTER1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTN_COUNTER1.Size = new System.Drawing.Size(322, 69);
            this.BTN_COUNTER1.TabIndex = 12;
            this.BTN_COUNTER1.Text = "              NEXT";
            this.BTN_COUNTER1.UseVisualStyleBackColor = true;
            this.BTN_COUNTER1.Click += new System.EventHandler(this.BTN_COUNTER1_Click);
            // 
            // BTNC1_RECALL
            // 
            this.BTNC1_RECALL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNC1_RECALL.BackgroundImage")));
            this.BTNC1_RECALL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTNC1_RECALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNC1_RECALL.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNC1_RECALL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNC1_RECALL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNC1_RECALL.Location = new System.Drawing.Point(25, 441);
            this.BTNC1_RECALL.Name = "BTNC1_RECALL";
            this.BTNC1_RECALL.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTNC1_RECALL.Size = new System.Drawing.Size(73, 69);
            this.BTNC1_RECALL.TabIndex = 14;
            this.BTNC1_RECALL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNC1_RECALL.UseVisualStyleBackColor = true;
            // 
            // BTN_COUNTER2
            // 
            this.BTN_COUNTER2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_COUNTER2.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_COUNTER2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_COUNTER2.Image = ((System.Drawing.Image)(resources.GetObject("BTN_COUNTER2.Image")));
            this.BTN_COUNTER2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_COUNTER2.Location = new System.Drawing.Point(576, 441);
            this.BTN_COUNTER2.Name = "BTN_COUNTER2";
            this.BTN_COUNTER2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTN_COUNTER2.Size = new System.Drawing.Size(322, 69);
            this.BTN_COUNTER2.TabIndex = 17;
            this.BTN_COUNTER2.Text = "              NEXT";
            this.BTN_COUNTER2.UseVisualStyleBackColor = true;
            this.BTN_COUNTER2.Click += new System.EventHandler(this.BTN_COUNTER2_Click);
            // 
            // BTNC2_RECALL
            // 
            this.BTNC2_RECALL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNC2_RECALL.BackgroundImage")));
            this.BTNC2_RECALL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTNC2_RECALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNC2_RECALL.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNC2_RECALL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNC2_RECALL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNC2_RECALL.Location = new System.Drawing.Point(497, 441);
            this.BTNC2_RECALL.Name = "BTNC2_RECALL";
            this.BTNC2_RECALL.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BTNC2_RECALL.Size = new System.Drawing.Size(73, 69);
            this.BTNC2_RECALL.TabIndex = 18;
            this.BTNC2_RECALL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNC2_RECALL.UseVisualStyleBackColor = true;
            // 
            // TXT_COUNTER1
            // 
            this.TXT_COUNTER1.AutoSize = true;
            this.TXT_COUNTER1.Font = new System.Drawing.Font("Leelawadee UI", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_COUNTER1.Location = new System.Drawing.Point(91, 65);
            this.TXT_COUNTER1.Name = "TXT_COUNTER1";
            this.TXT_COUNTER1.Size = new System.Drawing.Size(122, 142);
            this.TXT_COUNTER1.TabIndex = 0;
            this.TXT_COUNTER1.Text = "0";
            // 
            // TXT_COUNTER2
            // 
            this.TXT_COUNTER2.AutoSize = true;
            this.TXT_COUNTER2.Font = new System.Drawing.Font("Leelawadee UI", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_COUNTER2.Location = new System.Drawing.Point(55, 65);
            this.TXT_COUNTER2.Name = "TXT_COUNTER2";
            this.TXT_COUNTER2.Size = new System.Drawing.Size(122, 142);
            this.TXT_COUNTER2.TabIndex = 1;
            this.TXT_COUNTER2.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Serving";
            // 
            // currentDateTime
            // 
            this.currentDateTime.AutoSize = true;
            this.currentDateTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateTime.Location = new System.Drawing.Point(361, 103);
            this.currentDateTime.Name = "currentDateTime";
            this.currentDateTime.Size = new System.Drawing.Size(147, 37);
            this.currentDateTime.TabIndex = 19;
            this.currentDateTime.Text = "---.----.---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.splitContainerMAIN);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counter System ver.1 ST21-2024";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainerMAIN.Panel1.ResumeLayout(false);
            this.splitContainerMAIN.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMAIN)).EndInit();
            this.splitContainerMAIN.ResumeLayout(false);
            this.tblMAIN.ResumeLayout(false);
            this.panelCounterSection.ResumeLayout(false);
            this.panelCounterSection.PerformLayout();
            this.gb_counter2.ResumeLayout(false);
            this.gb_counter2.PerformLayout();
            this.gb_counter1.ResumeLayout(false);
            this.gb_counter1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMAIN;
        private System.Windows.Forms.Button BTN_RECALL;
        private System.Windows.Forms.Button BTN_TRIGGER_RESET;
        private System.Windows.Forms.Button BTN_BREAK;
        private System.Windows.Forms.Button BTN_SETTINGS;
        private System.Windows.Forms.Button BTN_CONNECTTV;
        private System.Windows.Forms.TableLayoutPanel tblMAIN;
        private System.Windows.Forms.Panel panelCounterSection;
        private System.Windows.Forms.GroupBox gb_counter2;
        private System.Windows.Forms.GroupBox gb_counter1;
        private System.Windows.Forms.Button BTNC1_RECALL;
        private System.Windows.Forms.Button BTN_COUNTER1;
        private System.Windows.Forms.Button BTN_COUNTER2;
        private System.Windows.Forms.Button BTNC2_RECALL;
        private System.Windows.Forms.Label TXT_COUNTER1;
        private System.Windows.Forms.Label TXT_COUNTER2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label currentDateTime;
    }
}

