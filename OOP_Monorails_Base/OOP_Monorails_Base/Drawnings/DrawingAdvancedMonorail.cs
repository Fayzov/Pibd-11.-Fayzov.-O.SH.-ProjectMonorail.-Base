using System.Drawing;
using OOP_Monorails_Base.Entities;

namespace OOP_Monorails_Base.Drawnings
{
    /// <summary>
    /// Класс прорисовки продвинутого монорельса
    /// </summary>
    public class DrawingAdvancedMonorail : DrawingMonorail
    {
        /// <summary>
        /// Конструктор: передает в базу новые размеры (110x70) и создает продвинутую сущность
        /// </summary>
        public DrawingAdvancedMonorail(int speed, double weight, Color bodyColor,
            Color additionalColor, bool magnetic, bool lines) : base(155, 90)
        {
            _entityMonorail = new EntityAdvancedMonorail(speed, weight, bodyColor, additionalColor, magnetic, lines);
        }

        // Метод изменения доп. цвета через сущность
        public void SetSecondaryColor(Color color)
        {
            if (_entityMonorail is EntityAdvancedMonorail advanced)
            {
                advanced.SetSecondaryColor(color);
            }
        }

        /// <summary>
        /// Переопределенный метод прорисовки
        /// </summary>
        public override void DrawTransport(Graphics g)
        {
            if (_entityMonorail is not EntityAdvancedMonorail entity || !_startPosX.HasValue || !_startPosY.HasValue)
            {
                return;
            }

            int x = _startPosX.Value;
            int y = _startPosY.Value;

            Pen blackPen = new Pen(Color.Black, 2);
            Brush additionalBrush = new SolidBrush(entity.AdditionalColor);

            // 1. Контактные линии (сверху) [7, 8]
            if (entity.HasContactLines)
            {
                // Рисуем пантографы сверху
                g.DrawLine(blackPen, x + 40, y + 10, x + 40, y);
                g.DrawLine(blackPen, x + 100, y + 10, x + 100, y);
                g.DrawLine(blackPen, x + 30, y, x + 110, y);
            }

            // 2. Смещаем отрисовку базовой части вниз, чтобы она не перекрыла линии сверху
            _startPosY += 10;
            base.DrawTransport(g); // Вызов отрисовки простого монорельса
            _startPosY -= 10; // Возвращаем координату на место для дальнейших расчетов

            // 3. Магнитная платформа 
            if (entity.HasMagneticPlatform)
            {
                // Колеса в базе заканчиваются на y + 10(смещение) + 59 = 69. Рисуем платформу ниже.
                g.FillRectangle(additionalBrush, x + 5, y + 70, 140, 8);
                g.DrawRectangle(blackPen, x + 5, y + 70, 140, 8);
            }

            additionalBrush.Dispose();
            blackPen.Dispose();
        }
    }
}
