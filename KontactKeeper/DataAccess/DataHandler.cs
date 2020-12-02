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
            conn = new SqlConnection("Data Source=JAMESPC;Initial Catalog=Kontactkeeper;Integrated Security=True");
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
        public void AddFBUser(string fbid, string name, SqlDateTime lastseen, string lastsent)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = string.Format("INSERT INTO tblFBUser (FBID, FBName, LastSeen, LastSent) VALUES ('{0}','{1}','{2}', '{3}')", fbid, name, lastseen, lastsent);
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

        public DataTable SearchFBUser(string fbid = null, string name = null)
        {
            string query = "";
            if (fbid != null & name == null)
                query = string.Format("SELECT * FROM tblFBUser WHERE FBID='{0}'", fbid);
            if (fbid == null & name != null)
                query = string.Format("SELECT * FROM tblFBUser WHERE FBName='{0}''", name);
            DataTable dt = new DataTable();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
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
        public void AddWAUser(string phone, string lastseen, string lastsent)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = string.Format("INSERT INTO tblWAUser (Phone, LastSeen, LastSent) VALUES ('{0}','{1}','{2}')", phone, lastseen, lastsent);
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

        public DataTable SearchWAUser(string phone=null)
        {
            string query = "";
            if (phone != null)
                query = string.Format("SELECT * FROM tblWAUser where Phone='{0}'", phone);
            DataTable dt = new DataTable();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
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
        //////////////////////////////////////////////////////EmailUser/////////////////////////////////////////
        public void AddEmailUser(string email, string lastseen, string lastsent)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = string.Format("INSERT INTO tblEmailUser(Email, LastSeen, LastSent) VALUES ('{0}','{1}','{2})", email, lastseen, lastsent);
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

        public DataTable SearchEmailUser(string email = null)
{
    string query = "";
    if (email != null)
        query = string.Format("SELECT * FROM tblEmailUser where Email='{0}'", email);
    DataTable dt = new DataTable();
    try
    {
        if (conn.State != ConnectionState.Open)
        {
            conn.Open();
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

public void DeleteEmailUser(string email)
{
    try
    {
        if (conn.State != ConnectionState.Open)
        {
            conn.Open();
            string query = string.Format("delete from tblEmailUser where Email = {0}", email);
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

        public DataTable SearchAdmin(string fname=null, string lname = null, string uname = null)
        {
            string query="";
            if (fname != null & lname == null & uname == null)
                query = string.Format("SELECT * FROM tblAdmin WHERE FName='{0}'", fname);
            if (fname == null & lname != null & uname == null)
                query = string.Format("SELECT * FROM tblAdmin WHERE LName='{0}'", lname);
            if (fname == null & lname == null & uname != null)
                query = string.Format("SELECT * FROM tblAdmin WHERE UName='{0}'", uname);
            DataTable dt = new DataTable();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
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
        public void AddEndUser(string fname, string lname, string uname, string password, string cellnumber, string email,  string fbid)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    string query = string.Format("INSERT INTO tblEndUser (FName, LName, UName, Password, Cellnumber, Email, FBID) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", fname, lname, uname, password, cellnumber, email, fbid);
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

        public DataTable SearchEndUser(string fbid=null, string fname=null, string lname = null, string uname = null, string cellnumber = null, string email = null)
        {
            string query = "";
            if (fbid == null & fname == null & lname == null & uname != null & cellnumber == null & email == null)
                query = string.Format("SELECT * FROM tblEndUser WHERE UName='{0}'", uname);
            if (fbid == null & fname == null & lname != null & uname == null & cellnumber == null & email == null)
                query = string.Format("SELECT * FROM tblEndUser WHERE LName='{0}'", lname);
            if (fbid == null & fname != null & lname == null & uname == null & cellnumber == null & email == null)
                query = string.Format("SELECT * FROM tblEndUser WHERE FName='{0}'", fname);
            if (fbid == null & fname == null & lname == null & uname == null & cellnumber != null & email == null)
                query = string.Format("SELECT * FROM tblEndUser WHERE Cellnumber='{0}'", cellnumber);
            if (fbid == null & fname == null & lname == null & uname == null & cellnumber == null & email != null)
                query = string.Format("SELECT * FROM tblEndUser WHERE Email='{0}'", email);
            if (fbid != null & fname == null & lname == null & uname == null & cellnumber == null & email == null)
                query = string.Format("SELECT * FROM tblEndUser WHERE FBID='{0}'", fbid);
            DataTable dt = new DataTable();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
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

        public DataTable SearchCallAgent(string fname=null, string lname = null, string uname = null, int totalHours = 0, int totalCalls = 0)
        {
            string query = "";
            if (fname != null & lname == null & uname != null & totalCalls == 0 & totalHours == 0)
                query = string.Format("SELECT * FROM tblCallAgent WHERE FName='{0}'", fname);
            if (fname == null & lname != null & uname == null & totalCalls == 0 & totalHours == 0)
                query = string.Format("SELECT * FROM tblCallAgent WHERE LName='{0}'", lname);
            if (fname == null & lname == null & uname != null & totalCalls == 0 & totalHours == 0)
                query = string.Format("SELECT * FROM tblCallAgent WHERE UName='{0}'", uname);
            if (fname == null & lname == null & uname == null & totalCalls == 0 & totalHours != 0)
                query = string.Format("SELECT * FROM tblCallAgent WHERE TotalHours='{0}'", totalHours);
            if (fname == null & lname == null & uname == null & totalCalls != 0 & totalHours == 0)
                query = string.Format("SELECT * FROM tblCallAgent WHERE TotalCalls='{0}'", totalCalls);
            DataTable dt = new DataTable();
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
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
