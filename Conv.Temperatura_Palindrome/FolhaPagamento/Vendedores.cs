using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
{
    class Vendedores:Funcionarios
    {
        public static bool cadastrarvendedor(Vendedores[] listarVendedores, Vendedores cadastro)
        {
            for (int i = 0; i < listarVendedores.Length; i++)
            {
                if (listarVendedores[i] == null)
                {
                    listarVendedores[i] = cadastro;
                    return true;
                }
            }
            return false;
        }
        public static Vendedores buscarVendedores(Vendedores[] listarVendedores, string nome)
        {
            for (int i = 0; i < listarVendedores.Length; i++)
            {
                if (listarVendedores[i].Nome == nome)
                {
                    return listarVendedores[i];
                }
            }
            return null;
        }
    }
}
