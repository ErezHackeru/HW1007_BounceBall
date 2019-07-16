namespace HW1007_BounceBall
{
    partial class BB_Form
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
            this.BallPicBx = new System.Windows.Forms.PictureBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.AddBallBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BallPicBx)).BeginInit();
            this.SuspendLayout();
            // 
            // BallPicBx
            // 
            this.BallPicBx.Image = global::HW1007_BounceBall.Properties.Resources.Ball_Pic;
            this.BallPicBx.Location = new System.Drawing.Point(700, 350);
            this.BallPicBx.Name = "BallPicBx";
            this.BallPicBx.Size = new System.Drawing.Size(100, 100);
            this.BallPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BallPicBx.TabIndex = 0;
            this.BallPicBx.TabStop = false;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(415, 418);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // AddBallBtn
            // 
            this.AddBallBtn.Location = new System.Drawing.Point(332, 418);
            this.AddBallBtn.Name = "AddBallBtn";
            this.AddBallBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBallBtn.TabIndex = 2;
            this.AddBallBtn.Text = "Add a Ball";
            this.AddBallBtn.UseVisualStyleBackColor = true;
            this.AddBallBtn.Click += new System.EventHandler(this.AddBallBtn_Click);
            // 
            // BB_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.AddBallBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.BallPicBx);
            this.Name = "BB_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BallPicBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BallPicBx;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button AddBallBtn;
    }
}

