using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento
{
    class Funcionarios
    {
        protected string _nome;
        protected string _dataNascimento;
        protected int _quantidadeFilhos;
        protected double _salarioBase;
        protected int _comissao;
        protected double _salarioComissao;

        public double calculoComissao(double comissao,double salarioBase)
        {
            double salarioComissao;
            comissao = comissao / 100;
            return salarioComissao = (salarioBase * comissao)+SalarioBase;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public string DataNascimento
        {
            get
            {
                return _dataNascimento;
            }

            set
            {
                _dataNascimento = value;
            }
        }

        public int QuantidadeFilhos
        {
            get
            {
                return _quantidadeFilhos;
            }

            set
            {
                _quantidadeFilhos = value;
            }
        }

        public double SalarioBase
        {
            get
            {
                return _salarioBase;
            }

            set
            {
                _salarioBase = value;
            }
        }

        public int Comissao
        {
            get
            {
                return _comissao;
            }

            set
            {
                _comissao = value;
            }
        }

        public double SalarioComissao
        {
            get
            {
                return _salarioComissao;
            }

            set
            {
                _salarioComissao = value;
            }
        }
    }
}
