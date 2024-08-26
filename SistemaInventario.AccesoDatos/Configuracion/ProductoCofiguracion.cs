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
    public class ProductoCofiguracion : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.Property(X => X.Id).IsRequired();
            builder.Property(X => X.NumeroSerie).IsRequired().HasMaxLength(60);
            builder.Property(X => X.Descripcion).IsRequired().HasMaxLength(100);
            builder.Property(X => X.Estado).IsRequired();
            builder.Property(X => X.Precio).IsRequired();
            builder.Property(X => X.Costo).IsRequired();
            builder.Property(X => X.CategoriaId).IsRequired();
            builder.Property(X => X.MarcaId).IsRequired();
            builder.Property(X => X.ImagenURL).IsRequired(false);
            builder.Property(X => X.PadreId).IsRequired(false);

            /*  Relaciones */

            builder.HasOne(X => X.Categoria).WithMany()
                .HasForeignKey(X => X.CategoriaId)
                .OnDelete(DeleteBehavior.NoAction);
                

            builder.HasOne(X => X.Marca).WithMany()
                .HasForeignKey(X => X.MarcaId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(X=>X.Padre).WithMany()
                .HasForeignKey(X=>X.PadreId)
                .OnDelete(DeleteBehavior.NoAction);
        }

    }
}
