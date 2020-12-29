namespace Szakdolgozat_KissPeterAttila_Vinoporto_5_13T_2020_2021
{
    partial class Kezdolap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kezdolap));
            this.kl_kikep_btn = new System.Windows.Forms.Button();
            this.kl_tovabb_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kl_kikep_btn
            // 
            this.kl_kikep_btn.BackColor = System.Drawing.Color.DarkRed;
            this.kl_kikep_btn.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kl_kikep_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kl_kikep_btn.Location = new System.Drawing.Point(12, 578);
            this.kl_kikep_btn.Name = "kl_kikep_btn";
            this.kl_kikep_btn.Size = new System.Drawing.Size(250, 75);
            this.kl_kikep_btn.TabIndex = 0;
            this.kl_kikep_btn.Text = "Kilépés!";
            this.kl_kikep_btn.UseVisualStyleBackColor = false;
            // 
            // kl_tovabb_btn
            // 
            this.kl_tovabb_btn.BackColor = System.Drawing.Color.DarkRed;
            this.kl_tovabb_btn.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kl_tovabb_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kl_tovabb_btn.Location = new System.Drawing.Point(998, 578);
            this.kl_tovabb_btn.Name = "kl_tovabb_btn";
            this.kl_tovabb_btn.Size = new System.Drawing.Size(250, 75);
            this.kl_tovabb_btn.TabIndex = 1;
            this.kl_tovabb_btn.Text = "Tovább!";
            this.kl_tovabb_btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(475, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 100);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Kezdolap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kl_tovabb_btn);
            this.Controls.Add(this.kl_kikep_btn);
            this.Name = "Kezdolap";
            this.Text = "Kezdőlap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kl_kikep_btn;
        private System.Windows.Forms.Button kl_tovabb_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

