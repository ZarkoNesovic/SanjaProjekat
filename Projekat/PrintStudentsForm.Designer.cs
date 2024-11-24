namespace Projekat
{
    partial class PrintStudentsForm
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
            dataGridView1 = new DataGridView();
            buttonAddStudent = new Button();
            groupBox1 = new GroupBox();
            buttonGo = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            radioButtonYes = new RadioButton();
            radioButtonNo = new RadioButton();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            radioButtonAll = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1192, 370);
            dataGridView1.TabIndex = 1;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Location = new Point(12, 519);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(1192, 53);
            buttonAddStudent.TabIndex = 16;
            buttonAddStudent.Text = "Print to text";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonGo);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(radioButtonMale);
            groupBox1.Controls.Add(radioButtonFemale);
            groupBox1.Controls.Add(radioButtonAll);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1192, 125);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // buttonGo
            // 
            buttonGo.Location = new Point(868, 32);
            buttonGo.Name = "buttonGo";
            buttonGo.Size = new Size(300, 76);
            buttonGo.TabIndex = 18;
            buttonGo.Text = "GO";
            buttonGo.UseVisualStyleBackColor = true;
            buttonGo.Click += buttonGo_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(radioButtonYes);
            groupBox2.Controls.Add(radioButtonNo);
            groupBox2.Location = new Point(291, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(549, 82);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 54);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 10;
            label3.Text = "and";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(415, 49);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(101, 27);
            dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(195, 49);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 49);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 7;
            label2.Text = "Birthdate between:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 6;
            label1.Text = "Use Date Range:";
            // 
            // radioButtonYes
            // 
            radioButtonYes.AutoSize = true;
            radioButtonYes.Location = new Point(308, 20);
            radioButtonYes.Name = "radioButtonYes";
            radioButtonYes.Size = new Size(51, 24);
            radioButtonYes.TabIndex = 4;
            radioButtonYes.TabStop = true;
            radioButtonYes.Text = "Yes";
            radioButtonYes.UseVisualStyleBackColor = true;
            radioButtonYes.CheckedChanged += radioButtonYes_CheckedChanged;
            // 
            // radioButtonNo
            // 
            radioButtonNo.AutoSize = true;
            radioButtonNo.Checked = true;
            radioButtonNo.Location = new Point(440, 20);
            radioButtonNo.Name = "radioButtonNo";
            radioButtonNo.Size = new Size(50, 24);
            radioButtonNo.TabIndex = 5;
            radioButtonNo.TabStop = true;
            radioButtonNo.Text = "No";
            radioButtonNo.UseVisualStyleBackColor = true;
            radioButtonNo.CheckedChanged += radioButtonNo_CheckedChanged;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(98, 42);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(63, 24);
            radioButtonMale.TabIndex = 2;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(182, 42);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(78, 24);
            radioButtonFemale.TabIndex = 1;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonAll
            // 
            radioButtonAll.AutoSize = true;
            radioButtonAll.Location = new Point(31, 42);
            radioButtonAll.Name = "radioButtonAll";
            radioButtonAll.Size = new Size(48, 24);
            radioButtonAll.TabIndex = 0;
            radioButtonAll.TabStop = true;
            radioButtonAll.Text = "All";
            radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // PrintStudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1216, 596);
            Controls.Add(groupBox1);
            Controls.Add(buttonAddStudent);
            Controls.Add(dataGridView1);
            Name = "PrintStudentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrintStudentsForm";
            Load += PrintStudentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonAddStudent;
        private GroupBox groupBox1;
        private RadioButton radioButtonAll;
        private GroupBox groupBox2;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private Button buttonGo;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private RadioButton radioButtonYes;
        private RadioButton radioButtonNo;
    }
}