namespace TerminalMillion
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            panel1 = new Panel();
            labelMilliodemeMenteqesi1 = new Label();
            labelMillion = new Label();
            panel2 = new Panel();
            label1 = new Label();
            buttonRus = new Button();
            buttonEnglish = new Button();
            buttonMelumat = new Button();
            buttonEvvele = new Button();
            label2 = new Label();
            label3BalansaElaveOlunan = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(labelMilliodemeMenteqesi1);
            panel1.Controls.Add(labelMillion);
            panel1.Location = new Point(12, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 101);
            panel1.TabIndex = 0;
            // 
            // labelMilliodemeMenteqesi1
            // 
            labelMilliodemeMenteqesi1.AutoSize = true;
            labelMilliodemeMenteqesi1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelMilliodemeMenteqesi1.ForeColor = SystemColors.ActiveCaptionText;
            labelMilliodemeMenteqesi1.Location = new Point(55, 66);
            labelMilliodemeMenteqesi1.Name = "labelMilliodemeMenteqesi1";
            labelMilliodemeMenteqesi1.Size = new Size(191, 23);
            labelMilliodemeMenteqesi1.TabIndex = 4;
            labelMilliodemeMenteqesi1.Text = "Milli Ödəmə məntəqəsi";
            // 
            // labelMillion
            // 
            labelMillion.AutoSize = true;
            labelMillion.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelMillion.ForeColor = SystemColors.Control;
            labelMillion.Location = new Point(45, 6);
            labelMillion.Name = "labelMillion";
            labelMillion.Size = new Size(216, 60);
            labelMillion.TabIndex = 2;
            labelMillion.Text = "   milliÖn";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(buttonRus);
            panel2.Controls.Add(buttonEnglish);
            panel2.Controls.Add(buttonMelumat);
            panel2.Controls.Add(buttonEvvele);
            panel2.Location = new Point(12, 592);
            panel2.Name = "panel2";
            panel2.Size = new Size(1172, 101);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(988, 20);
            label1.Name = "label1";
            label1.Size = new Size(143, 50);
            label1.TabIndex = 13;
            label1.Text = "* 00 10";
            // 
            // buttonRus
            // 
            buttonRus.BackgroundImage = (Image)resources.GetObject("buttonRus.BackgroundImage");
            buttonRus.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRus.Location = new Point(829, 20);
            buttonRus.Name = "buttonRus";
            buttonRus.Size = new Size(65, 58);
            buttonRus.TabIndex = 12;
            buttonRus.UseVisualStyleBackColor = true;
            // 
            // buttonEnglish
            // 
            buttonEnglish.BackColor = Color.Gray;
            buttonEnglish.BackgroundImage = (Image)resources.GetObject("buttonEnglish.BackgroundImage");
            buttonEnglish.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEnglish.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEnglish.Location = new Point(756, 20);
            buttonEnglish.Name = "buttonEnglish";
            buttonEnglish.Size = new Size(67, 59);
            buttonEnglish.TabIndex = 11;
            buttonEnglish.UseVisualStyleBackColor = false;
            // 
            // buttonMelumat
            // 
            buttonMelumat.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonMelumat.ForeColor = SystemColors.ActiveCaptionText;
            buttonMelumat.Location = new Point(367, 25);
            buttonMelumat.Name = "buttonMelumat";
            buttonMelumat.Size = new Size(182, 55);
            buttonMelumat.TabIndex = 9;
            buttonMelumat.Text = "Məlumat";
            buttonMelumat.UseVisualStyleBackColor = true;
            buttonMelumat.Click += buttonMelumat_Click;
            // 
            // buttonEvvele
            // 
            buttonEvvele.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonEvvele.ForeColor = SystemColors.ActiveCaptionText;
            buttonEvvele.Location = new Point(34, 25);
            buttonEvvele.Name = "buttonEvvele";
            buttonEvvele.Size = new Size(182, 55);
            buttonEvvele.TabIndex = 8;
            buttonEvvele.Text = "Əvvələ";
            buttonEvvele.UseVisualStyleBackColor = true;
            buttonEvvele.Click += buttonEvvele_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(198, 272);
            label2.Name = "label2";
            label2.Size = new Size(392, 41);
            label2.TabIndex = 1;
            label2.Text = "Balansınıza əlavə olundu :";
            // 
            // label3BalansaElaveOlunan
            // 
            label3BalansaElaveOlunan.AutoSize = true;
            label3BalansaElaveOlunan.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3BalansaElaveOlunan.Location = new Point(622, 272);
            label3BalansaElaveOlunan.Name = "label3BalansaElaveOlunan";
            label3BalansaElaveOlunan.Size = new Size(50, 41);
            label3BalansaElaveOlunan.TabIndex = 1;
            label3BalansaElaveOlunan.Text = "....";
            label3BalansaElaveOlunan.Click += label3BalansaElaveOlunan_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1208, 695);
            Controls.Add(label3BalansaElaveOlunan);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
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
        private Label labelMilliodemeMenteqesi1;
        private Button buttonEvvele;
        private Button buttonMelumat;
        private Button buttonEnglish;
        private Button buttonRus;
        private Label label1;
        private Label label2;
        public Label label3BalansaElaveOlunan;
    }
}