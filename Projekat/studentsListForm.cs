using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Projekat
{
    public partial class studentsListForm : Form
    {
        public studentsListForm()
        {
            InitializeComponent();
        }

        Student student = new Student();
        private void studentsListForm_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * from `student`");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn column = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            column = (DataGridViewImageColumn)dataGridView1.Columns[7];
            column.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm forma = new UpdateDeleteStudentForm();
            forma.textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            forma.textBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            forma.textBoxLName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            forma.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                forma.radioButtonFemale.Checked = true;
            }
            forma.textBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            forma.textBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] slika;
            slika = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream p = new MemoryStream(slika);
            forma.pictureBoxStudentImage.Image = Image.FromStream(p);
            forma.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * from `student`");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn column = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            column = (DataGridViewImageColumn)dataGridView1.Columns[7];
            column.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
