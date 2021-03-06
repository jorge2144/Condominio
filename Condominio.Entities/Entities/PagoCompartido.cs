﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class PagoCompartido
    {
        public int PagoCompartidoId { get; set; }
        public int CodPago { get; set; }
        public double Total { get; set; }

        //Departamento
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }

        //Luz
        public int LuzId { get; set; }
        public Luz Luz { get; set; }

        //Agua
        public int AguaId { get; set; }
        public Agua Agua { get; set; }

        //Vigilancia
        public int VigilanciaId { get; set; }
        public Vigilancia Vigilancia { get; set; }

        //Gas
        public int GasId { get; set; }
        public Gas Gas { get; set; }

        //Mantenimiento
        public int MantenimientoId { get; set; }
        public Mantenimiento Mantenimiento { get; set; }

        //EstadopagoServBasico
        public int EstadoPagoServBasicoId { get; set; }
        public EstadoPagoServBasico EstadoPagoServBasico { get; set; }
    }
}
