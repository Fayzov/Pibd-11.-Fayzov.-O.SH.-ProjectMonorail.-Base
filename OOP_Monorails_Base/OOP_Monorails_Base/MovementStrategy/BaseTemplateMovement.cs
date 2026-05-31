using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP_Monorails_Base.MovementStrategy
{
    /// <summary>
    /// Абстрактный класс-шаблон стратегии перемещения объекта к цели
    /// </summary>
    public abstract class BaseTemplateMovement
    {
        /// <summary>
        /// Перемещаемый объект (через интерфейс)
        /// </summary>
        private IMoveableObject? _moveableObject;

        /// <summary>
        /// Текущий статус перемещения
        /// </summary>
        private TemplateMovementStatus _state = TemplateMovementStatus.NotInit;

        /// <summary>
        /// Ширина поля перемещения
        /// </summary>
        protected int FieldWidth { get; private set; }

        /// <summary>
        /// Высота поля перемещения
        /// </summary>
        protected int FieldHeight { get; private set; }

        /// <summary>
        /// Признак того, что цель достигнута
        /// </summary>
        public bool IsFinishReached => _state == TemplateMovementStatus.Finish;

        /// <summary>
        /// Инициализация данных для перемещения
        /// </summary>
        public void SetData(IMoveableObject moveableObject, int width, int height)
        {
            if (moveableObject is null)
            {
                _state = TemplateMovementStatus.NotInit;
                return;
            }
            _state = TemplateMovementStatus.InProgress;
            _moveableObject = moveableObject;
            FieldWidth = width;
            FieldHeight = height;
        }

        /// <summary>
        /// Метод совершения одного шага к цели
        /// </summary>
        public void MakeStep()
        {
            if (_state != TemplateMovementStatus.InProgress)
            {
                return;
            }
            // Если мы уже в цели, меняем статус и выходим
            if (IsTargetDestinaion())
            {
                _state = TemplateMovementStatus.Finish;
                return;
            }
            // Иначе — делаем шаг по направлению к цели
            MoveToTarget();
        }

        // Вспомогательные методы перемещения, доступные наследникам
        protected void MoveLeft() => MoveTo(MovementDirection.Left);
        protected void MoveRight() => MoveTo(MovementDirection.Right);
        protected void MoveUp() => MoveTo(MovementDirection.Up);
        protected void MoveDown() => MoveTo(MovementDirection.Down);

        /// <summary>
        /// Получение координат объекта для расчетов в наследниках
        /// </summary>
        protected ObjectCoordinates? GetObjectCoordinates() => _moveableObject?.ObjectCoordinates;

        /// <summary>
        /// Получение величины шага объекта
        /// </summary>
        protected int GetStep() => _moveableObject?.ObjectStep ?? 0;

        /// <summary>
        /// Абстрактный метод: логика движения к конкретной цели
        /// </summary>
        protected abstract void MoveToTarget();

        /// <summary>
        /// Абстрактный метод: проверка достижения конкретной цели
        /// </summary>
        protected abstract bool IsTargetDestinaion();

        /// <summary>
        /// Приватный метод для совершения физического сдвига через адаптер
        /// </summary>
        private void MoveTo(MovementDirection movementDirection)
        {
            if (_state != TemplateMovementStatus.InProgress || _moveableObject is null)
            {
                return;
            }
            _moveableObject.MoveObject(movementDirection);
        }
    }
}