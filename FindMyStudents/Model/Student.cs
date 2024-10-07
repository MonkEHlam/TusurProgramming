using System;
using System.Collections.Generic;

namespace FindMyStudents.Model
{
    /// <summary>
    ///     Хранит студента.
    /// </summary>
    [Serializable]
    internal class Student : IComparable<Student>, IEquatable<Student>
    {
        /// <summary>
        ///     Хранит уже используемые номера зачеток.
        /// </summary>
        private static List<int> IdInUse = new List<int>();

        /// <summary>
        ///     Ф.И.О
        /// </summary>
        private string _fullName = "Ф.И.О.";

        /// <summary>
        ///     Группа
        /// </summary>
        private string _group = "группа";

        /// <summary>
        ///     Номер зачетки.
        /// </summary>
        private int _id;

        /// <summary>
        ///     Возвращает номер зачетки. Если не заполено, генерирует случайный номер.
        ///     Номер состоит из 6 цифр. Единожды дает возможность задать номер.
        /// </summary>
        public int Id
        {
            get
            {
                if (_id == 0) _id = GenerateId();

                return _id;
            }
            set
            {
                if (_id == 0 && (value > 100000) & (value < 999999)) _id = value;
            }
        }

        public string FullName
        {
            get => _fullName;
            set
            {
                if (!(string.IsNullOrEmpty(value) || value.Length > 200 || value.Contains("0123456789")))
                    _fullName = value;
                else throw new ArgumentException("Некорректный формат Ф.И.О.");
            }
        }

        public string Group
        {
            get => _group;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _group = value;
                else throw new ArgumentException("Некорректный формат группы.");
            }
        }

        public Faculties Faculty { get; set; } = Faculties.None;

        public EducationForms EducationForm { get; set; } = EducationForms.None;

        /// <summary>
        ///     Баозове сравнение класса.
        /// </summary>
        /// <param name="compareStudent"><see cref="Student" /> для сравнения.</param>
        /// <returns>Int индекс сравнения IComparable.</returns>
        public int CompareTo(Student compareStudent)
        {
            if (compareStudent == null)
                return 1;

            return FullName.CompareTo(compareStudent.FullName);
        }

        /// <summary>
        ///     Сравнение пары экземпляров <see cref="Student" />
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Student other)
        {
            if (other == null) return false;
            return Id.Equals(other.Id);
        }

        /// <summary>
        ///     Строковое представление класса.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{FullName}, {Id}, {EnumParser.GetStringFaculty(Faculty)} {Group}";
        }

        /// <summary>
        ///     Идентификатор элемента
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Id;
        }

        /// <summary>
        ///     Удаляет номер зачетки из используемых
        /// </summary>
        public void RemoveMe()
        {
            IdInUse.Remove(Id);
        }

        /// <summary>
        ///     Генерирует номер зачетки.
        /// </summary>
        /// <returns></returns>
        private int GenerateId()
        {
            var rand = new Random();
            var output = 0;
            do
            {
                output = rand.Next(100000, 999999);
            } while (IdInUse.Contains(output));

            return output;
        }
    }
}