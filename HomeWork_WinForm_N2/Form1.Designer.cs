namespace HomeWork_WinForm_N2
{
    partial class Form1
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
            textBoxDay = new TextBox();
            textBoxMonth = new TextBox();
            textBoxYear = new TextBox();
            monthCalendar1 = new MonthCalendar();
            labelBegin = new Label();
            buttonShow = new Button();
            labelDay = new Label();
            labelMonth = new Label();
            labelYear = new Label();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // textBoxDay
            // 
            textBoxDay.Location = new Point(12, 63);
            textBoxDay.Margin = new Padding(3, 2, 3, 2);
            textBoxDay.MaxLength = 2;
            textBoxDay.Name = "textBoxDay";
            textBoxDay.Size = new Size(32, 23);
            textBoxDay.TabIndex = 0;
            // 
            // textBoxMonth
            // 
            textBoxMonth.Location = new Point(50, 63);
            textBoxMonth.Margin = new Padding(3, 2, 3, 2);
            textBoxMonth.MaxLength = 2;
            textBoxMonth.Name = "textBoxMonth";
            textBoxMonth.Size = new Size(41, 23);
            textBoxMonth.TabIndex = 1;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(97, 63);
            textBoxYear.Margin = new Padding(3, 2, 3, 2);
            textBoxYear.MaxLength = 4;
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(39, 23);
            textBoxYear.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(200, 9);
            monthCalendar1.Margin = new Padding(8, 7, 8, 7);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowToday = false;
            monthCalendar1.TabIndex = 3;
            // 
            // labelBegin
            // 
            labelBegin.AutoSize = true;
            labelBegin.Location = new Point(12, 9);
            labelBegin.Name = "labelBegin";
            labelBegin.Size = new Size(177, 15);
            labelBegin.TabIndex = 4;
            labelBegin.Text = "Введите дату своего рождения:";
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(114, 139);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(75, 23);
            buttonShow.TabIndex = 5;
            buttonShow.Text = "Показать";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Location = new Point(12, 38);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(32, 15);
            labelDay.TabIndex = 6;
            labelDay.Text = "день";
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.Location = new Point(50, 38);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(41, 15);
            labelMonth.TabIndex = 7;
            labelMonth.Text = "месяц";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(97, 38);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(25, 15);
            labelYear.TabIndex = 8;
            labelYear.Text = "год";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(18, 140);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 9;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 174);
            Controls.Add(buttonClear);
            Controls.Add(labelYear);
            Controls.Add(labelMonth);
            Controls.Add(labelDay);
            Controls.Add(buttonShow);
            Controls.Add(labelBegin);
            Controls.Add(monthCalendar1);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxMonth);
            Controls.Add(textBoxDay);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDay;
        private TextBox textBoxMonth;
        private TextBox textBoxYear;
        private MonthCalendar monthCalendar1;
        private Label labelBegin;
        private Button buttonShow;
        private Label labelDay;
        private Label labelMonth;
        private Label labelYear;
        private Button buttonClear;
    }
}