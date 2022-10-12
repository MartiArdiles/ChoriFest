using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLibrary.Utils
{
    public class UtilidadesNHibernate
    {
		public static JoinType ObtenerTipoJoin(TipoJoin tipoJoin)
		{
			if (tipoJoin == TipoJoin.FullJoin)
			{
				return JoinType.FullJoin;
			}
			else if (tipoJoin == TipoJoin.InnerJoin)
			{
				return JoinType.InnerJoin;
			}
			else if (tipoJoin == TipoJoin.LeftOuterJoin)
			{
				return JoinType.LeftOuterJoin;
			}
			else if (tipoJoin == TipoJoin.None)
			{
				return JoinType.None;
			}
			else if (tipoJoin == TipoJoin.RightOuterJoin)
			{
				return JoinType.RightOuterJoin;
			}
			else return JoinType.CrossJoin;
		}

		public static void CrearAsociaciones(
			List<Asociacion> asociaciones,
			ICriteria criterio)
		{
			if (asociaciones == null) return;

			foreach (Asociacion asociacion in asociaciones)
			{
				JoinType nhJoinType =
					UtilidadesNHibernate.ObtenerTipoJoin(asociacion.TipoJoin);

				criterio.CreateAlias(
					asociacion.RutaDeAsociacion,
					asociacion.Alias,
					nhJoinType);
			}
		}

		public static void AgregarCriteriosDeBusqueda(
			List<AtributoBusqueda> atributosBusqueda,
			string query,
			ICriteria criteria)
		{
			if (atributosBusqueda == null || query == null) return;

			ICriterion criterio = null;
			foreach (AtributoBusqueda atributoBusqueda in atributosBusqueda)
			{
				ICriterion criterioTmp = null;
				if (atributoBusqueda.TipoDato == TipoDato.String)
				{
					criterioTmp = Restrictions.Like(
						atributoBusqueda.NombreAtributo,
							$"%{query}%");
				}
				else if (atributoBusqueda.TipoDato == TipoDato.Int32)
				{
					int nro = 0;
					if (int.TryParse(query, out nro))
					{
						criterioTmp = Restrictions.Eq(
							atributoBusqueda.NombreAtributo,
							nro);
					}
				}
				else if (atributoBusqueda.TipoDato == TipoDato.Int64)
				{
					long nro = 0;
					if (long.TryParse(query, out nro))
					{
						criterioTmp = Restrictions.Eq(
							atributoBusqueda.NombreAtributo,
							nro);
					}
				}
				else if (atributoBusqueda.TipoDato == TipoDato.Float)
				{
					float nro = 0;
					if (float.TryParse(query, out nro))
					{
						criterioTmp = Restrictions.Eq(
							atributoBusqueda.NombreAtributo,
							nro);
					}
				}
				else if (atributoBusqueda.TipoDato == TipoDato.Double)
				{
					double nro = 0;
					if (double.TryParse(query, out nro))
					{
						criterioTmp = Restrictions.Eq(
							atributoBusqueda.NombreAtributo,
							nro);
					}
				}
				else if (atributoBusqueda.TipoDato == TipoDato.Boolean)
				{
					bool boolean = false;
					if (bool.TryParse(query, out boolean))
					{
						criterioTmp = Restrictions.Eq(
							atributoBusqueda.NombreAtributo,
							boolean);
					}
				}
				else if (atributoBusqueda.TipoDato == TipoDato.StringClob)
				{
					criterioTmp = Restrictions.Like(
						atributoBusqueda.NombreAtributo,
							$"%{query}%");
				}
				else if (atributoBusqueda.TipoDato == TipoDato.DateTime)
				{
					DateTime dateTime = DateTime.MinValue;
					if (DateTime.TryParse(query, out dateTime))
					{
						criterioTmp = Restrictions.Eq(
							atributoBusqueda.NombreAtributo,
							dateTime);
					}
				}

				if (criterioTmp != null)
				{
					if (criterio == null) criterio = criterioTmp;
					else criterio = Restrictions.Or(criterio, criterioTmp);
				}
			}

			if (criterio != null)
			{
				criteria.Add(criterio);
			}
		}

		public static void AgregarOrdenamiento(
			Ordenamiento ordenamiento,
			ICriteria criterio)
		{
			if (ordenamiento == null) return;

			Order order = new Order(
				ordenamiento.Atributo,
				!ordenamiento.Direccion.Trim().ToUpper().Equals("DESC"));

			criterio.AddOrder(order);
		}

		public static void AgregarPaginado(
			Paginado paginado,
			ICriteria lista)
		{
			if (paginado == null) return;
			lista
				.SetFirstResult(paginado.Comienzo)
				.SetMaxResults(paginado.Cantidad);
		}

		public static long ObtenerCantidad(ICriteria cantidad)
		{
			long cantidadTotal;
			cantidad.SetProjection(Projections.RowCountInt64());
			cantidadTotal = (long)cantidad.UniqueResult();
			return cantidadTotal;
		}
	}
}
