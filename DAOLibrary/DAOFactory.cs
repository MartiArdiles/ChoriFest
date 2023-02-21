using System;
using DAOLibrary.Fest;
using DAOLibrary.System.Assist;
using NHibernate;


namespace DAOLibrary
{
    public class DAOFactory: IDisposable
    {
		#region atributos privados
		private ISession session = null;
		private ITransaction transaction = null;
		#endregion

		#region Constructor
		public DAOFactory()
		{
			this.session = Database.Instance.SessionFactory.OpenSession();
		}
		#endregion

		#region métodos de la base de datos
		public bool BeginTrans()
		{
			try
			{
				this.transaction = this.session.BeginTransaction();
				return true;
			}
			catch (Exception e)
			{
				throw new Exception(
					"DAOLibrary.DAOFactory.BeginTrans()",
					e);
			}
		}
		public bool Commit()
		{
			try
			{
				this.transaction.Commit();

				this.transaction = null;

				return true;
			}
			catch (Exception e)
			{
				throw new Exception(
					"DAOLibrary.DAOFactory.Commit()",
					e);
			}
		}

		public void Rollback()
		{
			try
			{
				if (this.transaction == null || !this.transaction.IsActive) return;

				this.transaction.Rollback();

				this.transaction = null;
			}
			catch (Exception e)
			{
				throw new Exception("DAOLibrary.DAOFactory.Rollback()", e);
			}
		}

		public void Close()
		{
			try
			{
				if (this.transaction != null && this.transaction.IsActive)
				{
					this.transaction.Rollback();
				}

				this.session.Close();
			}
			catch (Exception e)
			{
				throw new Exception("DAOLibrary.DAOFactory.Close()", e);
			}
		}

		public void Dispose()
		{
			try
			{
				this.Close();
			}
			catch (Exception e)
			{
				throw new Exception("DAOLibrary.DAOFactory.Dispose()", e);
			}
		}
        #endregion

        #region DAOs: Agregar los DAOs de ustedes
        private DAOUser DaoUserInstance= null;
        public DAOUser DAOUsuario
        {
            get
            {
                if (this.DaoUserInstance == null)
                {
                    this.DaoUserInstance = new DAOUser(this.session);
                }

                return DaoUserInstance;
            }
        }
		private DAOChorifest DaoChorifestInstance = null;
		public DAOChorifest DAOChorifest
		{
			get
			{
				if (this.DaoChorifestInstance == null)
				{
					this.DaoChorifestInstance = new DAOChorifest(this.session);
				}

				return DaoChorifestInstance;
			}
		}

		private DAOMenu DaoMenuChoriInstance = null;
		public DAOMenu DaoMenu
		{
			get
			{
				if (this.DaoMenuChoriInstance == null)
				{
					this.DaoMenuChoriInstance = new DAOMenu(this.session);
				}

				return DaoMenuChoriInstance;
			}
		}

		private DAOAssist DaoAssistInstance = null;
		public DAOAssist DaoAssist
		{
			get
			{
				if (this.DaoAssistInstance == null)
				{
					this.DaoAssistInstance = new DAOAssist(this.session);
				}

				return DaoAssistInstance;
			}
		}
		#endregion
	}
}
