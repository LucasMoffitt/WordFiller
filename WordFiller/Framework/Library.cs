using System;
using System.Collections.Generic;
using System.IO;

namespace WordFiller.Framework
{
    public class Library
    {
        public static List<String> _resourceCollection = new List<String>();
        public const string LibraryLocation = "Library/";

        public static void CheckLibrarySatus()
        {
            if (!DoesLibraryExist)
            {
                CreateLibrary();
            }
        }

        private static bool DoesLibraryExist
        {
            get { return Directory.Exists(LibraryLocation); }
        }

        public static bool IsWordWrappedInBrackets(string word)
        {
            if (word == "")
            {
                return false;
            }

            return word[0] == '<' && word[word.Length - 1] == '>';
        }

        public static string WrapInBrackets(string word)
        {
            string wrappedWord = ("<" + word.Trim() + ">");
            return wrappedWord;
        }
            
        public static void CreateLibrary()
        {
            Directory.CreateDirectory(LibraryLocation);
        }

        public static void LoadLibraryItemList()
        {
            _resourceCollection.Clear();
            string[] collection = Directory.GetFiles(LibraryLocation, "*.txt");
       
            foreach (var resource in collection)
            {
                _resourceCollection.Add(resource.Substring(LibraryLocation.Length, resource.Length - (LibraryLocation.Length + 4)));
            }
        }

        public static void SaveResource(string resourceTitle, string resourceContent)
        {
            StreamWriter saveFile = new StreamWriter(LibraryLocation + resourceTitle + ".txt");
            saveFile.Write(resourceContent);
            saveFile.Close();
        }

        public static string ReadResource(string resourceName)
        {
            StreamReader reader = new StreamReader(LibraryLocation + resourceName + ".txt");
            string resourceContent = reader.ReadToEnd();
            reader.Close();
            
            return resourceContent;            
        }
 
        public static void DeleteResource(string resourceName)
        {
            var resourceFileLocation = (LibraryLocation + resourceName + ".txt");

            if (File.Exists(resourceFileLocation))
            {
                File.Delete(resourceFileLocation);               
            }
        }
    }
}
