using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2
{
    class Automovel:Veiculo
    {
        private int _ocupantes;
        private int _qntdPortas;
        private int _volumePortaMalas;

        public int Ocupantes
        {
            get
            {
                return _ocupantes;
            }

            set
            {
                _ocupantes = value;
            }
        }

        public int QntdPortas
        {
            get
            {
                return _qntdPortas;
            }

            set
            {
                _qntdPortas = value;
            }
        }

        public int VolumePortaMalas
        {
            get
            {
                return _volumePortaMalas;
            }

            set
            {
                _volumePortaMalas = value;
            }
        }
    }
}
