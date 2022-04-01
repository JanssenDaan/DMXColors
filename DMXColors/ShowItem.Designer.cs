namespace DMXColors
{
    partial class ShowItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTextID = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlItemColor = new System.Windows.Forms.Panel();
            this.cdlColor = new System.Windows.Forms.ColorDialog();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.nudDjan = new System.Windows.Forms.NumericUpDown();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudDjan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextID
            // 
            this.lblTextID.AutoSize = true;
            this.lblTextID.Location = new System.Drawing.Point(3, 19);
            this.lblTextID.Name = "lblTextID";
            this.lblTextID.Size = new System.Drawing.Size(21, 13);
            this.lblTextID.TabIndex = 0;
            this.lblTextID.Text = "ID:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblID.Location = new System.Drawing.Point(3, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(10, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "-";
            // 
            // pnlItemColor
            // 
            this.pnlItemColor.Location = new System.Drawing.Point(118, 3);
            this.pnlItemColor.Name = "pnlItemColor";
            this.pnlItemColor.Size = new System.Drawing.Size(80, 66);
            this.pnlItemColor.TabIndex = 2;
            // 
            // btnPickColor
            // 
            this.btnPickColor.Location = new System.Drawing.Point(37, 9);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(75, 23);
            this.btnPickColor.TabIndex = 3;
            this.btnPickColor.Text = "Pick Color";
            this.btnPickColor.UseVisualStyleBackColor = true;
            this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
            // 
            // nudDjan
            // 
            this.nudDjan.Location = new System.Drawing.Point(63, 38);
            this.nudDjan.Name = "nudDjan";
            this.nudDjan.Size = new System.Drawing.Size(49, 20);
            this.nudDjan.TabIndex = 4;
            this.nudDjan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // ShowItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudDjan);
            this.Controls.Add(this.btnPickColor);
            this.Controls.Add(this.pnlItemColor);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblTextID);
            this.Name = "ShowItem";
            this.Size = new System.Drawing.Size(201, 72);
            ((System.ComponentModel.ISupportInitialize)(this.nudDjan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextID;
        private System.Windows.Forms.Panel pnlItemColor;
        private System.Windows.Forms.ColorDialog cdlColor;
        private System.Windows.Forms.Button btnPickColor;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Timer tmr;
        public System.Windows.Forms.NumericUpDown nudDjan;
    }
}
