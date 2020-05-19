using Loja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidade

{
    public class Loja
    {
        #region Propriedade

        public int IdLoja { set; get; }

        public string NomeLoja { set; get; }

        public string Cnpj { set; get; }
        public System.Windows.Forms.DataGridViewRow CurrentRow { get; }
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new FormCliente().Show();

            FrLoja lj = new FrLoja();

            lj.Show();

        }

        #endregion
    }
}