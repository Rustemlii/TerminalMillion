namespace TerminalMillion
{
    partial class Form5
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
            labelMelumat = new Label();
            SuspendLayout();
            // 
            // labelMelumat
            // 
            labelMelumat.AutoSize = true;
            labelMelumat.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelMelumat.ForeColor = SystemColors.Control;
            labelMelumat.ImageAlign = ContentAlignment.TopLeft;
            labelMelumat.Location = new Point(96, 168);
            labelMelumat.Name = "labelMelumat";
            labelMelumat.Size = new Size(0, 17);
            labelMelumat.TabIndex = 0;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1208, 693);
            Controls.Add(labelMelumat);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelMelumat;
    }
}