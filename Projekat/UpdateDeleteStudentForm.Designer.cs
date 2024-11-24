namespace Projekat
{
    partial class UpdateDeleteStudentForm
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
            textBoxAddress = new TextBox();
            groupBox1 = new GroupBox();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textBoxPhone = new TextBox();
            textBoxLName = new TextBox();
            textBoxFname = new TextBox();
            textBoxID = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBoxStudentImage = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            buttonUploadImage = new Button();
            buttonEditStudent = new Button();
            buttonRemoveStudent = new Button();
            buttonFind = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudentImage).BeginInit();
            SuspendLayout();
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(569, 35);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(250, 78);
            textBoxAddress.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonFemale);
            groupBox1.Controls.Add(radioButtonMale);
            groupBox1.Location = new Point(157, 269);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 39);
            groupBox1.TabIndex = 21;
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
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(157, 219);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 20;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(157, 327);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(250, 27);
            textBoxPhone.TabIndex = 19;
            // 
            // textBoxLName
            // 
            textBoxLName.Location = new Point(157, 161);
            textBoxLName.Name = "textBoxLName";
            textBoxLName.Size = new Size(250, 27);
            textBoxLName.TabIndex = 18;
            // 
            // textBoxFname
            // 
            textBoxFname.Location = new Point(157, 110);
            textBoxFname.Name = "textBoxFname";
            textBoxFname.Size = new Size(250, 27);
            textBoxFname.TabIndex = 17;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(157, 48);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(102, 27);
            textBoxID.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 109);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 24;
            label1.Text = "First name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 272);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 27;
            label4.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 217);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 26;
            label3.Text = "Birth date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 163);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 25;
            label2.Text = "Last name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(38, 326);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 28;
            label5.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(76, 50);
            label6.Name = "label6";
            label6.Size = new Size(37, 25);
            label6.TabIndex = 29;
            label6.Text = "ID:";
            // 
            // pictureBoxStudentImage
            // 
            pictureBoxStudentImage.BackColor = SystemColors.ActiveCaption;
            pictureBoxStudentImage.Location = new Point(569, 161);
            pictureBoxStudentImage.Name = "pictureBoxStudentImage";
            pictureBoxStudentImage.Size = new Size(250, 162);
            pictureBoxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStudentImage.TabIndex = 30;
            pictureBoxStudentImage.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(472, 50);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 31;
            label7.Text = "Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(485, 187);
            label8.Name = "label8";
            label8.Size = new Size(78, 25);
            label8.TabIndex = 32;
            label8.Text = "Picture:";
            // 
            // buttonUploadImage
            // 
            buttonUploadImage.Location = new Point(569, 331);
            buttonUploadImage.Name = "buttonUploadImage";
            buttonUploadImage.Size = new Size(250, 29);
            buttonUploadImage.TabIndex = 33;
            buttonUploadImage.Text = "Upload Image";
            buttonUploadImage.UseVisualStyleBackColor = true;
            buttonUploadImage.Click += buttonUploadImage_Click;
            // 
            // buttonEditStudent
            // 
            buttonEditStudent.Location = new Point(205, 426);
            buttonEditStudent.Name = "buttonEditStudent";
            buttonEditStudent.Size = new Size(164, 53);
            buttonEditStudent.TabIndex = 34;
            buttonEditStudent.Text = "Edit";
            buttonEditStudent.UseVisualStyleBackColor = true;
            buttonEditStudent.Click += buttonEditStudent_Click;
            // 
            // buttonRemoveStudent
            // 
            buttonRemoveStudent.Location = new Point(617, 426);
            buttonRemoveStudent.Name = "buttonRemoveStudent";
            buttonRemoveStudent.Size = new Size(164, 53);
            buttonRemoveStudent.TabIndex = 35;
            buttonRemoveStudent.Text = "Remove";
            buttonRemoveStudent.UseVisualStyleBackColor = true;
            buttonRemoveStudent.Click += buttonRemoveStudent_Click;
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(284, 46);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(123, 37);
            buttonFind.TabIndex = 36;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // UpdateDeleteStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 519);
            Controls.Add(buttonFind);
            Controls.Add(buttonRemoveStudent);
            Controls.Add(buttonEditStudent);
            Controls.Add(buttonUploadImage);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBoxStudentImage);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxID);
            Controls.Add(textBoxAddress);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxLName);
            Controls.Add(textBoxFname);
            Name = "UpdateDeleteStudentForm";
            Text = "UpdateDeleteStudentForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudentImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button buttonUploadImage;
        private Button buttonEditStudent;
        private Button buttonRemoveStudent;
        private Button buttonFind;
        internal TextBox textBoxID;
        internal DateTimePicker dateTimePicker1;
        internal TextBox textBoxAddress;
        internal RadioButton radioButtonFemale;
        internal RadioButton radioButtonMale;
        internal TextBox textBoxPhone;
        internal PictureBox pictureBoxStudentImage;
        internal TextBox textBoxLName;
        internal TextBox textBoxFname;
    }
}