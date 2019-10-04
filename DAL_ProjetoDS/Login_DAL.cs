using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ProjetoDS;
using System.Data;
using System.Data.SqlClient;



namespace DAL_ProjetoDS
{
    public class Login_DAL
    {
        public static pessoaDTO vldLogin(loginDTO obj)
        {
            try
                //inicia o bloco de tratamento de exception
            {
                string script = "SELECT * FROM Pessoa WHERE (userName = @login OR email = @login)" + "AND senha = @senha;";
                //cria uma string com consuta sql

                SqlCommand cm = new SqlCommand(script, Conexao.Conectar());
                //cria o comando para rodar a instrução, passando instrução sql e coxeção

                cm.Parameters.AddWithValue("@login", obj.prpUsuario);
                cm.Parameters.AddWithValue("@senha", obj.prpSenha);
                //substitui as variaveis na instrução sql pelos valores digitados pelo usuario

                SqlDataReader dados = cm.ExecuteReader();
                //roda a instrução sql e atribui resultado no sqlDataReader

                while (dados.Read())
                //le a proxima linha do resultado da instrução
                {
                    if (dados.HasRows)
                        //verifica se existe a linha com as credenciais
                    {
                        pessoaDTO pessoa = new pessoaDTO();
                        pessoa.prp_idPessoa = dados["idPessoa"].ToString();
                        pessoa.prp_nome = dados["nome"].ToString();
                        pessoa.prp_email = dados["email"].ToString();
                        pessoa.prp_userName = dados["UserName"].ToString();
                        pessoa.prp_senha = dados["senha"].ToString();
                        pessoa.prp_cargo = dados["cargo"].ToString();
                        pessoa.prp_dtNascimento = dados["dtNascimento"].ToString();
                        pessoa.prp_sexo = dados["sexo"].ToString();
                        pessoa.prp_telFixo = dados["telFixo"].ToString();
                        pessoa.prp_telCelular = dados["telCelular"].ToString();
                        pessoa.prp_ativo = dados["ativo"].ToString();
                        pessoa.prp_rg = dados["rg"].ToString();
                        pessoa.prp_cpf = dados["cpf"].ToString();

                        return pessoa;
                    }
                }
                throw new Exception("Usuario ou senha invalido!");
            }
            catch (Exception)
            //esse bloco e executado caso aconteça exceção no bloco try
            {
                throw new Exception("Erro de conexão, contate o suporte");
            }

            finally
            {
                if (Conexao.Conectar().State != ConnectionState.Closed)
                {
                    Conexao.Conectar().Close();
                }
            }
        }
    }
}
