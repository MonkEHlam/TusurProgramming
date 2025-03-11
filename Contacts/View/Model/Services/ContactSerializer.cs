using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows;

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
        /// <param name="contact">Contact entity for saving</param>
        public void Serialize(Contact contact)
        {
            if (contact == null) 
            {
                return; 
            }
            
            try
            {
                string json = JsonConvert.SerializeObject(contact, Formatting.Indented);
                File.WriteAllText(FilePath, json);

                MessageBox.Show("File succsesfully saved!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on content saving: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Load saved <see cref="Contact"/> from json file.
        /// </summary>
        /// <returns></returns>
        public Contact Deserialize()
        {
            if (!File.Exists(FilePath)) { return new Contact(); }
            try
            {
                Contact contact = JsonConvert.DeserializeObject<Contact>(File.ReadAllText(FilePath));
                return contact;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on content load: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
        }
    }
}
