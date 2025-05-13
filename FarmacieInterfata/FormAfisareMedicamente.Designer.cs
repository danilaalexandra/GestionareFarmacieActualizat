namespace FarmacieInterfata
{
    partial class FormAfisareMedicamente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnDenumire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNecesitaReteta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textCautare = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(83, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(627, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adauga Medicament Nou";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonAdauga_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Inapoi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonInapoi_click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDenumire,
            this.columnPret,
            this.columnNecesitaReteta,
            this.columnCategorie});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Teal;
            this.dataGridView1.Location = new System.Drawing.Point(74, 69);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(627, 250);
            this.dataGridView1.TabIndex = 3;
            // 
            // columnDenumire
            // 
            this.columnDenumire.HeaderText = "Denumire";
            this.columnDenumire.Name = "columnDenumire";
            // 
            // columnPret
            // 
            this.columnPret.HeaderText = "Pret";
            this.columnPret.Name = "columnPret";
            // 
            // columnNecesitaReteta
            // 
            this.columnNecesitaReteta.HeaderText = "Necesita Reteta?";
            this.columnNecesitaReteta.Name = "columnNecesitaReteta";
            // 
            // columnCategorie
            // 
            this.columnCategorie.HeaderText = "Categorie";
            this.columnCategorie.Name = "columnCategorie";
            // 
            // textCautare
            // 
            this.textCautare.Location = new System.Drawing.Point(525, 28);
            this.textCautare.Name = "textCautare";
            this.textCautare.Size = new System.Drawing.Size(176, 20);
            this.textCautare.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(716, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cauta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonCauta);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(716, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Sterge";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonStergere_Click);
            // 
            // FormAfisareMedicamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textCautare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormAfisareMedicamente";
            this.Text = "FormAfisareMedicamente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDenumire;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPret;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNecesitaReteta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCategorie;
        private System.Windows.Forms.TextBox textCautare;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        // private System.Windows.Forms.Button buttonStergere;
    }
}