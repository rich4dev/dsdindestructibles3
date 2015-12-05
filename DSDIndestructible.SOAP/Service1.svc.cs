using DSDIndestructibles3.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DSDIndestructible.SOAP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string GetData(SolicitudAfiliacion solicitud)
        {
            SqlConnection objConnection = new SqlConnection();
            DataSet ObjDataset = new DataSet();
            SqlDataAdapter objAdapater = new SqlDataAdapter();
            SqlCommand objCommand = new SqlCommand("sp_SolicitudAfiliacion_I01", objConnection);

            objConnection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CnnSQL"].ToString();
            objConnection.Open();
            SqlTransaction trans = objConnection.BeginTransaction(IsolationLevel.ReadCommitted);
            objCommand.Connection = objConnection;


            SolicitudAfiliacion _Be = (SolicitudAfiliacion)solicitud;//pasarle la entidad
            objCommand.Transaction = trans;
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.Parameters.Add("@ruc", SqlDbType.VarChar).Value = _Be.SRUC;
            objCommand.Parameters.Add("@razonsocial", SqlDbType.VarChar).Value = _Be.SRAZO_SOCI;
            objCommand.Parameters.Add("@nombrcomercial", SqlDbType.VarChar).Value = _Be.SNOMB_COME;
            objCommand.Parameters.Add("@direccioncomercial", SqlDbType.VarChar).Value = _Be.SDIRE_COME;
            objCommand.Parameters.Add("@direccionadmin", SqlDbType.VarChar).Value = _Be.SDIRE_ADMI;
            objCommand.Parameters.Add("@reprelegal1", SqlDbType.VarChar).Value = _Be.SREPR_LEGA_1;
            objCommand.Parameters.Add("@reprelegal2", SqlDbType.VarChar).Value = _Be.SREPR_LEGA_2;
            objCommand.Parameters.Add("@personcontactoventa", SqlDbType.VarChar).Value = _Be.SPERS_CONT;
            objCommand.Parameters.Add("@numerocuentabancaria", SqlDbType.VarChar).Value = _Be.SNUME_CUEN;
            objCommand.Parameters.Add("@tipocuenta", SqlDbType.VarChar).Value = _Be.STIPO_CUEN;
            objCommand.Parameters.Add("@tipomoneda", SqlDbType.VarChar).Value = _Be.SMONE;
            objCommand.Parameters.Add("@entidadfinan", SqlDbType.VarChar).Value = _Be.SENTI_FINA;
            objCommand.Parameters.Add("@tipoafiliacion", SqlDbType.VarChar).Value = _Be.STIPO_AFIL;
            objCommand.Parameters.Add("@tipoproducto", SqlDbType.VarChar).Value = _Be.STIPO_PROD;
            objCommand.Parameters.Add("@tipocomunicacion", SqlDbType.VarChar).Value = _Be.STIPO_COMU;
            objCommand.Parameters.Add("@fechainstal", SqlDbType.VarChar).Value = _Be.SFECH_INST;	
            objCommand.ExecuteNonQuery();
            trans.Commit();
            objConnection.Close();
            return "salio";
        }

        public SolicitudAfiliacion GetDataUsingDataContract(string ruc)
        {
            
            SqlConnection objConnection = new SqlConnection();
            DataSet ObjDataset = new DataSet();
            SqlDataAdapter objAdapater = new SqlDataAdapter();
            SqlCommand objCommand = new SqlCommand
            ("Select SolicitudAfiliacionID,RUC,RazonSocial,NombreComercial,DireccionComercial,DireccionAdministrativa,RepresentanteLegal1,RepresentanteLegal2,PersonaContactoPuntoVenta,NumerocuentaBancaria,TipoCuenta,TipoMoneda,EntidadFinanciera,TipoAfiliacion,TipoProduccto,TipoComunicacion,FechaInstalacion from SolicitudAfiliacion where RUC='" + ruc.ToString() + "'");
            objConnection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CnnSQL"].ToString();
            objConnection.Open();
            objCommand.Connection = objConnection;
            objAdapater.SelectCommand = objCommand;
            objAdapater.Fill(ObjDataset);
            SolicitudAfiliacion _Be= new SolicitudAfiliacion();
            if (ObjDataset.Tables.Count > 0)
            {

                _Be.SRUC        = ObjDataset.Tables[0].Rows[0][1].ToString();
                _Be.SRAZO_SOCI  = ObjDataset.Tables[0].Rows[0][2].ToString();
                _Be.SNOMB_COME  = ObjDataset.Tables[0].Rows[0][3].ToString();
                _Be.SDIRE_COME  = ObjDataset.Tables[0].Rows[0][4].ToString();
                _Be.SDIRE_ADMI  = ObjDataset.Tables[0].Rows[0][5].ToString();
                _Be.SREPR_LEGA_1= ObjDataset.Tables[0].Rows[0][6].ToString();
                _Be.SREPR_LEGA_2= ObjDataset.Tables[0].Rows[0][7].ToString();
                _Be.SPERS_CONT  = ObjDataset.Tables[0].Rows[0][8].ToString();
                _Be.SNUME_CUEN  = ObjDataset.Tables[0].Rows[0][9].ToString();
                _Be.STIPO_CUEN  = ObjDataset.Tables[0].Rows[0][10].ToString();
                _Be.SMONE       = ObjDataset.Tables[0].Rows[0][11].ToString();
                _Be.SENTI_FINA  = ObjDataset.Tables[0].Rows[0][12].ToString();
                _Be.STIPO_AFIL  = ObjDataset.Tables[0].Rows[0][13].ToString();
                _Be.STIPO_PROD  = ObjDataset.Tables[0].Rows[0][14].ToString();
                _Be.STIPO_COMU  = ObjDataset.Tables[0].Rows[0][15].ToString();
                _Be.SFECH_INST  = ObjDataset.Tables[0].Rows[0][16].ToString();

            }
            objConnection.Close();

            return _Be;
           
        }
        

        public int RegistrarSolicitud(SolicitudAfiliacion solicitud)
        {
            SqlConnection objConnection = new SqlConnection();
            DataSet ObjDataset = new DataSet();
            SqlDataAdapter objAdapater = new SqlDataAdapter();
            SqlCommand objCommand = new SqlCommand("sp_SolicitudAfiliacion_I01", objConnection);
       
            objConnection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CnnSQL"].ToString();
            objConnection.Open();
            SqlTransaction trans = objConnection.BeginTransaction(IsolationLevel.ReadCommitted);
            objCommand.Connection = objConnection;


            SolicitudAfiliacion _Be = (SolicitudAfiliacion)solicitud;//pasarle la entidad
                   objCommand.Transaction = trans;
                   objCommand.CommandType = CommandType.StoredProcedure;
                   objCommand.Parameters.Add("@ruc", SqlDbType.VarChar).Value = _Be.SRUC;
                   objCommand.Parameters.Add("@razonsocial", SqlDbType.VarChar).Value = _Be.SRAZO_SOCI;
                   objCommand.Parameters.Add("@nombrcomercial", SqlDbType.VarChar).Value = _Be.SNOMB_COME;
                   objCommand.Parameters.Add("@direccioncomercial", SqlDbType.VarChar).Value = _Be.SDIRE_COME;
                   objCommand.Parameters.Add("@direccionadmin", SqlDbType.VarChar).Value = _Be.SDIRE_ADMI;
                   objCommand.Parameters.Add("@reprelegal1", SqlDbType.VarChar).Value = _Be.SREPR_LEGA_1;
                   objCommand.Parameters.Add("@reprelegal2", SqlDbType.VarChar).Value = _Be.SREPR_LEGA_2;
                   objCommand.Parameters.Add("@personcontactoventa", SqlDbType.VarChar).Value = _Be.SPERS_CONT;
                   objCommand.Parameters.Add("@numerocuentabancaria", SqlDbType.VarChar).Value = _Be.SNUME_CUEN;
                   objCommand.Parameters.Add("@tipocuenta", SqlDbType.VarChar).Value = _Be.STIPO_CUEN;
                   objCommand.Parameters.Add("@tipomoneda", SqlDbType.VarChar).Value = _Be.SMONE;
                   objCommand.Parameters.Add("@entidadfinan", SqlDbType.VarChar).Value = _Be.SENTI_FINA;
                   objCommand.Parameters.Add("@tipoafiliacion", SqlDbType.VarChar).Value = _Be.STIPO_AFIL;
                   objCommand.Parameters.Add("@tipoproducto", SqlDbType.VarChar).Value = _Be.STIPO_PROD;
                   objCommand.Parameters.Add("@tipocomunicacion", SqlDbType.VarChar).Value = _Be.STIPO_COMU;
                   objCommand.Parameters.Add("@fechainstal", SqlDbType.VarChar).Value = _Be.SFECH_INST;
                   
                   objCommand.ExecuteNonQuery();
                   trans.Commit();
            objConnection.Close();
            return 0;
        
        }    
    }
}
