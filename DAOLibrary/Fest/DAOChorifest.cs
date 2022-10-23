using entity_library.Fest;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.Fest
{
    public class DAOChorifest
    {
        private ISession session;

        public DAOChorifest(ISession session)
        {
            this.session = session;
        }

		public Chorifest GetChorifest(int id)
		{
			try
			{
				var chorifest = session.QueryOver<Chorifest>().Where(x => x.Id == id).SingleOrDefault<Chorifest>();

				return chorifest;

			}
			catch (Exception ex)
			{
				throw new Exception("DAOlibrary.Chorifest.DAOChorifest.GetChorifest(int id): Error al obtener el chorifest con id = ", ex);
			}
		}

		public IList<Chorifest> GetListChorifestPaginated(
			string query,
			List<DAOLibrary.Utils.AtributoBusqueda> queryCols,
			DAOLibrary.Utils.Paginado paginado,
			DAOLibrary.Utils.Ordenamiento ordenamiento,
			List<DAOLibrary.Utils.Asociacion> asociaciones,
			out long cantidadTotal)
		{
			try
			{
				ICriteria lista = this.session.CreateCriteria<Chorifest>("ChoriFest");
				ICriteria cantidad = this.session.CreateCriteria<Chorifest>("ChoriFest");

				DAOLibrary.Utils.UtilidadesNHibernate.CrearAsociaciones(asociaciones, lista);
				DAOLibrary.Utils.UtilidadesNHibernate.CrearAsociaciones(asociaciones, cantidad);

				DAOLibrary.Utils.UtilidadesNHibernate.AgregarCriteriosDeBusqueda(queryCols, query, lista);
				DAOLibrary.Utils.UtilidadesNHibernate.AgregarCriteriosDeBusqueda(queryCols, query, cantidad);

				DAOLibrary.Utils.UtilidadesNHibernate.AgregarOrdenamiento(ordenamiento, lista);
				DAOLibrary.Utils.UtilidadesNHibernate.AgregarPaginado(paginado, lista);

				cantidadTotal = DAOLibrary.Utils.UtilidadesNHibernate.ObtenerCantidad(cantidad);

				IList<Chorifest> retorno = lista.List<Chorifest>();

				return retorno;
			}
			catch (Exception ex)
			{
				throw new Exception("DAOLibrary.Chorifest.DAOChorifest.GetListChorifest: Error al obtener el listado de Chorifest", ex);
			}
		}


		public async Task<IEnumerable<Chorifest>> GetListChorifest()
        {
			try
			{
				var ChorifestList = await session.QueryOver<Chorifest>().ListAsync<Chorifest>();

				return ChorifestList;

			}
			catch (Exception ex)
			{
				throw new Exception("DAOLibrary.Chorifest.DAOChorifest.GetListChorifest: Error al obtener el listado de Chorifest", ex);
			}

		}

		public void SaveChorifest(Chorifest Chorifest)
		{
			try
			{
				this.session.Save(Chorifest);
			}
			catch (Exception ex)
			{
				throw new Exception("DAOLibrary.Chorifest.DAOChorifest.SaveChorifest: Error al guardar el item.", ex);
			}
		}
	}
}
