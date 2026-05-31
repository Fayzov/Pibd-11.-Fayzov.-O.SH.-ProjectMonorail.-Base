using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Monorails_Base.MovementStrategy
{
    /// <summary>
    /// Реализация стратегии перемещения объекта к правой нижней границе экрана
    /// </summary>
    public class MoveToRightDownBorder : BaseTemplateMovement
    {
        /// <summary>
        /// Проверка, достигли ли края объекта границ поля
        /// </summary>
        protected override bool IsTargetDestinaion()
        {
            ObjectCoordinates? objParams = GetObjectCoordinates();
            if (objParams is null)
            {
                return false;
            }

            // Проверяем, прижался ли объект к правому и нижнему краю
            return Math.Abs(objParams.RightBorder - FieldWidth) <= GetStep() &&
                   Math.Abs(objParams.DownBorder - FieldHeight) <= GetStep();
        }

        /// <summary>
        /// Логика выбора направления движения к правому нижнему углу
        /// </summary>
        protected override void MoveToTarget()
        {
            ObjectCoordinates? objParams = GetObjectCoordinates();
            if (objParams is null)
            {
                return;
            }

            // Если правая граница объекта еще не у края — идем вправо
            if (FieldWidth - objParams.RightBorder > GetStep())
            {
                MoveRight();
            }

            // Если нижняя граница объекта еще не у края — идем вниз
            if (FieldHeight - objParams.DownBorder > GetStep())
            {
                MoveDown();
            }
        }
    }
}