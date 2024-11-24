namespace Projekat
{
    partial class AddStudentForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxFName = new TextBox();
            textBoxLName = new TextBox();
            textBoxPhone = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            textBoxAddress = new TextBox();
            pictureBoxStudentImage = new PictureBox();
            buttonUploadImage = new Button();
            buttonAddStudent = new Button();
            buttonCancel = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudentImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "First name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 1;
            label2.Text = "Last name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 131);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 2;
            label3.Text = "Birth date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 186);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 3;
            label4.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(46, 240);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 4;
            label5.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 286);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 5;
            label6.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(38, 397);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 6;
            label7.Text = "Picture:";
            // 
            // textBoxFName
            // 
            textBoxFName.Location = new Point(161, 26);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.Size = new Size(250, 27);
            textBoxFName.TabIndex = 7;
            // 
            // textBoxLName
            // 
            textBoxLName.Location = new Point(161, 75);
            textBoxLName.Name = "textBoxLName";
            textBoxLName.Size = new Size(250, 27);
            textBoxLName.TabIndex = 8;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(161, 241);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(250, 27);
            textBoxPhone.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(161, 130);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonFemale);
            groupBox1.Controls.Add(radioButtonMale);
            groupBox1.Location = new Point(161, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 39);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonFemale.Location = new Point(127, 9);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(85, 24);
            radioButtonFemale.TabIndex = 1;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Checked = true;
            radioButtonMale.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonMale.Location = new Point(19, 9);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(66, 24);
            radioButtonMale.TabIndex = 0;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(161, 286);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(250, 78);
            textBoxAddress.TabIndex = 12;
            // 
            // pictureBoxStudentImage
            // 
            pictureBoxStudentImage.BackColor = SystemColors.ActiveCaption;
            pictureBoxStudentImage.Location = new Point(161, 397);
            pictureBoxStudentImage.Name = "pictureBoxStudentImage";
            pictureBoxStudentImage.Size = new Size(250, 162);
            pictureBoxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStudentImage.TabIndex = 13;
            pictureBoxStudentImage.TabStop = false;
            pictureBoxStudentImage.Click += pictureBox1_Click;
            // 
            // buttonUploadImage
            // 
            buttonUploadImage.Location = new Point(161, 565);
            buttonUploadImage.Name = "buttonUploadImage";
            buttonUploadImage.Size = new Size(250, 29);
            buttonUploadImage.TabIndex = 14;
            buttonUploadImage.Text = "Upload Image";
            buttonUploadImage.UseVisualStyleBackColor = true;
            buttonUploadImage.Click += buttonUploadImage_Click;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Location = new Point(247, 614);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(164, 53);
            buttonAddStudent.TabIndex = 15;
            buttonAddStudent.Text = "Add";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(30, 614);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(164, 53);
            buttonCancel.TabIndex = 16;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 679);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAddStudent);
            Controls.Add(buttonUploadImage);
            Controls.Add(pictureBoxStudentImage);
            Controls.Add(textBoxAddress);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxLName);
            Controls.Add(textBoxFName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudentForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudentImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxFName;
        private TextBox textBoxLName;
        private TextBox textBoxPhone;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private TextBox textBoxAddress;
        private PictureBox pictureBoxStudentImage;
        private Button buttonUploadImage;
        private Button buttonAddStudent;
        private Button buttonCancel;
    }
}