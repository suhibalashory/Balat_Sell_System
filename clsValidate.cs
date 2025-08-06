﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Alkirat2.GlobalClass
{
	class clsValidate
	{

		public static bool ValidateInteger(string Number)
		{
			var pattern = @"^[0-9]*$";

			var regex = new Regex(pattern);

			return regex.IsMatch(Number);
		}

		public static bool ValidateFloat(string Number)
		{
			var pattern = @"^[0-9]*(?:\.[0-9]*)?$";

			var regex = new Regex(pattern);

			return regex.IsMatch(Number);
		}

		public static bool IsNumber(string Number)
		{
			return (ValidateInteger(Number) || ValidateFloat(Number));
		}

		private static string GenerateGUID()
		{ 
		// Generate a new GUID
		Guid newGuid = Guid.NewGuid();

            // convert the GUID to a string
            return newGuid.ToString();
            
        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
		{

			// Check if the folder exists
			if (!Directory.Exists(FolderPath))
			{
				try
				{
					// If it doesn't exist, create the folder
					Directory.CreateDirectory(FolderPath);
					return true;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error creating folder: " + ex.Message);
					return false;
				}
			}

			return true;

		}

		public static string ReplaceFileNameWithGUID(string sourceFile)
		{
			// Full file name. Change your file name   
			string fileName = sourceFile;
			FileInfo fi = new FileInfo(fileName);
			string extn = fi.Extension;
			return GenerateGUID() + extn;

		}

		public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
		{
			// this funciton will copy the image to the
			// project images foldr after renaming it
			// with GUID with the same extention, then it will update the sourceFileName with the new name.

			string DestinationFolder = @"C:\DVLD-People-Images\";
			if (!CreateFolderIfDoesNotExist(DestinationFolder))
			{
				return false;
			}

			string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
			try
			{
				File.Copy(sourceFile, destinationFile, true);

			}
			catch (IOException iox)
			{
				MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			sourceFile = destinationFile;
			return true;
		}

	}
}
