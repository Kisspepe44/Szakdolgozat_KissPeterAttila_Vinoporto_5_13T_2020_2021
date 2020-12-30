namespace Szakdolgozat_KissPeterAttila_Vinoporto_5_13T_2020_2021
{
    partial class Honlapok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Honlapok));
            this.honlapokvonal = new System.Windows.Forms.PictureBox();
            this.lb_honlapok = new System.Windows.Forms.Label();
            this.fomenu_exit_btn = new System.Windows.Forms.Button();
            this.honlapok_fomenu_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.honlapokvonal)).BeginInit();
            this.SuspendLayout();
            // 
            // honlapokvonal
            // 
            this.honlapokvonal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.honlapokvonal.Location = new System.Drawing.Point(-1, 49);
            this.honlapokvonal.Name = "honlapokvonal";
            this.honlapokvonal.Size = new System.Drawing.Size(1265, 5);
            this.honlapokvonal.TabIndex = 1;
            this.honlapokvonal.TabStop = false;
            // 
            // lb_honlapok
            // 
            this.lb_honlapok.BackColor = System.Drawing.Color.Transparent;
            this.lb_honlapok.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_honlapok.Location = new System.Drawing.Point(539, 1);
            this.lb_honlapok.Name = "lb_honlapok";
            this.lb_honlapok.Size = new System.Drawing.Size(181, 45);
            this.lb_honlapok.TabIndex = 2;
            this.lb_honlapok.Text = "Honlapok";
            // 
            // fomenu_exit_btn
            // 
            this.fomenu_exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.fomenu_exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fomenu_exit_btn.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fomenu_exit_btn.ForeColor = System.Drawing.Color.Black;
            this.fomenu_exit_btn.Location = new System.Drawing.Point(1212, 4);
            this.fomenu_exit_btn.Name = "fomenu_exit_btn";
            this.fomenu_exit_btn.Size = new System.Drawing.Size(38, 42);
            this.fomenu_exit_btn.TabIndex = 7;
            this.fomenu_exit_btn.Text = "X";
            this.fomenu_exit_btn.UseVisualStyleBackColor = false;
            this.fomenu_exit_btn.Click += new System.EventHandler(this.fomenu_exit_btn_Click);
            // 
            // honlapok_fomenu_btn
            // 
            this.honlapok_fomenu_btn.BackColor = System.Drawing.Color.DarkRed;
            this.honlapok_fomenu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.honlapok_fomenu_btn.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.honlapok_fomenu_btn.ForeColor = System.Drawing.Color.White;
            this.honlapok_fomenu_btn.Location = new System.Drawing.Point(12, 4);
            this.honlapok_fomenu_btn.Name = "honlapok_fomenu_btn";
            this.honlapok_fomenu_btn.Size = new System.Drawing.Size(153, 42);
            this.honlapok_fomenu_btn.TabIndex = 8;
            this.honlapok_fomenu_btn.Text = "Főmenü";
            this.honlapok_fomenu_btn.UseVisualStyleBackColor = false;
            // 
            // Honlapok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.honlapok_fomenu_btn);
            this.Controls.Add(this.fomenu_exit_btn);
            this.Controls.Add(this.lb_honlapok);
            this.Controls.Add(this.honlapokvonal);
            this.Name = "Honlapok";
            this.Text = "Honlapok";
            ((System.ComponentModel.ISupportInitialize)(this.honlapokvonal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox honlapokvonal;
        private System.Windows.Forms.Label lb_honlapok;
        private System.Windows.Forms.Button fomenu_exit_btn;
        private System.Windows.Forms.Button honlapok_fomenu_btn;
    }
}