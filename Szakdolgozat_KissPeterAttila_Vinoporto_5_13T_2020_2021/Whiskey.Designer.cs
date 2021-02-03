namespace Szakdolgozat_KissPeterAttila_Vinoporto_5_13T_2020_2021
{
    partial class Whiskey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Whiskey));
            this.futar_fomenu_btn = new System.Windows.Forms.Button();
            this.lb_Futar = new System.Windows.Forms.Label();
            this.fomenuvonal = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fomenuvonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // futar_fomenu_btn
            // 
            this.futar_fomenu_btn.BackColor = System.Drawing.Color.DarkRed;
            this.futar_fomenu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.futar_fomenu_btn.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.futar_fomenu_btn.ForeColor = System.Drawing.Color.White;
            this.futar_fomenu_btn.Location = new System.Drawing.Point(11, 5);
            this.futar_fomenu_btn.Name = "futar_fomenu_btn";
            this.futar_fomenu_btn.Size = new System.Drawing.Size(153, 42);
            this.futar_fomenu_btn.TabIndex = 16;
            this.futar_fomenu_btn.Text = "Főmenü";
            this.futar_fomenu_btn.UseVisualStyleBackColor = false;
            this.futar_fomenu_btn.Click += new System.EventHandler(this.futar_fomenu_btn_Click);
            // 
            // lb_Futar
            // 
            this.lb_Futar.BackColor = System.Drawing.Color.Transparent;
            this.lb_Futar.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Futar.Location = new System.Drawing.Point(406, 1);
            this.lb_Futar.Name = "lb_Futar";
            this.lb_Futar.Size = new System.Drawing.Size(432, 45);
            this.lb_Futar.TabIndex = 15;
            this.lb_Futar.Text = "Whiskey";
            this.lb_Futar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fomenuvonal
            // 
            this.fomenuvonal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fomenuvonal.Location = new System.Drawing.Point(-2, 49);
            this.fomenuvonal.Name = "fomenuvonal";
            this.fomenuvonal.Size = new System.Drawing.Size(1265, 5);
            this.fomenuvonal.TabIndex = 14;
            this.fomenuvonal.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1239, 600);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(1239, 600);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1239, 600);
            this.dataGridView1.TabIndex = 17;
            // 
            // Whiskey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.futar_fomenu_btn);
            this.Controls.Add(this.lb_Futar);
            this.Controls.Add(this.fomenuvonal);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Whiskey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whiskey";
            this.Load += new System.EventHandler(this.Whiskey_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fomenuvonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button futar_fomenu_btn;
        private System.Windows.Forms.Label lb_Futar;
        private System.Windows.Forms.PictureBox fomenuvonal;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}