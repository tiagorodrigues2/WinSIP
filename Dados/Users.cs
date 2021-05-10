using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSIP.Dados
{

    public struct User_t
    {
        public string username;
        public string password;
        public bool IsAdmin;
        public int UserID;

        public User_t(int id, string u, string p, bool admin)
        {
            username = u;
            password = p;
            IsAdmin = admin;
            UserID = id;
        }
    }

    public struct CheckUserReturn_t
    {
        public bool Success;
        public User_t user;
        public bool ForceChangePassword;
    }

    class Users
    {
        private MySqlConnection Conexao;

        internal Users()
        {
            Conexao = AcessoBD.Connection;
        }

        internal DataSet LerUsers()
        {
            MySqlDataAdapter da;
            DataSet ds;
            MySqlCommand cmd;

            cmd = new MySqlCommand("select * from users", Conexao);
            cmd.CommandType = CommandType.Text;

            da = new MySqlDataAdapter(cmd);
            ds = new DataSet();

            da.Fill(ds, "tabela");
            return ds;
        }

        internal bool CheckPassword( User_t user, string password )
        {
            CheckUserReturn_t Check = CheckUser( user.username, password );

            return Check.Success;
        }

        /// <summary>
        /// Muda a palavra-passe do utilizador
        /// </summary>
        /// <param name="user">Utilizador</param>
        /// <param name="password">Nova Palavra-passe</param>
        /// <returns>Resultado</returns>
        internal bool ChangePassword( int UserID, string password )
        {
            bool ret = false;

            try
            {
                string sql = @"
                
                    update users
                    set password = @Pass
                    where UserID = @ID";

                MySqlCommand cmd = new MySqlCommand( sql, Conexao );
                cmd.Parameters.Add( "Pass", MySqlDbType.VarChar ).Value = CreateMD5( password );
                cmd.Parameters.Add( "ID", MySqlDbType.Int32 ).Value = UserID;
                cmd.CommandType = CommandType.Text;

                if ( Conexao.State != ConnectionState.Open ) Conexao.Open();

                ret = cmd.ExecuteNonQuery() == 1;
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            Conexao.Close();
            return ret;
        }

        /// <summary>
        /// Retorna um utilizador por ID
        /// </summary>
        /// <param name="ID">ID do Utilizador</param>
        /// <returns>CheckUserReturn_t</returns>
        internal CheckUserReturn_t GetUserByID(int ID)
        {
            CheckUserReturn_t ret = new CheckUserReturn_t();
            
            try
            {
                string sql = @"
            
                    select * from users where UserID = @ID";

                MySqlCommand cmd = new MySqlCommand( sql, Conexao );
                cmd.Parameters.Add( "ID", MySqlDbType.Int32 ).Value = ID;
                cmd.CommandType = CommandType.Text;

                MySqlDataAdapter da = new MySqlDataAdapter( cmd );
                DataSet ds = new DataSet();

                da.Fill( ds, "tabela" );

                ret.Success = ds.Tables[0].Rows.Count == 1;
                ret.ForceChangePassword = int.Parse( ds.Tables[0].Rows[0]["ForceChangePassword"].ToString() ) == 1;
                ret.user.IsAdmin = int.Parse( ds.Tables[0].Rows[0]["IsAdmin"].ToString() ) == 1;
                ret.user.UserID = ID;
                ret.user.username = ds.Tables[0].Rows[0]["username"].ToString();
                ret.user.password = "";
            }
            catch ( Exception ex )
            {
                throw ex;
            }

            return ret;
        }

        /// <summary>
        /// Modifica o valor de "ForceChangePassword" de um utilizador
        /// </summary>
        /// <param name="user">Utilizador (ID)</param>
        /// <param name="value">Novo Valoe</param>
        /// <returns></returns>
        internal bool SetForceChangePassword( int UserID, bool value )
        {
            bool ret = false;

            try
            {
                MySqlCommand cmd = new MySqlCommand( "update users set ForceChangePassword = @Value where UserID = @ID", Conexao );
                cmd.Parameters.Add( "ID", MySqlDbType.Int32 ).Value = UserID;
                cmd.Parameters.Add( "Value", MySqlDbType.Int32 ).Value = value.Int32();

                if ( Conexao.State != ConnectionState.Open ) Conexao.Open();

                ret = cmd.ExecuteNonQuery() == 1;

                Conexao.Close();
            }
            catch ( Exception ex )
            {
                throw ex;
            }

            return ret;
        }

        /// <summary>
        /// Modifica o valor de "IsAdmin" do utilizador
        /// </summary>
        /// <param name="user">utilizador (ID)</param>
        /// <param name="value">Novo Valor</param>
        /// <returns></returns>
        internal bool SetAdmin( int UserID, bool value )
        {
            bool ret = false;

            try
            {
                MySqlCommand cmd = new MySqlCommand( "update users set IsAdmin = @Value where UserID = @ID", Conexao );
                cmd.Parameters.Add( "ID", MySqlDbType.Int32 ).Value = UserID;
                cmd.Parameters.Add( "Value", MySqlDbType.Int32 ).Value = value.Int32();

                if ( Conexao.State != ConnectionState.Open ) Conexao.Open();

                ret = cmd.ExecuteNonQuery() == 1;

                Conexao.Close();
            }
            catch ( Exception ex )
            {
                throw ex;
            }

            return ret;
        }

        /// <summary>
        /// Verifica o Login
        /// </summary>
        /// <param name="user">Nome de Utilizador</param>
        /// <param name="pass">Password</param>
        /// <returns>0 = nao existe; 1 = existe; 2 = admin</returns>
        internal CheckUserReturn_t CheckUser(string user, string pass )
        {
            CheckUserReturn_t ret;
            ret.Success = false;
            ret.ForceChangePassword = false;
            ret.user = new User_t( 0, user, pass, false );

            try
            {
                
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username=@User and password=@Pass", Conexao);
                cmd.Parameters.Add( "User", MySqlDbType.VarChar ).Value = user;
                cmd.Parameters.Add( "Pass", MySqlDbType.VarChar ).Value = CreateMD5( pass );

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);
                Conexao.Close();

                if ( dt.Rows.Count > 0 )
                {
                    ret.Success = true;
                    ret.user.UserID = dt.Rows[0].Field<Int32>( "UserID" );

                    if ( dt.Rows[0].Field<Int32>( "IsAdmin" ) == 1 )
                        ret.user.IsAdmin = true;

                    if ( dt.Rows[0].Field<Int32>( "ForceChangePassword" ) == 1 )
                        ret.ForceChangePassword = true;
                }

            }
            catch ( Exception ex )
            {
                throw ex;
            }

            return ret;
        }


        internal bool UsernameExists(string username)
        {
            bool ret = false;

            try
            {
                string sql = @"
                
                    select UserID from users where username = @Username";

                MySqlCommand cmd = new MySqlCommand( sql, Conexao );

                if ( Conexao.State != ConnectionState.Open ) Conexao.Open();

                MySqlDataAdapter da = new MySqlDataAdapter( cmd );
                DataSet ds = new DataSet();

                da.Fill( ds, "tabela" );

                ret = ds.Tables[0].Rows.Count > 0;

                Conexao.Close();

            }
            catch ( Exception ex )
            {
                throw ex;
            }

            return ret;
        }

        internal bool DeleteUser(int UserID)
        {
            bool ret = false;

            try
            {
                MySqlCommand cmd = new MySqlCommand( "delete from users where UserID = @ID", Conexao );
                cmd.Parameters.Add( "ID", MySqlDbType.Int32 ).Value = UserID;
                cmd.CommandType = CommandType.Text;

                if ( Conexao.State != ConnectionState.Open ) Conexao.Open();

                ret = cmd.ExecuteNonQuery() == 1;

                Conexao.Close();
            }
            catch ( Exception ex )
            {
                throw ex;
            }

            return ret;
        }

        /// <summary>
        /// Regista um utilizador
        /// </summary>
        /// <param name="username">username do utilizador</param>
        /// <param name="password">password do utilizador</param>
        /// <param name="accessCode">codigo de acesso do utilizador</param>
        /// <returns></returns>
        internal User_t RegisterUser( string username, string password, string accessCode )
        {
            User_t ret = new User_t(0, username, password, false );
            MySqlCommand cmd;

            AccessCodes codes = new AccessCodes();

            string sql = @"
                
                insert into users( username, password ) values ( @User, @Pass );
                select LAST_INSERT_ID() as SCOPE_IDENTITY";

            cmd = new MySqlCommand( sql, Conexao );
            cmd.Parameters.Add( "User", MySqlDbType.VarChar ).Value = username;
            cmd.Parameters.Add( "Pass", MySqlDbType.VarChar ).Value = CreateMD5( password );
            cmd.CommandType = CommandType.Text;

            try
            {
                MySqlDataAdapter da;
                DataSet ds;

                if ( codes.CheckAcessCode( accessCode ) == false )
                {
                    MessageBox.Show( "O codigo de acesso fornecido não é valido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    return ret;
                }

                da = new MySqlDataAdapter( cmd );
                ds = new DataSet();

                da.Fill( ds, "tabela" );

                if ( ds.Tables[0].Rows.Count > 0 )
                {
                    if ( ds.Tables[0].Rows[0]["SCOPE_IDENTITY"] != null )
                    {
                        ret.UserID = int.Parse( ds.Tables[0].Rows[0]["SCOPE_IDENTITY"].ToString() );
                    }
                }

                codes.UseAccessCode( ret, accessCode );
            }
            catch ( Exception ex )
            {
                throw ex;
            }

            if ( Conexao.State == ConnectionState.Open )
                Conexao.Close();

            return ret;
        }

        internal User_t NewUser( string username, string password, bool ForceChangePassword, bool IsAdmin )
        {
            User_t ret = new User_t( 0, username, password, IsAdmin );

            try
            {
                string sql = @"
            
                    insert into users( username, password, IsAdmin, ForceChangePassword ) values( @User, @Pass, @Admin, @Force );
                    select LAST_INSERT_ID() as SCOPE_IDENTITY";

                MySqlCommand cmd = new MySqlCommand( sql, Conexao );
                cmd.Parameters.Add( "User", MySqlDbType.VarChar ).Value = username;
                cmd.Parameters.Add( "Pass", MySqlDbType.VarChar ).Value = CreateMD5( password );
                cmd.Parameters.Add( "Force", MySqlDbType.Int32 ).Value = ForceChangePassword.Int32();
                cmd.Parameters.Add( "Admin", MySqlDbType.Int32 ).Value = IsAdmin.Int32();
                cmd.CommandType = CommandType.Text;

                MySqlDataAdapter da = new MySqlDataAdapter( cmd );
                DataSet ds = new DataSet();

                da.Fill( ds, "tabela" );

                if ( ds.Tables[0].Rows.Count > 0 )
                {
                    if ( ds.Tables[0].Rows[0]["SCOPE_IDENTITY"] != null )
                    {
                        ret.UserID = int.Parse( ds.Tables[0].Rows[0]["SCOPE_IDENTITY"].ToString() );
                    }
                }

                Conexao.Close();
            }
            catch ( Exception ex )
            {
                throw ex;
            }

            return ret;
        }

        /// <summary>
        /// https://stackoverflow.com/questions/11454004/calculate-a-md5-hash-from-a-string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string CreateMD5( string input )
        {
            string ret = "";

            try
            {
                // Use input string to calculate MD5 hash
                using ( System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create() )
                {
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes( input );
                    byte[] hashBytes = md5.ComputeHash( inputBytes );

                    // Convert the byte array to hexadecimal string
                    StringBuilder sb = new StringBuilder();
                    for ( int i = 0; i < hashBytes.Length; i++ )
                    {
                        sb.Append( hashBytes[i].ToString( "X2" ) );
                    }
                    ret = sb.ToString();
                }
            }
            catch ( Exception ex )
            {
                throw ex;
            }

            return ret;
        }

    }
}

