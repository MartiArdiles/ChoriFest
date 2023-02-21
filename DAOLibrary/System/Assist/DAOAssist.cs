using entity_library.System.User;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.System.Assist
{
    public class DAOAssist
    {
		private ISession session;

		public DAOAssist(ISession session)
		{
			this.session = session;
		}

		public Assist.DAOAssist GetAssist(int id)
		{
			try
			{
				return this.session.Get<Assist.DAOAssist>(id);
			}
			catch (Exception ex)
			{
				throw new Exception("DAOLibrary.Assist.DAOAssist.GetAssist(int id): Error al obtener el item con id = " + id.ToString(), ex);
			}
		}

		public void EliminarUsuario(Assist.DAOAssist assist)
		{
			try
			{
				this.session.Delete(assist);
			}
			catch (Exception ex)
			{
				throw new Exception("DAOLibrary.Assist.DAOAssist.EliminarUsuario(Usuario usuario): Error al eliminar el usuario", ex);
			}
		}

		public IList<entity_library.System.Assist.Assist> GetAllAssist(
            string query,
            List<DAOLibrary.Utils.AtributoBusqueda> queryCols,
            DAOLibrary.Utils.Paginado paginado,
            DAOLibrary.Utils.Ordenamiento ordenamiento,
            out long cantidadTotal)

        {
            try
            {
                ICriteria lista = this.session.CreateCriteria<entity_library.System.Assist.Assist>("Assist");
                ICriteria cantidad = this.session.CreateCriteria<entity_library.System.Assist.Assist>("Assist");

                DAOLibrary.Utils.UtilidadesNHibernate.AgregarCriteriosDeBusqueda(queryCols, query, lista);
                DAOLibrary.Utils.UtilidadesNHibernate.AgregarCriteriosDeBusqueda(queryCols, query, cantidad);

                DAOLibrary.Utils.UtilidadesNHibernate.AgregarOrdenamiento(ordenamiento, lista);
                DAOLibrary.Utils.UtilidadesNHibernate.AgregarPaginado(paginado, lista);

                cantidadTotal = DAOLibrary.Utils.UtilidadesNHibernate.ObtenerCantidad(cantidad);

                IList<entity_library.System.Assist.Assist> retorno = lista.List<entity_library.System.Assist.Assist>();

                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("DAOLibrary.Assist.DAOAssist.ObtenerListaUsuario: Error al obtener el listado de items", ex);
            }
        }


        //public IList<Assist.DAOAssist> GetListAssist(
        //	string query,
        //	List<dao_library.Utils.AtributoBusqueda> queryCols,
        //	dao_library.Utils.Paginado paginado,
        //	dao_library.Utils.Ordenamiento ordenamiento,
        //	out long cantidadTotal)
        //{
        //	try
        //	{
        //		ICriteria lista = this.session.CreateCriteria<entity_library.Sistema.Usuario>("Usuario");
        //		ICriteria cantidad = this.session.CreateCriteria<entity_library.Sistema.Usuario>("Usuario");

        //		dao_library.Utils.UtilidadesNHibernate.AgregarCriteriosDeBusqueda(queryCols, query, lista);
        //		dao_library.Utils.UtilidadesNHibernate.AgregarCriteriosDeBusqueda(queryCols, query, cantidad);

        //		dao_library.Utils.UtilidadesNHibernate.AgregarOrdenamiento(ordenamiento, lista);
        //		dao_library.Utils.UtilidadesNHibernate.AgregarPaginado(paginado, lista);

        //		cantidadTotal = dao_library.Utils.UtilidadesNHibernate.ObtenerCantidad(cantidad);

        //		IList<entity_library.Sistema.Usuario> retorno = lista.List<entity_library.Sistema.Usuario>();

        //		return retorno;
        //	}
        //	catch (Exception ex)
        //	{
        //		throw new Exception("dao_library.Sistema.DAOUsuario.ObtenerListaUsuario: Error al obtener el listado de items", ex);
        //	}
        //}

        //public Usuario ObtenerUsuario(string userName, string password)
        //{
        //	ICriteria lista = this.session.CreateCriteria<entity_library.Sistema.Usuario>("Usuario");

        //	lista.Add(Restrictions.Eq("Usuario.NombreUsuario", userName));
        //	lista.Add(Restrictions.Eq("Usuario.Password", password));

        //	IList<entity_library.Sistema.Usuario> retorno = lista.List<entity_library.Sistema.Usuario>();

        //	if (retorno != null && retorno.Count > 0)
        //	{
        //		return retorno[0];
        //	}

        //	return null;
        //}

        //public IList<entity_library.Sistema.Usuario> ObtenerListaUsuario(
        //	string query,
        //	List<dao_library.Utils.AtributoBusqueda> queryCols,
        //	dao_library.Utils.Paginado paginado,
        //	dao_library.Utils.Ordenamiento ordenamiento,
        //	List<dao_library.Utils.Asociacion> asociaciones,
        //	out long cantidadTotal)
        //{
        //	try
        //	{
        //		ICriteria lista = this.session.CreateCriteria<entity_library.Sistema.Usuario>("Usuario");
        //		ICriteria cantidad = this.session.CreateCriteria<entity_library.Sistema.Usuario>("Usuario");

        //		dao_library.Utils.UtilidadesNHibernate.CrearAsociaciones(asociaciones, lista);
        //		dao_library.Utils.UtilidadesNHibernate.CrearAsociaciones(asociaciones, cantidad);

        //		dao_library.Utils.UtilidadesNHibernate.AgregarCriteriosDeBusqueda(queryCols, query, lista);
        //		dao_library.Utils.UtilidadesNHibernate.AgregarCriteriosDeBusqueda(queryCols, query, cantidad);

        //		dao_library.Utils.UtilidadesNHibernate.AgregarOrdenamiento(ordenamiento, lista);
        //		dao_library.Utils.UtilidadesNHibernate.AgregarPaginado(paginado, lista);

        //		cantidadTotal = dao_library.Utils.UtilidadesNHibernate.ObtenerCantidad(cantidad);

        //		IList<entity_library.Sistema.Usuario> retorno = lista.List<entity_library.Sistema.Usuario>();

        //		return retorno;
        //	}
        //	catch (Exception ex)
        //	{
        //		throw new Exception("dao_library.Sistema.DAOUsuario.ObtenerListaUsuario: Error al obtener el listado de items", ex);
        //	}
        //}
        //public User ObtenerUsuario(string userName, string password)
        //{
        //    ICriteria lista = this.session.CreateCriteria<entity_library.System.User.User>("Usuario");

        //    lista.Add(Restrictions.Eq("User.Name", userName));
        //    lista.Add(Restrictions.Eq("User.Password", password));

        //    IList<entity_library.System.User.User> retorno = lista.List<entity_library.System.User.User>();

        //    if (retorno != null && retorno.Count > 0)
        //    {
        //        return retorno[0];
        //    }

        //    return null;
        //}

        public void SaveAssist(entity_library.System.Assist.Assist item)
		{
			try
			{
				this.session.Save(item);
			}
			catch (Exception ex)
			{
				throw new Exception("DAOLibrary.Assist.DAOAssist.Guardar: Error al guardar el item.", ex);
			}
		}
	}
}
