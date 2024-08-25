using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication1
{
    public class datacode : databased
    {
    string query = "Data Source=.;Initial Catalog=AA;Integrated Security=True;Encrypt=False";

        public bool datareder(string us, string pass)
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=AA;Integrated Security=True;Encrypt=False");
            SqlCommand command = new SqlCommand("select *from up where us=@us and pass=@pass", connection);
            command.Parameters.AddWithValue("@us", us);
            command.Parameters.AddWithValue("@pass", pass);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

        public bool dataRow()
        {
            SqlConnection sql = new SqlConnection(query);
            SqlCommand command = new SqlCommand("select *from news2", sql);
            sql.Open();
            SqlDataReader reader = command.ExecuteReader();
            sql.Close();
            return true;
        }

        public bool delet(int id)
        {
            SqlConnection connection = new SqlConnection(query);
            try
            {
                string query = "delete from news2 where id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }


        }



        public bool Insert( int id,string onvan, string matn)
        {
            string cmd = "insert into news2(id,onvan,matn) values(@id,@onvan,@matn)";
            SqlConnection connection = new SqlConnection(query);
            SqlCommand Command = new SqlCommand(cmd, connection);
            Command.Parameters.AddWithValue("@id", id);
            Command.Parameters.AddWithValue("@onvan", onvan);
            Command.Parameters.AddWithValue("@matn", matn);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        public DataTable show()
        {
            SqlConnection c = new SqlConnection(query);
            SqlDataAdapter adapter = new SqlDataAdapter("select *from news2", c);
            DataTable data = new DataTable();
            c.Open();
            adapter.Fill(data);
            c.Close();
            return data;
        }

        public bool update(int id, string onvan, string matn)
        {
            SqlConnection connection = new SqlConnection(query);
            try
            {
                string query = "update news2 set onvan=@onvan,matn=@matn where id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@onvan", onvan);
                command.Parameters.AddWithValue("@matn", matn);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        SqlConnection Connection = new SqlConnection("Data Source=.;Initial Catalog=AA;Integrated Security=True;Encrypt=False");
        public DataTable showmail()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("select *from mail", Connection);
            DataTable data = new DataTable();
            Connection.Open();
            sqlData.Fill(data);
            Connection.Close();
            return data;
        }
        public bool insertproduct(int id, string name, string gimat, string imag)
        {
            SqlCommand command = new SqlCommand("insert into mahsol(id,nam,gimat,image) values(@id,@nam,@gimat,@image) ", Connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@nam", name);
            command.Parameters.AddWithValue("@gimat", gimat);
            command.Parameters.AddWithValue("@image", imag);
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
            return true;
        }
        public DataTable showproduct()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("select *from mahsol", Connection);
            DataTable data = new DataTable();
            Connection.Open();
            sqlData.Fill(data);
            Connection.Close();
            return data;
        }
        public bool updatepro(int id, string name, string gimat, string imag)
        {
            SqlConnection connection = new SqlConnection(query);
            try
            {
                string query = "update mahsol set nam=@nam,gimat=@gimat,image=@im where id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nam", name);
                command.Parameters.AddWithValue("@gimat", gimat);
                command.Parameters.AddWithValue("@im", imag);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool deletpro(int id)
        {
            SqlConnection connection = new SqlConnection(query);
            try
            {
                string query = "delete from mahsol where id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }


        }

    }

 
}

namespace fp
{
  class datacode
    {
        SqlConnection Connection = new SqlConnection("Data Source=.;Initial Catalog=AA;Integrated Security=True;Encrypt=False");
        public bool insertmail(string name, string fname, string ph, string mes)
        {
            SqlCommand command = new SqlCommand("insert into mail(nam,ln,ph,matn) values(@name,@fname,@ph,@mes)", Connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@fname", fname);
            command.Parameters.AddWithValue("@ph", ph);
            command.Parameters.AddWithValue("@mes", mes);
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
            return true;
        }
        public bool insertproduct(int id, string name, string gimat, float vazn, string price, string imag)
        {
            SqlCommand command = new SqlCommand("insert into mahsol(nam,gimat,image) values("+"N"+"@nam,@gimat,@image) ", Connection);
 
            command.Parameters.AddWithValue("@nam", name);
            command.Parameters.AddWithValue("@gimat", gimat);
            command.Parameters.AddWithValue("@image", imag);
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
            return true;
        }
        public DataTable show()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("select *from mahsol", Connection);
            DataTable data = new DataTable();
             Connection.Open();
            sqlData.Fill(data);
            Connection.Close();
            return data;
        }
    }
}

