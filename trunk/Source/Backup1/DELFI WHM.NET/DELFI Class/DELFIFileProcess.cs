using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DELFI_WHM.NET.DELFI_Class
{
    public class DELFIFileProcess
    {
        public static byte[] ReadFile(string sPath)
        {
            byte[] data = null;
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }
        public static bool WriteFile(byte[] fData, string sPath, string sFileName)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(fData, 0, fData.Length))
                {
                    ms.Write(fData, 0, fData.Length);
                    System.IO.File.WriteAllBytes(sPath + "/" + sFileName, fData);
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                DELFIException.LogException(ex);
                return false;
            }
        }
        public static bool WriteFile(byte[] fData, string sFullPath)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(fData, 0, fData.Length))
                {
                    ms.Write(fData, 0, fData.Length);
                    System.IO.File.WriteAllBytes(sFullPath, fData);
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                DELFIException.LogException(ex);
                return false;
            }
        }
        public static bool WriteFile(byte[] fData, string sPath, string sFileName, bool bOpenFile)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(fData, 0, fData.Length))
                {
                    ms.Write(fData, 0, fData.Length);
                    System.IO.File.WriteAllBytes(sPath + "/" + sFileName, fData);
                    if (bOpenFile)
                        System.Diagnostics.Process.Start(sPath + "/" + sFileName);
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                DELFIException.LogException(ex);
                return false;
            }
        }
        public static bool WriteFile(byte[] fData, string sFullPath, bool bOpenFile)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(fData, 0, fData.Length))
                {
                    ms.Write(fData, 0, fData.Length);
                    System.IO.File.WriteAllBytes(sFullPath, fData);
                    if (bOpenFile)
                        System.Diagnostics.Process.Start(sFullPath);
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                DELFIException.LogException(ex);
                return false;
            }
        }
    }
}
