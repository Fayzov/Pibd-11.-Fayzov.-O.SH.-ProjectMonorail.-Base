using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Monorails_Base.Helpers
{
    /// <summary>
    /// Константы-разделители для сохранения и загрузки из файлов
    /// </summary>
    public static class SeparatorConstants
    {
        // Разделитель для записи названия станции и её данных
        public const string SeparatorForKeyValue = ",";

        // Разделитель для типа компании и типа коллекции
        public const string SeparatorForCompanyData = "|";

        // Разделитель между отдельными монорельсами в списке
        public const string SeparatorForItems = ";";

        // Разделитель для характеристик внутри одного монорельса
        public const string SeparatorForObject = ":";
    }
}