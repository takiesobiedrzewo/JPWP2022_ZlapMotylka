
namespace gra_zlapmotylka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblLife = new System.Windows.Forms.TextBox();
            this.lblPoints = new System.Windows.Forms.TextBox();
            this.butterfly = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.butterfly)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLife
            // 
            this.lblLife.BackColor = System.Drawing.Color.White;
            this.lblLife.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLife.Location = new System.Drawing.Point(581, 21);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(144, 32);
            this.lblLife.TabIndex = 0;
            this.lblLife.Text = "Zycia: ";
            // 
            // lblPoints
            // 
            this.lblPoints.BackColor = System.Drawing.Color.White;
            this.lblPoints.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPoints.Location = new System.Drawing.Point(581, 59);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(144, 32);
            this.lblPoints.TabIndex = 1;
            this.lblPoints.Text = "Punkty: ";
            // 
            // butterfly
            // 
            this.butterfly.BackColor = System.Drawing.Color.Transparent;
            this.butterfly.BackgroundImage = global::gra_zlapmotylka.Properties.Resources.blue;
            this.butterfly.Location = new System.Drawing.Point(177, 149);
            this.butterfly.Name = "butterfly";
            this.butterfly.Size = new System.Drawing.Size(160, 106);
            this.butterfly.TabIndex = 2;
            this.butterfly.TabStop = false;
            this.butterfly.Click += new System.EventHandler(this.gotButterfly);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.moveButterfly);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gra_zlapmotylka.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.butterfly);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblLife);
            this.Name = "Form1";
            this.Text = "Zlap Motylka";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.butterfly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblLife;
        private System.Windows.Forms.TextBox lblPoints;
        private System.Windows.Forms.PictureBox butterfly;
        private System.Windows.Forms.Timer timer1;
    }
}

