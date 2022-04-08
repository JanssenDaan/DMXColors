namespace DMXColors
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpHome = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxPort = new System.Windows.Forms.ComboBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tbpShow = new System.Windows.Forms.TabPage();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.btnStartShow = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlShowItems = new System.Windows.Forms.FlowLayoutPanel();
            this.tbpSettings = new System.Windows.Forms.TabPage();
            this.tmrShow = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbpHome.SuspendLayout();
            this.tbpShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpHome);
            this.tabControl1.Controls.Add(this.tbpShow);
            this.tabControl1.Controls.Add(this.tbpSettings);
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpHome
            // 
            this.tbpHome.Controls.Add(this.button2);
            this.tbpHome.Controls.Add(this.button1);
            this.tbpHome.Controls.Add(this.cbxPort);
            this.tbpHome.Controls.Add(this.btnCheck);
            this.tbpHome.Location = new System.Drawing.Point(4, 22);
            this.tbpHome.Name = "tbpHome";
            this.tbpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHome.Size = new System.Drawing.Size(790, 424);
            this.tbpHome.TabIndex = 0;
            this.tbpHome.Text = "Home";
            this.tbpHome.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxPort
            // 
            this.cbxPort.FormattingEnabled = true;
            this.cbxPort.Location = new System.Drawing.Point(38, 126);
            this.cbxPort.Name = "cbxPort";
            this.cbxPort.Size = new System.Drawing.Size(121, 21);
            this.cbxPort.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(618, 180);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(142, 69);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check and make Connection";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tbpShow
            // 
            this.tbpShow.Controls.Add(this.pnlShow);
            this.tbpShow.Controls.Add(this.btnStartShow);
            this.tbpShow.Controls.Add(this.btnAdd);
            this.tbpShow.Controls.Add(this.pnlShowItems);
            this.tbpShow.Location = new System.Drawing.Point(4, 22);
            this.tbpShow.Name = "tbpShow";
            this.tbpShow.Padding = new System.Windows.Forms.Padding(3);
            this.tbpShow.Size = new System.Drawing.Size(790, 424);
            this.tbpShow.TabIndex = 1;
            this.tbpShow.Text = "Show";
            this.tbpShow.UseVisualStyleBackColor = true;
            // 
            // pnlShow
            // 
            this.pnlShow.Location = new System.Drawing.Point(7, 215);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(258, 203);
            this.pnlShow.TabIndex = 3;
            // 
            // btnStartShow
            // 
            this.btnStartShow.Location = new System.Drawing.Point(7, 6);
            this.btnStartShow.Name = "btnStartShow";
            this.btnStartShow.Size = new System.Drawing.Size(117, 57);
            this.btnStartShow.TabIndex = 2;
            this.btnStartShow.Text = "StartShow";
            this.btnStartShow.UseVisualStyleBackColor = true;
            this.btnStartShow.Click += new System.EventHandler(this.btnStartShow_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(550, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(234, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlShowItems
            // 
            this.pnlShowItems.AutoScroll = true;
            this.pnlShowItems.Location = new System.Drawing.Point(550, 35);
            this.pnlShowItems.Name = "pnlShowItems";
            this.pnlShowItems.Size = new System.Drawing.Size(233, 383);
            this.pnlShowItems.TabIndex = 0;
            // 
            // tbpSettings
            // 
            this.tbpSettings.Location = new System.Drawing.Point(4, 22);
            this.tbpSettings.Name = "tbpSettings";
            this.tbpSettings.Size = new System.Drawing.Size(790, 424);
            this.tbpSettings.TabIndex = 2;
            this.tbpSettings.Text = "Settings";
            this.tbpSettings.UseVisualStyleBackColor = true;
            // 
            // tmrShow
            // 
            this.tmrShow.Tick += new System.EventHandler(this.tmrShow_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(588, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tbpHome.ResumeLayout(false);
            this.tbpShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpHome;
        private System.Windows.Forms.TabPage tbpShow;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TabPage tbpSettings;
        private System.Windows.Forms.FlowLayoutPanel pnlShowItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStartShow;
        public System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.Timer tmrShow;
        private System.Windows.Forms.ComboBox cbxPort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

