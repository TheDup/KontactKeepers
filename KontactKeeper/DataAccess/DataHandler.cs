using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlTypes;

namespace DataAccess
{
    public class DataHandler
    {
        SqlConnection conn;
        public DataHandler()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString);
        }
        public DataTable Read(string table)
        {
            DataTable dt = new DataTable();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = string.Format("SELECT * FROM {0}", table);
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dt;
        }
        /////////////////////////////////////////////////////////////////////////FBUSER///////////////////////////
        public void AddFBUser(string fbid, string name, SqlDateTime lastseen)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = string.Format("INSERT INTO tblFBUser (FBID, FBName, LastSeen) VALUES ('{0}','{1}','{2}')", fbid, name, lastseen);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void DeleteFBUser(string id)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = string.Format("delete from tblFBUser where FBID = {0}", id);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        /////////////////////////////////////////////////////////////////////////WAUSER///////////////////////////
        public void AddWAUser(string phone, SqlDateTime lastseen)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = string.Format("INSERT INTO tblWAUser (Phone, LastSeen) VALUES ('{0}','{1}')", phone, lastseen);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void DeleteWAUser(string phone)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = string.Format("delete from tblWAUser where Phone = {0}", phone);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        /////////////////////////////////////////////////////////////////////////ADMIN///////////////////////////
        public void AddAdmin(string fname, string lname, string uname, string password)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = string.Format("INSERT INTO tblAdmin (FName, LName, UName, Password) VALUES ('{0}','{1}','{2}','{3}')", fname, lname, uname, password);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void DeleteAdmin(string id)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = string.Format("delete from tblAdmin where ID = {0}", id);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        /////////////////////////////////////////////////////////////////////////ENDUSER///////////////////////////
        public void AddEndUser(string fname, string lname, string uname, string password, string cellnumber, bool waverified, string email, bool emailverified, string fbid, bool fbverified)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = string.Format("INSERT INTO tblEndUser (FName, LName, UName, Password, Cellnumber, WAVerified, Email, EmailVerified, FBID, FBVerified) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", fname, lname, uname, password, cellnumber, waverified.ToString(), email, emailverified.ToString(), fbid, fbverified.ToString());
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void DeleteEndUser(string id)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = string.Format("delete from tblEndUser where ID = {0}", id);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        /////////////////////////////////////////////////////////////////////////CALLAGENT///////////////////////////
        public void AddCallAgent(string fname, string lname, string uname, string password, int totalhours, string agentext, string avgcalllength, int totalcalls, int performancescore)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = string.Format("INSERT INTO tblCallAgent (FName, LName, UName, Password, TotalHours, AgentEXT, AVGCallLength, TotalCalls, Performance) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", fname, lname, uname, password, totalhours.ToString(), agentext, avgcalllength, totalcalls.ToString(), performancescore.ToString());
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public void DeleteCallAgent(string id)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = string.Format("delete from tblCallAgent where ID = {0}", id);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }

}
