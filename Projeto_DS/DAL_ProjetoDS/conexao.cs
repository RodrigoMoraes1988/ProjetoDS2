using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_ProjetoDS
{
    class Conexao
    {
        public static SqlConnection Conectar()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjetoDS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                conn.Open();
                return conn;
            }
            catch(Exception ex)
            {
                throw new Exception("Não foi possivel conectar. Tente novamente!!\n" + ex.Message);
            }
        }
    }
}
