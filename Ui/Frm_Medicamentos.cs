using System;
using System.Windows.Forms;

//Importação da camada de negócio
using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;

namespace Projeto3Camadas.Ui
{
    public partial class Frm_Medicamentos : Form
    {
        
        //Criação dos objetos que acessam a camada de negócio
        FilmesBLL flmbll = new FilmesBLL();
        FilmeDTO flmdto = new FilmeDTO();

        public Frm_Medicamentos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            flmdto.Filme = txtFilme.Text;
            flmdto.Genero = txtGenero.Text;

            //Envio do dto preenchido para o método inserir
            flmbll.Inserir(flmdto);

            MessageBox.Show("Cadastrado com Sucesso!", "Filme", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtId.Clear();
            txtFilme.Clear();
            txtGenero.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
