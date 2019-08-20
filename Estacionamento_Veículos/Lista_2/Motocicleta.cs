using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2
{
    class Motocicleta:Veiculo
    {
        private int _cilindradas;
        private bool _temFreioDisco;
        private bool _temPartidaEletrica;
        private bool _temPortaCapacete;

        public int Cilindradas
        {
            get
            {
                return _cilindradas;
            }

            set
            {
                _cilindradas = value;
            }
        }

        public bool TemFreioDisco
        {
            get
            {
                return _temFreioDisco;
            }

            set
            {
                _temFreioDisco = value;
            }
        }

        public bool TemPartidaEletrica
        {
            get
            {
                return _temPartidaEletrica;
            }

            set
            {
                _temPartidaEletrica = value;
            }
        }

        public bool TemPortaCapacete
        {
            get
            {
                return _temPortaCapacete;
            }

            set
            {
                _temPortaCapacete = value;
            }
        }
    }
}
