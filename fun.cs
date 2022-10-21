    ystem.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace hospital_mangement_system
{
    internal class fun
    {
        protected SqlConnection getConnection()// bulding connection
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-JOHQ61G;Initial Catalog=Hotel;Integrated Security=True");
            
            return conn;
        }
        public DataSet getdata(string querry)// get data from database
        {
            //try
            //{
                SqlConnection con = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = querry;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand = cmd;
                DataSet s = new DataSet();
                adapter.AcceptChangesDuringFill = true;
                DataTable d = new DataTable();
                adapter.Fill(s);

             return s;
            
            //catch(   SqlException e)
            //{
              //  MessageBox.Show("error");
            //}
               // SqlException e = new SqlException();
                 //   return e;
            
            
            
            

        }
        public void setData(string q,string message)//insert ,delete ,update
        {
            SqlConnection con= getConnection();   
            SqlCommand cmd=new SqlCommand();
            cmd.Connection = con;
            con.Open();
            
                cmd.CommandText = q;//"insert into table @id,"
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("  '" + q + " '", "sucsess", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
           
            

            }
        public SqlDataReader getforcombo(string query)
        {
            SqlConnection connection = getConnection();
            SqlCommand cmd=new SqlCommand();
            cmd.Connection = connection;
            cmd=new  SqlCommand(query,connection);
            SqlDataReader sdr=cmd.ExecuteReader();
            return sdr;
        }
        
         }
    }

p