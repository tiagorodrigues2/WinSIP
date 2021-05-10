using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinSIP.Dados
{

    class PlaylistFiles
    {
        MySqlConnection Conexao;

        public int IdPlaylistFiles;
        public int IdPlaylist;
        public int IdFile;
        public int NrOrdem;

        internal PlaylistFiles()
        {
            Conexao = AcessoBD.Connection;

            IdPlaylistFiles = 0;
            IdPlaylist = 0;
            IdFile = 0;
            NrOrdem = 0;
        }

        /// <summary>
        /// Devolve todos os registos da tabela PlaylistFiles
        /// </summary>
        /// <returns>DataSet com todos os registos da tabela</returns>
        internal DataSet LerPlaylistFiles()
        {
            MySqlDataAdapter da;
            DataSet ds;
            MySqlCommand cmd;

            cmd = new MySqlCommand( "select * from playlistfiles", Conexao );
            cmd.CommandType = CommandType.Text;

            ds = new DataSet();
            da = new MySqlDataAdapter( cmd );

            da.Fill( ds, "tabela" );
            return ds;
        }

        /// <summary>
        /// Devolve um registo da tabela PlaylistFiles a partir do ID de relação
        /// </summary>
        /// <param name="IdPlaylistFiles">ID da relação</param>
        /// <returns>DataSet com um elemento</returns>
        internal DataSet GetPlaylistFiles( int IdPlaylistFiles )
        {
            MySqlDataAdapter da;
            DataSet ds;
            MySqlCommand cmd;

            cmd = new MySqlCommand( "select * from playlistfiles where IdPlaylistFiles=@IdPlaylistFiles", Conexao );
            cmd.Parameters.Add( "IdPlaylistFiles", MySqlDbType.Int32 ).Value = IdPlaylistFiles;
            cmd.CommandType = CommandType.Text;

            ds = new DataSet();
            da = new MySqlDataAdapter( cmd );

            da.Fill( ds, "tabela" );
            return ds;
        }


        internal DataSet CalculaProximoFicheiro( int IdDisplay )
        {
            MySqlDataAdapter da;
            DataSet ds;
            MySqlCommand cmd;

            string sql = @"
            select plf.* , f.*
            from display d 
			inner join grupos g on g.idgrupo = d.idgrupo
			inner join gruposPlaylist gp on gp.Idgrupo = g.Idgrupo
			inner join playlist p on p.idPlaylist = gp.idPlaylist
			inner join playlistfiles plf  on plf.idPlaylist = p.idPlaylist
			inner join files f on f.IdFile = plf.idFile
            where d.IdDisplay = @IdDisplay
			and plf.mostrou = 0
			order by gp.NrOrdem, plf.NrOrdem
			limit 1
            ";

            cmd = new MySqlCommand( sql, Conexao );
            cmd.Parameters.Add( "IdDisplay", MySqlDbType.Int32 ).Value = IdDisplay;
            cmd.CommandType = CommandType.Text;

            ds = new DataSet();
            da = new MySqlDataAdapter( cmd );

            da.Fill( ds, "tabela" );
            return ds;
        }

        internal string GetCurrentFooterPath( int iDisplay )
        {
            string ret = "";

            MySqlDataAdapter da;
            DataSet ds;
            MySqlCommand cmd;

            string sql = @"
            select p.FooterPath
            from display d 
			inner join grupos g on g.idgrupo = d.idgrupo
			inner join gruposPlaylist gp on gp.Idgrupo = g.Idgrupo
			inner join playlist p on p.idPlaylist = gp.idPlaylist
			inner join playlistfiles plf  on plf.idPlaylist = p.idPlaylist
			inner join files f on f.IdFile = plf.idFile
            where d.IdDisplay = @IdDisplay
			and plf.mostrou = 0
			order by gp.NrOrdem, plf.NrOrdem
			limit 1
            ";

            cmd = new MySqlCommand( sql, AcessoBD.Connection );
            cmd.Parameters.Add( "IdDisplay", MySqlDbType.Int16 ).Value = iDisplay;
            cmd.CommandType = CommandType.Text;

            ds = new DataSet();
            da = new MySqlDataAdapter( cmd );

            da.Fill( ds );

            DataRow row = ds.Tables[0].Rows[0];

            ret = row["FooterPath"].ToString();

            return ret;
        }

        internal int MarcaComoMostrado( int IdPlaylistFiles )
        {
            MySqlCommand cmd;
            int rowAffect = 0;

            cmd = new MySqlCommand( @"
                                    UPDATE  playlistfiles
                                    SET     Mostrou = 1               
                                    WHERE   IdPlaylistFiles=@IdPlaylistFiles", Conexao );


          
            cmd.Parameters.Add( "IdPlaylistFiles", MySqlDbType.Int32 ).Value = IdPlaylistFiles;
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



        internal int ResetMostrouPlaylist( int IdDisplay )
        {
            MySqlCommand cmd;
            int rowAffect = 0;

            cmd = new MySqlCommand( @"
                                   
         UPDATE  playlistfiles plf 

            inner join playlist p on plf.idPlaylist = p.idPlaylist
            inner join gruposPlaylist gp on gp.idPlaylist = p.idPlaylist
            inner join grupos g on g.idgrupo = gp.Idgrupo
            inner join display d on d.Idgrupo = gp.Idgrupo            

            SET  plf.Mostrou = 0

            where d.IdDisplay = @IdDisplay
            ", Conexao );


            cmd.Parameters.Add( "IdDisplay", MySqlDbType.Int32 ).Value = IdDisplay;
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



        internal int ResetMostrouGrupoPlaylist( int IdDisplay )
        {
            MySqlCommand cmd;
            int rowAffect = 0;

            cmd = new MySqlCommand( @"
                                   
          UPDATE  gruposPlaylist gp 
            inner join grupos g on g.idgrupo = gp.Idgrupo
            inner join display d on d.Idgrupo = gp.Idgrupo

            SET  gp.Mostrou = 0

            where d.IdDisplay = @IdDisplay
            ", Conexao );


            cmd.Parameters.Add( "IdDisplay", MySqlDbType.Int32 ).Value = IdDisplay;
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
        /// Devolve registos da tabela PlaylistFiles filtrado pelo ID da Playlist
        /// </summary>
        /// <param name="IdPlaylist">ID da Playlist</param>
        /// <returns>DataSet com registos filtrados</returns>
        internal DataSet GetPlaylistFilesByPlaylist(int IdPlaylist)
        {
            MySqlCommand cmd;
            DataSet ds;
            MySqlDataAdapter da;

            cmd = new MySqlCommand( "select * from playlistfiles where IdPlaylist = @IdPlaylist", Conexao );
            cmd.Parameters.Add( "IdPlaylist", MySqlDbType.Int32 ).Value = IdPlaylist;

            ds = new DataSet();
            da = new MySqlDataAdapter( cmd );

            da.Fill( ds, "tabela" );
            return ds;
        }

        /// <summary>
        /// Insere um registo na tabela PlaylistFiles
        /// </summary>
        /// <param name="dados">
        /// dados.IdPlaylistFiles: Não necessário |
        /// dados.IdPlaylist: ID da Playlist |
        /// dados.IdFile: ID do Ficheiro
        /// </param>
        /// <returns></returns>
        internal int InsertPlaylistFiles( PlaylistFiles dados )
        {
            MySqlCommand cmd;

            int id = -1;

            string sql = @" 

	                insert into playlistfiles( IdPlaylist, IdFile, NrOrdem ) values( @IdPlaylist, @IdFile, @NrOrdem );
                    select LAST_INSERT_ID() as SCOPE_IDENTITY";

            cmd = new MySqlCommand( sql, Conexao );
            cmd.Parameters.Add( "IdPlaylist", MySqlDbType.Int32 ).Value = dados.IdPlaylist;
            cmd.Parameters.Add( "IdFile", MySqlDbType.Int32 ).Value = dados.IdFile;
            cmd.Parameters.Add( "NrOrdem", MySqlDbType.Int32 ).Value = dados.NrOrdem;
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
        /// Atualiza um registo na tabela PlaylistFiles
        /// </summary>
        /// <param name="dados">
        /// dados.IdPlaylistFiles: ID da relação a ser atualizada |
        /// dados.IdPlaylist: ID da playlist |
        /// dados.IdFiles: ID do ficheiro
        /// </param>
        /// <returns></returns>
        internal int UpdatePlaylistFiles( PlaylistFiles dados )
        {
            MySqlCommand cmd;
            int rowAffect = 0;

            cmd = new MySqlCommand( @"
                                    UPDATE  playlistfiles
                                    SET     IdPlaylist=@IdPlaylist, IdFile=@IdFile, NrOrdem = @NrOrdem                
                                    WHERE   IdPlaylistFiles=@IdPlaylistFiles", Conexao );


            cmd.Parameters.Add( "IdPlaylist", MySqlDbType.VarChar ).Value = dados.IdPlaylist;
            cmd.Parameters.Add( "IdFile", MySqlDbType.Int32 ).Value = dados.IdFile;
            cmd.Parameters.Add( "IdPlaylistFiles", MySqlDbType.Int32 ).Value = dados.IdPlaylistFiles;
            cmd.Parameters.Add("NrOrdem", MySqlDbType.Int32).Value = dados.NrOrdem;
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


        internal int DeletePlaylistFiles( int IdPlaylistFiles )
        {
            int rowAffect = 0;
            MySqlCommand cmd;

            string query = @"
                delete from playlistfiles where IdPlaylistFiles = @IdPlaylistFiles;
            ";

            cmd = new MySqlCommand( query, Conexao );
            cmd.Parameters.Add( "IdPlaylistFiles", MySqlDbType.Int32).Value = IdPlaylistFiles;
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
