using CourseLibrary.API.DbContexts;
using RestAPI.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Data.Repositories
{
    public class DirectoresRepository : IDirectoresRepository
    {
        private readonly CineContext _context;

        public DirectoresRepository(CineContext context)
        {
            _context = context;
        }

        public void CrearDirector(Director director)
        {
            if (director == null)
            {
                throw new ArgumentNullException(nameof(director));
            }
            director.Id = Guid.NewGuid();
            _context.Directores.Add(director);
        }

        public void Guardar()
        {
            _context.SaveChanges();
        }

        public Director ObtenerDirector(Guid idDirector)
        {
            if (idDirector == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(idDirector));
            }

            return _context.Directores.Where(d => d.Id == idDirector).FirstOrDefault();
        }

        public IEnumerable<Director> ObtenerDirectores()
        {
            return _context.Directores.ToList();
        }

        public bool ExisteDirector(Guid idDirector)
        {
            if (idDirector == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(idDirector));
            }
            return _context.Directores.Any(d => d.Id == idDirector);
        }
    }
}
