using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Monorails_Base.MovementStrategy
{
    /// <summary>
    /// Реализация стратегии перемещения объекта в центр экрана
    /// </summary>
    public class MoveToCenter : BaseTemplateMovement
    {
        /// <summary>
        /// Проверка, достиг ли центр объекта центра поля
        /// </summary>
        protected override bool IsTargetDestinaion()
        {
            ObjectCoordinates? objParams = GetObjectCoordinates();
            if (objParams is null)
            {
                return false;
            }

            // Проверяем расстояние от центра объекта до центра поля по обеим осям
            return Math.Abs(objParams.ObjectMiddleHorizontal - FieldWidth / 2) <= GetStep() &&
                   Math.Abs(objParams.ObjectMiddleVertical - FieldHeight / 2) <= GetStep();
        }

        /// <summary>
        /// Логика выбора направления движения к центру
        /// </summary>
        protected override void MoveToTarget()
        {
            ObjectCoordinates? objParams = GetObjectCoordinates();
            if (objParams is null)
            {
                return;
            }

            // Расчет отклонения по горизонтали
            int diffX = objParams.ObjectMiddleHorizontal - FieldWidth / 2;
            if (Math.Abs(diffX) > GetStep())
            {
                if (diffX > 0) MoveLeft();
                else MoveRight();
            }

            // Расчет отклонения по вертикали
            int diffY = objParams.ObjectMiddleVertical - FieldHeight / 2;
            if (Math.Abs(diffY) > GetStep())
            {
                if (diffY > 0) MoveUp();
                else MoveDown();
            }
        }
    }
}