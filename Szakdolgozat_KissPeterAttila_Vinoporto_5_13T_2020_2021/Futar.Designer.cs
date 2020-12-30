namespace Szakdolgozat_KissPeterAttila_Vinoporto_5_13T_2020_2021
{
    partial class Futar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Futar));
            this.fomenuvonal = new System.Windows.Forms.PictureBox();
            this.lb_Futar = new System.Windows.Forms.Label();
            this.futar_exit_btn = new System.Windows.Forms.Button();
            this.futar_fomenu_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fomenuvonal)).BeginInit();
            this.SuspendLayout();
            // 
            // fomenuvonal
            // 
            this.fomenuvonal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fomenuvonal.Location = new System.Drawing.Point(-1, 49);
            this.fomenuvonal.Name = "fomenuvonal";
            this.fomenuvonal.Size = new System.Drawing.Size(1265, 5);
            this.fomenuvonal.TabIndex = 1;
            this.fomenuvonal.TabStop = false;
            // 
            // lb_Futar
            // 
            this.lb_Futar.BackColor = System.Drawing.Color.Transparent;
            this.lb_Futar.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Futar.Location = new System.Drawing.Point(465, 1);
            this.lb_Futar.Name = "lb_Futar";
            this.lb_Futar.Size = new System.Drawing.Size(291, 45);
            this.lb_Futar.TabIndex = 2;
            this.lb_Futar.Text = "Futár Elszámolás";
            // 
            // futar_exit_btn
            // 
            this.futar_exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.futar_exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.futar_exit_btn.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futar_exit_btn.ForeColor = System.Drawing.Color.Black;
            this.futar_exit_btn.Location = new System.Drawing.Point(1212, 4);
            this.futar_exit_btn.Name = "futar_exit_btn";
            this.futar_exit_btn.Size = new System.Drawing.Size(38, 42);
            this.futar_exit_btn.TabIndex = 7;
            this.futar_exit_btn.Text = "X";
            this.futar_exit_btn.UseVisualStyleBackColor = false;
            this.futar_exit_btn.Click += new System.EventHandler(this.futar_exit_btn_Click);
            // 
            // futar_fomenu_btn
            // 
            this.futar_fomenu_btn.BackColor = System.Drawing.Color.DarkRed;
            this.futar_fomenu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.futar_fomenu_btn.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.futar_fomenu_btn.ForeColor = System.Drawing.Color.White;
            this.futar_fomenu_btn.Location = new System.Drawing.Point(12, 5);
            this.futar_fomenu_btn.Name = "futar_fomenu_btn";
            this.futar_fomenu_btn.Size = new System.Drawing.Size(153, 42);
            this.futar_fomenu_btn.TabIndex = 9;
            this.futar_fomenu_btn.Text = "Főmenü";
            this.futar_fomenu_btn.UseVisualStyleBackColor = false;
            this.futar_fomenu_btn.Click += new System.EventHandler(this.futar_fomenu_btn_Click);
            // 
            // Futar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.futar_fomenu_btn);
            this.Controls.Add(this.futar_exit_btn);
            this.Controls.Add(this.lb_Futar);
            this.Controls.Add(this.fomenuvonal);
            this.Name = "Futar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Futar";
            ((System.ComponentModel.ISupportInitialize)(this.fomenuvonal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fomenuvonal;
        private System.Windows.Forms.Label lb_Futar;
        private System.Windows.Forms.Button futar_exit_btn;
        private System.Windows.Forms.Button futar_fomenu_btn;
    }
}