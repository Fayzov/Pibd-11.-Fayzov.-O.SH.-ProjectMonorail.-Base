using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Monorails_Base.Collections
{
    /// <summary>
    /// Типы доступных коллекций
    /// </summary>
    public enum CollectionType
    {
        // Тип не задан
        None,
        // Обычный массив (из Лабы 3)
        Massive,
        // Динамический список List
        List,
        // Связанный список LinkedList
        LinkedList
    }
}