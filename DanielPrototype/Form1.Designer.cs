namespace DanielPrototype
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadvalue = new System.Windows.Forms.Panel();
            this.fullload = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gradientpanel1 = new DanielPrototype.gradientpanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gradientpanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DanielPrototype.Properties.Resources.icon2;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // loadvalue
            // 
            this.loadvalue.BackColor = System.Drawing.Color.White;
            this.loadvalue.Location = new System.Drawing.Point(25, 228);
            this.loadvalue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadvalue.Name = "loadvalue";
            this.loadvalue.Size = new System.Drawing.Size(8, 20);
            this.loadvalue.TabIndex = 3;
            this.loadvalue.Paint += new System.Windows.Forms.PaintEventHandler(this.Loadvalue_Paint);
            // 
            // fullload
            // 
            this.fullload.Location = new System.Drawing.Point(25, 228);
            this.fullload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fullload.Name = "fullload";
            this.fullload.Size = new System.Drawing.Size(463, 20);
            this.fullload.TabIndex = 2;
            this.fullload.Paint += new System.Windows.Forms.PaintEventHandler(this.Fullload_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // gradientpanel1
            // 
            this.gradientpanel1.Angle = 0F;
            this.gradientpanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(48)))), ((int)(((byte)(46)))));
            this.gradientpanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientpanel1.Controls.Add(this.pictureBox1);
            this.gradientpanel1.Controls.Add(this.loadvalue);
            this.gradientpanel1.Controls.Add(this.fullload);
            this.gradientpanel1.Location = new System.Drawing.Point(13, 12);
            this.gradientpanel1.Name = "gradientpanel1";
            this.gradientpanel1.Size = new System.Drawing.Size(501, 280);
            this.gradientpanel1.TabIndex = 5;
            this.gradientpanel1.TopColor = System.Drawing.Color.Empty;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 304);
            this.Controls.Add(this.gradientpanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gradientpanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel loadvalue;
        private System.Windows.Forms.Panel fullload;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private gradientpanel gradientpanel1;
    }
}

