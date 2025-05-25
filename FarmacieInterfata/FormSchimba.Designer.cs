namespace FarmacieInterfata
{
    partial class FormSchimba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSchimba));
            this.textBoxParolaVeche = new System.Windows.Forms.TextBox();
            this.textBoxConfirmare = new System.Windows.Forms.TextBox();
            this.textBoxParolaNoua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSchimbaParola = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelEroareParolaNoua = new System.Windows.Forms.Label();
            this.labelEroareParolaVeche = new System.Windows.Forms.Label();
            this.labelEroareParolaConfirmata = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxParolaVeche
            // 
            this.textBoxParolaVeche.Location = new System.Drawing.Point(332, 110);
            this.textBoxParolaVeche.Name = "textBoxParolaVeche";
            this.textBoxParolaVeche.Size = new System.Drawing.Size(172, 20);
            this.textBoxParolaVeche.TabIndex = 0;
            // 
            // textBoxConfirmare
            // 
            this.textBoxConfirmare.Location = new System.Drawing.Point(332, 296);
            this.textBoxConfirmare.Name = "textBoxConfirmare";
            this.textBoxConfirmare.Size = new System.Drawing.Size(172, 20);
            this.textBoxConfirmare.TabIndex = 1;
            // 
            // textBoxParolaNoua
            // 
            this.textBoxParolaNoua.Location = new System.Drawing.Point(332, 210);
            this.textBoxParolaNoua.Name = "textBoxParolaNoua";
            this.textBoxParolaNoua.Size = new System.Drawing.Size(172, 20);
            this.textBoxParolaNoua.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Parola veche";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parola noua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirma parola";
            // 
            // buttonSchimbaParola
            // 
            this.buttonSchimbaParola.Location = new System.Drawing.Point(258, 392);
            this.buttonSchimbaParola.Name = "buttonSchimbaParola";
            this.buttonSchimbaParola.Size = new System.Drawing.Size(282, 23);
            this.buttonSchimbaParola.TabIndex = 6;
            this.buttonSchimbaParola.Text = "Schimba";
            this.buttonSchimbaParola.UseVisualStyleBackColor = true;
            this.buttonSchimbaParola.Click += new System.EventHandler(this.buttonSchimbaParola_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelEroareParolaNoua
            // 
            this.labelEroareParolaNoua.AutoSize = true;
            this.labelEroareParolaNoua.ForeColor = System.Drawing.Color.Red;
            this.labelEroareParolaNoua.Location = new System.Drawing.Point(555, 217);
            this.labelEroareParolaNoua.Name = "labelEroareParolaNoua";
            this.labelEroareParolaNoua.Size = new System.Drawing.Size(35, 13);
            this.labelEroareParolaNoua.TabIndex = 7;
            this.labelEroareParolaNoua.Text = "label4";
            this.labelEroareParolaNoua.Visible = false;
            // 
            // labelEroareParolaVeche
            // 
            this.labelEroareParolaVeche.AutoSize = true;
            this.labelEroareParolaVeche.ForeColor = System.Drawing.Color.Red;
            this.labelEroareParolaVeche.Location = new System.Drawing.Point(555, 113);
            this.labelEroareParolaVeche.Name = "labelEroareParolaVeche";
            this.labelEroareParolaVeche.Size = new System.Drawing.Size(35, 13);
            this.labelEroareParolaVeche.TabIndex = 8;
            this.labelEroareParolaVeche.Text = "label5";
            this.labelEroareParolaVeche.Visible = false;
            // 
            // labelEroareParolaConfirmata
            // 
            this.labelEroareParolaConfirmata.AutoSize = true;
            this.labelEroareParolaConfirmata.ForeColor = System.Drawing.Color.Red;
            this.labelEroareParolaConfirmata.Location = new System.Drawing.Point(555, 303);
            this.labelEroareParolaConfirmata.Name = "labelEroareParolaConfirmata";
            this.labelEroareParolaConfirmata.Size = new System.Drawing.Size(35, 13);
            this.labelEroareParolaConfirmata.TabIndex = 9;
            this.labelEroareParolaConfirmata.Text = "label6";
            this.labelEroareParolaConfirmata.Visible = false;
            // 
            // FormSchimba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEroareParolaConfirmata);
            this.Controls.Add(this.labelEroareParolaVeche);
            this.Controls.Add(this.labelEroareParolaNoua);
            this.Controls.Add(this.buttonSchimbaParola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxParolaNoua);
            this.Controls.Add(this.textBoxConfirmare);
            this.Controls.Add(this.textBoxParolaVeche);
            this.Name = "FormSchimba";
            this.Text = "FormSchimba";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxParolaVeche;
        private System.Windows.Forms.TextBox textBoxConfirmare;
        private System.Windows.Forms.TextBox textBoxParolaNoua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSchimbaParola;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelEroareParolaConfirmata;
        private System.Windows.Forms.Label labelEroareParolaVeche;
        private System.Windows.Forms.Label labelEroareParolaNoua;
    }
}