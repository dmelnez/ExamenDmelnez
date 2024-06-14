using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmnExamen.Dtos
{
    internal class VehiculosDtos
    {
        long id;

        string matricula = "aaaaa";

        DateTime fechaMatriculacio = new DateTime(1999 / 29 / 12);



        public long Id { get => id; set => id = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public DateTime FechaMatriculacio { get => fechaMatriculacio; set => fechaMatriculacio = value; }

        public VehiculosDtos(long id, string matricula, DateTime fechaMatriculacio, string dni)
        {
            this.id = id;
            this.matricula = matricula;
            this.fechaMatriculacio = fechaMatriculacio;
        }

        public VehiculosDtos() { }
    }
}
