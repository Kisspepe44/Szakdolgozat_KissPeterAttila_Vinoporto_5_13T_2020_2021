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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Termek));
            this.Termekvonal = new System.Windows.Forms.PictureBox();
            this.lb_termek = new System.Windows.Forms.Label();
            this.Termek_termekcsoport_cb = new System.Windows.Forms.ComboBox();
            this.Termecsoport_lb = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.termek_fomenu_btn = new System.Windows.Forms.Button();
            this.Termek_keres_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Termek_min_nup = new System.Windows.Forms.NumericUpDown();
            this.Termek_max_nup = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Termekvonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Termek_min_nup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Termek_max_nup)).BeginInit();
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
            // Termek_termekcsoport_cb
            // 
            this.Termek_termekcsoport_cb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Termek_termekcsoport_cb.BackColor = System.Drawing.Color.DarkOrange;
            this.Termek_termekcsoport_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Termek_termekcsoport_cb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Termek_termekcsoport_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Termek_termekcsoport_cb.ForeColor = System.Drawing.Color.Black;
            this.Termek_termekcsoport_cb.FormattingEnabled = true;
            this.Termek_termekcsoport_cb.Location = new System.Drawing.Point(43, 198);
            this.Termek_termekcsoport_cb.Name = "Termek_termekcsoport_cb";
            this.Termek_termekcsoport_cb.Size = new System.Drawing.Size(387, 33);
            this.Termek_termekcsoport_cb.TabIndex = 11;
            // 
            // Termecsoport_lb
            // 
            this.Termecsoport_lb.AutoSize = true;
            this.Termecsoport_lb.BackColor = System.Drawing.Color.Transparent;
            this.Termecsoport_lb.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Termecsoport_lb.Location = new System.Drawing.Point(-10, 136);
            this.Termecsoport_lb.Name = "Termecsoport_lb";
            this.Termecsoport_lb.Size = new System.Drawing.Size(507, 50);
            this.Termecsoport_lb.TabIndex = 12;
            this.Termecsoport_lb.Text = "Kérem válasszon termékcsoportot:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(503, 60);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(747, 601);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(747, 601);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(747, 601);
            this.dataGridView1.TabIndex = 18;
            // 
            // termek_fomenu_btn
            // 
            this.termek_fomenu_btn.BackColor = System.Drawing.Color.DarkRed;
            this.termek_fomenu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.termek_fomenu_btn.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.termek_fomenu_btn.ForeColor = System.Drawing.Color.White;
            this.termek_fomenu_btn.Location = new System.Drawing.Point(12, 1);
            this.termek_fomenu_btn.Name = "termek_fomenu_btn";
            this.termek_fomenu_btn.Size = new System.Drawing.Size(146, 45);
            this.termek_fomenu_btn.TabIndex = 9;
            this.termek_fomenu_btn.Text = "Főmenü";
            this.termek_fomenu_btn.UseVisualStyleBackColor = false;
            this.termek_fomenu_btn.Click += new System.EventHandler(this.honlapok_fomenu_btn_Click);
            // 
            // Termek_keres_btn
            // 
            this.Termek_keres_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.Termek_keres_btn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Termek_keres_btn.ForeColor = System.Drawing.Color.Black;
            this.Termek_keres_btn.Location = new System.Drawing.Point(123, 589);
            this.Termek_keres_btn.Name = "Termek_keres_btn";
            this.Termek_keres_btn.Size = new System.Drawing.Size(189, 43);
            this.Termek_keres_btn.TabIndex = 30;
            this.Termek_keres_btn.Text = "Keresés";
            this.Termek_keres_btn.UseVisualStyleBackColor = false;
            this.Termek_keres_btn.Click += new System.EventHandler(this.Termek_keres_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(78, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 50);
            this.label1.TabIndex = 31;
            this.label1.Text = "Minimum összeg-től";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(78, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 50);
            this.label2.TabIndex = 32;
            this.label2.Text = "Maximum összeg-ig:";
            // 
            // Termek_min_nup
            // 
            this.Termek_min_nup.BackColor = System.Drawing.Color.DarkOrange;
            this.Termek_min_nup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Termek_min_nup.Location = new System.Drawing.Point(134, 287);
            this.Termek_min_nup.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.Termek_min_nup.Name = "Termek_min_nup";
            this.Termek_min_nup.Size = new System.Drawing.Size(205, 30);
            this.Termek_min_nup.TabIndex = 33;
            // 
            // Termek_max_nup
            // 
            this.Termek_max_nup.BackColor = System.Drawing.Color.DarkOrange;
            this.Termek_max_nup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Termek_max_nup.Location = new System.Drawing.Point(134, 373);
            this.Termek_max_nup.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.Termek_max_nup.Name = "Termek_max_nup";
            this.Termek_max_nup.Size = new System.Drawing.Size(205, 30);
            this.Termek_max_nup.TabIndex = 34;
            this.Termek_max_nup.Value = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            // 
            // Termek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Termek_max_nup);
            this.Controls.Add(this.Termek_min_nup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Termek_keres_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Termecsoport_lb);
            this.Controls.Add(this.Termek_termekcsoport_cb);
            this.Controls.Add(this.termek_fomenu_btn);
            this.Controls.Add(this.lb_termek);
            this.Controls.Add(this.Termekvonal);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Termek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Termek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Termekvonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Termek_min_nup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Termek_max_nup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Termekvonal;
        private System.Windows.Forms.Label lb_termek;
        private System.Windows.Forms.ComboBox Termek_termekcsoport_cb;
        private System.Windows.Forms.Label Termecsoport_lb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button termek_fomenu_btn;
        private System.Windows.Forms.Button Termek_keres_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Termek_min_nup;
        private System.Windows.Forms.NumericUpDown Termek_max_nup;
    }
}