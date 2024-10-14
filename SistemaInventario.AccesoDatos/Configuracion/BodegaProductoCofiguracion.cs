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
    public class BodegaProductoCofiguracion : IEntityTypeConfiguration<BodegaProducto>
    {
        public void Configure(EntityTypeBuilder<BodegaProducto> builder)
        {
            builder.Property(X => X.Id).IsRequired();
            builder.Property(X => X.BodegaId).IsRequired();
            builder.Property(X => X.ProductoId).IsRequired();
            builder.Property(X => X.Cantidad).IsRequired();

            /*  Relaciones */
            builder.HasOne(x => x.Bodega).WithMany()
                .HasForeignKey(x => x.BodegaId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Producto).WithMany()
                .HasForeignKey(x => x.ProductoId)
                .OnDelete(DeleteBehavior.NoAction);

        }

    }
}
