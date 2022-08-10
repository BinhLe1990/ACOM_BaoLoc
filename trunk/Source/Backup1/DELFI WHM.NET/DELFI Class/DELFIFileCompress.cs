using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DELFI_WHM.NET.DELFI_Class
{
    public class DELFIFileCompress
    {
        public static bool Compress(string sFileInput, string sFileOutput)
        {
            FileStream fsIn = null;
            FileStream fsOut = null;
            System.IO.Compression.GZipStream gzip = null;
            byte[] buffer;
            int count = 0;
            try
            {
                fsOut = new FileStream(sFileOutput, FileMode.Create, FileAccess.Write, FileShare.None);
                gzip = new System.IO.Compression.GZipStream(fsOut, System.IO.Compression.CompressionMode.Compress, true);
                fsIn = new FileStream(sFileInput, FileMode.Open, FileAccess.Read, FileShare.Read);
                buffer = new byte[fsIn.Length];
                count = fsIn.Read(buffer, 0, buffer.Length);
                fsIn.Close();
                fsIn = null;
                gzip.Write(buffer, 0, buffer.Length);
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.Assert(false, ex.ToString());
                return false;
            }
            finally
            {
                if (gzip != null)
                {
                    gzip.Close();
                    gzip = null;
                }
                if (fsOut != null)
                {
                    fsOut.Close();
                    fsOut = null;
                }
                if (fsIn != null)
                {
                    fsIn.Close();
                    fsIn = null;
                }
            }
            return true;
        }
        public static bool Decompress(string sFileInput, string sFileOutput)
        {
            FileStream fsIn = null;
            FileStream fsOut = null;
            System.IO.Compression.GZipStream gzip = null;
            const int bufferSize = 4096;
            byte[] buffer = new byte[bufferSize];
            int count = 0;
            try
            {
                fsIn = new FileStream(sFileInput, FileMode.Open, FileAccess.Read, FileShare.Read);
                fsOut = new FileStream(sFileOutput, FileMode.Create, FileAccess.Write, FileShare.None);
                gzip = new System.IO.Compression.GZipStream(fsIn, System.IO.Compression.CompressionMode.Decompress, true);
                while (true)
                {
                    count = gzip.Read(buffer, 0, bufferSize);
                    if (count != 0)
                    {
                        fsOut.Write(buffer, 0, count);
                    }
                    if (count != bufferSize)
                    {
                        break;
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debug.Assert(false, ex.ToString());
                return false;
            }
            finally
            {
                if (gzip != null)
                {
                    gzip.Close();
                    gzip = null;
                }
                if (fsOut != null)
                {
                    fsOut.Close();
                    fsOut = null;
                }
                if (fsIn != null)
                {
                    fsIn.Close();
                    fsIn = null;
                }
            }
            return true;
        }
    }
}
