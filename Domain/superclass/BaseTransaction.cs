using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain.superclass
{
    public abstract class BaseTransaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string State { get; set; }
        public bool Available { get; set; }


    }
}
