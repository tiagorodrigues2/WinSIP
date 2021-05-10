using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSIP
{
    public static class Extension
    {

        public static string ToStringPT( this bool booleano )
        {
            return ( booleano ) ? "Sim" : "Nao";
        }


        public static void AjustarColunas( this DataGridView dataGridView1 )
        {
            int NovaLagura = ( dataGridView1.Width / dataGridView1.Columns.Count ) - ( dataGridView1.RowHeadersWidth / dataGridView1.Columns.Count ) - 1;

            for ( int i = 0; i < dataGridView1.Columns.Count; i++ )            
                dataGridView1.Columns[i].Width = NovaLagura;
            
        }

        public static Int32 Int32( this bool booleano )
        {
            return booleano ? 1 : 0;
        }

}
}
