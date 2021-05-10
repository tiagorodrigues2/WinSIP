using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace WinSIP.Dados
{
    class GruposPlaylist
    {
        private MySqlConnection Conexao;

        public int IdGruposPlaylist;
        public int IdGrupo;
        public int IdPlaylist;
        public int NrOrdem;
        public int Ativo;

        internal GruposPlaylist()
        {
            Conexao = AcessoBD.Connection;

            IdGrupo = 0;
            IdGruposPlaylist = 0;
            IdPlaylist = 0;
            NrOrdem = 0;
            Ativo = 0;
        }

        /// <summary>
        /// Devolve todos os registos da tabela GruposPlaylist
        /// </summary>
        /// <returns>DataSet com todos os registos da tabela</returns>
        internal DataSet LerGruposPlaylist()
        {
            MySqlDataAdapter da;
            DataSet ds;
            MySqlCommand cmd;

            cmd = new MySqlCommand( "select * from gruposplaylist", Conexao );
            cmd.CommandType = CommandType.Text;

            ds = new DataSet();
            da = new MySqlDataAdapter( cmd );

            da.Fill( ds, "tabela" );
            return ds;
        }

        /// <summary>
        /// Devolve um registo da tabela GruposPlaylist a partir do ID de relação
        /// </summary>
        /// <param name="IdGruposPlaylist">ID da relação</param>
        /// <returns>DataSet com um elemento</returns>
        internal DataSet GetGruposPlaylist( int IdGruposPlaylist )
        {
            MySqlDataAdapter da;
            DataSet ds;
            MySqlCommand cmd;

            cmd = new MySqlCommand( "select * from gruposplaylist where IdGruposPlaylist=@IdGruposPlaylist", Conexao );
            cmd.Parameters.Add( "IdGruposPlaylist", MySqlDbType.Int32 ).Value = IdGruposPlaylist;
            cmd.CommandType = CommandType.Text;

            ds = new DataSet();
            da = new MySqlDataAdapter( cmd );

            da.Fill( ds, "tabela" );
            return ds;
        }

        /// <summary>
        /// Devolve todos os registos filtrados por ID do Grupo
        /// </summary>
        /// <param name="IdGrupo">ID do Grupo</param>
        /// <returns></returns>
        internal DataSet GetGruposPlaylistsByGrupo( int IdGrupo )
        {
            MySqlDataAdapter da;
            DataSet ds;
            MySqlCommand cmd;

            cmd = new MySqlCommand( "select * from gruposplaylist where IdGrupo = @IdGrupo", Conexao );
            cmd.Parameters.Add( "IdGrupo", MySqlDbType.Int32 ).Value = IdGrupo;
            cmd.CommandType = CommandType.Text;

            ds = new DataSet();
            da = new MySqlDataAdapter( cmd );

            da.Fill( ds, "tabela" );
            return ds;
        }

        /// <summary>
        /// Insere um registo na tabela GruposPlaylist
        /// </summary>
        /// <param name="tGruposPlaylist">
        /// tGruposPlaylist.IdGruposPlaylist: Não necessário |
        /// tGruposPlaylist.IdGrupo: ID do Grupo |
        /// tGruposPlaylist.IdPlaylist: ID da Playlist
        /// </param>
        /// <returns></returns>
        internal int InsertGruposPlaylist( GruposPlaylist dados )
        {
            MySqlCommand cmd;

            int id = -1;

            string sql = @" 

                
	                insert into gruposplaylist( IdGrupo, IdPlaylist, NrOrdem, Ativo ) values( @IdGrupo, @IdPlaylist, @NrOrdem, @Ativo );
                    select LAST_INSERT_ID() as SCOPE_IDENTITY";

            cmd = new MySqlCommand( sql, Conexao );
            cmd.Parameters.Add( "IdGrupo", MySqlDbType.Int32 ).Value = dados.IdGrupo;
            cmd.Parameters.Add( "IdPlaylist", MySqlDbType.Int32 ).Value = dados.IdPlaylist;
            cmd.Parameters.Add( "NrOrdem", MySqlDbType.Int32 ).Value = dados.NrOrdem;
            cmd.Parameters.Add( "Ativo", MySqlDbType.Int32 ).Value = dados.Ativo;
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
        /// Atualiza um registo na tabela GruposPlaylist
        /// </summary>
        /// <param name="tGruposPlaylist">
        /// tGruposPlaylist.IdGruposPlaylist: ID da relação |
        /// tGruposPlaylist.IdGrupo: ID do Grupo
        /// tGruposPlaylist.IdPlaylist: ID da Playlist
        /// </param>
        /// <returns>Numero de rows afetadas</returns>
        internal int UpdateGruposPlaylist( GruposPlaylist dados )
        {
            MySqlCommand cmd;
            int rowAffect = 0;

            cmd = new MySqlCommand( @"
                                    UPDATE  gruposplaylist
                                    SET     IdGrupo=@IdGrupo, IdPlaylist=@IdPlaylist                
                                    WHERE   IdGrupoPlaylist=@IdGruposPlaylist", Conexao );


            cmd.Parameters.Add( "IdPlaylist", MySqlDbType.VarChar ).Value = dados.IdPlaylist;
            cmd.Parameters.Add( "IdGrupo", MySqlDbType.Int32 ).Value = dados.IdGrupo;
            cmd.Parameters.Add( "IdGruposPlaylist", MySqlDbType.Int32 ).Value = dados.IdGruposPlaylist;
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
        /// Elimina um registo na tabela GruposPlaylist
        /// </summary>
        /// <param name="IdGruposPlaylist">ID da relação</param>
        /// <returns>Numero de rows afetadsa</returns>
        internal int DeleteGruposPlaylist( int IdGruposPlaylist )
        {
            MySqlCommand cmd;
            int rowAffect = 0;

            string query = @"

                delete from gruposplaylist where IdGrupoPlaylist=@IdGruposPlaylist

            ";

            cmd = new MySqlCommand( query, Conexao );
            cmd.Parameters.Add( "IdGruposPlaylist", MySqlDbType.Int32 ).Value = IdGruposPlaylist;
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
