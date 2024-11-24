using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }

        Color total;
        Color male;
        Color female;

        private void StaticsForm_Load(object sender, EventArgs e)
        {
            total = panelTotal.BackColor; male = panelMale.BackColor;
            female = panelFemale.BackColor;
            Student student = new Student();
            double totalStudents = Convert.ToDouble(student.totalStudent());
            double totalMaleStudents = Convert.ToDouble(student.totalMaleStudent());
            double totalFemaleStudents = Convert.ToDouble(student.totalFemaleStudent());

            double malePercentage = (totalMaleStudents * 100) / totalStudents;
            double femalePercentage = (totalFemaleStudents * 100) / totalStudents;

            labelTotal.Text = "Total students: " + totalStudents;
            labelM.Text = "Male: " + malePercentage.ToString("0.00")+"%";
            labelFemale.Text = "Female: " + femalePercentage.ToString("0.00")+"%";
        }

        private void StaticsForm_MouseEnter(object sender, EventArgs e)
        {

        }

        private void labelTotal_MouseEnter(object sender, EventArgs e)
        {
            panelTotal.BackColor = Color.White;
            labelTotal.ForeColor = total;
        }

        private void labelTotal_MouseLeave(object sender, EventArgs e)
        {
            panelTotal.BackColor = total;
            labelTotal.ForeColor = Color.White;
        }

        private void labelM_MouseEnter(object sender, EventArgs e)
        {

        }

        private void labelM_MouseLeave(object sender, EventArgs e)
        {

        }

        private void labelFemale_MouseEnter(object sender, EventArgs e)
        {

        }

        private void labelFemale_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
