namespace OOP_Monorails_Base
{
    partial class FormMonorailConfig
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBoxParams = new GroupBox();
            checkBoxLines = new CheckBox();
            checkBoxPlatform = new CheckBox();
            labelWeight = new Label();
            labelSpeed = new Label();
            numericUpDownWeight = new NumericUpDown();
            numericUpDownSpeed = new NumericUpDown();
            groupBoxColors = new GroupBox();
            panelPurple = new Panel();
            panelBlack = new Panel();
            panelGray = new Panel();
            panelWhite = new Panel();
            panelYellow = new Panel();
            panelBlue = new Panel();
            panelGreen = new Panel();
            panelRed = new Panel();
            pictureBoxObject = new PictureBox();
            groupBoxTypes = new GroupBox();
            labelAdvanced = new Label();
            labelSimple = new Label();
            panelTarget = new Panel();
            labelSecondaryColor = new Label();
            labelBaseColor = new Label();
            buttonAdd = new Button();
            buttonCancel = new Button();
            groupBoxParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).BeginInit();
            groupBoxColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxObject).BeginInit();
            groupBoxTypes.SuspendLayout();
            panelTarget.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxParams
            // 
            groupBoxParams.Controls.Add(buttonCancel);
            groupBoxParams.Controls.Add(checkBoxLines);
            groupBoxParams.Controls.Add(buttonAdd);
            groupBoxParams.Controls.Add(checkBoxPlatform);
            groupBoxParams.Controls.Add(labelWeight);
            groupBoxParams.Controls.Add(labelSpeed);
            groupBoxParams.Controls.Add(numericUpDownWeight);
            groupBoxParams.Controls.Add(numericUpDownSpeed);
            groupBoxParams.Location = new Point(15, 15);
            groupBoxParams.Margin = new Padding(4, 4, 4, 4);
            groupBoxParams.Name = "groupBoxParams";
            groupBoxParams.Padding = new Padding(4, 4, 4, 4);
            groupBoxParams.Size = new Size(305, 344);
            groupBoxParams.TabIndex = 0;
            groupBoxParams.TabStop = false;
            groupBoxParams.Text = "Параметры";
            // 
            // checkBoxLines
            // 
            checkBoxLines.AutoSize = true;
            checkBoxLines.Location = new Point(19, 185);
            checkBoxLines.Margin = new Padding(4, 4, 4, 4);
            checkBoxLines.Name = "checkBoxLines";
            checkBoxLines.Size = new Size(171, 29);
            checkBoxLines.TabIndex = 5;
            checkBoxLines.Text = "Есть конт. линии";
            checkBoxLines.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlatform
            // 
            checkBoxPlatform.AutoSize = true;
            checkBoxPlatform.Location = new Point(19, 148);
            checkBoxPlatform.Margin = new Padding(4, 4, 4, 4);
            checkBoxPlatform.Name = "checkBoxPlatform";
            checkBoxPlatform.Size = new Size(221, 29);
            checkBoxPlatform.TabIndex = 4;
            checkBoxPlatform.Text = "Магнитная платформа";
            checkBoxPlatform.UseVisualStyleBackColor = true;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(19, 94);
            labelWeight.Margin = new Padding(4, 0, 4, 0);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(43, 25);
            labelWeight.TabIndex = 3;
            labelWeight.Text = "Вес:";
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Location = new Point(19, 51);
            labelSpeed.Margin = new Padding(4, 0, 4, 0);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(93, 25);
            labelSpeed.TabIndex = 2;
            labelSpeed.Text = "Скорость:";
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.Location = new Point(135, 91);
            numericUpDownWeight.Margin = new Padding(4, 4, 4, 4);
            numericUpDownWeight.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownWeight.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(150, 31);
            numericUpDownWeight.TabIndex = 1;
            numericUpDownWeight.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // numericUpDownSpeed
            // 
            numericUpDownSpeed.Location = new Point(135, 49);
            numericUpDownSpeed.Margin = new Padding(4, 4, 4, 4);
            numericUpDownSpeed.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownSpeed.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownSpeed.Name = "numericUpDownSpeed";
            numericUpDownSpeed.Size = new Size(150, 31);
            numericUpDownSpeed.TabIndex = 0;
            numericUpDownSpeed.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // groupBoxColors
            // 
            groupBoxColors.Controls.Add(panelPurple);
            groupBoxColors.Controls.Add(panelBlack);
            groupBoxColors.Controls.Add(panelGray);
            groupBoxColors.Controls.Add(panelWhite);
            groupBoxColors.Controls.Add(panelYellow);
            groupBoxColors.Controls.Add(panelBlue);
            groupBoxColors.Controls.Add(panelGreen);
            groupBoxColors.Controls.Add(panelRed);
            groupBoxColors.Location = new Point(344, 15);
            groupBoxColors.Margin = new Padding(4, 4, 4, 4);
            groupBoxColors.Name = "groupBoxColors";
            groupBoxColors.Padding = new Padding(4, 4, 4, 4);
            groupBoxColors.Size = new Size(251, 188);
            groupBoxColors.TabIndex = 1;
            groupBoxColors.TabStop = false;
            groupBoxColors.Text = "Цвета";
            // 
            // panelPurple
            // 
            panelPurple.BackColor = Color.Purple;
            panelPurple.BorderStyle = BorderStyle.FixedSingle;
            panelPurple.Location = new Point(185, 106);
            panelPurple.Margin = new Padding(4, 4, 4, 4);
            panelPurple.Name = "panelPurple";
            panelPurple.Size = new Size(50, 50);
            panelPurple.TabIndex = 7;
            panelPurple.MouseDown += PanelColor_MouseDown;
            // 
            // panelBlack
            // 
            panelBlack.BackColor = Color.Black;
            panelBlack.BorderStyle = BorderStyle.FixedSingle;
            panelBlack.Location = new Point(128, 106);
            panelBlack.Margin = new Padding(4, 4, 4, 4);
            panelBlack.Name = "panelBlack";
            panelBlack.Size = new Size(50, 50);
            panelBlack.TabIndex = 6;
            panelBlack.MouseDown += PanelColor_MouseDown;
            // 
            // panelGray
            // 
            panelGray.BackColor = Color.Gray;
            panelGray.BorderStyle = BorderStyle.FixedSingle;
            panelGray.Location = new Point(70, 106);
            panelGray.Margin = new Padding(4, 4, 4, 4);
            panelGray.Name = "panelGray";
            panelGray.Size = new Size(50, 50);
            panelGray.TabIndex = 5;
            panelGray.MouseDown += PanelColor_MouseDown;
            // 
            // panelWhite
            // 
            panelWhite.BackColor = Color.White;
            panelWhite.BorderStyle = BorderStyle.FixedSingle;
            panelWhite.Location = new Point(12, 106);
            panelWhite.Margin = new Padding(4, 4, 4, 4);
            panelWhite.Name = "panelWhite";
            panelWhite.Size = new Size(50, 50);
            panelWhite.TabIndex = 4;
            panelWhite.MouseDown += PanelColor_MouseDown;
            // 
            // panelYellow
            // 
            panelYellow.BackColor = Color.Yellow;
            panelYellow.BorderStyle = BorderStyle.FixedSingle;
            panelYellow.Location = new Point(185, 38);
            panelYellow.Margin = new Padding(4, 4, 4, 4);
            panelYellow.Name = "panelYellow";
            panelYellow.Size = new Size(50, 50);
            panelYellow.TabIndex = 3;
            panelYellow.MouseDown += PanelColor_MouseDown;
            // 
            // panelBlue
            // 
            panelBlue.BackColor = Color.Blue;
            panelBlue.BorderStyle = BorderStyle.FixedSingle;
            panelBlue.Location = new Point(128, 38);
            panelBlue.Margin = new Padding(4, 4, 4, 4);
            panelBlue.Name = "panelBlue";
            panelBlue.Size = new Size(50, 50);
            panelBlue.TabIndex = 2;
            panelBlue.MouseDown += PanelColor_MouseDown;
            // 
            // panelGreen
            // 
            panelGreen.BackColor = Color.Green;
            panelGreen.BorderStyle = BorderStyle.FixedSingle;
            panelGreen.Location = new Point(70, 38);
            panelGreen.Margin = new Padding(4, 4, 4, 4);
            panelGreen.Name = "panelGreen";
            panelGreen.Size = new Size(50, 50);
            panelGreen.TabIndex = 1;
            panelGreen.MouseDown += PanelColor_MouseDown;
            // 
            // panelRed
            // 
            panelRed.BackColor = Color.Red;
            panelRed.BorderStyle = BorderStyle.FixedSingle;
            panelRed.Location = new Point(12, 38);
            panelRed.Margin = new Padding(4, 4, 4, 4);
            panelRed.Name = "panelRed";
            panelRed.Size = new Size(50, 50);
            panelRed.TabIndex = 0;
            panelRed.MouseDown += PanelColor_MouseDown;
            // 
            // pictureBoxObject
            // 
            pictureBoxObject.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxObject.Location = new Point(618, 15);
            pictureBoxObject.Margin = new Padding(4, 4, 4, 4);
            pictureBoxObject.Name = "pictureBoxObject";
            pictureBoxObject.Size = new Size(395, 188);
            pictureBoxObject.TabIndex = 2;
            pictureBoxObject.TabStop = false;
            // 
            // groupBoxTypes
            // 
            groupBoxTypes.Controls.Add(labelAdvanced);
            groupBoxTypes.Controls.Add(labelSimple);
            groupBoxTypes.Location = new Point(344, 225);
            groupBoxTypes.Margin = new Padding(4, 4, 4, 4);
            groupBoxTypes.Name = "groupBoxTypes";
            groupBoxTypes.Padding = new Padding(4, 4, 4, 4);
            groupBoxTypes.Size = new Size(251, 134);
            groupBoxTypes.TabIndex = 3;
            groupBoxTypes.TabStop = false;
            groupBoxTypes.Text = "Тип объекта";
            // 
            // labelAdvanced
            // 
            labelAdvanced.BorderStyle = BorderStyle.FixedSingle;
            labelAdvanced.Location = new Point(12, 85);
            labelAdvanced.Margin = new Padding(4, 0, 4, 0);
            labelAdvanced.Name = "labelAdvanced";
            labelAdvanced.Size = new Size(222, 37);
            labelAdvanced.TabIndex = 1;
            labelAdvanced.Text = "Продвинутый";
            labelAdvanced.TextAlign = ContentAlignment.MiddleCenter;
            labelAdvanced.MouseDown += LabelObject_MouseDown;
            // 
            // labelSimple
            // 
            labelSimple.BorderStyle = BorderStyle.FixedSingle;
            labelSimple.Location = new Point(12, 38);
            labelSimple.Margin = new Padding(4, 0, 4, 0);
            labelSimple.Name = "labelSimple";
            labelSimple.Size = new Size(222, 37);
            labelSimple.TabIndex = 0;
            labelSimple.Text = "Простой";
            labelSimple.TextAlign = ContentAlignment.MiddleCenter;
            labelSimple.MouseDown += LabelObject_MouseDown;
            // 
            // panelTarget
            // 
            panelTarget.AllowDrop = true;
            panelTarget.BorderStyle = BorderStyle.Fixed3D;
            panelTarget.Controls.Add(labelSecondaryColor);
            panelTarget.Controls.Add(labelBaseColor);
            panelTarget.Location = new Point(618, 241);
            panelTarget.Margin = new Padding(4, 4, 4, 4);
            panelTarget.Name = "panelTarget";
            panelTarget.Size = new Size(412, 118);
            panelTarget.TabIndex = 4;
            panelTarget.DragDrop += PanelObject_DragDrop;
            panelTarget.DragEnter += PanelObject_DragEnter;
            // 
            // labelSecondaryColor
            // 
            labelSecondaryColor.BorderStyle = BorderStyle.FixedSingle;
            labelSecondaryColor.Location = new Point(219, 25);
            labelSecondaryColor.Margin = new Padding(4, 0, 4, 0);
            labelSecondaryColor.Name = "labelSecondaryColor";
            labelSecondaryColor.Size = new Size(174, 74);
            labelSecondaryColor.TabIndex = 1;
            labelSecondaryColor.Text = "Доп. цвет";
            labelSecondaryColor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelBaseColor
            // 
            labelBaseColor.BorderStyle = BorderStyle.FixedSingle;
            labelBaseColor.Location = new Point(19, 25);
            labelBaseColor.Margin = new Padding(4, 0, 4, 0);
            labelBaseColor.Name = "labelBaseColor";
            labelBaseColor.Size = new Size(174, 74);
            labelBaseColor.TabIndex = 0;
            labelBaseColor.Text = "Основной цвет";
            labelBaseColor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(165, 284);
            buttonAdd.Margin = new Padding(4, 4, 4, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(120, 44);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(19, 284);
            buttonCancel.Margin = new Padding(4, 4, 4, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(120, 44);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormMonorailConfig
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 388);
            Controls.Add(panelTarget);
            Controls.Add(groupBoxTypes);
            Controls.Add(pictureBoxObject);
            Controls.Add(groupBoxColors);
            Controls.Add(groupBoxParams);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMonorailConfig";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Конфигуратор монорельса";
            groupBoxParams.ResumeLayout(false);
            groupBoxParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).EndInit();
            groupBoxColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxObject).EndInit();
            groupBoxTypes.ResumeLayout(false);
            panelTarget.ResumeLayout(false);
            ResumeLayout(false);
        }

        private GroupBox groupBoxParams;
        private Label labelWeight;
        private Label labelSpeed;
        private NumericUpDown numericUpDownWeight;
        private NumericUpDown numericUpDownSpeed;
        private CheckBox checkBoxLines;
        private CheckBox checkBoxPlatform;
        private GroupBox groupBoxColors;
        private Panel panelPurple;
        private Panel panelBlack;
        private Panel panelGray;
        private Panel panelWhite;
        private Panel panelYellow;
        private Panel panelBlue;
        private Panel panelGreen;
        private Panel panelRed;
        private PictureBox pictureBoxObject;
        private GroupBox groupBoxTypes;
        private Label labelAdvanced;
        private Label labelSimple;
        private Panel panelTarget;
        private Label labelSecondaryColor;
        private Label labelBaseColor;
        private Button buttonAdd;
        private Button buttonCancel;
    }
}