namespace FarmacieInterfata
{
    partial class FormAdministrare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrare));
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonDeconectare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.BackColor = System.Drawing.Color.Teal;
            this.buttonAdauga.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdauga.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdauga.Location = new System.Drawing.Point(57, 49);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(373, 53);
            this.buttonAdauga.TabIndex = 0;
            this.buttonAdauga.Text = "Adauga Client";
            this.buttonAdauga.UseVisualStyleBackColor = false;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdaugaClient_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(57, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(373, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Adauga Medicament";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonAdaugaMedicament_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.Location = new System.Drawing.Point(452, 165);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(297, 122);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Gestionare \n             Farmacie";
            // 
            // buttonDeconectare
            // 
            this.buttonDeconectare.Location = new System.Drawing.Point(674, 415);
            this.buttonDeconectare.Name = "buttonDeconectare";
            this.buttonDeconectare.Size = new System.Drawing.Size(105, 23);
            this.buttonDeconectare.TabIndex = 3;
            this.buttonDeconectare.Text = "Deconecteaza-te";
            this.buttonDeconectare.UseVisualStyleBackColor = true;
            this.buttonDeconectare.Click += new System.EventHandler(this.buttonDeconectare_Click);
            // 
            // FormAdministrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeconectare);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAdauga);
            this.Name = "FormAdministrare";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonDeconectare;
    }
}

