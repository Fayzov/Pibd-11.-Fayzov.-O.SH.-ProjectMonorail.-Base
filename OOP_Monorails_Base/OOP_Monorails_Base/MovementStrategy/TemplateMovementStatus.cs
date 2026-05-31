using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Monorails_Base.MovementStrategy
{
    /// <summary>
    /// Статус выполнения операции перемещения к цели
    /// </summary>
    public enum TemplateMovementStatus
    {
        /// <summary>
        /// Все готово к началу (не инициализировано)
        /// </summary>
        NotInit,

        /// <summary>
        /// Процесс перемещения выполняется
        /// </summary>
        InProgress,

        /// <summary>
        /// Перемещение успешно завершено
        /// </summary>
        Finish
    }
}
