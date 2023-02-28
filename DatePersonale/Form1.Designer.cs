namespace DatePersonale
{
    partial class Form1
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox12 = new System.Windows.Forms.ListBox();
            this.textnume = new System.Windows.Forms.Label();
            this.textprenume = new System.Windows.Forms.Label();
            this.textvarsta = new System.Windows.Forms.Label();
            this.textlocdemunca = new System.Windows.Forms.Label();
            this.textserie = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.txtLocDeMunca = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.textnr = new System.Windows.Forms.Label();
            this.txtNumar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btntrimite = new System.Windows.Forms.Button();
            this.textdepartament = new System.Windows.Forms.Label();
            this.textadresa = new System.Windows.Forms.Label();
            this.txtDepartament = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(608, 248);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(208, 148);
            this.listBox2.TabIndex = 0;
            // 
            // listBox12
            // 
            this.listBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox12.FormattingEnabled = true;
            this.listBox12.ItemHeight = 25;
            this.listBox12.Location = new System.Drawing.Point(22, 46);
            this.listBox12.Name = "listBox12";
            this.listBox12.Size = new System.Drawing.Size(346, 354);
            this.listBox12.TabIndex = 1;
            // 
            // textnume
            // 
            this.textnume.AutoSize = true;
            this.textnume.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textnume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnume.Location = new System.Drawing.Point(36, 60);
            this.textnume.Name = "textnume";
            this.textnume.Size = new System.Drawing.Size(57, 22);
            this.textnume.TabIndex = 2;
            this.textnume.Text = "Nume";
            this.textnume.Click += new System.EventHandler(this.label1_Click);
            // 
            // textprenume
            // 
            this.textprenume.AutoSize = true;
            this.textprenume.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textprenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textprenume.Location = new System.Drawing.Point(36, 103);
            this.textprenume.Name = "textprenume";
            this.textprenume.Size = new System.Drawing.Size(82, 22);
            this.textprenume.TabIndex = 3;
            this.textprenume.Text = "Prenume";
            // 
            // textvarsta
            // 
            this.textvarsta.AutoSize = true;
            this.textvarsta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textvarsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textvarsta.Location = new System.Drawing.Point(36, 149);
            this.textvarsta.Name = "textvarsta";
            this.textvarsta.Size = new System.Drawing.Size(62, 22);
            this.textvarsta.TabIndex = 4;
            this.textvarsta.Text = "Varsta";
            // 
            // textlocdemunca
            // 
            this.textlocdemunca.AutoSize = true;
            this.textlocdemunca.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textlocdemunca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textlocdemunca.Location = new System.Drawing.Point(37, 195);
            this.textlocdemunca.Name = "textlocdemunca";
            this.textlocdemunca.Size = new System.Drawing.Size(122, 22);
            this.textlocdemunca.TabIndex = 5;
            this.textlocdemunca.Text = "Loc de munca";
            // 
            // textserie
            // 
            this.textserie.AutoSize = true;
            this.textserie.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textserie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textserie.Location = new System.Drawing.Point(37, 329);
            this.textserie.Name = "textserie";
            this.textserie.Size = new System.Drawing.Size(52, 22);
            this.textserie.TabIndex = 6;
            this.textserie.Text = "Serie";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(115, 62);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(235, 22);
            this.txtNume.TabIndex = 7;
            this.txtNume.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(149, 105);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(201, 22);
            this.txtPrenume.TabIndex = 8;
            this.txtPrenume.TextChanged += new System.EventHandler(this.txtPrenume_TextChanged);
            // 
            // txtVarsta
            // 
            this.txtVarsta.Location = new System.Drawing.Point(115, 151);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(235, 22);
            this.txtVarsta.TabIndex = 9;
            this.txtVarsta.TextChanged += new System.EventHandler(this.txtVarsta_TextChanged);
            // 
            // txtLocDeMunca
            // 
            this.txtLocDeMunca.Location = new System.Drawing.Point(196, 197);
            this.txtLocDeMunca.Name = "txtLocDeMunca";
            this.txtLocDeMunca.Size = new System.Drawing.Size(154, 22);
            this.txtLocDeMunca.TabIndex = 10;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(115, 329);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(72, 22);
            this.txtSerie.TabIndex = 11;
            this.txtSerie.TextChanged += new System.EventHandler(this.txtSerie_TextChanged);
            // 
            // textnr
            // 
            this.textnr.AutoSize = true;
            this.textnr.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnr.Location = new System.Drawing.Point(206, 329);
            this.textnr.Name = "textnr";
            this.textnr.Size = new System.Drawing.Size(63, 22);
            this.textnr.TabIndex = 12;
            this.textnr.Text = "Numar";
            // 
            // txtNumar
            // 
            this.txtNumar.Location = new System.Drawing.Point(278, 329);
            this.txtNumar.Name = "txtNumar";
            this.txtNumar.Size = new System.Drawing.Size(72, 22);
            this.txtNumar.TabIndex = 13;
            this.txtNumar.TextChanged += new System.EventHandler(this.txtNumar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DatePersonale.Properties.Resources.YKIC9415;
            this.pictureBox1.Location = new System.Drawing.Point(604, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btntrimite
            // 
            this.btntrimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrimite.ForeColor = System.Drawing.Color.Black;
            this.btntrimite.Location = new System.Drawing.Point(398, 348);
            this.btntrimite.Name = "btntrimite";
            this.btntrimite.Size = new System.Drawing.Size(185, 48);
            this.btntrimite.TabIndex = 15;
            this.btntrimite.Text = "Trimite";
            this.btntrimite.UseVisualStyleBackColor = true;
            this.btntrimite.Click += new System.EventHandler(this.btntrimite_Click);
            // 
            // textdepartament
            // 
            this.textdepartament.AutoSize = true;
            this.textdepartament.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textdepartament.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdepartament.Location = new System.Drawing.Point(37, 238);
            this.textdepartament.Name = "textdepartament";
            this.textdepartament.Size = new System.Drawing.Size(113, 22);
            this.textdepartament.TabIndex = 16;
            this.textdepartament.Text = "Departament";
            // 
            // textadresa
            // 
            this.textadresa.AutoSize = true;
            this.textadresa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textadresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textadresa.Location = new System.Drawing.Point(37, 278);
            this.textadresa.Name = "textadresa";
            this.textadresa.Size = new System.Drawing.Size(67, 22);
            this.textadresa.TabIndex = 17;
            this.textadresa.Text = "Adresa";
            // 
            // txtDepartament
            // 
            this.txtDepartament.Location = new System.Drawing.Point(165, 238);
            this.txtDepartament.Name = "txtDepartament";
            this.txtDepartament.Size = new System.Drawing.Size(185, 22);
            this.txtDepartament.TabIndex = 18;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(126, 278);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(224, 22);
            this.txtAdresa.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtDepartament);
            this.Controls.Add(this.textadresa);
            this.Controls.Add(this.textdepartament);
            this.Controls.Add(this.btntrimite);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNumar);
            this.Controls.Add(this.textnr);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtLocDeMunca);
            this.Controls.Add(this.txtVarsta);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.textserie);
            this.Controls.Add(this.textlocdemunca);
            this.Controls.Add(this.textvarsta);
            this.Controls.Add(this.textprenume);
            this.Controls.Add(this.textnume);
            this.Controls.Add(this.listBox12);
            this.Controls.Add(this.listBox2);
            this.Name = "Form1";
            this.Text = "Date Personale";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox12;
        private System.Windows.Forms.Label textnume;
        private System.Windows.Forms.Label textprenume;
        private System.Windows.Forms.Label textvarsta;
        private System.Windows.Forms.Label textlocdemunca;
        private System.Windows.Forms.Label textserie;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.TextBox txtLocDeMunca;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label textnr;
        private System.Windows.Forms.TextBox txtNumar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btntrimite;
        private System.Windows.Forms.Label textdepartament;
        private System.Windows.Forms.Label textadresa;
        private System.Windows.Forms.TextBox txtDepartament;
        private System.Windows.Forms.TextBox txtAdresa;
    }
}

