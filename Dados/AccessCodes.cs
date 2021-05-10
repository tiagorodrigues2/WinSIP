using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinSIP.Dados
{
    class AccessCodes
    {
        private MySqlConnection Conexao;

        public int CodeID;
        public string code;
        public int user;

        public AccessCodes()
        {
            Conexao = AcessoBD.Connection;

            CodeID = 0;
            code = "";
            user = 0;
        }

        /// <summary>
        /// Devolve todos os registos da tabela
        /// </summary>
        /// <returns>DataSet com todos os registos</returns>
        internal DataSet LerAcessCodes()
        {
            MySqlDataAdapter da;
            DataSet ds;
            MySqlCommand cmd;

            try
            {
                cmd = new MySqlCommand( "select * from acesscodes", Conexao );
                cmd.CommandType = CommandType.Text;

                da = new MySqlDataAdapter( cmd );
                ds = new DataSet();

                da.Fill( ds, "tablea" );
            }
            catch ( Exception ex )
            {
                throw ex;
            }

            return ds;
        }

        /// <summary>
        /// Verifica se o código de acess existe
        /// </summary>
        /// <param name="code">Codigo de acesso</param>
        /// <returns>booleano true/false</returns>
        internal bool CheckAcessCode(string code)
        {
            bool ret = false;

            try
            {
                MySqlCommand cmd = new MySqlCommand( @"select * from acesscodes where code = @Code and user = 0", Conexao );
                cmd.Parameters.Add( "Code", MySqlDbType.VarChar ).Value = code;
                cmd.CommandType = CommandType.Text;

                MySqlDataAdapter da = new MySqlDataAdapter( cmd );
                DataTable dt = new DataTable();

                da.Fill( dt );

                ret = dt.Rows.Count > 0;
            }
            catch ( Exception ex  )
            {
                throw ex;
            }

            return ret;
        }

        /// <summary>
        /// Marca o codigo de acesso como usado
        /// </summary>
        /// <param name="user"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        internal bool UseAccessCode(User_t user, string code)
        {
            bool ret = false;

            try
            {
                string sql = @"
        
                    update acesscodes
                    set user = @UserID
                    where code = @Code";

                MySqlCommand cmd = new MySqlCommand( sql, Conexao );
                cmd.Parameters.Add( "UserID", MySqlDbType.Int32 ).Value = user.UserID;
                cmd.Parameters.Add( "Code", MySqlDbType.VarChar ).Value = code;
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
        /// Elimina um registo na tabela acesscodes
        /// </summary>
        /// <param name="CodeID">id do codigo</param>
        /// <returns></returns>
        internal bool DeleteCode(int CodeID)
        {
            bool ret = false;

            try
            {
                string sql = @"
                    
                    delete from acesscodes where CodeID = @ID";

                MySqlCommand cmd = new MySqlCommand( sql, Conexao );
                cmd.Parameters.Add( "ID", MySqlDbType.Int32 ).Value = CodeID;
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

        internal bool CreateCode()
        {
            bool ret = false;

            try
            {
                string hash = GenerateCode();
                string sql = @"
        
                    insert into acesscodes( code ) values( @Hash );
                    select LAST_INSERT_ID() as SCOPE_IDENTITY";


                MySqlCommand cmd = new MySqlCommand( sql, Conexao );
                cmd.Parameters.Add( "Hash", MySqlDbType.VarChar ).Value = hash;
                cmd.CommandType = CommandType.Text;

                if ( Conexao.State != ConnectionState.Open ) Conexao.Open();

                MySqlDataAdapter da = new MySqlDataAdapter( cmd );
                DataSet ds = new DataSet();

                da.Fill( ds, "tabela" );

                if ( ds.Tables[0].Rows.Count > 0 )
                {
                    if ( ds.Tables[0].Rows[0]["SCOPE_IDENTITY"] != null )
                    {
                        ret = int.Parse( ds.Tables[0].Rows[0]["SCOPE_IDENTITY"].ToString() ) > 0;
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
        /// Genera uma string aleatoria de 12 letras de A-Z com numeros.
        /// </summary>
        /// <returns></returns>
        internal string GenerateCode()
        {
            Random random = new Random();

            string chars = "abcdefghijklmnopqrstuvwxyz0123456789";

            return new string( Enumerable.Repeat( chars, 12 ).Select( s => s[random.Next( s.Length )] ).ToArray() );
        }
    }
}
