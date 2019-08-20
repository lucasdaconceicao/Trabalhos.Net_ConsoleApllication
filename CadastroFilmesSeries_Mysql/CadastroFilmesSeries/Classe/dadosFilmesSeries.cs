using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFilmesSeries
{
    abstract class dadosFilmesSeries
    {
        protected string _nome;
        protected string _classificacao;
        protected string _duracao;
        protected string _diretor;
        protected string _estudio;

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {

                if (!String.IsNullOrEmpty(value))
                {
                    _nome = value;
                }
                else
                {
                    throw new Exception("O nome não pode ser vazio.");
                }
            }
        }

        public string Classificacao
        {
            get
            {
                return _classificacao;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _classificacao = value;
                }
                else
                {
                    throw new Exception("A classificação não pode ser vazio.");
                }
            }
        }

        public string Duracao
        {
            get
            {
                return _duracao;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _duracao = value;
                }
                else
                {
                    throw new Exception("A duração não pode ser vazio.");
                }
            }
        }

        public string Diretor
        {
            get
            {
                return _diretor;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _diretor = value;
                }
                else
                {
                    throw new Exception("O diretor não pode ser vazio.");
                }
            }
        }

        public string Estudio
        {
            get
            {
                return _estudio;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _estudio = value;
                }
                else
                {
                    throw new Exception("O estúdio não pode ser vazio.");
                }
            }
        }
    }
}
