using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE_Tesoreria
{
    public class NichoInventario
    {
        #region Constructors
        public NichoInventario()
        {
        }
        public NichoInventario(int iDNICHOINVENTARIO,string cODCEMENTERIO, string cODESTADO, bool tAPA, string lETRAFILANICHO, int nUMEROCOLNICHO, string cODPABELLON, string cODESTADOFISICO, string cODMATERIAL, bool lAPIDA, bool rEJA, string oBSNICHOINV, string fLAGGABINETE, DateTime fECHAREGISTRO, DateTime fECHAMODIFICA, string uSUARIOREGISTRO, string uSUARIOMODIFICA, string rutaImagen, bool pERSONAJEIMPORTANTE)
        {
            this.IDNICHOINVENTARIO = iDNICHOINVENTARIO;
            this.CODCEMENTERIO = cODCEMENTERIO;
            this.CODESTADO = cODESTADO;
            this.TAPA = tAPA;
            this.LETRAFILANICHO = lETRAFILANICHO;
            this.NUMEROCOLNICHO = nUMEROCOLNICHO;
            this.CODPABELLON = cODPABELLON;
            this.CODESTADOFISICO = cODESTADOFISICO;
            this.CODMATERIAL = cODMATERIAL;
            this.LAPIDA = lAPIDA;
            this.REJA = rEJA;
            this.OBSNICHOINV = oBSNICHOINV;
            this.FLAGGABINETE = fLAGGABINETE;
            this.FECHAREGISTRO = fECHAREGISTRO;
            this.FECHAMODIFICA = fECHAMODIFICA;
            this.USUARIOREGISTRO = uSUARIOREGISTRO;
            this.USUARIOMODIFICA = uSUARIOMODIFICA;
            this.RutaImagen = rutaImagen;
            this.PERSONAJEIMPORTANTE = pERSONAJEIMPORTANTE;
        }

        #endregion

        #region Properties
        public int iDNICHOINVENTARIO { get; set; }
        /// <summary>
        /// Gets or sets the IDNICHOINVENTARIO value.
        /// </summary>
        public int IDNICHOINVENTARIO { get; set; }

        /// <summary>
        /// Gets or sets the CODCEMENTERIO value.
        /// </summary>
        public string CODCEMENTERIO { get; set; }

        /// <summary>
        /// Gets or sets the CODESTADO value.
        /// </summary>
        public string CODESTADO { get; set; }

        /// <summary>
        /// Gets or sets the TAPA value.
        /// </summary>
        public bool TAPA { get; set; }

        /// <summary>
        /// Gets or sets the LETRAFILANICHO value.
        /// </summary>
        public string LETRAFILANICHO { get; set; }

        /// <summary>
        /// Gets or sets the NUMEROCOLNICHO value.
        /// </summary>
        public int NUMEROCOLNICHO { get; set; }

        /// <summary>
        /// Gets or sets the CODPABELLON value.
        /// </summary>
        public string CODPABELLON { get; set; }

        /// <summary>
        /// Gets or sets the CODESTADOFISICO value.
        /// </summary>
        public string CODESTADOFISICO { get; set; }

        /// <summary>
        /// Gets or sets the CODMATERIAL value.
        /// </summary>
        public string CODMATERIAL { get; set; }

        /// <summary>
        /// Gets or sets the LAPIDA value.
        /// </summary>
        public bool LAPIDA { get; set; }

        /// <summary>
        /// Gets or sets the REJA value.
        /// </summary>
        public bool REJA { get; set; }

        /// <summary>
        /// Gets or sets the OBSNICHOINV value.
        /// </summary>
        public string OBSNICHOINV { get; set; }

        /// <summary>
        /// Gets or sets the FLAGGABINETE value.
        /// </summary>
        public string FLAGGABINETE { get; set; }

        /// <summary>
        /// Gets or sets the FECHAREGISTRO value.
        /// </summary>
        public DateTime FECHAREGISTRO { get; set; }

        /// <summary>
        /// Gets or sets the FECHAMODIFICA value.
        /// </summary>
        public DateTime FECHAMODIFICA { get; set; }

        /// <summary>
        /// Gets or sets the USUARIOREGISTRO value.
        /// </summary>
        public string USUARIOREGISTRO { get; set; }

        /// <summary>
        /// Gets or sets the USUARIOMODIFICA value.
        /// </summary>
        public string USUARIOMODIFICA { get; set; }

        /// <summary>
        /// Gets or sets the RutaImagen value.
        /// </summary>
        public string RutaImagen { get; set; }

        /// <summary>
        /// Gets or sets the PERSONAJEIMPORTANTE value.
        /// </summary>
        public bool PERSONAJEIMPORTANTE { get; set; }

        #endregion
    }
}
