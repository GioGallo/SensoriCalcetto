namespace SensoriCalcetto
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDifensore1 = new System.Windows.Forms.ComboBox();
            this.cmbAttaccante1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbAttaccante2 = new System.Windows.Forms.ComboBox();
            this.cmbDifensore2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGol1 = new System.Windows.Forms.Button();
            this.btnGol2 = new System.Windows.Forms.Button();
            this.btnGolMancato1 = new System.Windows.Forms.Button();
            this.btnGolMancato2 = new System.Windows.Forms.Button();
            this.btnRollataAtt1 = new System.Windows.Forms.Button();
            this.btnRollataAtt2 = new System.Windows.Forms.Button();
            this.btnRollataDif1 = new System.Windows.Forms.Button();
            this.btnRollataDif2 = new System.Windows.Forms.Button();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.lblPunteggio1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblPunteggio2 = new System.Windows.Forms.Label();
            this.btnNuovaPartita = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcetto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDifensore1);
            this.groupBox1.Controls.Add(this.cmbAttaccante1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Squadra 1";
            // 
            // cmbDifensore1
            // 
            this.cmbDifensore1.FormattingEnabled = true;
            this.cmbDifensore1.Location = new System.Drawing.Point(101, 76);
            this.cmbDifensore1.Name = "cmbDifensore1";
            this.cmbDifensore1.Size = new System.Drawing.Size(198, 24);
            this.cmbDifensore1.TabIndex = 18;
            this.cmbDifensore1.SelectedIndexChanged += new System.EventHandler(this.CheckPlayers);
            // 
            // cmbAttaccante1
            // 
            this.cmbAttaccante1.FormattingEnabled = true;
            this.cmbAttaccante1.Location = new System.Drawing.Point(101, 39);
            this.cmbAttaccante1.Name = "cmbAttaccante1";
            this.cmbAttaccante1.Size = new System.Drawing.Size(198, 24);
            this.cmbAttaccante1.TabIndex = 17;
            this.cmbAttaccante1.Text = " ";
            this.cmbAttaccante1.SelectedIndexChanged += new System.EventHandler(this.CheckPlayers);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Difensore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Attaccante";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbAttaccante2);
            this.groupBox2.Controls.Add(this.cmbDifensore2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(474, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 155);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Squadra 2";
            // 
            // cmbAttaccante2
            // 
            this.cmbAttaccante2.FormattingEnabled = true;
            this.cmbAttaccante2.Location = new System.Drawing.Point(16, 39);
            this.cmbAttaccante2.Name = "cmbAttaccante2";
            this.cmbAttaccante2.Size = new System.Drawing.Size(198, 24);
            this.cmbAttaccante2.TabIndex = 19;
            this.cmbAttaccante2.SelectedIndexChanged += new System.EventHandler(this.CheckPlayers);
            // 
            // cmbDifensore2
            // 
            this.cmbDifensore2.FormattingEnabled = true;
            this.cmbDifensore2.Location = new System.Drawing.Point(16, 76);
            this.cmbDifensore2.Name = "cmbDifensore2";
            this.cmbDifensore2.Size = new System.Drawing.Size(198, 24);
            this.cmbDifensore2.TabIndex = 18;
            this.cmbDifensore2.SelectedIndexChanged += new System.EventHandler(this.CheckPlayers);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Difensore";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Attaccante";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(366, 118);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnGol1
            // 
            this.btnGol1.Location = new System.Drawing.Point(125, 294);
            this.btnGol1.Name = "btnGol1";
            this.btnGol1.Size = new System.Drawing.Size(89, 43);
            this.btnGol1.TabIndex = 4;
            this.btnGol1.Text = "Gol";
            this.btnGol1.UseVisualStyleBackColor = true;
            this.btnGol1.Click += new System.EventHandler(this.btnGol1_Click);
            // 
            // btnGol2
            // 
            this.btnGol2.Location = new System.Drawing.Point(490, 294);
            this.btnGol2.Name = "btnGol2";
            this.btnGol2.Size = new System.Drawing.Size(89, 43);
            this.btnGol2.TabIndex = 5;
            this.btnGol2.Text = "Gol";
            this.btnGol2.UseVisualStyleBackColor = true;
            this.btnGol2.Click += new System.EventHandler(this.btnGol2_Click);
            // 
            // btnGolMancato1
            // 
            this.btnGolMancato1.Location = new System.Drawing.Point(222, 294);
            this.btnGolMancato1.Name = "btnGolMancato1";
            this.btnGolMancato1.Size = new System.Drawing.Size(89, 43);
            this.btnGolMancato1.TabIndex = 6;
            this.btnGolMancato1.Text = "Gol Mancato";
            this.btnGolMancato1.UseVisualStyleBackColor = true;
            this.btnGolMancato1.Click += new System.EventHandler(this.btnGolMancato1_Click);
            // 
            // btnGolMancato2
            // 
            this.btnGolMancato2.Location = new System.Drawing.Point(587, 294);
            this.btnGolMancato2.Name = "btnGolMancato2";
            this.btnGolMancato2.Size = new System.Drawing.Size(89, 43);
            this.btnGolMancato2.TabIndex = 7;
            this.btnGolMancato2.Text = "Gol Mancato";
            this.btnGolMancato2.UseVisualStyleBackColor = true;
            this.btnGolMancato2.Click += new System.EventHandler(this.btnGolMancato2_Click);
            // 
            // btnRollataAtt1
            // 
            this.btnRollataAtt1.Location = new System.Drawing.Point(125, 343);
            this.btnRollataAtt1.Name = "btnRollataAtt1";
            this.btnRollataAtt1.Size = new System.Drawing.Size(186, 38);
            this.btnRollataAtt1.TabIndex = 8;
            this.btnRollataAtt1.Text = "Rollata Attaccante";
            this.btnRollataAtt1.UseVisualStyleBackColor = true;
            this.btnRollataAtt1.Click += new System.EventHandler(this.btnRollataAtt1_Click);
            // 
            // btnRollataAtt2
            // 
            this.btnRollataAtt2.Location = new System.Drawing.Point(490, 343);
            this.btnRollataAtt2.Name = "btnRollataAtt2";
            this.btnRollataAtt2.Size = new System.Drawing.Size(186, 38);
            this.btnRollataAtt2.TabIndex = 9;
            this.btnRollataAtt2.Text = "Rollata Attaccante";
            this.btnRollataAtt2.UseVisualStyleBackColor = true;
            this.btnRollataAtt2.Click += new System.EventHandler(this.btnRollataAtt2_Click);
            // 
            // btnRollataDif1
            // 
            this.btnRollataDif1.Location = new System.Drawing.Point(125, 387);
            this.btnRollataDif1.Name = "btnRollataDif1";
            this.btnRollataDif1.Size = new System.Drawing.Size(186, 38);
            this.btnRollataDif1.TabIndex = 10;
            this.btnRollataDif1.Text = "Rollata Difensore";
            this.btnRollataDif1.UseVisualStyleBackColor = true;
            this.btnRollataDif1.Click += new System.EventHandler(this.btnRollataDif1_Click);
            // 
            // btnRollataDif2
            // 
            this.btnRollataDif2.Location = new System.Drawing.Point(490, 387);
            this.btnRollataDif2.Name = "btnRollataDif2";
            this.btnRollataDif2.Size = new System.Drawing.Size(186, 38);
            this.btnRollataDif2.TabIndex = 11;
            this.btnRollataDif2.Text = "Rollata Difensore";
            this.btnRollataDif2.UseVisualStyleBackColor = true;
            this.btnRollataDif2.Click += new System.EventHandler(this.btnRollataDif2_Click);
            // 
            // lblRisultato
            // 
            this.lblRisultato.AutoSize = true;
            this.lblRisultato.Location = new System.Drawing.Point(363, 206);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(63, 17);
            this.lblRisultato.TabIndex = 12;
            this.lblRisultato.Text = "Risultato";
            // 
            // lblPunteggio1
            // 
            this.lblPunteggio1.AutoSize = true;
            this.lblPunteggio1.Location = new System.Drawing.Point(362, 231);
            this.lblPunteggio1.Name = "lblPunteggio1";
            this.lblPunteggio1.Size = new System.Drawing.Size(16, 17);
            this.lblPunteggio1.TabIndex = 13;
            this.lblPunteggio1.Text = "0";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(384, 231);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(12, 17);
            this.lbl.TabIndex = 14;
            this.lbl.Text = ":";
            // 
            // lblPunteggio2
            // 
            this.lblPunteggio2.AutoSize = true;
            this.lblPunteggio2.Location = new System.Drawing.Point(413, 231);
            this.lblPunteggio2.Name = "lblPunteggio2";
            this.lblPunteggio2.Size = new System.Drawing.Size(16, 17);
            this.lblPunteggio2.TabIndex = 15;
            this.lblPunteggio2.Text = "0";
            // 
            // btnNuovaPartita
            // 
            this.btnNuovaPartita.Location = new System.Drawing.Point(326, 445);
            this.btnNuovaPartita.Name = "btnNuovaPartita";
            this.btnNuovaPartita.Size = new System.Drawing.Size(149, 23);
            this.btnNuovaPartita.TabIndex = 16;
            this.btnNuovaPartita.Text = "NUOVA PARTITA";
            this.btnNuovaPartita.UseVisualStyleBackColor = true;
            this.btnNuovaPartita.Click += new System.EventHandler(this.NuovaParttita);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 493);
            this.Controls.Add(this.btnNuovaPartita);
            this.Controls.Add(this.lblPunteggio2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblPunteggio1);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.btnRollataDif2);
            this.Controls.Add(this.btnRollataDif1);
            this.Controls.Add(this.btnRollataAtt2);
            this.Controls.Add(this.btnRollataAtt1);
            this.Controls.Add(this.btnGolMancato2);
            this.Controls.Add(this.btnGolMancato1);
            this.Controls.Add(this.btnGol2);
            this.Controls.Add(this.btnGol1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnGol1;
        private System.Windows.Forms.Button btnGol2;
        private System.Windows.Forms.Button btnGolMancato1;
        private System.Windows.Forms.Button btnGolMancato2;
        private System.Windows.Forms.Button btnRollataAtt1;
        private System.Windows.Forms.Button btnRollataAtt2;
        private System.Windows.Forms.Button btnRollataDif1;
        private System.Windows.Forms.Button btnRollataDif2;
        private System.Windows.Forms.Label lblRisultato;
        private System.Windows.Forms.Label lblPunteggio1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblPunteggio2;
        private System.Windows.Forms.Button btnNuovaPartita;
        private System.Windows.Forms.ComboBox cmbDifensore1;
        private System.Windows.Forms.ComboBox cmbAttaccante1;
        private System.Windows.Forms.ComboBox cmbAttaccante2;
        private System.Windows.Forms.ComboBox cmbDifensore2;
    }
}

