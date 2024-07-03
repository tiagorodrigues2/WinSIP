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
