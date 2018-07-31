using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Tesoreria
{
    public class TituloNicho
    {
        #region Constructors


        /// Initializes a new instance of the TITULONICHO class.

        public TituloNicho()
        {
        }


        /// Initializes a new instance of the TITULONICHO class.

        public TituloNicho(int iDTITULONICHO, string eSTADO, string nUMEROTITULO, string nUMERODOCUMENTOVENTA
            , string nOMBRERESPONSABLE, DateTime fECHAINHUMACION, DateTime fECHACONCESION
            , int iDMOTIVO, string oBSERVACIONMOTIVO, bool gENEROTITULO, bool rECOGIOTITULO
            , string cEMENTERIO, string nOMBRECUARTEL, string lETRAFILANICHO, int nUMEROCOLNICHO
            , string cODCUARTEL, string aNULADO, int uSUARIOING, DateTime fECHAING, int uSUARIOMOD
            , DateTime fECHAMOD)
        {
            this.IDTITULONICHO = iDTITULONICHO;
            this.ESTADO = eSTADO;
            this.NUMEROTITULO = nUMEROTITULO;
            this.NUMERODOCUMENTOVENTA = nUMERODOCUMENTOVENTA;
            this.NOMBRERESPONSABLE = nOMBRERESPONSABLE;
            this.FECHAINHUMACION = fECHAINHUMACION;
            this.FECHACONCESION = fECHACONCESION;
            this.IDMOTIVO = iDMOTIVO;
            this.OBSERVACIONMOTIVO = oBSERVACIONMOTIVO;
            this.GENEROTITULO = gENEROTITULO;
            this.RECOGIOTITULO = rECOGIOTITULO;
            this.CEMENTERIO = cEMENTERIO;
            this.NOMBRECUARTEL = nOMBRECUARTEL;
            this.LETRAFILANICHO = lETRAFILANICHO;
            this.NUMEROCOLNICHO = nUMEROCOLNICHO;
            this.CODCUARTEL = cODCUARTEL;
            this.ANULADO = aNULADO;
            this.USUARIOING = uSUARIOING;
            this.FECHAING = fECHAING;
            this.USUARIOMOD = uSUARIOMOD;
            this.FECHAMOD = fECHAMOD;
        }

        #endregion

        #region Properties


        public int IDTITULONICHO { get; set; }

        public string ESTADO { get; set; }

        public string NUMEROTITULO { get; set; }

        public string NUMERODOCUMENTOVENTA { get; set; }

        public string NOMBRERESPONSABLE { get; set; }

        public DateTime? FECHAINHUMACION { get; set; }

        public DateTime? FECHACONCESION { get; set; }

        public int IDMOTIVO { get; set; }

        public string OBSERVACIONMOTIVO { get; set; }

        public bool GENEROTITULO { get; set; }

        public bool RECOGIOTITULO { get; set; }

        public string CEMENTERIO { get; set; }

        public string NOMBRECUARTEL { get; set; }

        public string LETRAFILANICHO { get; set; }

        public int NUMEROCOLNICHO { get; set; }

        public string CODCUARTEL { get; set; }

        public string ANULADO { get; set; }

        public int USUARIOING { get; set; }

        public DateTime FECHAING { get; set; }

        public int USUARIOMOD { get; set; }

        public DateTime FECHAMOD { get; set; }    
        #endregion
    }
}
