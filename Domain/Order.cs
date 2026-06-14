using Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain.superclass;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Security.Permissions;

namespace Proyecto_Asados_La_Flaca_Versión_1._1_Completo.Domain
{
    public class Order : BaseTransaction
    {

            public int OrderId { get; set; }
            public string OrderCode { get; set; }
            public int CustomerId { get; set; }
            public int EmployeeId { get; set; }
            public string Observations { get; set; }
            public DateTime Date { get; set; }
            public string State{ get; set; }
       
           public List<OrderDetail> Detalles { get; set; } = new List<OrderDetail>();
 
            public bool EsValido()
            {
                return CustomerId > 0 && EmployeeId > 0 && Detalles.Count > 0;
            }
        }


    }
