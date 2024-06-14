using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmnExamen.Dtos
{
    internal class PropietariosDtos
    {
        long id;

        string dni = "aaaaa";

        DateTime fechaCompra = new DateTime(1999 / 29 / 12);

        string matricula = "aaaaa";

        bool esHistorico = false;


        public long Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public bool EsHistorico { get => esHistorico; set => esHistorico = value; }

        public PropietariosDtos(long id, string dni, DateTime fechaCompra, string matricula, bool esHistorico)
        {
            this.id = id;
            this.dni = dni;
            this.fechaCompra = fechaCompra;
            this.matricula = matricula;
            this.esHistorico = esHistorico;
        }


        public PropietariosDtos() { }

        override
        public string ToString()
        {
            string datosUsuario = this.id + "-" + this.dni;

            return datosUsuario;
        }

    }
}
