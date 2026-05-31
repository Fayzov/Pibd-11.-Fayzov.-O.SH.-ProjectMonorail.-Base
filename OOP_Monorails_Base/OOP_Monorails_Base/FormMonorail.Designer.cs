namespace OOP_Monorails_Base
{
    partial class FormMonorail
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btnArrowRight;
            pictureBoxMonorail = new PictureBox();
            btnArrowDown = new Button();
            btnArrowUp = new Button();
            btnArrowLeft = new Button();
            btnSizeCheck = new Button();
            comboBoxDestination = new ComboBox();
            buttonStep = new Button();
            buttonCreateSimple = new Button();
            buttonCreateAdvanced = new Button();
            btnArrowRight = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMonorail).BeginInit();
            SuspendLayout();
            // 
            // btnArrowRight
            // 
            btnArrowRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnArrowRight.BackgroundImage = Properties.Resources.RIGHT;
            btnArrowRight.BackgroundImageLayout = ImageLayout.Stretch;
            btnArrowRight.Location = new Point(1060, 449);
            btnArrowRight.Name = "btnArrowRight";
            btnArrowRight.Size = new Size(63, 59);
            btnArrowRight.TabIndex = 5;
            btnArrowRight.UseVisualStyleBackColor = true;
            btnArrowRight.Click += btnMove_Click;
            // 
            // pictureBoxMonorail
            // 
            pictureBoxMonorail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxMonorail.BackColor = Color.Cornsilk;
            pictureBoxMonorail.Location = new Point(0, 0);
            pictureBoxMonorail.Name = "pictureBoxMonorail";
            pictureBoxMonorail.Size = new Size(1178, 549);
            pictureBoxMonorail.TabIndex = 0;
            pictureBoxMonorail.TabStop = false;
            // 
            // btnArrowDown
            // 
            btnArrowDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnArrowDown.BackgroundImage = Properties.Resources.DOWN;
            btnArrowDown.BackgroundImageLayout = ImageLayout.Stretch;
            btnArrowDown.Location = new Point(991, 449);
            btnArrowDown.Name = "btnArrowDown";
            btnArrowDown.Size = new Size(63, 59);
            btnArrowDown.TabIndex = 2;
            btnArrowDown.UseVisualStyleBackColor = true;
            btnArrowDown.Click += btnMove_Click;
            // 
            // btnArrowUp
            // 
            btnArrowUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnArrowUp.BackgroundImage = Properties.Resources.UP;
            btnArrowUp.BackgroundImageLayout = ImageLayout.Stretch;
            btnArrowUp.Location = new Point(991, 384);
            btnArrowUp.Name = "btnArrowUp";
            btnArrowUp.Size = new Size(63, 59);
            btnArrowUp.TabIndex = 3;
            btnArrowUp.UseVisualStyleBackColor = true;
            btnArrowUp.Click += btnMove_Click;
            // 
            // btnArrowLeft
            // 
            btnArrowLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnArrowLeft.BackgroundImage = Properties.Resources.LEFT;
            btnArrowLeft.BackgroundImageLayout = ImageLayout.Stretch;
            btnArrowLeft.Location = new Point(922, 449);
            btnArrowLeft.Name = "btnArrowLeft";
            btnArrowLeft.Size = new Size(63, 59);
            btnArrowLeft.TabIndex = 4;
            btnArrowLeft.UseVisualStyleBackColor = true;
            btnArrowLeft.Click += btnMove_Click;
            // 
            // btnSizeCheck
            // 
            btnSizeCheck.Location = new Point(30, 26);
            btnSizeCheck.Name = "btnSizeCheck";
            btnSizeCheck.Size = new Size(215, 34);
            btnSizeCheck.TabIndex = 6;
            btnSizeCheck.Text = "проверка границ";
            btnSizeCheck.UseVisualStyleBackColor = true;
            btnSizeCheck.Click += ButtonCheckBorders_Click;
            // 
            // comboBoxDestination
            // 
            comboBoxDestination.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDestination.FormattingEnabled = true;
            comboBoxDestination.Items.AddRange(new object[] { "К центру", "К углу" });
            comboBoxDestination.Location = new Point(941, 26);
            comboBoxDestination.Name = "comboBoxDestination";
            comboBoxDestination.Size = new Size(182, 33);
            comboBoxDestination.TabIndex = 7;
            comboBoxDestination.SelectedIndexChanged += comboBoxDestination_SelectedIndexChanged;
            // 
            // buttonStep
            // 
            buttonStep.Location = new Point(1011, 75);
            buttonStep.Name = "buttonStep";
            buttonStep.Size = new Size(112, 34);
            buttonStep.TabIndex = 8;
            buttonStep.Text = "Шаг";
            buttonStep.UseVisualStyleBackColor = true;
            buttonStep.Click += buttonStep_Click;
            // 
            // buttonCreateSimple
            // 
            buttonCreateSimple.Location = new Point(30, 488);
            buttonCreateSimple.Name = "buttonCreateSimple";
            buttonCreateSimple.Size = new Size(168, 34);
            buttonCreateSimple.TabIndex = 9;
            buttonCreateSimple.Text = "Создать простую";
            buttonCreateSimple.UseVisualStyleBackColor = true;
            buttonCreateSimple.Click += buttonCreateSimple_Click;
            // 
            // buttonCreateAdvanced
            // 
            buttonCreateAdvanced.Location = new Point(204, 488);
            buttonCreateAdvanced.Name = "buttonCreateAdvanced";
            buttonCreateAdvanced.Size = new Size(218, 34);
            buttonCreateAdvanced.TabIndex = 10;
            buttonCreateAdvanced.Text = "Создать продвинутую";
            buttonCreateAdvanced.UseVisualStyleBackColor = true;
            buttonCreateAdvanced.Click += buttonCreateAdvanced_Click;
            // 
            // FormMonorail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 544);
            Controls.Add(buttonCreateAdvanced);
            Controls.Add(buttonCreateSimple);
            Controls.Add(buttonStep);
            Controls.Add(comboBoxDestination);
            Controls.Add(btnSizeCheck);
            Controls.Add(btnArrowRight);
            Controls.Add(btnArrowLeft);
            Controls.Add(btnArrowUp);
            Controls.Add(btnArrowDown);
            Controls.Add(pictureBoxMonorail);
            Name = "FormMonorail";
            Text = "Form1";
            Load += FormMonorail_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMonorail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxMonorail;
        private Button btnArrowDown;
        private Button btnArrowUp;
        private Button btnArrowLeft;
        private Button btnArrowRight;
        private Button btnSizeCheck;
        private ComboBox comboBoxDestination;
        private Button buttonStep;
        private Button buttonCreateSimple;
        private Button buttonCreateAdvanced;
    }
}
