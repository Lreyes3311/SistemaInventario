using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio.IRespositorio
{
    public interface IRepositorio <T> where T : class
    {

<<<<<<< HEAD
        Task<T> Obtener(int id);

        Task<IEnumerable<T>> ObtenerTodos(
               Expression<Func<T, bool>> filtro = null,
               Func<IQueryable<T>,IOrderedQueryable<T>> orderBy = null,
               string incluirPropiedades = null, 
               bool isTracking = true   //Esto para acceder a un objeto y al mismo tiempo lo querramos modificar, para eso sirve
               );

        Task<T> ObtenerPrimero(
               Expression<Func<T, bool>> filtro = null,               
               string incluirPropiedades = null,
               bool isTracking = true 
            );

        Task Agregar(T entidad);
=======
        T Obtener(int id);

        IEnumerable<T> ObtenerTodos(
               Expression<Func<T, bool>> filtro = null,
               Func<IQueryable<T>,IOrderedQueryable<T>> orderBy = null,
               string incluirPropiedades = null, 
               bool isTracking = true
               );

        T ObtenerPrimero(
               Expression<Func<T, bool>> filtro = null,               
               string incluirPropiedades = null,
               bool isTracking = true
            );

        void Agregar(T entidad);
>>>>>>> 57ffefe2cb0cb096d34e0ccc8c22f38a4215f5b6

        void Remover(T entidad);

        void RemoverRango(IEnumerable<T> entidad);
    }
}
