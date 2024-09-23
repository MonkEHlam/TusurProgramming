//using System.Collections.Generic;
//using System.IO;
//using System;

//namespace ObjectOrientedPractice.Services
//{
//    public static class ProjectSerializer
//    {
//        /// <summary>
//        ///     Добавляет товары, полученных из памяти в список товаров.
//        /// </summary>
//        private void LoadSavedDataIntoList()
//        {
//            if (IsDataFileExist())
//            {
//                _items.AddRange(GetSavedItemsArray());
//                isDataSaved = true;
//            }

//            UpdateListBox();
//        }

//        /// <summary>
//        ///     Проверяет существование файла с сохранением.
//        /// </summary>
//        /// <returns>True, если файл существует, иначе false.</returns>
//        private bool IsDataFileExist()
//        {
//            return new FileInfo(GetDataFilePath()).Exists;
//        }

//        /// <summary>
//        ///     Возвращает путь к файлу с сохранением
//        /// </summary>
//        /// <param name="directory">Если true, то возвращает путь к папке с файлом сохранения. По умолчанию false.</param>
//        /// <returns></returns>
//        private string GetDataFilePath(bool directory = false)
//        {
//            if (!directory)
//                return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
//                       @"\VoidPublishing\OOP\savedData\data.json";
//            return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
//                   @"\VoidPublishing\OOP\savedData\";
//        }

//        /// <summary>
//        ///     Десереализирует JSONы из фалйа сохранения.
//        /// </summary>
//        /// <returns>Массив с экземплярами класса Student <see cref="Student" /></returns>
//        private Item[] GetSavedItemsArray()
//        {
//            var output = new List<Item>();
//            foreach (var jsonItem in GetJsonItemData().Split('\n'))
//                if (jsonItem != "")
//                    output.Add(JsonSerializer.Deserialize<Item>(jsonItem));

//            return output.ToArray();
//        }

//        /// <summary>
//        ///     Считывает json.
//        /// </summary>
//        /// <returns></returns>
//        private string GetJsonItemData()
//        {
//            using (var reader = new StreamReader(GetDataFilePath()))
//            {
//                return reader.ReadToEnd();
//            }
//        }

//        /// <summary>
//        ///     Сериализирует студентов в списке.
//        /// </summary>
//        /// <returns></returns>
//        private string SerializeItems()
//        {
//            var output = string.Empty;
//            foreach (var item in _items) output += JsonSerializer.Serialize(item) + "\n";
//            return output;
//        }
//    }
//}
