using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2
{
    class Veiculo
    {
        //long.parse
        protected int _capacidadeTanque;
        protected int _placa;
        protected string _proprietario;
        protected DateTime horaEntrada;
        protected DateTime horaSaida;
        protected double _total;

        public int CapacidadeTanque
        {
            get
            {
                return _capacidadeTanque;
            }

            set
            {
                _capacidadeTanque = value;
            }
        }

        public int Placa
        {
            get
            {
                return _placa;
            }
            set
            {
                _placa = value;
            }
        }

        public string Proprietario
        {
            get
            {
                return _proprietario;
            }
            set
            {
                _proprietario = value;
            }
        }

        public double Comprimento { get; set; }
        public string Cor { get; set; }
        public double Largura { get; set; }
        public string Modelo { get; set; }
        public double Peso { get; set; }
        public double VelocidadeAtual { get; set; }

        public DateTime HoraEntrada
        {
            get
            {
                return horaEntrada;
            }

            set
            {
                horaEntrada = value;
            }
        }

        public DateTime HoraSaida
        {
            get
            {
                return horaSaida;
            }

            set
            {
                horaSaida = value;
            }
        }

        public double Total
        {
            get
            {
                return _total;
            }

            set
            {
                _total = value;
            }
        }

        public void  Acelerar()
        {

        }

        public void Freiar()
        {

        }
    }
}
