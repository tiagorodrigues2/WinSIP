using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace WinSIP.Dados
{
    class AcessoBD
    {
        private MySqlConnection Conexao;


        internal AcessoBD()
        {
            try
            {
                Conexao = Connection;

            } catch ( Exception ex )
            {
                throw ex;
            }

        }

        /// <summary>
        /// Objeto da Conexão a Base de Dados
        /// </summary>
        internal static MySqlConnection Connection
        {
            get
            {
                MySqlConnection Con = new MySqlConnection();

                try
                {
                    /*
                    https://web10.meuhost.net:7544/
                    Con = new MySqlConnection( "Server=130.185.85.210;PORT=7575;Database=monitores;Uid=user_monitores;Pwd=6ghd%sKxA;" );
                    */

                    Con = new MySqlConnection( "Server=localhost;Database=monitores;Uid=root;" );

                } catch ( Exception ex )
                {

                    throw ex;
                }

                return Con;
            }
        }

    }
}
