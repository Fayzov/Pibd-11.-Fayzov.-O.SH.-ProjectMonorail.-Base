namespace OOP_Monorails_Base
{
    partial class FormMonorailCollection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTools = new Panel();
            buttonAddConfig = new Button();
            buttonCompanyDel = new Button();
            listBoxCompanies = new ListBox();
            buttonCompanyAdd = new Button();
            groupBoxType = new GroupBox();
            radioButtonLinkedList = new RadioButton();
            radioButtonList = new RadioButton();
            radioButtonMassive = new RadioButton();
            textBoxCompanyName = new TextBox();
            labelCompanyName = new Label();
            buttonRefresh = new Button();
            buttonTransfer = new Button();
            buttonRemove = new Button();
            maskedTextBoxPosition = new MaskedTextBox();
            labelPosition = new Label();
            buttonCreateAdvanced = new Button();
            buttonCreateSimple = new Button();
            labelTools = new Label();
            pictureBoxDepot = new PictureBox();
            panelTools.SuspendLayout();
            groupBoxType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDepot).BeginInit();
            SuspendLayout();
            // 
            // panelTools
            // 
            panelTools.Controls.Add(buttonAddConfig);
            panelTools.Controls.Add(buttonCompanyDel);
            panelTools.Controls.Add(listBoxCompanies);
            panelTools.Controls.Add(buttonCompanyAdd);
            panelTools.Controls.Add(groupBoxType);
            panelTools.Controls.Add(textBoxCompanyName);
            panelTools.Controls.Add(labelCompanyName);
            panelTools.Controls.Add(buttonRefresh);
            panelTools.Controls.Add(buttonTransfer);
            panelTools.Controls.Add(buttonRemove);
            panelTools.Controls.Add(maskedTextBoxPosition);
            panelTools.Controls.Add(labelPosition);
            panelTools.Controls.Add(buttonCreateAdvanced);
            panelTools.Controls.Add(buttonCreateSimple);
            panelTools.Controls.Add(labelTools);
            panelTools.Dock = DockStyle.Right;
            panelTools.Location = new Point(852, 0);
            panelTools.Name = "panelTools";
            panelTools.Size = new Size(250, 704);
            panelTools.TabIndex = 0;
            // 
            // buttonAddConfig
            // 
            buttonAddConfig.Location = new Point(20, 428);
            buttonAddConfig.Name = "buttonAddConfig";
            buttonAddConfig.Size = new Size(214, 63);
            buttonAddConfig.TabIndex = 16;
            buttonAddConfig.Text = "Добавить через конструктор";
            buttonAddConfig.UseVisualStyleBackColor = true;
            buttonAddConfig.Click += buttonAddConfig_Click;
            // 
            // buttonCompanyDel
            // 
            buttonCompanyDel.Location = new Point(20, 378);
            buttonCompanyDel.Name = "buttonCompanyDel";
            buttonCompanyDel.Size = new Size(214, 34);
            buttonCompanyDel.TabIndex = 15;
            buttonCompanyDel.Text = "Удалить станцию";
            buttonCompanyDel.UseVisualStyleBackColor = true;
            buttonCompanyDel.Click += buttonCompanyDel_Click;
            // 
            // listBoxCompanies
            // 
            listBoxCompanies.Cursor = Cursors.Hand;
            listBoxCompanies.FormattingEnabled = true;
            listBoxCompanies.Location = new Point(20, 243);
            listBoxCompanies.Name = "listBoxCompanies";
            listBoxCompanies.RightToLeft = RightToLeft.No;
            listBoxCompanies.Size = new Size(214, 129);
            listBoxCompanies.TabIndex = 14;
            listBoxCompanies.Click += listBoxCompanies_SelectedIndexChanged;
            // 
            // buttonCompanyAdd
            // 
            buttonCompanyAdd.Location = new Point(20, 200);
            buttonCompanyAdd.Name = "buttonCompanyAdd";
            buttonCompanyAdd.Size = new Size(214, 34);
            buttonCompanyAdd.TabIndex = 13;
            buttonCompanyAdd.Text = "Добавить станцию";
            buttonCompanyAdd.UseVisualStyleBackColor = true;
            buttonCompanyAdd.Click += buttonCompanyAdd_Click;
            // 
            // groupBoxType
            // 
            groupBoxType.Controls.Add(radioButtonLinkedList);
            groupBoxType.Controls.Add(radioButtonList);
            groupBoxType.Controls.Add(radioButtonMassive);
            groupBoxType.Location = new Point(25, 24);
            groupBoxType.Name = "groupBoxType";
            groupBoxType.Size = new Size(207, 111);
            groupBoxType.TabIndex = 12;
            groupBoxType.TabStop = false;
            groupBoxType.Text = "Тип коллекции";
            // 
            // radioButtonLinkedList
            // 
            radioButtonLinkedList.AutoSize = true;
            radioButtonLinkedList.Location = new Point(11, 69);
            radioButtonLinkedList.Name = "radioButtonLinkedList";
            radioButtonLinkedList.Size = new Size(188, 29);
            radioButtonLinkedList.TabIndex = 2;
            radioButtonLinkedList.TabStop = true;
            radioButtonLinkedList.Text = "Связанный список";
            radioButtonLinkedList.UseVisualStyleBackColor = true;
            // 
            // radioButtonList
            // 
            radioButtonList.AutoSize = true;
            radioButtonList.Location = new Point(110, 31);
            radioButtonList.Name = "radioButtonList";
            radioButtonList.Size = new Size(96, 29);
            radioButtonList.TabIndex = 1;
            radioButtonList.TabStop = true;
            radioButtonList.Text = "Список";
            radioButtonList.UseVisualStyleBackColor = true;
            // 
            // radioButtonMassive
            // 
            radioButtonMassive.AutoSize = true;
            radioButtonMassive.Location = new Point(9, 32);
            radioButtonMassive.Name = "radioButtonMassive";
            radioButtonMassive.Size = new Size(98, 29);
            radioButtonMassive.TabIndex = 0;
            radioButtonMassive.TabStop = true;
            radioButtonMassive.Text = "Массив";
            radioButtonMassive.UseVisualStyleBackColor = true;
            radioButtonMassive.CheckedChanged += listBoxCompanies_SelectedIndexChanged;
            // 
            // textBoxCompanyName
            // 
            textBoxCompanyName.Location = new Point(20, 164);
            textBoxCompanyName.Name = "textBoxCompanyName";
            textBoxCompanyName.Size = new Size(214, 31);
            textBoxCompanyName.TabIndex = 11;
            // 
            // labelCompanyName
            // 
            labelCompanyName.AutoSize = true;
            labelCompanyName.Location = new Point(20, 138);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(164, 25);
            labelCompanyName.TabIndex = 10;
            labelCompanyName.Text = "Название станции:";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(124, 654);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(108, 38);
            buttonRefresh.TabIndex = 9;
            buttonRefresh.Text = "Обновить депо";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonTransfer
            // 
            buttonTransfer.Location = new Point(20, 654);
            buttonTransfer.Name = "buttonTransfer";
            buttonTransfer.Size = new Size(98, 38);
            buttonTransfer.TabIndex = 8;
            buttonTransfer.Text = "На тесты";
            buttonTransfer.UseVisualStyleBackColor = true;
            buttonTransfer.Click += buttonTransfer_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(111, 616);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(123, 35);
            buttonRemove.TabIndex = 7;
            buttonRemove.Text = "Удалить монорельс";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // maskedTextBoxPosition
            // 
            maskedTextBoxPosition.Location = new Point(20, 618);
            maskedTextBoxPosition.Mask = "00";
            maskedTextBoxPosition.Name = "maskedTextBoxPosition";
            maskedTextBoxPosition.Size = new Size(85, 31);
            maskedTextBoxPosition.TabIndex = 6;
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Location = new Point(20, 587);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(193, 25);
            labelPosition.TabIndex = 5;
            labelPosition.Text = "Позиция удаления ТС:";
            // 
            // buttonCreateAdvanced
            // 
            buttonCreateAdvanced.Location = new Point(20, 544);
            buttonCreateAdvanced.Name = "buttonCreateAdvanced";
            buttonCreateAdvanced.Size = new Size(214, 39);
            buttonCreateAdvanced.TabIndex = 4;
            buttonCreateAdvanced.Text = "Создать продвинутый";
            buttonCreateAdvanced.UseVisualStyleBackColor = true;
            buttonCreateAdvanced.Click += buttonCreateAdvanced_Click;
            // 
            // buttonCreateSimple
            // 
            buttonCreateSimple.Location = new Point(20, 505);
            buttonCreateSimple.Name = "buttonCreateSimple";
            buttonCreateSimple.Size = new Size(214, 34);
            buttonCreateSimple.TabIndex = 3;
            buttonCreateSimple.Text = "Создать простой";
            buttonCreateSimple.UseVisualStyleBackColor = true;
            buttonCreateSimple.Click += buttonCreateSimple_Click;
            // 
            // labelTools
            // 
            labelTools.AutoSize = true;
            labelTools.Location = new Point(-4, 0);
            labelTools.Name = "labelTools";
            labelTools.Size = new Size(122, 25);
            labelTools.TabIndex = 2;
            labelTools.Text = "Инструменты";
            // 
            // pictureBoxDepot
            // 
            pictureBoxDepot.Dock = DockStyle.Fill;
            pictureBoxDepot.Location = new Point(0, 0);
            pictureBoxDepot.Name = "pictureBoxDepot";
            pictureBoxDepot.Size = new Size(852, 704);
            pictureBoxDepot.TabIndex = 1;
            pictureBoxDepot.TabStop = false;
            // 
            // FormMonorailCollection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 704);
            Controls.Add(pictureBoxDepot);
            Controls.Add(panelTools);
            Name = "FormMonorailCollection";
            Text = "Депо монорельсов";
            panelTools.ResumeLayout(false);
            panelTools.PerformLayout();
            groupBoxType.ResumeLayout(false);
            groupBoxType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDepot).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTools;
        private Button buttonCreateSimple;
        private Label labelTools;
        private PictureBox pictureBoxDepot;
        private Button buttonRemove;
        private MaskedTextBox maskedTextBoxPosition;
        private Label labelPosition;
        private Button buttonCreateAdvanced;
        private Button buttonTransfer;
        private Button buttonRefresh;
        private TextBox textBoxCompanyName;
        private Label labelCompanyName;
        private GroupBox groupBoxType;
        private RadioButton radioButtonList;
        private RadioButton radioButtonMassive;
        private RadioButton radioButtonLinkedList;
        private ListBox listBoxCompanies;
        private Button buttonCompanyAdd;
        private Button buttonCompanyDel;
        private Button buttonAddConfig;
    }
}