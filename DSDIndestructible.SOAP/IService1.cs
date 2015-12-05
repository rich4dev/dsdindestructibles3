using DSDIndestructibles3.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DSDIndestructible.SOAP
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(SolicitudAfiliacion solicitud);

        [OperationContract]
        SolicitudAfiliacion GetDataUsingDataContract(string ruc);

        int RegistrarSolicitud(SolicitudAfiliacion solicitud);
        // TODO: agregue aquí sus operaciones de servicio
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.

    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }


        string sRUC = "";
        [DataMember]
        public string SRUC
        {
            get { return sRUC; }
            set { sRUC = value; }
        }
        string sRAZO_SOCI = "";
        [DataMember]
        public string SRAZO_SOCI
        {
            get { return sRAZO_SOCI; }
            set { sRAZO_SOCI = value; }
        }
        string sNOMB_COME = "";
        [DataMember]
        public string SNOMB_COME
        {
            get { return sNOMB_COME; }
            set { sNOMB_COME = value; }
        }
        string sDIRE_COME = "";
        [DataMember]
        public string SDIRE_COME
        {
            get { return sDIRE_COME; }
            set { sDIRE_COME = value; }
        }
        string sDIRE_ADMI = "";
        [DataMember]
        public string SDIRE_ADMI
        {
            get { return sDIRE_ADMI; }
            set { sDIRE_ADMI = value; }
        }
        string sREPR_LEGA_1 = "";
        [DataMember]
        public string SREPR_LEGA_1
        {
            get { return sREPR_LEGA_1; }
            set { sREPR_LEGA_1 = value; }
        }
        string sREPR_LEGA_2 = "";
        [DataMember]
        public string SREPR_LEGA_2
        {
            get { return sREPR_LEGA_2; }
            set { sREPR_LEGA_2 = value; }
        }
        string sPERS_CONT = "";
        [DataMember]
        public string SPERS_CONT
        {
            get { return sPERS_CONT; }
            set { sPERS_CONT = value; }
        }
        string sNUME_CUEN = "";
        [DataMember]
        public string SNUME_CUEN
        {
            get { return sNUME_CUEN; }
            set { sNUME_CUEN = value; }
        }
        string sTIPO_CUEN = "";
        [DataMember]
        public string STIPO_CUEN
        {
            get { return sTIPO_CUEN; }
            set { sTIPO_CUEN = value; }
        }
        string sMONE = "";
        [DataMember]
        public string SMONE
        {
            get { return sMONE; }
            set { sMONE = value; }
        }
        string sENTI_FINA = "";
        [DataMember]
        public string SENTI_FINA
        {
            get { return sENTI_FINA; }
            set { sENTI_FINA = value; }
        }
        string sTIPO_AFIL = "";
        [DataMember]
        public string STIPO_AFIL
        {
            get { return sTIPO_AFIL; }
            set { sTIPO_AFIL = value; }
        }
        string sTIPO_PROD = "";
        [DataMember]
        public string STIPO_PROD
        {
            get { return sTIPO_PROD; }
            set { sTIPO_PROD = value; }
        }
        string sTIPO_COMU = "";
        [DataMember]
        public string STIPO_COMU
        {
            get { return sTIPO_COMU; }
            set { sTIPO_COMU = value; }
        }
       
       
        string sFECH_INST = "";
        [DataMember]
        public string SFECH_INST
        {
            get { return sFECH_INST; }
            set { sFECH_INST = value; }
        }
    }
}
