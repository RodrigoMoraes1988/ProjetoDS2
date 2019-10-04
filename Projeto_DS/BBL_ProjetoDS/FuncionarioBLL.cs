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

            return null;
        }
        
    }
}
