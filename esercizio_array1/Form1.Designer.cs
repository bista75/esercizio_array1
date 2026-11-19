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
            this.lst_conto = new System.Windows.Forms.ListBox();
            this.lst_saldo = new System.Windows.Forms.ListBox();
            this.lst_risultati = new System.Windows.Forms.ListBox();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.btn_n1 = new System.Windows.Forms.Button();
            this.btn_n2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_n4 = new System.Windows.Forms.Button();
            this.btn_n5 = new System.Windows.Forms.Button();
            this.btn_n6 = new System.Windows.Forms.Button();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_nomi
            // 
            this.lst_nomi.FormattingEnabled = true;
            this.lst_nomi.Location = new System.Drawing.Point(45, 62);
            this.lst_nomi.Name = "lst_nomi";
            this.lst_nomi.Size = new System.Drawing.Size(143, 121);
            this.lst_nomi.TabIndex = 0;
            // 
            // lst_conto
            // 
            this.lst_conto.FormattingEnabled = true;
            this.lst_conto.Location = new System.Drawing.Point(305, 62);
            this.lst_conto.Name = "lst_conto";
            this.lst_conto.Size = new System.Drawing.Size(141, 121);
            this.lst_conto.TabIndex = 1;
            // 
            // lst_saldo
            // 
            this.lst_saldo.FormattingEnabled = true;
            this.lst_saldo.Location = new System.Drawing.Point(563, 62);
            this.lst_saldo.Name = "lst_saldo";
            this.lst_saldo.Size = new System.Drawing.Size(146, 121);
            this.lst_saldo.TabIndex = 2;
            // 
            // lst_risultati
            // 
            this.lst_risultati.FormattingEnabled = true;
            this.lst_risultati.Location = new System.Drawing.Point(45, 234);
            this.lst_risultati.Name = "lst_risultati";
            this.lst_risultati.Size = new System.Drawing.Size(392, 212);
            this.lst_risultati.TabIndex = 3;
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(457, 247);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(100, 20);
            this.txt_n1.TabIndex = 4;
            // 
            // btn_n1
            // 
            this.btn_n1.Location = new System.Drawing.Point(595, 228);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(86, 52);
            this.btn_n1.TabIndex = 5;
            this.btn_n1.Text = "vedi persona e saldo";
            this.btn_n1.UseVisualStyleBackColor = true;
            // 
            // btn_n2
            // 
            this.btn_n2.Location = new System.Drawing.Point(595, 302);
            this.btn_n2.Name = "btn_n2";
            this.btn_n2.Size = new System.Drawing.Size(87, 47);
            this.btn_n2.TabIndex = 6;
            this.btn_n2.Text = "vedi numero conto e saldo";
            this.btn_n2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(467, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "vedi nomi con conto negativo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_n4
            // 
            this.btn_n4.Location = new System.Drawing.Point(609, 367);
            this.btn_n4.Name = "btn_n4";
            this.btn_n4.Size = new System.Drawing.Size(88, 50);
            this.btn_n4.TabIndex = 8;
            this.btn_n4.Text = "vedi cliente con saldo massimo";
            this.btn_n4.UseVisualStyleBackColor = true;
            // 
            // btn_n5
            // 
            this.btn_n5.Location = new System.Drawing.Point(467, 432);
            this.btn_n5.Name = "btn_n5";
            this.btn_n5.Size = new System.Drawing.Size(90, 49);
            this.btn_n5.TabIndex = 9;
            this.btn_n5.Text = "vedi media saldi";
            this.btn_n5.UseVisualStyleBackColor = true;
            // 
            // btn_n6
            // 
            this.btn_n6.Location = new System.Drawing.Point(609, 432);
            this.btn_n6.Name = "btn_n6";
            this.btn_n6.Size = new System.Drawing.Size(88, 49);
            this.btn_n6.TabIndex = 10;
            this.btn_n6.Text = "vedi saldi in modo crescente";
            this.btn_n6.UseVisualStyleBackColor = true;
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(457, 318);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(100, 20);
            this.txt_n2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Inserire numero del conto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Inserire nome e cognome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.btn_n6);
            this.Controls.Add(this.btn_n5);
            this.Controls.Add(this.btn_n4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_n2);
            this.Controls.Add(this.btn_n1);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lst_risultati);
            this.Controls.Add(this.lst_saldo);
            this.Controls.Add(this.lst_conto);
            this.Controls.Add(this.lst_nomi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_nomi;
        private System.Windows.Forms.ListBox lst_conto;
        private System.Windows.Forms.ListBox lst_saldo;
        private System.Windows.Forms.ListBox lst_risultati;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Button btn_n1;
        private System.Windows.Forms.Button btn_n2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_n4;
        private System.Windows.Forms.Button btn_n5;
        private System.Windows.Forms.Button btn_n6;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

