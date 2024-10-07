namespace FindMyStudents.Model
{
    /// <summary>
    ///     Переводит значения перечислений в вид, для конечного пользователя и наоборот.
    /// </summary>
    internal static class EnumParser
    {
        /// <summary>
        ///     Преобразует тип <see cref="Faculties" /> к виду для конечного пользователя.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Строковое представление типа в польовательском виде.</returns>
        public static string GetStringFaculty(Faculties value)
        {
            switch (value)
            {
                case Faculties.Economical:
                    return "ЭФ";
                case Faculties.ComputingSystems:
                    return "ФВС";
                case Faculties.ElectricalEngineering:
                    return "ФЭТ";
                case Faculties.InnovationTechnologies:
                    return "ФИТ";
                case Faculties.ManagementSystems:
                    return "ФСУ";
                case Faculties.Humanity:
                    return "ГФ";
                case Faculties.Law:
                    return "ЮФ";
                case Faculties.Security:
                    return "ФБ";
                case Faculties.RadioConstruct:
                    return "РКФ";
                case Faculties.RadioTechnical:
                    return "РТФ";
                default:
                    return "";
            }
        }

        /// <summary>
        ///     Преобразует вид конечного пользователя в тип <see cref="Faculties" />
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Значение типа <see cref="Faculties" /></returns>
        public static Faculties GetEnumFaculty(string value)
        {
            switch (value)
            {
                case "ФВС":
                    return Faculties.ComputingSystems;
                case "ФСУ":
                    return Faculties.ManagementSystems;
                case "ФЭТ":
                    return Faculties.ElectricalEngineering;
                case "ФИТ":
                    return Faculties.InnovationTechnologies;
                case "РКФ":
                    return Faculties.RadioConstruct;
                case "РТФ":
                    return Faculties.RadioTechnical;
                case "ФБ":
                    return Faculties.Security;
                case "ЭФ":
                    return Faculties.Economical;
                case "ГФ":
                    return Faculties.Humanity;
                case "ЮФ":
                    return Faculties.Law;
                default:
                    return Faculties.None;
            }
        }

        /// <summary>
        ///     Преобразует тип <see cref="EducationForms" /> к виду для конечного пользователя.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Строковое представление типа в польовательском виде.</returns>
        public static string GetStringEducationForm(EducationForms value)
        {
            switch (value)
            {
                case EducationForms.FullTime:
                    return "Очная форма обучения";
                case EducationForms.Correspondence:
                    return "Заочная форма обучения";
                case EducationForms.PartTime:
                    return "Очно-заочная форма обучения";
                default:
                    return "";
            }
        }

        /// <summary>
        ///     Преобразует вид конечного пользователя в тип <see cref="Faculties" />
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Значение типа <see cref="Faculties" /></returns>
        public static EducationForms GetEnumEducationForm(string value)
        {
            switch (value)
            {
                case "Очная форма обучения":
                    return EducationForms.FullTime;
                case "Заочная форма обучения":
                    return EducationForms.Correspondence;
                case "Очно-заочная форма обучения":
                    return EducationForms.PartTime;
                default:
                    return EducationForms.None;
            }
        }
    }
}