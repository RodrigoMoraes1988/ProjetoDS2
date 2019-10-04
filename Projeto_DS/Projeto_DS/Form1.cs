using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_ProjetoDS;
using BLL_ProjetoDS;

namespace UI_ProjetoDS //UI- User Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            try
            {
                loginDTO obj = new loginDTO();
                pessoaDTO pessoa = new pessoaDTO();

                obj.prpUsuario = txtNome.Text;
                obj.prpSenha = txtSenha.Text;

                pessoa = LoginBLL.vldLogin(obj);

                if (pessoa.prp_nome != "" & pessoa.prp_ativo == "true")
                {
                    this.Hide();
                    Projeto_DS.Home tela2 = new Projeto_DS.Home(pessoa);
                    tela2.ShowDialog();
                    this.Close();

                }
                else
                {
                    throw new Exception("Usuario dou senha invalidos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
