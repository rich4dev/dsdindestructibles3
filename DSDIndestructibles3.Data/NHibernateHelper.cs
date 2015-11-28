using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Cfg;

namespace DSDIndestructibles3.Data
{
    public class NHibernateHelper
    {
        private static ISessionFactory _Fabrica;

        private static ISessionFactory Fabrica
        {
            get
            {
                if (_Fabrica == null)
                {
                    var _Conf = new Configuration();
                    _Conf.SetProperty("connection.provider", "NHibernate.Connection.DriverConnectionProvider");
                    _Conf.SetProperty("connection.driver_class", "NHibernate.Driver.SqlClientDriver");
                    _Conf.SetProperty("connection.connection_string", ConexionUtil.ObtenerCadena());
                    _Conf.SetProperty("adonet.batch_size", "10");
                    _Conf.SetProperty("show_sql", "true");
                    _Conf.SetProperty("dialect", "NHibernate.Dialect.MsSql2000Dialect");
                    _Conf.SetProperty("command_timeout", "60");
                    _Conf.SetProperty("query.substitutions", "true 1, false 0, yes 'Y', no 'N'");
                    _Conf.AddAssembly(typeof(NHibernateHelper).Assembly);
                    _Fabrica = _Conf.BuildSessionFactory();
                }
                return _Fabrica;
            }
        }
        public static ISession ObtenerSesion()
        {
            return Fabrica.OpenSession();
        }
        public static void CerrarFabrica()
        {
            _Fabrica = null;
        }
    }
}
