﻿using Condominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Persistence.EntitiesConfiguration
{
    public class EstadoPagoServBasicoConfiguration : EntityTypeConfiguration<EstadoPagoServBasico>
    {
        public EstadoPagoServBasicoConfiguration()
        {
            //table configuration
            ToTable("EstadopagoServBasico");
            HasKey(m => m.EstadoPagoServBasicoId);
        }
    }
}
