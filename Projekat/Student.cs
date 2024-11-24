using System.Data;
using MySql.Data.MySqlClient;

namespace Projekat
{
    public class Student
    {
        Baza baza = new Baza();

        public bool insertStudent(string fname,string lname,DateTime bdate,string phone,string gender, string address,MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`first_name`, `last_name`, `birthdate`, `gender`, `phone`, `address`, `picture`) VALUES (@fn,@ln,@bdt,@gdr,@phn,@adrs,@pic)", baza.getConnection);

            //@fn,@ln,@bdt,@gdr,@phn,@adrs,@pic
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value=fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs",MySqlDbType.Text).Value = address;
            command.Parameters.Add("@pic", MySqlDbType.LongBlob).Value = picture.ToArray();

            baza.openConnection();
            if(command.ExecuteNonQuery() ==1)
            {
                baza.closeConnection();
                return true;
            }
            else
            {
                baza.closeConnection();
                return false;
            }
           
        }
        public DataTable getStudents(MySqlCommand command)
        {
            command.Connection = baza.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
            
        public bool updateStudent(int id, string fname, string lname, DateTime bdate, string phone, string gender, string address, MemoryStream picture)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET `first_name`=@fn, `last_name`=@ln, `birthdate`=@bdt,`gender`=@gdr,`phone`=@phn,`address`=@adrs,`picture`=@pic WHERE `id`=@ID", baza.getConnection);

            //@fn,@ln,@bdt,@gdr,@phn,@adrs,@pic
            command.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", MySqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gdr", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@pic", MySqlDbType.LongBlob).Value = picture.ToArray();

            baza.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                baza.closeConnection();
                return true;
            }
            else
            {
                baza.closeConnection();
                return false;
            }

         }
        
        public bool deleteStudent(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `student` WHERE `id`=@studentID", baza.getConnection);
            command.Parameters.Add("@studentID", MySqlDbType.Int32).Value = id;
            baza.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                baza.closeConnection();
                return true;
            }
            else
            {
                baza.closeConnection();
                return false;
            }
        }
        public string execCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query,baza.getConnection);
            baza.openConnection();
            string count = command.ExecuteScalar().ToString();
            baza.closeConnection();
            return count;
        }
        
        public string totalStudent()
        {
            return execCount("SELECT COUNT(*) FROM `student`");

        }
        public string totalMaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM `student` WHERE `gender` = 'Male'");
        }
        public string totalFemaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM `student` WHERE `gender` = 'Female'");
        }
    }
}
