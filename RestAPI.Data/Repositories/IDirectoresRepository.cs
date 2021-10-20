using RestAPI.Data.Entities;
using RestAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Data.Repositories
{
    public interface IDirectoresRepository
    {
        Director ObtenerDirector(Guid idDirector);
        IEnumerable<Director> ObtenerDirectores();
        void CrearDirector(Director director);
        public void Guardar();
    }
}
