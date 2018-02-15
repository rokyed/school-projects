using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SQLDataSimplifier
{
    class SqlDataConnector
    {
        private string server="";
        private string user="";
        private string password="";
        private string dataBase = "";
        private bool trustedConnection = false;
        public string compiledSqlConnection = "";
        public string error = "";
        public string command_out = "";

        public SqlDataConnector(string Server_Address,string Data_base)
        {
            trustedConnection = true;
            server = Server_Address;
            dataBase = Data_base;
            CompileConnection();


        }
        public SqlDataConnector(string Server_Address, string Data_base, string User_Name,string Password)
        {
            trustedConnection = false;
            server = Server_Address;
            dataBase = Data_base;
            user = User_Name;
            password = Password;
            CompileConnection();


        }
        private void CompileConnection()
        {
            if (trustedConnection)
            {
                compiledSqlConnection += "Server=" + server + ";";
                compiledSqlConnection += "Database=" + dataBase + ";";
                compiledSqlConnection += "Trusted_Connection = True;" ;
            }
            else
            {
                compiledSqlConnection += "Server=" + server + ";";
                compiledSqlConnection += "Database=" + dataBase + ";";
                compiledSqlConnection += "User Id=" + user + ";";
                compiledSqlConnection += "Password=" + password + ";";
            }
        }

        public DataSet GetDataQuery(string command)
        {
            ClearError();
            // create dataset to return
            DataSet ds = new DataSet();
            // create new connection
            SqlConnection sc = new System.Data.SqlClient.SqlConnection(compiledSqlConnection);
            using (sc)
            {
                // open connection
                sc.Open();
                // create sql data adapter with command
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command, sc);
                // build command
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                try
                {

                    dataAdapter.Fill(ds);
                }
                catch (Exception e)
                {
                    error = e.ToString();
                }
                commandBuilder.Dispose();
                dataAdapter.Dispose();
                

                sc.Close();

            }
            command_out = command;
            return ds;
        }
        public DataSet GetDataQuery(string commandBegin, SQLVarContainer[] variables/* make shure variables are in order*/, string commandEnd)
        {
            ClearError();
            DataSet ds = new DataSet();
          // build command
            string sqlCommand = "";
            // add command prefix
            sqlCommand += commandBegin+" ";
            // add command variables
            for (int i = 0; i < variables.Length; i++)
            {
                
                if (i < variables.Length - 1)
                {
                    // if is not the last variable add comma
                    sqlCommand += variables[i].variableName;
                    sqlCommand += ",";
                }
                else
                {
                    // if  the last variable don't add comma
                    sqlCommand += variables[i].variableName;
                }
            }
            sqlCommand += " "+commandEnd;
            // make connection with compiled connection
            SqlConnection sc = new System.Data.SqlClient.SqlConnection(compiledSqlConnection);

           
            using (sc)
            {
                sc.Open();
                // create command
                SqlCommand scom = new SqlCommand(sqlCommand, sc);
                using (scom)
                {
                    // add  varaible types
                    for (int i = 0; i < variables.Length; i++)
                    {
                        // add parameter
                        scom.Parameters.Add(variables[i].variableName, variables[i].type);
                        // set value
                        scom.Parameters[variables[i].variableName].Value = variables[i].value;
                    }
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(scom);
                    try
                    {
                        dataAdapter.Fill(ds);
                    }
                    catch (Exception e)
                    {
                        error = e.ToString();
                    }
                    

                }
                scom.Dispose();
                sc.Close();
               
            }
            command_out = sqlCommand;
            return ds;
        }

        public DataSet GetDataQuery(string commandBegin, SQLVarContainer variable, string commandEnd)
        {
            ClearError();
            DataSet ds = new DataSet();
            // build command
            string sqlCommand = "";
            // add command prefix
            sqlCommand += commandBegin + " ";
            // add command variables
           
                    // if  the last variable don't add comma
                    sqlCommand += variable.variableName;
            
            sqlCommand += " " + commandEnd;
            // make connection with compiled connection
            SqlConnection sc = new System.Data.SqlClient.SqlConnection(compiledSqlConnection);


            using (sc)
            {
                sc.Open();
                // create command
                SqlCommand scom = new SqlCommand(sqlCommand, sc);
                using (scom)
                {
                    // add  varaible types
                  
                        scom.Parameters.Add(variable.variableName, variable.type);
                        // set value
                        scom.Parameters[variable.variableName].Value = variable.value;
                    
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(scom);
                    try
                    {
                        dataAdapter.Fill(ds);
                    }
                    catch (Exception e)
                    {
                        error = e.ToString();
                    }


                }
                scom.Dispose();
                sc.Close();

            }
            command_out = sqlCommand;
            return ds;
        }
        
       
        public void SetDataQuery(string command)
        {
            ClearError();
            //create connection
             SqlConnection sc = new System.Data.SqlClient.SqlConnection(compiledSqlConnection);
            using (sc)
            {

                sc.Open();
                // create command
                SqlCommand scom = new SqlCommand(command, sc);
                using (scom)
                {
                    //execute command
                    scom.ExecuteNonQuery();
                }
                scom.Dispose();
                sc.Close();
               
            }
            command_out = command;
        
        }


        public void SetDataQuery(string commandBegin, SQLVarContainer[] variables/* make shure variables are in order*/, string commandEnd)
        {
            ClearError();
            // build command
            string sqlCommand = "";
            // add command prefix
            sqlCommand += commandBegin + " ";
            // add command variables
            for (int i = 0; i < variables.Length; i++)
            {

                if (i < variables.Length - 1)
                {
                    // if is not the last variable add comma
                    sqlCommand += variables[i].variableName;
                    sqlCommand += ",";
                }
                else
                {
                    // if  the last variable don't add comma
                    sqlCommand += variables[i].variableName;
                }
            }
            sqlCommand += " " + commandEnd;
            // make connection with compiled connection
            SqlConnection sc = new System.Data.SqlClient.SqlConnection(compiledSqlConnection);

           
            using (sc)
            {
                sc.Open();
                // create command
                SqlCommand scom = new SqlCommand(sqlCommand, sc);
                using (scom)
                {
                    // add  varaible types
                    for (int i = 0; i < variables.Length; i++)
                    {
                        // add parameter
                        scom.Parameters.Add(variables[i].variableName, variables[i].type);
                        // set value
                        scom.Parameters[variables[i].variableName].Value = variables[i].value;
                    }


                    scom.ExecuteNonQuery();
                }
                scom.Dispose();
                sc.Close();
               
            }
            command_out = sqlCommand;
        
        }
         
    
     public void SetDataQuery(string commandBegin,SQLVarContainer variable, string commandEnd)
        {
            ClearError();
            // build command
            string sqlCommand = "";
            // add command prefix
            sqlCommand += commandBegin + " ";
            // add command variables
          
           
                    sqlCommand += variable.variableName;
           
            sqlCommand += " " + commandEnd;
            // make connection with compiled connection
            SqlConnection sc = new System.Data.SqlClient.SqlConnection(compiledSqlConnection);

           
            using (sc)
            {
                sc.Open();
                // create command
                SqlCommand scom = new SqlCommand(sqlCommand, sc);
                using (scom)
                {
                    // add  varaible types
                   
                        scom.Parameters.Add(variable.variableName, variable.type);
                        // set value
                        scom.Parameters[variable.variableName].Value = variable.value;
                    


                    scom.ExecuteNonQuery();
                }
                scom.Dispose();
                sc.Close();
               
            }
            command_out = sqlCommand;
        
        }
     public void ClearError()
     {
         error = "";
         command_out = "";
     }
    }

    class SQLVarContainer
    {
        
        public SqlDbType type;
        public string variableName;
        public string value;

        public SQLVarContainer(SqlDbType Type, string Name, string Value)
        {
            type = Type;
            variableName = Name;
            value = Value;
        }
       


    }
}
