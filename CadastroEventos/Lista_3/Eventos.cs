using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_3
{
    class Eventos
    {
        protected string _titulo;
        protected DateTime _data;
        protected DateTime _horaInicial;
        protected DateTime _horaFinal;
        protected string _descricao;

        public string Titulo
        {
            get
            {
                return _titulo;
            }

            set
            {
                _titulo = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return _data;
            }

            set
            {
                _data = value;
            }
        }

        public DateTime HoraInicial
        {
            get
            {
                return _horaInicial;
            }

            set
            {
                _horaInicial = value;
            }
        }

        public DateTime HoraFinal
        {
            get
            {
                return _horaFinal;
            }

            set
            {
                _horaFinal = value;
            }
        }

        public string Descricao
        {
            get
            {
                return _descricao;
            }

            set
            {
                _descricao = value;
            }
        }
    }
}
