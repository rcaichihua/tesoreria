using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Security;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Linq;
using System.Drawing;
using System.Data.SqlTypes;

namespace GUI_Tesoreria
{
    public static class VariablesMetodosEstaticos
    {
        //public static int intCodUsuario { get; set; }
        public static int intPerfilID { get; set; }
        public static int menuPrincipalID { get; set; }
        public static int subMenuPrincipalID { get; set; }
        public static string varUsuario { get; set; }
        public static string varNombreUser { get; set; }
        public static string intAnnioActual { get; set; }
        public static string varNombreSucursal { get; set; }
        public static string varNombrePerfil { get; set; }
        public static string encabezado { get; set; }
        public static string host_user { get; set; }
        public static string ip_user { get; set; }
        public static string mac_pc { get; set; }
        public static bool tiene_mac { get; set; }
        public static decimal igv { get; set; }
        public static int mac_id { get; set; }
        public static int idcajausuario { get; set; }
        public static int id_user { get; set; }
        public static int idcaja { get; set; }
        public static string numeroapertura { get; set; }
        public static int id_programa { get; set; }
        public static int id_Sucursal { get; set; }
        public static int AnioFiscal { get; set; }

        public static object ToSafeDbDateDBnull(this object objectstring)
        {
            try
            {
                if ((DateTime)objectstring >= SqlDateTime.MinValue)
                {
                    return objectstring;
                }
                else
                {
                    return DBNull.Value;
                }
            }
            catch (Exception)
            {

                return DBNull.Value;
            }

        }

        public static string Right(this string str, int length)
        {
            str = (str ?? string.Empty);
            return (str.Length >= length) ? str.Substring(str.Length - length, length) : str;
        }

        public static string GetMimeType(string ext)
        {
            //    CodecName FilenameExtension FormatDescription MimeType 
            //    .BMP;*.DIB;*.RLE BMP ==> image/bmp 
            //    .JPG;*.JPEG;*.JPE;*.JFIF JPEG ==> image/jpeg 
            //    *.GIF GIF ==> image/gif 
            //    *.TIF;*.TIFF TIFF ==> image/tiff 
            //    *.PNG PNG ==> image/png 
            switch (ext.ToLower())
            {
                case ".bmp":
                case ".dib":
                case ".rle":
                    return "image/bmp";

                case ".jpg":
                case ".jpeg":
                case ".jpe":
                case ".fif":
                    return "image/jpeg";

                case "gif":
                    return "image/gif";
                case ".tif":
                case ".tiff":
                    return "image/tiff";
                case "png":
                    return "image/png";
                default:
                    return "image/jpeg";
            }
        }

        public static ImageCodecInfo GetEncoderInfo(string mimeType)
        {

            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();

            ImageCodecInfo encoder = (from enc in encoders where enc.MimeType == mimeType select enc).First();
            return encoder;

        }

        public static void ComprimirImagen(string inputFile, string ouputfile, long compression)
        {
            Image image = Image.FromFile(inputFile);
            EncoderParameters eps = new EncoderParameters(1);

            eps.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, compression);
            string mimetype = VariablesMetodosEstaticos.GetMimeType(new System.IO.FileInfo(inputFile).Extension);
            ImageCodecInfo ici = VariablesMetodosEstaticos.GetEncoderInfo(mimetype);

            if (File.Exists(ouputfile))
            {
                File.Delete(ouputfile);
            }

            image.Save(ouputfile, ici, eps);
        }

#region metodos para encriptar y desencriptar password
        public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;
            byte[] saltBytes = passwordBytes;

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (CryptoStream cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            byte[] saltBytes = passwordBytes;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (RijndaelManaged AES = new RijndaelManaged())
                    {
                        AES.KeySize = 256;
                        AES.BlockSize = 128;

                        var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                        AES.Key = key.GetBytes(AES.KeySize / 8);
                        AES.IV = key.GetBytes(AES.BlockSize / 8);

                        AES.Mode = CipherMode.CBC;

                        using (CryptoStream cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                            cs.Close();
                        }
                        decryptedBytes = ms.ToArray();
                    }
                }

                return decryptedBytes;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static SecureString ConvertToSecureString(this string password)
        {
            if (password == null)
                throw new ArgumentNullException("password");

            unsafe
            {
                fixed (char* passwordChars = password)
                {
                    var securePassword = new SecureString(passwordChars, password.Length);
                    securePassword.MakeReadOnly();
                    return securePassword;
                }
            }
        }
#endregion

#region keypress de validacion numerica
        public static void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
        }

        public static void Decimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator
                )
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
        }
        #endregion
    }
}
