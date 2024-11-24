using MySql.Data.MySqlClient;
using System.Globalization;
using System.IO;
namespace Projekat
{
    public partial class PrintStudentsForm : Form
    {
        public PrintStudentsForm()
        {
            InitializeComponent();
        }
        Student student = new Student();
        private void PrintStudentsForm_Load(object sender, EventArgs e)
        {
            fillGrid(new MySqlCommand("SELECT * from `student`"));
            if (radioButtonNo.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        public void fillGrid(MySqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn col = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            col = (DataGridViewImageColumn)dataGridView1.Columns[7];
            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            string query;
            if (radioButtonYes.Checked)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                if (radioButtonMale.Checked)
                {
                    query = "SELECT * from `student` WHERE `birthdate` BETWEEN '" + date1 + "' AND '" + date2 + "'AND gender='Male'";
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT * from `student` WHERE `birthdate` BETWEEN '" + date1 + "' AND '" + date2 + "' AND gender='Female'";
                }
                else
                {
                    query = "SELECT * from `student` WHERE `birthdate` BETWEEN '" + date1 + "' AND '" + date2 + "'";
                }
                command = new MySqlCommand(query);
                fillGrid(command);
            }
            else
            {
                if (radioButtonMale.Checked)
                {
                    query = "SELECT * from `student` WHERE gender='Male'";
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT * from `student` WHERE  gender='Female'";
                }
                else
                {
                    query = "SELECT * from `student`";
                }
                command = new MySqlCommand(query);
                fillGrid(command);
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\students_list.txt";
            using(var writer = new StreamWriter(path))
            {
                if(!File.Exists(path))
                {
                    File.Create(path);
                }
                DateTime date;
                for(int i =0;i<dataGridView1.Rows.Count;i++)
                {
                    for(int j=0;j<dataGridView1.Columns.Count-1;j++) {

                        if (j == 3)
                        {
                            date = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            writer.Write("\t" + date.ToString("yyyy-MM-dd") + "\t" + "|");

                        }
                        else if(j==dataGridView1.Columns.Count-2)
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                    }
                    writer.WriteLine("");
                    writer.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------");
                }
            
                writer.Close();
                MessageBox.Show("Data exported");
            }
        }
    }
}
