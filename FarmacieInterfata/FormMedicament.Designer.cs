namespace FarmacieInterfata
{
    partial class FormMedicament
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicament));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.numericUpDownPret = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.radioButtonDa = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelDenumire = new System.Windows.Forms.Label();
            this.labelPret = new System.Windows.Forms.Label();
            this.labelNecesitaReteta = new System.Windows.Forms.Label();
            this.labelCategorie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPret)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denumire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Necesita reteta?";
            // 
            // textBoxDenumire
            // 
            this.textBoxDenumire.Location = new System.Drawing.Point(249, 29);
            this.textBoxDenumire.Name = "textBoxDenumire";
            this.textBoxDenumire.Size = new System.Drawing.Size(295, 20);
            this.textBoxDenumire.TabIndex = 3;
            // 
            // numericUpDownPret
            // 
            this.numericUpDownPret.DecimalPlaces = 2;
            this.numericUpDownPret.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPret.Location = new System.Drawing.Point(249, 107);
            this.numericUpDownPret.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPret.Name = "numericUpDownPret";
            this.numericUpDownPret.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPret.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(120, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(445, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonAdauga_click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNu);
            this.groupBox1.Controls.Add(this.radioButtonDa);
            this.groupBox1.Location = new System.Drawing.Point(249, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 24);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Location = new System.Drawing.Point(103, 0);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(37, 17);
            this.radioButtonNu.TabIndex = 1;
            this.radioButtonNu.TabStop = true;
            this.radioButtonNu.Text = "nu";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // radioButtonDa
            // 
            this.radioButtonDa.AutoSize = true;
            this.radioButtonDa.Location = new System.Drawing.Point(6, 1);
            this.radioButtonDa.Name = "radioButtonDa";
            this.radioButtonDa.Size = new System.Drawing.Size(37, 17);
            this.radioButtonDa.TabIndex = 0;
            this.radioButtonDa.TabStop = true;
            this.radioButtonDa.Text = "da";
            this.radioButtonDa.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(664, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Inapoi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonInapoi_click);
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(249, 266);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(295, 21);
            this.comboBoxCategorie.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Categorie";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenumire.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDenumire.Location = new System.Drawing.Point(614, 32);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(57, 14);
            this.labelDenumire.TabIndex = 14;
            this.labelDenumire.Text = "Categorie";
            this.labelDenumire.Visible = false;
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPret.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPret.Location = new System.Drawing.Point(464, 113);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(57, 14);
            this.labelPret.TabIndex = 15;
            this.labelPret.Text = "Categorie";
            this.labelPret.Visible = false;
            // 
            // labelNecesitaReteta
            // 
            this.labelNecesitaReteta.AutoSize = true;
            this.labelNecesitaReteta.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNecesitaReteta.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNecesitaReteta.Location = new System.Drawing.Point(464, 191);
            this.labelNecesitaReteta.Name = "labelNecesitaReteta";
            this.labelNecesitaReteta.Size = new System.Drawing.Size(57, 14);
            this.labelNecesitaReteta.TabIndex = 16;
            this.labelNecesitaReteta.Text = "Categorie";
            this.labelNecesitaReteta.Visible = false;
            // 
            // labelCategorie
            // 
            this.labelCategorie.AutoSize = true;
            this.labelCategorie.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategorie.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCategorie.Location = new System.Drawing.Point(614, 273);
            this.labelCategorie.Name = "labelCategorie";
            this.labelCategorie.Size = new System.Drawing.Size(57, 14);
            this.labelCategorie.TabIndex = 17;
            this.labelCategorie.Text = "Categorie";
            this.labelCategorie.Visible = false;
            // 
            // FormMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCategorie);
            this.Controls.Add(this.labelNecesitaReteta);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.labelDenumire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxCategorie);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownPret);
            this.Controls.Add(this.textBoxDenumire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMedicament";
            this.Text = "FormMedicament";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPret)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDenumire;
        private System.Windows.Forms.NumericUpDown numericUpDownPret;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNu;
        private System.Windows.Forms.RadioButton radioButtonDa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxCategorie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelCategorie;
        private System.Windows.Forms.Label labelNecesitaReteta;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.Label labelDenumire;
    }
}