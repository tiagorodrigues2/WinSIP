using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinSIP.Dados
{

    class Grupos
    {
        private MySqlConnection Conexao;

        public int IdGrupo;
        public string Descritivo;

        internal Grupos()
        {
            Conexao = AcessoBD.Connection;

            IdGrupo = 0;
            Descritivo = "";
        }

        /// <summary>
        /// Devolve todos os registos na tabela Grupos
        /// </summary>
        /// <returns>DataSet com todos os registos</returns>
        internal DataSet LerGrupos()
        {
            MySqlDataAdapter da;
            DataSet ds;
            MySqlCommand cmd;

            cmd = new MySqlCommand( "select * from grupos", Conexao );
            cmd.CommandType = CommandType.Text;

            da = new MySqlDataAdapter( cmd );
            ds = new DataSet();

            da.Fill( ds, "tabela" );
            return ds;
        }


        /// <summary>
        /// Devolve um registo da tabela Grupos
        /// </summary>
        /// <param name="IdGrupo">ID do grupo a aser devolvido</param>
        /// <returns>DataSet com um elemento</returns>
        internal DataSet GetGrupo( int IdGrupo )
        {
            MySqlDataAdapter da;
            DataSet ds;
            MySqlCommand cmd;

            cmd = new MySqlCommand( @"select * from grupos where IdGrupo = @IdGrupo", Conexao );
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add( "IdGrupo", MySqlDbType.Int32 ).Value = IdGrupo;

            da = new MySqlDataAdapter( cmd );
            ds = new DataSet();

            da.Fill( ds, "tabela" );
            return ds;
        }

        /// <summary>
        /// Insere um gestio na tabela Grupos
        /// </summary>
        /// <param name="dados">
        /// dados.IdGrupo: Não necessário |
        /// dados.Descritivo: Descritivo do Grupo
        /// </param>
        /// <returns>ID do Grupo inserido</returns>
        internal int InsertGrupo( Grupos dados )
        {
            MySqlCommand cmd;

            int id = -1;

            string sql = @" 

	                insert into grupos( Descritivo ) values( @Descritivo );
                    select LAST_INSERT_ID() as SCOPE_IDENTITY";

            cmd = new MySqlCommand( sql, Conexao );
            cmd.Parameters.Add( "Descritivo", MySqlDbType.VarChar ).Value = dados.Descritivo;
            cmd.CommandType = CommandType.Text;

            try
            {
                MySqlDataAdapter da;
                DataSet ds;

                da = new MySqlDataAdapter( cmd );
                ds = new DataSet();

                da.Fill( ds, "tabela" );

                if ( ds.Tables[0].Rows.Count > 0 )
                {
                    if ( ds.Tables[0].Rows[0]["SCOPE_IDENTITY"] != null )
                    {
                        id = int.Parse( ds.Tables[0].Rows[0]["SCOPE_IDENTITY"].ToString() );
                    }
                    else
                        id = -1;
                }
                else
                    id = -1;

            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                Conexao.Close();
            }

            return id;

        }


        /// <summary>
        /// Atualiza um registo na tabela Grupos
        /// </summary>
        /// <param name="dados">
        /// dados.IdGrupo: ID do grupo a ser atualizado |
        /// dados.Descritivo: Novo Descritivo do Grupo
        /// </param>
        /// <returns></returns>
        internal int UpdateGrupo( Grupos dados )
        {
            MySqlCommand cmd;
            int rowAffect = 0;

            cmd = new MySqlCommand( @"
                                    UPDATE  grupos
                                    SET     Descritivo=@Descritivo, DataA=CURRENT_TIMESTAMP()                
                                    WHERE   IdGrupo=@IdGrupo", Conexao );


            cmd.Parameters.Add( "Descritivo", MySqlDbType.VarChar ).Value = dados.Descritivo;
            cmd.Parameters.Add( "IdGrupo", MySqlDbType.Int32 ).Value = dados.IdGrupo;
            cmd.CommandType = CommandType.Text;

            try
            {
                Conexao.Open();
                rowAffect = cmd.ExecuteNonQuery();
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                Conexao.Close();
            }

            return rowAffect;
        }


        /// <summary>
        /// Elimina um registo na tabela Grupos
        /// </summary>
        /// <param name="IdGrupo">ID do grupo a ser eliminado</param>
        /// <returns>Numero de rows afetadas</returns>
        internal int DeleteGrupo( int IdGrupo )
        {
            MySqlCommand cmd;
            int rowAffect = 0;

            string query = @"

                delete from grupos where IdGrupo=@IdGrupo;
                delete from gruposplaylist where IdGrupo=@IdGrupo;

            ";

            cmd = new MySqlCommand( query, Conexao );
            cmd.Parameters.Add( "IdGrupo", MySqlDbType.Int32 ).Value = IdGrupo;
            cmd.CommandType = CommandType.Text;

            try
            {
                Conexao.Open();
                rowAffect = cmd.ExecuteNonQuery();
            }
            catch ( Exception ex )
            {
                throw ex;
            }
            finally
            {
                Conexao.Close();
            }

            return rowAffect;
        }
    }
}
