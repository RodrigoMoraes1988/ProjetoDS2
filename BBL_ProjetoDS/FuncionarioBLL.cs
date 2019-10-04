using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ProjetoDS;
using DAL_ProjetoDS;

namespace BBL_ProjetoDS
{
    class FuncionarioBLL
    {
        public static string CadFuncionario(pessoaDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.prp_nome))
            {
                throw new Exception("Campo Nome vazio!!");
            }

            if (string.IsNullOrWhiteSpace(obj.prp_cpf))
            {
                throw new Exception("Campo CPF vazio!!");
            }
            if (obj.prp_cpf.Length != 11)
            {
                throw new Exception("Campo CPF precisa conter 11 digitos!!");
            }
            try
            {
                Int64.Parse(obj.prp_cpf);
            }
            catch
            {
                throw new Exception("Campo CPF deve conter apenas numeros!!");
            }

            try
            {
                Convert.ToDateTime(obj.prp_dtNascimento);
            }
            catch
            {
                throw new Exception("Digite uma data no formato dd/mm/aaaa !!");
            }
                                             
            DateTime dataAtual = DateTime.Today;
            if (Convert.ToDateTime(obj.prp_dtNascimento) > dataAtual)
            {
                throw new Exception("Data de nascimento deve ser menor que a data atual!!");
            }

            if(obj.prp_telFixo != "")
            {
                if(obj.prp_telFixo.Length < 10)
                {
                    throw new Exception("Numero invalido!!");
                }
            }

            if (string.IsNullOrWhiteSpace(obj.prp_telCelular))
            {
                throw new Exception("Preencha o numero de telefone movel!!");
            }
            if (obj.prp_telCelular.Length < 11)
            {
                throw new Exception("Numero invalido!!");
            }

            if(string.IsNullOrWhiteSpace(obj.prp_endereco))
            {
                throw new Exception("Digite seu endereço!!");
            }
            if(string.IsNullOrWhiteSpace(obj.prp_numero))
            {
                throw new Exception("Digite o numero do imovel!!");
            }
            if (string.IsNullOrWhiteSpace(obj.prp_bairro))
            {
                throw new Exception("Digite o bairro!!");
            }
            if (string.IsNullOrWhiteSpace(obj.prp_cidade))
            {
                throw new Exception("Digite a cidade!!");
            }
            if (string.IsNullOrWhiteSpace(obj.prp_uf))
            {
                throw new Exception("Selecione a UF!!");
            }

            if (string.IsNullOrWhiteSpace(obj.prp_cep))
            {
                throw new Exception("Preencha o CEP!!");
            }
            if(obj.prp_cep.Length < 8)
            {
                throw new Exception("Numero de CEP invalido!");
            }

            if (string.IsNullOrWhiteSpace(obj.prp_rg))
            {
                throw new Exception("Digite o numero do RG!!");
            }
            if (string.IsNullOrWhiteSpace(obj.prp_sexo))
            {
                throw new Exception("Selecione o sexo do funcionario!!");
            }
            if (string.IsNullOrWhiteSpace(obj.prp_ativo))
            {
                throw new Exception("Selecione o Status!!");
            }
            return null;
        }
        
    }
}
