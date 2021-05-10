using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WinSIP.Dados
{
    internal class Display
    {
        private MySqlConnection Conexao;

        public int IdDisplay;
        public string Descritivo;
        public int IdGrupo;

        internal Display()
        {
            Conexao = AcessoBD.Connection;

            IdDisplay = 0;
            Descritivo = "";
            IdGrupo = 0;
        }

        /// <summary>
        /// Devolve todos os registos da tabela
        /// </summary>
        /// <returns>DataSet com todos os registos</returns>
        internal DataSet LerDisplay()
        {
            MySqlDataAdapter da;
            DataSet ds;
            MySqlCommand cmd;

            try
            {
                cmd = new MySqlCommand( "Select * from display", Conexao );
                cmd.CommandType = CommandType.Text;

                da = new MySqlDataAdapter( cmd );
                ds = new DataSet();

                da.Fill( ds, "tabela" );
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }


        /// <summary>
        /// Devolde um registo
        /// </summary>
        /// <param name="IdDisplay">ID do Display a ser devolvido</param>
        /// <returns>DataSet com um elemento</returns>
        internal DataSet GetDisplay( int IdDisplay )
        {
            MySqlDataAdapter da;
            DataSet ds;
            MySqlCommand cmd;

            try
            {
                cmd = new MySqlCommand( "select * from Display where IdDisplay = @IdDisplay ", Conexao );
                cmd.Parameters.Add( "IdDisplay", MySqlDbType.Int32 ).Value = IdDisplay;
                cmd.CommandType = CommandType.Text;

                da = new MySqlDataAdapter( cmd );
                ds = new DataSet();

                da.Fill( ds, "tabela" );
            }
            catch ( Exception ex )
            {
                throw ex;
            }

            return ds;
        }

        /// <summary>
        /// Insere um Display na Tabela
        /// </summary>
        /// <param name="dados">
        /// dados.IdDisplay: Não necessário |
        /// dados.Descritivo: Descritivo do Display |
        /// dados.IdGrupo: Grupo do Display
        /// </param>
        /// <returns>ID do Display inserido.</returns>
        internal int InsertDisplay( Display dados )
        {
            MySqlCommand cmd;

            int id = -1;

            string sql = @" 

	            insert into display( Descritivo, IdGrupo ) VALUES( @Descritivo, @IdGrupo );
                select LAST_INSERT_ID() as SCOPE_IDENTITY";

            cmd = new MySqlCommand( sql, Conexao );
            cmd.Parameters.Add( "@Descritivo", MySqlDbType.VarChar ).Value = dados.Descritivo;
            cmd.Parameters.Add( "IdGrupo", MySqlDbType.Int32 ).Value = dados.IdGrupo;
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
                    } else
                        id = -1;
                } else
                    id = -1;

            } catch ( Exception ex )
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
        /// Atualiza um registo na tabela Display
        /// </summary>
        /// <param name="dados">
        /// dados.IdDisplay: ID do Display a ser atualizado |
        /// dados.Descritivo: Novo Descritivo do Display |
        /// dados.IdGrupo: ID do novo grupo
        /// </param>
        /// <returns>Numero de rows afetadas</returns>
        internal int UpdateDisplay( Display dados )
        {
            MySqlCommand cmd;
            int rowAffect = 0;

            cmd = new MySqlCommand( @"
                                    UPDATE  display
                                    SET     Descritivo=@Descritivo, IdGrupo=@IdGrupo, DataA=CURRENT_TIMESTAMP()                
                                    WHERE   IdDisplay=@IdDisplay", Conexao );


            cmd.Parameters.Add( "Descritivo", MySqlDbType.VarChar ).Value = dados.Descritivo;
            cmd.Parameters.Add( "IdDisplay", MySqlDbType.Int32 ).Value = dados.IdDisplay;
            cmd.Parameters.Add( "IdGrupo", MySqlDbType.Int32 ).Value = dados.IdGrupo;
            cmd.CommandType = CommandType.Text;

            try
            {
                Conexao.Open();
                rowAffect = cmd.ExecuteNonQuery();
            } catch ( Exception ex )
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
        /// Elimina um regissto na tabela Display
        /// </summary>
        /// <param name="IdDisplay">ID do Display a ser eliminado</param>
        /// <returns>Numero de rows afetadas</returns>
        internal int DeleteDisplay( int IdDisplay )
        {
            MySqlCommand cmd;
            int rowAffect = 0;

            string query = @"

                delete from display where IdDisplay=@IdDisplay

            ";

            cmd = new MySqlCommand( query, Conexao );
            cmd.Parameters.Add( "IdDisplay", MySqlDbType.Int32 ).Value = IdDisplay;
            cmd.CommandType = CommandType.Text;

            try
            {
                Conexao.Open();
                rowAffect = cmd.ExecuteNonQuery();
            } catch ( Exception ex )
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
