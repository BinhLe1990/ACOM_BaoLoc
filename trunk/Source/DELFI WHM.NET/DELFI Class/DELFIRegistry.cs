using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Security.Cryptography;
using System.IO;
using System.Management;

namespace DELFI_WHM.NET.DELFI_Class
{
    public class DELFIRegistry
    {
        public static string Exx = "";

        public string GetSerial(string serialType, string selectType)
        {
            string result = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + serialType);
            foreach (ManagementObject info in searcher.Get())
            {
                result += info.GetPropertyValue(selectType).ToString();
            }
            return result;
        }

        public static string Encrypt(string clearText, string Password)
        {
            byte[] clearBytes = System.Text.Encoding.Unicode.GetBytes(clearText);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            byte[] encryptedData = Encrypt(clearBytes, pdb.GetBytes(32), pdb.GetBytes(16));
            return Convert.ToBase64String(encryptedData);
        }
        public static byte[] Encrypt(byte[] clearData, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;
            CryptoStream cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(clearData, 0, clearData.Length);
            cs.Close();
            byte[] encryptedData = ms.ToArray();
            return encryptedData;
        }
        public static string Decrypt(string cipherText, string Password)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            byte[] decryptedData = Decrypt(cipherBytes, pdb.GetBytes(32), pdb.GetBytes(16));
            return System.Text.Encoding.Unicode.GetString(decryptedData);
        }
        public static byte[] Decrypt(byte[] cipherData, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;
            CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(cipherData, 0, cipherData.Length);
            cs.Close();
            byte[] decryptedData = ms.ToArray();
            return decryptedData;
        }
        public static bool WriteRegistry(String subKey, Hashtable ObjValueSet)
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\" + Properties.Settings.Default.Registry_Name + "\\Delfi_VN\\" + subKey, true);
            try
            {
                if (key == null) //If the key doesn't exist.
                    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\" + Properties.Settings.Default.Registry_Name + "\\Delfi_VN\\" + subKey);
                //Set the value.
                foreach (DictionaryEntry IVal in ObjValueSet)
                {
                    key.SetValue(IVal.Key.ToString(), IVal.Value);
                }
                return true;
            }
            catch (System.Exception e)
            {
                DELFIException.LogException(e);
                Exx = e.Message;
                return false;
            }
        }
        public static bool WriteRegistry(String subKey, Hashtable ObjValueSet, String KeyEncrypt)
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\" + Properties.Settings.Default.Registry_Name + "\\Delfi_VN\\" + subKey, true);
            try
            {
                if (key == null) //If the key doesn't exist.
                    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\" + Properties.Settings.Default.Registry_Name + "\\Delfi_VN\\" + subKey);
                //Set the value.
                foreach (DictionaryEntry IVal in ObjValueSet)
                {
                    key.SetValue(IVal.Key.ToString(), Encrypt(IVal.Value.ToString(), KeyEncrypt));
                }
                return true;
            }
            catch (System.Exception e)
            {
                DELFIException.LogException(e);
                Exx = e.Message;
                return false;
            }
        }
        public static bool WriteRegistry(String subKey, String NameSet, String ValueSet, String KeyEncrypt)
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\" + Properties.Settings.Default.Registry_Name + "\\Delfi_VN\\" + subKey, true);
            try
            {
                if (key == null) //If the key doesn't exist.
                    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\" + Properties.Settings.Default.Registry_Name + "\\Delfi_VN\\" + subKey);
                //Set the value.
                key.SetValue(NameSet, Encrypt(ValueSet, KeyEncrypt));
                return true;
            }
            catch (System.Exception e)
            {
                DELFIException.LogException(e);
                Exx = e.Message;
                return false;
            }
        }
        public static bool WriteRegistry(String subKey, String NameSet, Object ValueSet)
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\" + Properties.Settings.Default.Registry_Name + "\\Delfi_VN\\" + subKey, true);
            try
            {
                if (key == null) //If the key doesn't exist.
                    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\" + Properties.Settings.Default.Registry_Name + "\\Delfi_VN\\" + subKey);
                //Set the value.
                key.SetValue(NameSet, ValueSet);
                return true;
            }
            catch (System.Exception e)
            {
                DELFIException.LogException(e);
                Exx = e.Message;
                return false;
            }
        }
        public static bool WriteRegistry(String subKey, String NameSet, String ValueSet)
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\" + Properties.Settings.Default.Registry_Name + "\\Delfi_VN\\" + subKey, true);
            try
            {
                if (key == null) //If the key doesn't exist.
                    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\"+Properties.Settings.Default.Registry_Name+"\\Delfi_VN\\" + subKey);
                //Set the value.
                key.SetValue(NameSet, ValueSet);
                return true;
            }
            catch (System.Exception e)
            {
                DELFIException.LogException(e);
                Exx = e.Message;
                return false;
            }
        }
        public static bool ReadRegistry(String subKey, String GetValueName, out Object ReturnValue)
        {
            Microsoft.Win32.RegistryKey key;
            try
            {
                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\"+Properties.Settings.Default.Registry_Name+"\\Delfi_VN\\" + subKey, true);
                if (key == null)//If the key doesn't exist.
                {
                    Exx = "The registry key doesn't exist";
                    ReturnValue = "";
                    return false;
                }
                //Get the value.
                ReturnValue = key.GetValue(GetValueName);
                return true;
            }
            catch (System.Exception e)
            {
                DELFIException.LogException(e);
                Exx = e.Message;
                ReturnValue = "";
                return false;
            }
        }
        public static bool ReadRegistry(String subKey, String GetValueName, out String ReturnValue)
        {
            Microsoft.Win32.RegistryKey key;
            try
            {
                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\"+Properties.Settings.Default.Registry_Name+"\\Delfi_VN\\" + subKey, true);
                if (key == null)//If the key doesn't exist.
                {
                    Exx = "The registry key doesn't exist";
                    ReturnValue = "";
                    return false;
                }
                //Get the value.
                ReturnValue = key.GetValue(GetValueName).ToString();
                return true;
            }
            catch (System.Exception e)
            {
                DELFIException.LogException(e);
                Exx = e.Message;
                ReturnValue = "";
                return false;
            }
        }
        public static bool ReadRegistry(String subKey, String GetValueName, out String ReturnValue, String KeyEncrypt)
        {
            Microsoft.Win32.RegistryKey key;
            try
            {
                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\" + Properties.Settings.Default.Registry_Name + "\\Delfi_VN\\" + subKey, true);
                if (key == null)//If the key doesn't exist.
                {
                    Exx = "The registry key doesn't exist";
                    ReturnValue = "";
                    return false;
                }
                //Get the value.
                ReturnValue = Decrypt((String)key.GetValue(GetValueName), KeyEncrypt);
                return true;
            }
            catch (System.Exception e)
            {
                DELFIException.LogException(e);
                Exx = e.Message;
                ReturnValue = "";
                return false;
            }
        }
        public static bool ReadRegistry(String subKey, String GetValueName, out Object ReturnValue, String KeyEncrypt)
        {
            Microsoft.Win32.RegistryKey key;
            try
            {
                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\"+Properties.Settings.Default.Registry_Name+"\\Delfi_VN\\" + subKey, true);
                if (key == null)//If the key doesn't exist.
                {
                    Exx = "The registry key doesn't exist";
                    ReturnValue = "";
                    return false;
                }
                //Get the value.
                ReturnValue = Decrypt((String)key.GetValue(GetValueName), KeyEncrypt);
                return true;
            }
            catch (System.Exception e)
            {
                DELFIException.LogException(e);
                Exx = e.Message;
                ReturnValue = "";
                return false;
            }
        }
    }
}
