using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_ProjetoDS;
using DTO_ProjetoDS;

namespace BLL_ProjetoDS
{
    public class LoginBLL
    {
    

        public static pessoaDTO vldLogin(loginDTO obj)
        {
       
            if (string.IsNullOrWhiteSpace(obj.prpUsuario))
            {
                throw new Exception ("Informe seu nome de Usuário ou E-mail");
            }
            if (string.IsNullOrWhiteSpace(obj.prpSenha))
            {
                throw new Exception ("Informe sua Senha");
            }

            return Login_DAL.vldLogin(obj);

        }

    }
}
