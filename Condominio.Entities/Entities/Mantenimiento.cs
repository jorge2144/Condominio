﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Entities
{
    public class Mantenimiento
    {
        public int MantenimientoId { get; set; }
        public double Importe { get; set; }
        public string Descripcion { get; set; }

        //ServicioCompartido
        public int ServicioCompartidoId { get; set; }
        public ServicioCompartido ServicioCompartido { get; set; }

        //Insumo
        public int InsumoId { get; set; }
        public Insumo Insumo { get; set; }

        //Pagocompartido
        public int PagoCompartidoId { get; set; }
        public PagoCompartido PagoCompartido { get; set; }
    }
}
