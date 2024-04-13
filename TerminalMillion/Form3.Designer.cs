namespace TerminalMillion
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            labelMilliodemeMenteqesi2 = new Label();
            labelMillion = new Label();
            panel2 = new Panel();
            buttonEnglish = new Button();
            buttonRus = new Button();
            buttonMelumat = new Button();
            buttonEvvele = new Button();
            label1 = new Label();
            textBoxEskinaz = new TextBox();
            labelBalans = new Label();
            buttonIreli3 = new Button();
            buttonGeri3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(labelMilliodemeMenteqesi2);
            panel1.Controls.Add(labelMillion);
            panel1.Location = new Point(12, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 101);
            panel1.TabIndex = 0;
            // 
            // labelMilliodemeMenteqesi2
            // 
            labelMilliodemeMenteqesi2.AutoSize = true;
            labelMilliodemeMenteqesi2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelMilliodemeMenteqesi2.ForeColor = SystemColors.ActiveCaptionText;
            labelMilliodemeMenteqesi2.Location = new Point(60, 60);
            labelMilliodemeMenteqesi2.Name = "labelMilliodemeMenteqesi2";
            labelMilliodemeMenteqesi2.Size = new Size(191, 23);
            labelMilliodemeMenteqesi2.TabIndex = 3;
            labelMilliodemeMenteqesi2.Text = "Milli Ödəmə məntəqəsi";
            // 
            // labelMillion
            // 
            labelMillion.AutoSize = true;
            labelMillion.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelMillion.ForeColor = SystemColors.Control;
            labelMillion.Location = new Point(46, 0);
            labelMillion.Name = "labelMillion";
            labelMillion.Size = new Size(216, 60);
            labelMillion.TabIndex = 1;
            labelMillion.Text = "   milliÖn";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(buttonEnglish);
            panel2.Controls.Add(buttonRus);
            panel2.Controls.Add(buttonMelumat);
            panel2.Controls.Add(buttonEvvele);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 582);
            panel2.Name = "panel2";
            panel2.Size = new Size(1172, 101);
            panel2.TabIndex = 0;
            // 
            // buttonEnglish
            // 
            buttonEnglish.BackColor = Color.Gray;
            buttonEnglish.BackgroundImage = (Image)resources.GetObject("buttonEnglish.BackgroundImage");
            buttonEnglish.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEnglish.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEnglish.Location = new Point(738, 24);
            buttonEnglish.Name = "buttonEnglish";
            buttonEnglish.Size = new Size(67, 59);
            buttonEnglish.TabIndex = 10;
            buttonEnglish.UseVisualStyleBackColor = false;
            // 
            // buttonRus
            // 
            buttonRus.BackgroundImage = (Image)resources.GetObject("buttonRus.BackgroundImage");
            buttonRus.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRus.Location = new Point(830, 24);
            buttonRus.Name = "buttonRus";
            buttonRus.Size = new Size(65, 58);
            buttonRus.TabIndex = 9;
            buttonRus.UseVisualStyleBackColor = true;
            // 
            // buttonMelumat
            // 
            buttonMelumat.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonMelumat.ForeColor = SystemColors.ActiveCaptionText;
            buttonMelumat.Location = new Point(409, 24);
            buttonMelumat.Name = "buttonMelumat";
            buttonMelumat.Size = new Size(182, 55);
            buttonMelumat.TabIndex = 8;
            buttonMelumat.Text = "Məlumat";
            buttonMelumat.UseVisualStyleBackColor = true;
            buttonMelumat.Click += buttonMelumat_Click;
            // 
            // buttonEvvele
            // 
            buttonEvvele.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonEvvele.ForeColor = SystemColors.ActiveCaptionText;
            buttonEvvele.Location = new Point(80, 24);
            buttonEvvele.Name = "buttonEvvele";
            buttonEvvele.Size = new Size(182, 55);
            buttonEvvele.TabIndex = 7;
            buttonEvvele.Text = "Əvvələ";
            buttonEvvele.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(996, 29);
            label1.Name = "label1";
            label1.Size = new Size(143, 50);
            label1.TabIndex = 1;
            label1.Text = "* 00 10";
            // 
            // textBoxEskinaz
            // 
            textBoxEskinaz.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxEskinaz.Location = new Point(421, 179);
            textBoxEskinaz.Multiline = true;
            textBoxEskinaz.Name = "textBoxEskinaz";
            textBoxEskinaz.PlaceholderText = "0 Azn";
            textBoxEskinaz.Size = new Size(251, 47);
            textBoxEskinaz.TabIndex = 1;
            textBoxEskinaz.TextAlign = HorizontalAlignment.Center;
            textBoxEskinaz.TextChanged += textBoxEskinaz_TextChanged;
            // 
            // labelBalans
            // 
            labelBalans.AutoSize = true;
            labelBalans.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelBalans.Location = new Point(398, 117);
            labelBalans.Name = "labelBalans";
            labelBalans.Size = new Size(292, 41);
            labelBalans.TabIndex = 2;
            labelBalans.Text = "Əskinazı daxil edin";
            // 
            // buttonIreli3
            // 
            buttonIreli3.BackColor = Color.Green;
            buttonIreli3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonIreli3.Location = new Point(952, 476);
            buttonIreli3.Name = "buttonIreli3";
            buttonIreli3.Size = new Size(180, 58);
            buttonIreli3.TabIndex = 4;
            buttonIreli3.Text = "İrəli-->";
            buttonIreli3.UseVisualStyleBackColor = false;
            buttonIreli3.Click += buttonIreli2_Click;
            // 
            // buttonGeri3
            // 
            buttonGeri3.BackColor = Color.Red;
            buttonGeri3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonGeri3.Location = new Point(952, 397);
            buttonGeri3.Name = "buttonGeri3";
            buttonGeri3.Size = new Size(180, 58);
            buttonGeri3.TabIndex = 5;
            buttonGeri3.Text = "<--Geri";
            buttonGeri3.UseVisualStyleBackColor = false;
            buttonGeri3.Click += buttonGeri2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1208, 695);
            Controls.Add(buttonGeri3);
            Controls.Add(buttonIreli3);
            Controls.Add(labelBalans);
            Controls.Add(textBoxEskinaz);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label labelMillion;
        public Label labelMilliodemeMenteqesi2;
        private Label label1;
        public Button buttonEvvele;
        public Button buttonMelumat;
        private Button buttonRus;
        private Button buttonEnglish;
        public TextBox textBoxEskinaz;
        public Label labelBalans;
        public Button buttonIreli3;
        public Button buttonGeri3;
    }
}