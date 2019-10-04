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


namespace Projeto_DS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            TimeSpan tarde = new TimeSpan(12, 0, 0);
            TimeSpan noite = new TimeSpan(18, 0, 0);
            TimeSpan HoraAtual = DateTime.Now.TimeOfDay;

            if (HoraAtual < tarde)
            {
                label1.Text = "Bom dia";

            } else if (HoraAtual < noite) {

                label1.Text = "Boa tarde";
            }
            else
            {
                label1.Text = "Boa noite";
            }
            
        }

        public Home(pessoaDTO pessoa)
        {
            InitializeComponent();
            TimeSpan tarde = new TimeSpan(12, 0, 0);
            TimeSpan noite = new TimeSpan(18, 0, 0);
            TimeSpan HoraAtual = DateTime.Now.TimeOfDay;

            if (HoraAtual < tarde)
            {
                label1.Text = "Bom dia";

            }
            else if (HoraAtual < noite)
            {

                label1.Text = "Boa tarde";
            }
            else
            {
                label1.Text = "Boa noite";
            }
            label2.Text = pessoa.prp_nome;
            if(pessoa.prp_cargo == "func")
            {
                this.tabControl1.TabPages.Remove(tabPage3);
                this.tabControl1.TabPages.Remove(tabPage4);
                this.tabControl1.TabPages.Remove(tabPage5);
                this.tabControl1.TabPages.Remove(tabPage6);
                this.tabControl1.TabPages.Remove(tabPage7);
            }
        }
        

            private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                pessoaDTO obj = new pessoaDTO();
                obj.prp_nome = textBox1.Text;
                obj.prp_cpf = maskedTextBox4.Text;
                obj.prp_rg = textBox10.Text;
                obj.prp_cargo = textBox3.Text;
                obj.prp_telFixo = maskedTextBox2.Text;
                obj.prp_telCelular = maskedTextBox1.Text;
                obj.prp_dtNascimento = maskedTextBox3.Text;
                obj.prp_endereco = textBox6.Text;
                obj.prp_numero = textBox11.Text;
                obj.prp_bairro = textBox7.Text;
                obj.prp_cidade = textBox8.Text;
                obj.prp_cep = textBox12.Text;
                obj.prp_uf = textBox9.Text;

                if(radioButton1.Checked == true)
                {
                    obj.prp_sexo = radioButton1.Text;
                }

                if (radioButton2.Checked == true)
                {
                    obj.prp_sexo = radioButton2.Text;
                }

                if (radioButton5.Checked == true)
                {
                    obj.prp_sexo = radioButton5.Text;
                }

                if (radioButton3.Checked == true)
                {
                    obj.prp_ativo = radioButton3.Text;
                }

                if (radioButton4.Checked == true)
                {
                    obj.prp_ativo = radioButton4.Text;
                }




            }
            catch { }
        }
    } 
}
