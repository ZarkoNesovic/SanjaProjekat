namespace Projekat
{
    partial class StaticsForm
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
            panelTotal = new Panel();
            labelMale = new Label();
            labelTotal = new Label();
            panelMale = new Panel();
            labelM = new Label();
            panelFemale = new Panel();
            labelFemale = new Label();
            panelTotal.SuspendLayout();
            panelMale.SuspendLayout();
            panelFemale.SuspendLayout();
            SuspendLayout();
            // 
            // panelTotal
            // 
            panelTotal.BackColor = SystemColors.ActiveCaption;
            panelTotal.Controls.Add(labelMale);
            panelTotal.Controls.Add(labelTotal);
            panelTotal.Location = new Point(0, -1);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(614, 179);
            panelTotal.TabIndex = 0;
            // 
            // labelMale
            // 
            labelMale.AutoSize = true;
            labelMale.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelMale.Location = new Point(603, 48);
            labelMale.Name = "labelMale";
            labelMale.Size = new Size(92, 32);
            labelMale.TabIndex = 3;
            labelMale.Text = "label2";
            labelMale.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotal.Location = new Point(282, 71);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(92, 32);
            labelTotal.TabIndex = 2;
            labelTotal.Text = "label1";
            labelTotal.TextAlign = ContentAlignment.MiddleCenter;
            labelTotal.MouseEnter += labelTotal_MouseEnter;
            labelTotal.MouseLeave += labelTotal_MouseLeave;
            // 
            // panelMale
            // 
            panelMale.BackColor = Color.RosyBrown;
            panelMale.Controls.Add(labelM);
            panelMale.Location = new Point(0, 177);
            panelMale.Name = "panelMale";
            panelMale.Size = new Size(324, 210);
            panelMale.TabIndex = 1;
            // 
            // labelM
            // 
            labelM.AutoSize = true;
            labelM.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelM.Location = new Point(116, 64);
            labelM.Name = "labelM";
            labelM.Size = new Size(92, 32);
            labelM.TabIndex = 5;
            labelM.Text = "label3";
            labelM.TextAlign = ContentAlignment.MiddleRight;
            labelM.MouseEnter += labelM_MouseEnter;
            labelM.MouseLeave += labelM_MouseLeave;
            // 
            // panelFemale
            // 
            panelFemale.BackColor = SystemColors.MenuHighlight;
            panelFemale.Controls.Add(labelFemale);
            panelFemale.Location = new Point(319, 177);
            panelFemale.Name = "panelFemale";
            panelFemale.Size = new Size(295, 213);
            panelFemale.TabIndex = 2;
            // 
            // labelFemale
            // 
            labelFemale.AutoSize = true;
            labelFemale.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelFemale.Location = new Point(51, 64);
            labelFemale.Name = "labelFemale";
            labelFemale.Size = new Size(92, 32);
            labelFemale.TabIndex = 4;
            labelFemale.Text = "label3";
            labelFemale.TextAlign = ContentAlignment.MiddleRight;
            labelFemale.MouseEnter += labelFemale_MouseEnter;
            labelFemale.MouseLeave += labelFemale_MouseLeave;
            // 
            // StaticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(609, 384);
            Controls.Add(panelFemale);
            Controls.Add(panelTotal);
            Controls.Add(panelMale);
            Name = "StaticsForm";
            Text = "StaticsForm";
            Load += StaticsForm_Load;
            MouseEnter += StaticsForm_MouseEnter;
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            panelMale.ResumeLayout(false);
            panelMale.PerformLayout();
            panelFemale.ResumeLayout(false);
            panelFemale.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTotal;
        private Label labelTotal;
        private Panel panelMale;
        private Panel panelFemale;
        private Label labelFemale;
        private Label labelMale;
        private Label labelM;
    }
}