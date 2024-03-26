using Microsoft.Win32;
using System;
using System.Configuration;
using System.IO;

namespace CarRental_UtilityLayer
{
    public static class Utility
    {
        public static bool CreateFolderIfDoesNotExist(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                try
                {
                    Directory.CreateDirectory(folderPath);
                    return true;
                }

                catch (Exception ex)
                {
                    ErrorLogger.LogError(ex);
                    return false;
                }
            }

            return true;
        }

        public static string ReplaceFilePathWithGuid(string sourceFilePath)
        {
            FileInfo fileInfo = new FileInfo(sourceFilePath);

            return Guid.NewGuid().ToString() + fileInfo.Extension;
        }

        public static bool CopyImageToProjectImagesFolder(ref string sourceFilePath, string destinationFolder)
        {
            if (!CreateFolderIfDoesNotExist(destinationFolder))
                return false;

            try
            {
                string destinationFilePath = Path.Combine(destinationFolder, ReplaceFilePathWithGuid(sourceFilePath));

                File.Copy(sourceFilePath, destinationFilePath);

                File.Delete(sourceFilePath);

                sourceFilePath = destinationFilePath;

                return true;
            }

            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
                return false;
            }

        }

        public static bool StoreUserCredintialsToRegistery(string Username, string password)
        {
            // Specify the Registry key and path
            string keyPath = @"HKEY_CURRENT_USER\Software\YourSoftware";
            string valueName1 = "Username";
            string valueName2 = "Password";

            string key = ConfigurationManager.AppSettings["Key"];

            try
            {
                // Write the Username and password to the Registry
                Registry.SetValue(keyPath, valueName1, CryptoUtility.Encrypt(Username, key), RegistryValueKind.String);
                Registry.SetValue(keyPath, valueName2, CryptoUtility.Encrypt(password, key), RegistryValueKind.String);

                return true;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
                return false;
            }
        }

        public static bool GetUserCredintialsFromRegistery(ref string Username, ref string password)
        {
            // Specify the Registry key and path
            string keyPath = @"HKEY_CURRENT_USER\Software\YourSoftware";
            string valueName1 = "Username";
            string valueName2 = "Password";

            string key = ConfigurationManager.AppSettings["Key"];

            try
            {
                // Read the Username and password from the Registry
                string usernameData = Registry.GetValue(keyPath, valueName1, null) as string;
                string passwordData = Registry.GetValue(keyPath, valueName2, null) as string;

                if (usernameData != null && passwordData != null)
                {
                    Username = CryptoUtility.Decrypt(usernameData, key);
                    password = CryptoUtility.Decrypt(passwordData, key);

                    return true;
                }

                return false;
            }

            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
                return false;
            }
        }

        public static bool DeleteUserCredintialsFromRegistery()
        {
            // Specify the Registry key and path
            string keyPath = @"SOFTWARE\YourSoftware";
            string valueName1 = "Username";
            string valueName2 = "Password";

            try
            {
                // Open the registry key in read/write mode with explicit registry view
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(keyPath, true))
                    {
                        if (key != null)
                        {
                            // Delete the Username and password 
                            key.DeleteValue(valueName1);
                            key.DeleteValue(valueName2);

                            return true;
                        }

                        return false;
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                ErrorLogger.LogError(ex);
                return false;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(ex);
                return false;
            }
        }

    }
}
