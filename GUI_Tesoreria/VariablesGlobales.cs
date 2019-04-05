using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GUI_Tesoreria
{
    public static class VariablesGlobales
    {
        public static string NombreMensajes { get; set; }
        public static int AnioEscolarLogueado { get; set; }
        public static int AnioEscolarAperturado { get; set; }

        public static string AnioFaseEscolarLogueado { get; set; }
        public static string AnioFaseEscolarAperturado { get; set; }
        
        public static int AnioFiscal { get; set; }
        public static string NombreAnioActual { get; set; }
        public static string FechaActual { get; set; }
        public static string NombreCompletoUsuario { get; set; }
        public static string NombreUsuario { get; set; }
        public static Boolean admin { get; set; }
        public static string UserHostIp { get; set; }
        public static string ServidorDestino { get; set; }
        public static readonly string configuracion = "this.MySettings";
        
        //Public PATH As String = My.Application.Info.DirectoryPath
    }
}
