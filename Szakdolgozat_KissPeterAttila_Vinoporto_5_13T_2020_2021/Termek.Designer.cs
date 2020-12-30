namespace Szakdolgozat_KissPeterAttila_Vinoporto_5_13T_2020_2021
{
    partial class Termek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Termek));
            this.Termekvonal = new System.Windows.Forms.PictureBox();
            this.lb_termek = new System.Windows.Forms.Label();
            this.termek_fomenu_btn = new System.Windows.Forms.Button();
            this.termek_exit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Termekvonal)).BeginInit();
            this.SuspendLayout();
            // 
            // Termekvonal
            // 
            this.Termekvonal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Termekvonal.Location = new System.Drawing.Point(-1, 49);
            this.Termekvonal.Name = "Termekvonal";
            this.Termekvonal.Size = new System.Drawing.Size(1265, 5);
            this.Termekvonal.TabIndex = 2;
            this.Termekvonal.TabStop = false;
            // 
            // lb_termek
            // 
            this.lb_termek.BackColor = System.Drawing.Color.Transparent;
            this.lb_termek.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_termek.Location = new System.Drawing.Point(514, 1);
            this.lb_termek.Name = "lb_termek";
            this.lb_termek.Size = new System.Drawing.Size(258, 45);
            this.lb_termek.TabIndex = 3;
            this.lb_termek.Text = "Termék Ajánló";
            // 
            // termek_fomenu_btn
            // 
            this.termek_fomenu_btn.BackColor = System.Drawing.Color.DarkRed;
            this.termek_fomenu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.termek_fomenu_btn.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.termek_fomenu_btn.ForeColor = System.Drawing.Color.White;
            this.termek_fomenu_btn.Location = new System.Drawing.Point(12, 4);
            this.termek_fomenu_btn.Name = "termek_fomenu_btn";
            this.termek_fomenu_btn.Size = new System.Drawing.Size(153, 42);
            this.termek_fomenu_btn.TabIndex = 9;
            this.termek_fomenu_btn.Text = "Főmenü";
            this.termek_fomenu_btn.UseVisualStyleBackColor = false;
            this.termek_fomenu_btn.Click += new System.EventHandler(this.honlapok_fomenu_btn_Click);
            // 
            // termek_exit_btn
            // 
            this.termek_exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.termek_exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.termek_exit_btn.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termek_exit_btn.ForeColor = System.Drawing.Color.Black;
            this.termek_exit_btn.Location = new System.Drawing.Point(1212, 4);
            this.termek_exit_btn.Name = "termek_exit_btn";
            this.termek_exit_btn.Size = new System.Drawing.Size(38, 42);
            this.termek_exit_btn.TabIndex = 10;
            this.termek_exit_btn.Text = "X";
            this.termek_exit_btn.UseVisualStyleBackColor = false;
            this.termek_exit_btn.Click += new System.EventHandler(this.termek_exit_btn_Click);
            // 
            // Termek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.termek_exit_btn);
            this.Controls.Add(this.termek_fomenu_btn);
            this.Controls.Add(this.lb_termek);
            this.Controls.Add(this.Termekvonal);
            this.Name = "Termek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termek";
            ((System.ComponentModel.ISupportInitialize)(this.Termekvonal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Termekvonal;
        private System.Windows.Forms.Label lb_termek;
        private System.Windows.Forms.Button termek_fomenu_btn;
        private System.Windows.Forms.Button termek_exit_btn;
    }
}