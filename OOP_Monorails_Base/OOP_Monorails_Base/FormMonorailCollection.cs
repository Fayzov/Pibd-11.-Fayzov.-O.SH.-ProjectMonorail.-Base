using OOP_Monorails_Base.Collections;
using OOP_Monorails_Base.Drawnings;

namespace OOP_Monorails_Base
{
    public partial class FormMonorailCollection : Form
    {
        // Ссылка на текущую выбранную станцию (абстракция из Лабы 3)
        private AbstractCompany? _company;

        // Хранилище всех станций (новое в Лабе 4)
        private readonly StorageCompanies _storageCompanies;

        public FormMonorailCollection()
        {
            InitializeComponent();
            // Инициализируем хранилище, передавая размеры области рисования
            _storageCompanies = new StorageCompanies(pictureBoxDepot.Width, pictureBoxDepot.Height);
        }

        // Обновление списка названий станций в ListBox (используем foreach по требованию Лабы 4)
        private void RefreshListBox()
        {
            listBoxCompanies.Items.Clear();
            foreach (var key in _storageCompanies.StorageKeys)
            {
                listBoxCompanies.Items.Add(key);
            }

            // Если ничего не выбрано, очищаем поле прорисовки
            if (listBoxCompanies.SelectedIndex == -1)
            {
                _company = null;
                pictureBoxDepot.Image = null;
            }
        }

        // Метод отрисовки текущей станции
        private void Draw() => pictureBoxDepot.Image = _company?.Show();

        /* --- Логика управления ХРАНИЛИЩЕМ (Лабораторная №4) --- */
        private void buttonCompanyAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCompanyName.Text))
            {
                MessageBox.Show("Введите название станции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CollectionType type = CollectionType.None;
            if (radioButtonMassive.Checked) type = CollectionType.Massive;
            else if (radioButtonList.Checked) type = CollectionType.List;
            else if (radioButtonLinkedList.Checked) type = CollectionType.LinkedList;

            if (type == CollectionType.None)
            {
                MessageBox.Show("Выберите способ хранения (Массив/Список/Связанный список)", "Ошибка");
                return;
            }
            _storageCompanies.AddCompany(textBoxCompanyName.Text, type);
            RefreshListBox();
        }



        // Выбор станции из списка
        private void listBoxCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? name = listBoxCompanies.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(name)) return;

            // Использование ИНДЕКСАТОРА (требование Лабы 4)
            _company = _storageCompanies[name];
            Draw();
        }

        // Удаление выбранной станции
        private void buttonCompanyDel_Click(object sender, EventArgs e)
        {
            if (listBoxCompanies.SelectedIndex == -1) return;

            string name = listBoxCompanies.SelectedItem!.ToString()!;
            if (MessageBox.Show($"Удалить станцию '{name}' из хранилища?", "Удаление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _storageCompanies.DelCompany(name);
                RefreshListBox();
            }
        }



        private void buttonCreateSimple_Click(object sender, EventArgs e) =>
            CreateAndAddObjectToCollection(nameof(DrawingMonorail));

        private void buttonCreateAdvanced_Click(object sender, EventArgs e) =>
            CreateAndAddObjectToCollection(nameof(DrawingAdvancedMonorail));

        private void CreateAndAddObjectToCollection(string type)
        {
            if (_company == null)
            {
                MessageBox.Show("Сначала выберите или создайте станцию!", "Внимание");
                return;
            }

            Random random = new();
            DrawingMonorail? monorail = null;

            if (type == nameof(DrawingMonorail))
            {
                monorail = new DrawingMonorail(random.Next(100, 300), random.Next(1000, 3000), GetColor(random));
            }
            else if (type == nameof(DrawingAdvancedMonorail))
            {
                monorail = new DrawingAdvancedMonorail(random.Next(100, 300), random.Next(1000, 3000),
                    GetColor(random), GetColor(random), true, true);
            }

            // Специализированный полиморфизм: оператор + (Лаба 3)
            if (monorail != null && (_company + monorail))
            {
                Draw();
            }
            else
            {
                MessageBox.Show("Не удалось добавить объект (место занято или депо заполнено)");
            }
        }

        private static Color GetColor(Random random)
        {
            using ColorDialog dialog = new();
            return dialog.ShowDialog() == DialogResult.OK ? dialog.Color :
                Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (_company == null || string.IsNullOrEmpty(maskedTextBoxPosition.Text)) return;

            int pos = Convert.ToInt32(maskedTextBoxPosition.Text);
            // Специализированный полиморфизм: оператор - (Лаба 3)
            if (_company - pos)
            {
                Draw();
            }
            else
            {
                MessageBox.Show("Ошибка удаления: неверный индекс или пустая ячейка");
            }
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            if (_company == null) return;

            var monorail = _company.GetRandomObject();
            if (monorail == null)
            {
                MessageBox.Show("На станции нет монорельсов для тестирования!");
                return;
            }

            FormMonorail testForm = new();
            testForm.SetDrawingMonorail(monorail);
            testForm.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e) => Draw();

        // Обработчик вызова формы-конструктора
        private void buttonAddConfig_Click(object sender, EventArgs e)
        {
            if (_company == null)
            {
                MessageBox.Show("Сначала выберите или создайте станцию!", "Ошибка");
                return;
            }

            // 1. Создаем экземпляр формы конфигурации
            FormMonorailConfig form = new();

            // 2. Подписываемся на её событие через встроенный делегат Action
            // Мы передаем в форму метод AddObjectToCollection
            form.AddEvent(AddObjectToCollection);

            // 3. Открываем форму методом Show (немодально), чтобы можно было
            // вызвать сразу несколько таких окон (требование Лабы 5)
            form.Show();
        }

        // Метод-обработчик, который получит объект из второй формы (Лаба 5)
        private void AddObjectToCollection(DrawingMonorail monorail)
        {
            // Используем уже готовую логику добавления через оператор +
            if (_company != null && (_company + monorail))
            {
                Draw(); // Перерисовываем депо, чтобы увидеть новый поезд
            }
            else
            {
                MessageBox.Show("Не удалось добавить объект (возможно, депо заполнено)");
            }
        }
    }
}