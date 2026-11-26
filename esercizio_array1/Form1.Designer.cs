namespace esercizio_array1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst_nomi = new System.Windows.Forms.ListBox();
            this.lst_conti = new System.Windows.Forms.ListBox();
            this.lst_saldi = new System.Windows.Forms.ListBox();
            this.lst_risultati = new System.Windows.Forms.ListBox();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.btn_n1 = new System.Windows.Forms.Button();
            this.btn_n2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_n4 = new System.Windows.Forms.Button();
            this.btn_n5 = new System.Windows.Forms.Button();
            this.btn_n6 = new System.Windows.Forms.Button();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.btn_n7 = new System.Windows.Forms.Button();
            this.btn_n8 = new System.Windows.Forms.Button();
            this.btn_n9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_nomi
            // 
            this.lst_nomi.FormattingEnabled = true;
            this.lst_nomi.Location = new System.Drawing.Point(31, 78);
            this.lst_nomi.Name = "lst_nomi";
            this.lst_nomi.Size = new System.Drawing.Size(163, 121);
            this.lst_nomi.TabIndex = 0;
            // 
            // lst_conti
            // 
            this.lst_conti.FormattingEnabled = true;
            this.lst_conti.Location = new System.Drawing.Point(296, 78);
            this.lst_conti.Name = "lst_conti";
            this.lst_conti.Size = new System.Drawing.Size(169, 121);
            this.lst_conti.TabIndex = 1;
            // 
            // lst_saldi
            // 
            this.lst_saldi.FormattingEnabled = true;
            this.lst_saldi.Location = new System.Drawing.Point(564, 78);
            this.lst_saldi.Name = "lst_saldi";
            this.lst_saldi.Size = new System.Drawing.Size(171, 121);
            this.lst_saldi.TabIndex = 2;
            // 
            // lst_risultati
            // 
            this.lst_risultati.FormattingEnabled = true;
            this.lst_risultati.Location = new System.Drawing.Point(31, 231);
            this.lst_risultati.Name = "lst_risultati";
            this.lst_risultati.Size = new System.Drawing.Size(392, 238);
            this.lst_risultati.TabIndex = 3;
            // 
            // txt_n1
            // 
            this.txt_n1.BackColor = System.Drawing.Color.Yellow;
            this.txt_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n1.Location = new System.Drawing.Point(446, 247);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(100, 20);
            this.txt_n1.TabIndex = 4;
            // 
            // btn_n1
            // 
            this.btn_n1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_n1.Location = new System.Drawing.Point(609, 230);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(86, 52);
            this.btn_n1.TabIndex = 5;
            this.btn_n1.Text = "vedi persona e saldo";
            this.btn_n1.UseVisualStyleBackColor = false;
            this.btn_n1.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // btn_n2
            // 
            this.btn_n2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n2.Location = new System.Drawing.Point(609, 302);
            this.btn_n2.Name = "btn_n2";
            this.btn_n2.Size = new System.Drawing.Size(87, 50);
            this.btn_n2.TabIndex = 6;
            this.btn_n2.Text = "vedi numero conto e saldo";
            this.btn_n2.UseVisualStyleBackColor = false;
            this.btn_n2.Click += new System.EventHandler(this.btn_n2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(446, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "vedi nomi con conto negativo";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_n4
            // 
            this.btn_n4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n4.Location = new System.Drawing.Point(582, 367);
            this.btn_n4.Name = "btn_n4";
            this.btn_n4.Size = new System.Drawing.Size(88, 50);
            this.btn_n4.TabIndex = 8;
            this.btn_n4.Text = "vedi cliente con saldo massimo";
            this.btn_n4.UseVisualStyleBackColor = false;
            // 
            // btn_n5
            // 
            this.btn_n5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n5.Location = new System.Drawing.Point(446, 432);
            this.btn_n5.Name = "btn_n5";
            this.btn_n5.Size = new System.Drawing.Size(90, 49);
            this.btn_n5.TabIndex = 9;
            this.btn_n5.Text = "vedi media saldi";
            this.btn_n5.UseVisualStyleBackColor = false;
            // 
            // btn_n6
            // 
            this.btn_n6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n6.Location = new System.Drawing.Point(582, 432);
            this.btn_n6.Name = "btn_n6";
            this.btn_n6.Size = new System.Drawing.Size(88, 49);
            this.btn_n6.TabIndex = 10;
            this.btn_n6.Text = "vedi saldi in modo crescente";
            this.btn_n6.UseVisualStyleBackColor = false;
            // 
            // txt_n2
            // 
            this.txt_n2.BackColor = System.Drawing.Color.Yellow;
            this.txt_n2.Location = new System.Drawing.Point(446, 318);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(100, 20);
            this.txt_n2.TabIndex = 11;
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.Location = new System.Drawing.Point(443, 231);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(155, 13);
            this.lbl_n1.TabIndex = 12;
            this.lbl_n1.Text = "Inserire numero del conto:";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.Location = new System.Drawing.Point(443, 302);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(153, 13);
            this.lbl_n2.TabIndex = 13;
            this.lbl_n2.Text = "Inserire nome e cognome:";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.Location = new System.Drawing.Point(291, -1);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(174, 29);
            this.lbl_n3.TabIndex = 14;
            this.lbl_n3.Text = "BANCA AURA";
            // 
            // btn_n7
            // 
            this.btn_n7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n7.Location = new System.Drawing.Point(58, 49);
            this.btn_n7.Name = "btn_n7";
            this.btn_n7.Size = new System.Drawing.Size(87, 23);
            this.btn_n7.TabIndex = 15;
            this.btn_n7.Text = "vedi clienti";
            this.btn_n7.UseVisualStyleBackColor = false;
            this.btn_n7.Click += new System.EventHandler(this.btn_n7_Click);
            // 
            // btn_n8
            // 
            this.btn_n8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_n8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n8.Location = new System.Drawing.Point(339, 49);
            this.btn_n8.Name = "btn_n8";
            this.btn_n8.Size = new System.Drawing.Size(84, 23);
            this.btn_n8.TabIndex = 16;
            this.btn_n8.Text = "vedi conti";
            this.btn_n8.UseVisualStyleBackColor = false;
            this.btn_n8.Click += new System.EventHandler(this.btn_n8_Click);
            // 
            // btn_n9
            // 
            this.btn_n9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_n9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n9.Location = new System.Drawing.Point(609, 49);
            this.btn_n9.Name = "btn_n9";
            this.btn_n9.Size = new System.Drawing.Size(86, 23);
            this.btn_n9.TabIndex = 17;
            this.btn_n9.Text = "vedi saldi";
            this.btn_n9.UseVisualStyleBackColor = false;
            this.btn_n9.Click += new System.EventHandler(this.btn_n9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(747, 487);
            this.Controls.Add(this.btn_n9);
            this.Controls.Add(this.btn_n8);
            this.Controls.Add(this.btn_n7);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.btn_n6);
            this.Controls.Add(this.btn_n5);
            this.Controls.Add(this.btn_n4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_n2);
            this.Controls.Add(this.btn_n1);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lst_risultati);
            this.Controls.Add(this.lst_saldi);
            this.Controls.Add(this.lst_conti);
            this.Controls.Add(this.lst_nomi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_nomi;
        private System.Windows.Forms.ListBox lst_conti;
        private System.Windows.Forms.ListBox lst_saldi;
        private System.Windows.Forms.ListBox lst_risultati;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Button btn_n1;
        private System.Windows.Forms.Button btn_n2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_n4;
        private System.Windows.Forms.Button btn_n5;
        private System.Windows.Forms.Button btn_n6;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.Button btn_n7;
        private System.Windows.Forms.Button btn_n8;
        private System.Windows.Forms.Button btn_n9;
    }
}

