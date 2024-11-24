using System.Data;
using MySql.Data.MySqlClient;
namespace Projekat
{
    public partial class UpdateDeleteStudentForm : Form
    {  
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }
        Student student = new Student();
        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }
        bool Verify()
        {
            if ((textBoxFname.Text.Trim() == "") || (textBoxLName.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "") || (textBoxAddress.Text.Trim() == "")
                || (pictureBoxStudentImage.Image == null))
                return false;
            else
                return true;
        }


        private void buttonEditStudent_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBoxID.Text);
            string fname = textBoxFname.Text;
            string lname = textBoxLName.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;
            string gender = "Male";
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
            MemoryStream picture = new MemoryStream();

            int b_year = dateTimePicker1.Value.Year;
            int n_year = DateTime.Now.Year;

            if ((n_year - b_year) < 10 || (n_year - b_year) > 100)
            {
                MessageBox.Show("Student age must be between 10 and 100 year", "Invalid birthday date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Verify())
            {
                pictureBoxStudentImage.Image.Save(picture, pictureBoxStudentImage.Image.RawFormat);

                if (student.updateStudent(id,fname, lname, bdate, phone, gender, address, picture))
                {
                    MessageBox.Show("Student information updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void buttonRemoveStudent_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);

            if (MessageBox.Show("Are you sure you want to delete this student", "Delete student",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if(student.deleteStudent(id))
                {
                    MessageBox.Show("Student deleted", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxID.Text = "";
                    textBoxFname.Text = "";
                    textBoxLName.Text = "";
                    textBoxAddress.Text = "";
                    textBoxPhone.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    pictureBoxStudentImage.Image = null;
                }
                else
                {
                    MessageBox.Show("Student not deleted", "Delete student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text);
            MySqlCommand command = new MySqlCommand("SELECT `id`,`first_name`,`last_name`,`birthdate`,`gender`,`phone`,`address`,`picture` FROM `student` WHERE `id`=" + id);

            DataTable table = student.getStudents(command);
            if(table.Rows.Count> 0)
            {
                textBoxFname.Text = table.Rows[0]["first_name"].ToString();
                textBoxLName.Text = table.Rows[0]["last_name"].ToString();
                textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                textBoxAddress.Text = table.Rows[0]["address"].ToString();
                dateTimePicker1.Value = (DateTime)table.Rows[0]["birthdate"];

                if (table.Rows[0]["gender"].ToString()=="Female")
                {
                    radioButtonFemale.Checked = true;
                }
                else
                {
                    radioButtonMale.Checked = true;
                }
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream p = new MemoryStream(pic);
                pictureBoxStudentImage.Image = Image.FromStream(p);
            }
        
        
        }
    }
}
