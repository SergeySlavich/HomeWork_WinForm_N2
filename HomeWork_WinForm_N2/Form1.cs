namespace HomeWork_WinForm_N2
{
    //Задание 4
    //Пользователь вводит дату своего рождения в элементы TextBox.
    //Программа выделяет в элементе MonthCalendar и отображает указанный день.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            int day, month, year;
            if (!Int32.TryParse(textBoxDay.Text, out day))
            {
                MessageBox.Show("Задайте день числом.");
            }
            if (!Int32.TryParse(textBoxMonth.Text, out month))
            {
                MessageBox.Show("Задайте месяц числом.");
            }
            if (!Int32.TryParse(textBoxYear.Text, out year))
            {
                MessageBox.Show("Задайте год числом.");
            }
            if (day > 31 || day < 1)
            {
                MessageBox.Show("Число дней в месяце не может быть больше 31 или меньше 1.");
                day = 1;
            }
            if (month > 12)
            {
                MessageBox.Show("Число месяцев в году не может быть больше 12 или меньше 1.");
                month = 1;
            }
            if (year < 100)
            {
                if (year + 2000 > DateTime.Now.Year)
                {
                    year += 1900;
                }
                else
                {
                    year += 2000;
                }
            }
            else if (year < DateTime.Now.Year && year > 1900)
            {
                return;
            }
            else
            {
                MessageBox.Show("Введите год двумя цифрами или четырьмя.");
                year = DateTime.Now.Year;
            }
            DateTime BDay = new DateTime(year, month, day);
            //monthCalendar1.SelectionRange.Start = BDay;
            monthCalendar1.SetDate(BDay);
            //monthCalendar1.SelectionRange.End = BDay;
            monthCalendar1.Show();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDay.Text = "";
            textBoxMonth.Text = "";
            textBoxYear.Text = "";
            monthCalendar1.SetDate(DateTime.Now);
        }
    }
}