using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinSIP.Dados
{
    class Files
    {
        private MySqlConnection Conexao;

        public int IdFile;
        public string Descritivo;
        public string Path;
        public int Tempo; 

        internal Files()
        {
            Conexao = AcessoBD.Connection;

            IdFile = 0;
            Descritivo = "";
            Path = "";
            Tempo = 0;
        }

        /// <summary>
        /// Devolve todos os registos na tabela Files
        /// </summary>
        /// <returns>DataSet com todos os registos</returns>
        internal DataSet LerFiles()
        {
            MySqlDataAdapter da;
            DataSet ds;
            MySqlCommand cmd;

            cmd = new MySqlCommand( "select * from files", Conexao );
            cmd.CommandType = CommandType.Text;

            da = new MySqlDataAdapter( cmd );
            ds = new DataSet();

            da.Fill( ds, "tabela" );
            return ds;
        }

        

        /// <summary>
        /// Devolve um registo da tabela Files
        /// </summary>
        /// <param name="IdFile">Id do ficheiro a ser devolvdo</param>
        /// <returns>DataSet com um elemento</returns>
        internal DataSet GetFile( int IdFile )
        {
            MySqlDataAdapter da;
            DataSet ds;
            MySqlCommand cmd;

            cmd = new MySqlCommand( "select * from files where IdFile=@IdFile", Conexao );
            cmd.Parameters.Add( "IdDisplay", MySqlDbType.Int32 ).Value = IdFile;

            ds = new DataSet();
            da = new MySqlDataAdapter( cmd );

            da.Fill( ds, "tabela" );
            return ds;
        }


        /// <summary>
        /// Insere um registo na tabela Files
        /// WARNING: Antes de inserir um registo, é recomendado que envie primeiro os ficheiros para os servidor.
        /// </summary>
        /// <param name="tFile">
        /// tFile.IdFile: Não necessario |
        /// tFile.Descritivo: Descritivo do ficheiro |
        /// tFile.Path: Caminho do ficheiro |
        /// tFile.Time: Tempo que o ficheiro é mostrado no monitor
        /// </param>
        /// <returns></returns>
        internal int InsertFile( Files tFile )
        {
            int id = -1;
            string sql = @"

                    insert into files( Descritivo, Path, Tempo ) values( @Descritivo, @Path, @Tempo );
                    select LAST_INSERT_ID() as SCOPE_IDENTITY";

            MySqlCommand cmd = new MySqlCommand( sql, Conexao );
            cmd.Parameters.Add( "Descritivo", MySqlDbType.VarChar, 128 ).Value = tFile.Descritivo;
            cmd.Parameters.Add( "Path", MySqlDbType.VarChar, 256 ).Value = tFile.Path;
            cmd.Parameters.Add( "Tempo", MySqlDbType.Int32 ).Value = tFile.Tempo;

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
                        id = int.Parse( ds.Tables[0].Rows[0]["SCOPE_IDENTITY"].ToString() );
                }
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
        /// Atualiza um registo na tabela Files
        /// </summary>
        /// <param name="dados">
        /// dados.IdFile: Id do ficheiro a ser atualizado |
        /// dados.Descritivo: Novo Descritivo do ficheiro |
        /// dados.Path: Novo caminho do ficheiro |
        /// dados.Tempo: Novo tempo que o ficheiro vai ser mostrado no monitor
        /// </param>
        /// <returns>Numero de rows afetadas</returns>
        internal int UpdateFile( Files dados )
        {
            MySqlCommand cmd;
            int rowAffect = 0;

            cmd = new MySqlCommand( @"
                                    update files
                                    set Descritivo = @Descritivo, Path = @Path, Tempo = @Tempo, DataA = CURRENT_TIMESTAMP()
                                    where IdFile = @IdFile", Conexao );

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add( "Descritivo", MySqlDbType.VarChar, 128 ).Value = dados.Descritivo;
            cmd.Parameters.Add( "Path", MySqlDbType.VarChar, 256 ).Value = dados.Path;
            cmd.Parameters.Add( "Tempo", MySqlDbType.Int32 ).Value = dados.Tempo;
            cmd.Parameters.Add( "IdFile", MySqlDbType.Int32 ).Value = dados.IdFile;

            try
            {
                Conexao.Open();
                rowAffect = cmd.ExecuteNonQuery();
            }
            catch ( MySqlException ex ) { throw ex; }
            finally { Conexao.Close(); }

            return rowAffect;
        }

        /// <summary>
        /// Elimina um registo na tabela Files.
        /// Elimina tambem qualquer relação entre Playlist com o ficheiro em questão.
        /// </summary>
        /// <param name="IdFile">ID do ficheiro</param>
        /// <returns>Numero de rows afetadas</returns>
        internal int DeleteFile( int IdFile )
        {
            int rowAffect = 0;
            MySqlCommand cmd;

            string sql = @"
                            delete from files where IdFile = @IdFile;
                            delete from playlistfiles where IdFile = @IdFile";

            cmd = new MySqlCommand( sql, Conexao );
            cmd.Parameters.Add( "IdFile", MySqlDbType.Int32 ).Value = IdFile;
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
