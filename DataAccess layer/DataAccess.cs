using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_managemenet_System.Business_logic_layer;

namespace Hospital_managemenet_System.DataAccess_layer
{
  public  class DataAccess
    {
        SqlConnection con;
        public DataAccess()
        {
            con = new SqlConnection(@"Data Source=AYSH-STAR;Initial Catalog=HMS;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }



        public int CreateAccountrecep(User u)
        {
            int i = 0;
            string query = "INSERT INTO RecepLogin(Name,Password,Email,Phone,Address,Gender,AssignDate) VALUES ('"+u.UserName+"','"+u.Password+"','"+u.Email+"','"+u.PhoneNumber+"','"+u.Address+"','"+u.Gender+"','"+DateTime.Now+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            //con.Close();
            return i;

        }

        public int CreateAccounstuff(User u)
        {
            int i = 0;
            string query = "INSERT INTO Stuff(Name,Phone,Address,Catagory,Gender,AssignDate) VALUES ('" + u.UserName + "','" + u.PhoneNumber + "','" + u.Address + "','" + u.Catagory + "','" + u.Gender + "','" + DateTime.Now + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            //con.Close();
            return i;

        }

        public int CreateAccountdoc(User u)
        {
            int i = 0;
            string query = "INSERT INTO DoctorLogin(Name,Password,Email,Phone,Catagory,Gender,AssignDate,Status,TP) VALUES ('" + u.UserName + "','" + u.Password + "','" + u.Email + "','" + u.PhoneNumber + "','" + u.Catagory + "','" + u.Gender + "','" + DateTime.Now + "','Active','0')";
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            //con.Close();
            return i;

        }

        public DataTable Resepuid(User u)
        {
            string query = string.Format("SELECT  Id FROM RecepLogin where  Name='" + u.UserName + "' and Phone='" + u.PhoneNumber + "' and Address= '" + u.Address + "' and Email='" + u.Email + "' and Gender='" + u.Gender + "' and Password='" + u.Password + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public DataTable LoginA(User e)
        {
            string query = string.Format("Select * from AdminLogin where Id= '" + e.UserId + "' and Password='" + e.Password + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable LoginD(User e)
        {
            string query = string.Format("Select * from DoctorLogin where Id= '" + e.UserId + "' and Password='" + e.Password + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable LoginR(User e)
        {
            string query = string.Format("Select * from RecepLogin where Id= '" + e.UserId + "' and Password='" + e.Password + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable Drid(User u)
        {
            string query = string.Format("SELECT  Id FROM DoctorLogin where  Name='" + u.UserName + "' and Phone='" + u.PhoneNumber + "' and Catagory= '" + u.Catagory + "' and Email='" + u.Email + "' and Gender='" + u.Gender + "' and Password='" + u.Password + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }


        public DataTable Drdetailsall(User u)
        {
            string query = string.Format("Select * from DoctorLogin where Status='Active'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }


        public int Drupdate(User u)
        {
            int i = 0;
            string query = String.Format("UPDATE DoctorLogin SET Password='" + u.Password + "',Phone='" + u.PhoneNumber + "',Email='" + u.Email + "',Name='" + u.UserName + "',Catagory='" + u.Catagory + "',Gender='" + u.Gender + "',Status='" + u.Status + "',Star='" + u.Star + "' WHERE Id='" + u.UserId + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }

        public int Drrelease(User u)
        {
            int i = 0;
            string query = String.Format("Delete from DoctorLogin where Id='" + u.UserId + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }



        public DataTable Staffdetailsall(User u)
        {
            string query = string.Format("Select * from Stuff ");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }


        public int Staffupdate(User u)
        {
            int i = 0;
            string query = String.Format("UPDATE Stuff SET Name='" + u.UserName + "',Catagory='" + u.Catagory + "',Gender='" + u.Gender + "',Address='" + u.Address + "' WHERE Phone='" + u.PhoneNumber + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }

        public int Staffdelete(User u)
        {
            int i = 0;
            string query = String.Format("Delete from Stuff where Phone='" + u.PhoneNumber +"'");
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }

        public int Createpatient(Patient u)
        {
            int i = 0;
            string query = "INSERT INTO Patient(Id,Name,Phone,Age,Drid,Drfees,DateTime) VALUES ('" + u.UserId + "','" + u.UserName + "','" + u.PhoneNumber + "','" + u.Age + "','" + u.Drid + "','" + u.Drfees + "','" + DateTime.Now + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            //con.Close();
            return i;

        }

        public DataTable Patientdetails(Patient u)
        {
            string query = string.Format("Select * from Patient ");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public DataTable DrTP(User u)
        {
            string query = string.Format("SELECT  TP FROM DoctorLogin where  Id='" + u.drid + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public int TPupdate(User u)
        {
            int i = 0;
            string query = String.Format("UPDATE DoctorLogin SET TP='" + u.tp + "' WHERE Id='" + u.drid + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }

        public int patientReg(Patient u)
        {
            int i = 0;
            string query = "INSERT INTO PatientReg(Id,Name,Phone,Age,Room,Gender,DateTime) VALUES ('" + u.UserId + "','" + u.UserName + "','" + u.PhoneNumber + "','" + u.Age + "','" + u.Room + "','" + u.gender + "','" + DateTime.Now + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            //con.Close();
            return i;

        }
        public DataTable Patientinfo(Patient u)
        {
            string query = string.Format("Select * from PatientReg ");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public int Patientdelete(Patient u)
        {
            int i = 0;
            string query = String.Format("Delete from PatientReg where Id='" + u.UserId + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }

        public DataTable DrAppointment(Patient u)
        {
            string query = string.Format("SELECT  * FROM Patient where  Drid='" + u.Drid + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public int Dractive(User u)
        {
            int i = 0;
            string query = String.Format("UPDATE DoctorLogin SET Status='Active' where Id='{0}'", u.UserId);
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }

        public int Drinactive(User u)
        {
            int i = 0;
            string query = String.Format("UPDATE DoctorLogin SET Status='Inactive' where Id='{0}'", u.UserId);
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }

        public DataTable Drfetch(User u)
        {
            string query = string.Format("Select * from DoctorLogin where Id='{0}'", u.UserId);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }


        //public int Drstar(User u)
        //{
        //    int i = 0;
        //    string query = String.Format("UPDATE DoctorLogin SET Star='"+u.Star+"' where Id='{0}'", u.UserId);
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    i = cmd.ExecuteNonQuery();
        //    return i;
        //}




    }
}
