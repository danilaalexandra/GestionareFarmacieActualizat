    namespace FarmacieInterfata
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelNume = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.labelDataNasterii = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(282, 59);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(316, 20);
            this.textBoxNume.TabIndex = 0;
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(282, 120);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(316, 20);
            this.textBoxPrenume.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Nasterii ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(90, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(508, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonAdauga_Click_1);
            // 
            // dateTimePickerDataNasterii
            // 
            this.dateTimePickerDataNasterii.Location = new System.Drawing.Point(282, 192);
            this.dateTimePickerDataNasterii.Name = "dateTimePickerDataNasterii";
            this.dateTimePickerDataNasterii.Size = new System.Drawing.Size(316, 20);
            this.dateTimePickerDataNasterii.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(681, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Inapoi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonInapoi_click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNume.Location = new System.Drawing.Point(625, 65);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(54, 14);
            this.labelNume.TabIndex = 9;
            this.labelNume.Text = "Prenume";
            this.labelNume.Visible = false;
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenume.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPrenume.Location = new System.Drawing.Point(625, 128);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(54, 14);
            this.labelPrenume.TabIndex = 10;
            this.labelPrenume.Text = "Prenume";
            this.labelPrenume.Visible = false;
            // 
            // labelDataNasterii
            // 
            this.labelDataNasterii.AutoSize = true;
            this.labelDataNasterii.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataNasterii.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDataNasterii.Location = new System.Drawing.Point(625, 198);
            this.labelDataNasterii.Name = "labelDataNasterii";
            this.labelDataNasterii.Size = new System.Drawing.Size(54, 14);
            this.labelDataNasterii.TabIndex = 11;
            this.labelDataNasterii.Text = "Prenume";
            this.labelDataNasterii.Visible = false;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDataNasterii);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePickerDataNasterii);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrenume);
            this.Controls.Add(this.textBoxNume);
            this.Name = "FormClient";
            this.Text = resources.GetString("$this.Text");
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNasterii;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelDataNasterii;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.Label labelNume;
    }
}