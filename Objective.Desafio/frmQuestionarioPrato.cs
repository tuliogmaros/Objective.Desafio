using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Objective.Desafio
{
    public partial class frmQuestionarioPrato : Form
    {
        public string Prato { get; set; }
        public string Exclusividade { get; set; }
        public string PratoComparado { get; set; }

        public frmQuestionarioPrato(string pratoComparado)
        {
            InitializeComponent();
            PratoComparado = pratoComparado;
        }

        private void btnOKQuest_Click(object sender, EventArgs e)
        {
            Prato = txtResposta.Text;
            var frmExclu = new frmExclusividadePrato(Prato, PratoComparado);
            frmExclu.ShowDialog();
            Exclusividade = frmExclu.Exclusividade;
            this.Close();
        }

        private void btnCancelarQuest_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
