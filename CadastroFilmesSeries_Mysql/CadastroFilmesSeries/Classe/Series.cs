using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFilmesSeries
{
    class Series : dadosFilmesSeries
    {
        private string _temporadas;

        public string Temporadas
        {
            get
            {
                return _temporadas;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _temporadas = value;
                }
                else
                {
                    throw new Exception("A temporada não pode ser vazio.");
                }
            }
        }
    }
}
