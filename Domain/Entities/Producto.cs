using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string  Nombre { get; set; }
         public string Descriccion { get; set; }

        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public DateTime caducidad { get; set; }

        public UnidadMedida medida { get; set; }
}
}
