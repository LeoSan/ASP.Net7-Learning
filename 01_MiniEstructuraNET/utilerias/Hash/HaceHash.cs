using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace utilerias.Hash
{
	/// <summary>
	/// Summary description for HaceHash.
	/// </summary>
	public class HaceHash
	{
		public HaceHash()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		private static byte[] StringToByteArray(string str)
		{
			ASCIIEncoding encoding = new ASCIIEncoding();
			return encoding.GetBytes(str);
		}

		private static string ByteArrayToHexString(byte[] byteArray)
		{
			string result = "";
			foreach(byte b in byteArray)
			{
				result += b.ToString("X2");
			}
			return result;

		}

		public static string ComputeSHA1HashArchivo(string strPath)
		{
			byte[] unarreglo = PasaArchivoByte(strPath);
			return ComputeSHA1Hash(unarreglo);
		}

		public static string ComputeSHA1HashString(string data)
		{
			SHA1 sha = new SHA1CryptoServiceProvider();
			byte[] hash = sha.ComputeHash(StringToByteArray(data));
			return ByteArrayToHexString(hash);
		}

		private static string ComputeSHA1Hash(byte[] byteArray)
		{
			SHA1 sha = new SHA1CryptoServiceProvider();
			byte[] hash = sha.ComputeHash(byteArray);
			return ByteArrayToHexString(hash);
		}

		private static byte[] PasaArchivoByte(string strRelativePath)
		{
			FileStream file = new FileStream(strRelativePath, FileMode.Open);
			byte[] buff = new byte[file.Length];
			file.Read(buff, 0, (int) file.Length );
			file.Close();

			return buff;
		}

	}//termina clase
}// termina namespace
