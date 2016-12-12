﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkEscola.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace EntityFrameworkEscola.DataAccess.Map
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");
            HasKey(x => x.UsuarioId);
            Property(x => x.Email).IsRequired().HasMaxLength(150);
            Property(u => u.Senha).HasMaxLength(20).IsRequired();
        }
    }
}
