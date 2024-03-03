using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental_UtilityLayer
{
    public static class clsUtility
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

                catch(Exception ex)
                {
                    clsErrorLogger.LogError(ex);
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

        public static bool CopyImageToProjectImagesFolder(ref string sourceFilePath , string destinationFolder)
        {
            if(!CreateFolderIfDoesNotExist(destinationFolder))           
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
                clsErrorLogger.LogError(ex);
                return false;
            }

        }
    }
}
