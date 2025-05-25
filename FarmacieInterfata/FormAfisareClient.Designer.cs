namespace FarmacieInterfata
{
    partial class FormAfisareClienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAfisareClienti));
            this.dataGridViewClienti = new System.Windows.Forms.DataGridView();
            this.columnNume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDataNaterii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxCautare = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClienti
            // 
            this.dataGridViewClienti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClienti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewClienti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClienti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClienti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNume,
            this.columnPrenume,
            this.columnDataNaterii,
            this.varsta});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClienti.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClienti.GridColor = System.Drawing.Color.Teal;
            this.dataGridViewClienti.Location = new System.Drawing.Point(15, 75);
            this.dataGridViewClienti.Name = "dataGridViewClienti";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClienti.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClienti.Size = new System.Drawing.Size(673, 241);
            this.dataGridViewClienti.TabIndex = 0;
            this.dataGridViewClienti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Editare_doubleClick);
            // 
            // columnNume
            // 
            this.columnNume.HeaderText = "Nume";
            this.columnNume.Name = "columnNume";
            // 
            // columnPrenume
            // 
            this.columnPrenume.HeaderText = "Prenume";
            this.columnPrenume.Name = "columnPrenume";
            // 
            // columnDataNaterii
            // 
            this.columnDataNaterii.HeaderText = "Data Naterii";
            this.columnDataNaterii.Name = "columnDataNaterii";
            // 
            // varsta
            // 
            this.varsta.HeaderText = "Varsta";
            this.varsta.Name = "varsta";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(37, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(673, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adauga Client nou";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonAdauga_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(668, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Inapoi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonInapoi_click);
            // 
            // textBoxCautare
            // 
            this.textBoxCautare.Location = new System.Drawing.Point(525, 15);
            this.textBoxCautare.Name = "textBoxCautare";
            this.textBoxCautare.Size = new System.Drawing.Size(163, 20);
            this.textBoxCautare.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cauta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonCauta_click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(713, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Sterge";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonStergeClient_Click);
            // 
            // FormAfisareClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxCautare);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewClienti);
            this.Name = "FormAfisareClienti";
            this.Text = "FormAfisareClient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClienti;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNume;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDataNaterii;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxCautare;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn varsta;
    }
}