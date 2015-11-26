namespace MainMenu
{
    partial class frmHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHang));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblStand = new System.Windows.Forms.Label();
            this.lblPole = new System.Windows.Forms.Label();
            this.lblArm = new System.Windows.Forms.Label();
            this.lblHook = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblArmRight = new System.Windows.Forms.Label();
            this.lblArmLeft = new System.Windows.Forms.Label();
            this.lblLegRight = new System.Windows.Forms.Label();
            this.lblLegLeft = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblStand
            // 
            this.lblStand.Image = ((System.Drawing.Image)(resources.GetObject("lblStand.Image")));
            this.lblStand.Location = new System.Drawing.Point(246, 269);
            this.lblStand.Name = "lblStand";
            this.lblStand.Size = new System.Drawing.Size(154, 16);
            this.lblStand.TabIndex = 1;
            this.lblStand.Text = "label1";
            // 
            // lblPole
            // 
            this.lblPole.Image = ((System.Drawing.Image)(resources.GetObject("lblPole.Image")));
            this.lblPole.Location = new System.Drawing.Point(369, 54);
            this.lblPole.Name = "lblPole";
            this.lblPole.Size = new System.Drawing.Size(21, 215);
            this.lblPole.TabIndex = 2;
            // 
            // lblArm
            // 
            this.lblArm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblArm.Image = ((System.Drawing.Image)(resources.GetObject("lblArm.Image")));
            this.lblArm.Location = new System.Drawing.Point(249, 44);
            this.lblArm.Name = "lblArm";
            this.lblArm.Size = new System.Drawing.Size(138, 10);
            this.lblArm.TabIndex = 3;
            // 
            // lblHook
            // 
            this.lblHook.Image = ((System.Drawing.Image)(resources.GetObject("lblHook.Image")));
            this.lblHook.Location = new System.Drawing.Point(249, 54);
            this.lblHook.Name = "lblHook";
            this.lblHook.Size = new System.Drawing.Size(13, 22);
            this.lblHook.TabIndex = 4;
            // 
            // lblBody
            // 
            this.lblBody.Location = new System.Drawing.Point(260, 17);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(100, 23);
            this.lblBody.TabIndex = 6;
            this.lblBody.Text = "label6";
            // 
            // lblArmRight
            // 
            this.lblArmRight.Location = new System.Drawing.Point(144, 9);
            this.lblArmRight.Name = "lblArmRight";
            this.lblArmRight.Size = new System.Drawing.Size(100, 23);
            this.lblArmRight.TabIndex = 7;
            this.lblArmRight.Text = "label7";
            // 
            // lblArmLeft
            // 
            this.lblArmLeft.Location = new System.Drawing.Point(106, 228);
            this.lblArmLeft.Name = "lblArmLeft";
            this.lblArmLeft.Size = new System.Drawing.Size(100, 23);
            this.lblArmLeft.TabIndex = 8;
            this.lblArmLeft.Text = "label8";
            // 
            // lblLegRight
            // 
            this.lblLegRight.Location = new System.Drawing.Point(68, 79);
            this.lblLegRight.Name = "lblLegRight";
            this.lblLegRight.Size = new System.Drawing.Size(100, 23);
            this.lblLegRight.TabIndex = 9;
            this.lblLegRight.Text = "label9";
            // 
            // lblLegLeft
            // 
            this.lblLegLeft.Location = new System.Drawing.Point(56, 140);
            this.lblLegLeft.Name = "lblLegLeft";
            this.lblLegLeft.Size = new System.Drawing.Size(100, 23);
            this.lblLegLeft.TabIndex = 10;
            this.lblLegLeft.Text = "label10";
            // 
            // lblHead
            // 
            this.lblHead.Location = new System.Drawing.Point(201, 79);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(100, 64);
            this.lblHead.TabIndex = 11;
            this.lblHead.Text = "label10";
            // 
            // frmHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 322);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.lblLegLeft);
            this.Controls.Add(this.lblLegRight);
            this.Controls.Add(this.lblArmLeft);
            this.Controls.Add(this.lblArmRight);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblHook);
            this.Controls.Add(this.lblArm);
            this.Controls.Add(this.lblPole);
            this.Controls.Add(this.lblStand);
            this.Controls.Add(this.textBox1);
            this.Name = "frmHang";
            this.Text = "Hang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblStand;
        private System.Windows.Forms.Label lblPole;
        private System.Windows.Forms.Label lblArm;
        private System.Windows.Forms.Label lblHook;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblArmRight;
        private System.Windows.Forms.Label lblArmLeft;
        private System.Windows.Forms.Label lblLegRight;
        private System.Windows.Forms.Label lblLegLeft;
        private System.Windows.Forms.Label lblHead;
    }
}