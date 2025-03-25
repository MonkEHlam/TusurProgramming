using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace View.Model.Services
{
    /// <summary>
    /// Class for (de)serializing contact.
    /// </summary>
    internal class ContactSerializer
    {
        /// <summary>
        /// Path to json save file.
        /// </summary>
        public string FilePath;

        /// <summary>
        /// Base class constructor.
        /// </summary>
        /// <param name="filePath">Path for save file. MyDocuments/Contacts by default.</param>
        public ContactSerializer(string filePath = null)
        {
            if (filePath == null)
            {
                FilePath = Path.Combine
                    (
                    Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                    "Contacts",
                    "contacts.json"
                );
            }
            else
            {
                FilePath = filePath;
            }

            Directory.CreateDirectory(Path.GetDirectoryName(FilePath));
        }

        /// <summary>
        /// Save <see cref="Contact"/> entity into json file.
        /// </summary>
        /// <param name="contact">SelectedContact entity for saving</param>
        public bool Serialize(ObservableCollection<Contact> contacts)
        {
            if (contacts == null) 
            {
                return false; 
            }
            
            try
            {
                string json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
                File.WriteAllText(FilePath, json);
                return true;
        }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Load saved <see cref="Contact"/> from json file.
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<Contact> Deserialize()
        {
            if (!File.Exists(FilePath)) { new ObservableCollection<Contact>(); }

            try
            {
                ObservableCollection<Contact> contact = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(File.ReadAllText(FilePath));
                return contact;
            }
            catch (Exception ex)
            {
                return new ObservableCollection<Contact>();
            }
        }
    }
}
