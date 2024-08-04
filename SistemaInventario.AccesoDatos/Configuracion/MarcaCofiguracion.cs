using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaInventario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Configuracion
{
    public class MarcaCofiguracion : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.Property(X => X.Id).IsRequired();
            builder.Property(X => X.Nombre).IsRequired().HasMaxLength(60);
            builder.Property(X => X.Descripcion).IsRequired().HasMaxLength(100);
            builder.Property(X => X.Estado).IsRequired();
        }

    }
}
