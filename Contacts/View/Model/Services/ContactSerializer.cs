using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace View.Model.Services
{
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
                FilePath = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments),
                "Contacts",
                "contact.json");
            }
            else
            {
                FilePath = filePath;
            }

            Directory.CreateDirectory(FilePath);
        }

        /// <summary>
        /// Save <see cref="Contact"/> entity into json file.
        /// </summary>
        /// <param name="contact">Contact entity for saving</param>
        void Serialize(Contact contact)
        {
            if (contact == null) { return; }
            
            try
            {
                string json = JsonConvert.SerializeObject(contact, Formatting.Indented);
                File.WriteAllText(json, FilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error on content saving: " + ex.Message);
            }
        }

        /// <summary>
        /// Load saved <see cref="Contact"/> from json file.
        /// </summary>
        /// <returns></returns>
        Contact Deserialize()
        {
            if (!File.Exists(FilePath)) { return null; }
            try
            {
                Contact contact = JsonConvert.DeserializeObject<Contact>(File.ReadAllText(FilePath));
                return contact;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error on content load: " + ex.Message);
                return null;
            }
        }
    }
}
