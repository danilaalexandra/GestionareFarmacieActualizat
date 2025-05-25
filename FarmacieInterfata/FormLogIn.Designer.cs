namespace FarmacieInterfata
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.buttonSchimba = new System.Windows.Forms.Button();
            this.labelEroare = new System.Windows.Forms.Label();
            this.buttonAfiseazaParola = new System.Windows.Forms.Button();
            this.toolTipAfisare = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adauga parola pentru a avea acces!";
            // 
            // textBoxParola
            // 
            this.textBoxParola.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.textBoxParola.Location = new System.Drawing.Point(273, 299);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(262, 20);
            this.textBoxParola.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(359, 338);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(93, 23);
            this.buttonLogIn.TabIndex = 2;
            this.buttonLogIn.Text = "Conecteaza-te";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // buttonSchimba
            // 
            this.buttonSchimba.Location = new System.Drawing.Point(359, 384);
            this.buttonSchimba.Name = "buttonSchimba";
            this.buttonSchimba.Size = new System.Drawing.Size(93, 23);
            this.buttonSchimba.TabIndex = 3;
            this.buttonSchimba.Text = "Schimba parola";
            this.buttonSchimba.UseVisualStyleBackColor = true;
            this.buttonSchimba.Click += new System.EventHandler(this.buttonSchimba_Click);
            // 
            // labelEroare
            // 
            this.labelEroare.AutoSize = true;
            this.labelEroare.ForeColor = System.Drawing.Color.Red;
            this.labelEroare.Location = new System.Drawing.Point(578, 306);
            this.labelEroare.Name = "labelEroare";
            this.labelEroare.Size = new System.Drawing.Size(35, 13);
            this.labelEroare.TabIndex = 4;
            this.labelEroare.Text = "label2";
            this.labelEroare.Visible = false;
            // 
            // buttonAfiseazaParola
            // 
            this.buttonAfiseazaParola.Location = new System.Drawing.Point(12, 12);
            this.buttonAfiseazaParola.Name = "buttonAfiseazaParola";
            this.buttonAfiseazaParola.Size = new System.Drawing.Size(19, 19);
            this.buttonAfiseazaParola.TabIndex = 5;
            this.toolTipAfisare.SetToolTip(this.buttonAfiseazaParola, "Click pentru a afisa parola!\r\n");
            this.buttonAfiseazaParola.UseVisualStyleBackColor = true;
            this.buttonAfiseazaParola.Click += new System.EventHandler(this.buttonAfiseazaParola_Click);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAfiseazaParola);
            this.Controls.Add(this.labelEroare);
            this.Controls.Add(this.buttonSchimba);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.label1);
            this.Name = "FormLogIn";
            this.Text = "FormLogIn";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonSchimba;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label labelEroare;
        private System.Windows.Forms.Button buttonAfiseazaParola;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}