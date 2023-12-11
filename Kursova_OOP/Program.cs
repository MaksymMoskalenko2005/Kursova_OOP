namespace Kursova_OOP
{
    public class Bank
    {
        public String name;
        public String adress;
        public double percent_1month;
        public double percent_3month;
        public double percent_6month;
        public double percent_12month;
        public bool isGovermental;
        public Bank(string name,
                    string adress,
                    double percent_1month,
                    double percent_3month,
                    double percent_6month,
                    double percent_12month,
                    bool isGovermental)
        {
            this.name = name;
            this.adress = adress;
            this.percent_1month = percent_1month;
            this.percent_3month = percent_3month;
            this.percent_6month = percent_6month;
            this.percent_12month = percent_12month;
            this.isGovermental = isGovermental;
        }
    }
    public class DataBase
    {
        static public List<Bank> banks = new List<Bank>();
        public void BanksData()
        {//                     Name           Adress       1m  3m   6m  1y форма вл.
            banks.Add(new Bank("Приватбанк", "Соборна 10", 2.1,4.5, 12.9, 15.1, true));
            banks.Add(new Bank("Ощадбанк","Травнева 22", 2.3,  4.1, 13.1, 14.8, true));
            banks.Add(new Bank("Альфабанк", "Петлюри 15", 2.2, 5.1, 11.3, 13.9, false));
            banks.Add(new Bank("Пумб", "Бандери 88", 2.9, 4.9, 10.9, 12.3, false));
            banks.Add(new Bank("Райфайзен", "Палія 39", 3.1, 4.4, 11.1, 11.9, false));
            banks.Add(new Bank("Таскомбанк", "Брандта 9", 1.9, 5.3, 10.5, 12.2, false));
            banks.Add(new Bank("Універсал банк", "Лугова 19", 2.5, 4.2, 12.4, 13.1, false));
            banks.Add(new Bank("Індустріал банк", "Петлюри 17", 2.4, 5.4, 11.7, 12.7, false));
            banks.Add(new Bank("Otp банк", "Шевченка 66", 1.8, 4.8, 10.3, 10.9, false));
            banks.Add(new Bank("Банк Альянс", "Річна 12", 2.6, 5.2, 10.8, 12.1, false));
        }
    }
    public class SortMethods : DataBase
    {
        public void SortByPercent_1month()
        {
            for (int i = 0; i < banks.Count - 1; i++)
            {
                for (int j = 0; j < banks.Count - i - 1; j++)
                {
                    // Порівнюємо сусідні елементи
                    if (banks[j].percent_1month < banks[j + 1].percent_1month)
                    {
                        // Обмінюємо елементи, якщо вони в неправильному порядку
                        Bank temp = banks[j];
                        banks[j] = banks[j + 1];
                        banks[j + 1] = temp;
                    }
                }
            }
        }
        public void SortByPercent_3month()
        {
            for (int i = 0; i < banks.Count - 1; i++)
            {
                for (int j = 0; j < banks.Count - i - 1; j++)
                {
                    // Порівнюємо сусідні елементи
                    if (banks[j].percent_3month < banks[j + 1].percent_3month)
                    {
                        // Обмінюємо елементи, якщо вони в неправильному порядку
                        Bank temp = banks[j];
                        banks[j] = banks[j + 1];
                        banks[j + 1] = temp;
                    }
                }
            }
        }
        public void SortByPercent_6month()
        {
            for (int i = 0; i < banks.Count - 1; i++)
            {
                for (int j = 0; j < banks.Count - i - 1; j++)
                {
                    // Порівнюємо сусідні елементи
                    if (banks[j].percent_6month < banks[j + 1].percent_6month)
                    {
                        // Обмінюємо елементи, якщо вони в неправильному порядку
                        Bank temp = banks[j];
                        banks[j] = banks[j + 1];
                        banks[j + 1] = temp;
                    }
                }
            }
        }
        public void SortByPercent_12month()
        {
            for (int i = 0; i < banks.Count - 1; i++)
            {
                for (int j = 0; j < banks.Count - i - 1; j++)
                {
                    // Порівнюємо сусідні елементи
                    if (banks[j].percent_12month < banks[j + 1].percent_12month)
                    {
                        // Обмінюємо елементи, якщо вони в неправильному порядку
                        Bank temp = banks[j];
                        banks[j] = banks[j + 1];
                        banks[j + 1] = temp;
                    }
                }
            }
        }
    }
    public class OutputMethods : DataBase
    {
        public void ShowResult(int i, String text, int option)
        {
            if(option == 1)
            {
                MessageBox.Show(banks[i].name + "\n______________________\n" +
                                   "За адресою: " + banks[i].adress +
                                  "\nВаша сума для вкладу " + text + "\n" + "Відсоток: " + banks[i].percent_1month +
                               "\nДохід(Річний): " + Math.Round((Convert.ToDouble(text) * banks[i].percent_1month) / 100, 2)+
                               "\nДохід(1 місяць):"+ Math.Round((Convert.ToDouble(text) * banks[i].percent_1month) / 100/12, 2),
                               "Найкращий банк за вашими критеріями(Cтрок 1 місяць)");
            }
            if (option == 2)
            {
                MessageBox.Show(banks[i].name + "\n______________________\n" +
                                   "За адресою: " + banks[i].adress +
                                  "\nВаша сума для вкладу " + text + "\n" + "Відсоток: " + banks[i].percent_3month +
                               "\nДохід(Річний): " + Math.Round((Convert.ToDouble(text) * banks[i].percent_3month) / 100, 2)+
                               "\nДохід(3 місяці):" +Math.Round((Convert.ToDouble(text) * banks[i].percent_3month) / 100/4, 2),
                               "Найкращий банк за вашими критеріями(Cтрок 3 місяці)");
            }
            if (option == 3)
            {
                MessageBox.Show(banks[i].name + "\n______________________\n" +
                                   "За адресою: " + banks[i].adress +
                                  "\nВаша сума для вкладу " + text + "\n" + "Відсоток: " + banks[i].percent_6month +
                               "\nДохід(Річний): " + Math.Round((Convert.ToDouble(text) * banks[i].percent_6month) / 100, 2) +
                               "\nДохід(6 місяців):" + Math.Round(((Convert.ToDouble(text) * banks[i].percent_6month) / 100)/2, 2),
                               "Найкращий банк за вашими критеріями(Cтрок 6 місяців)");
            }
            if (option == 4)
            {
                MessageBox.Show(banks[i].name + "\n______________________\n" +
                                   "За адресою: " + banks[i].adress +
                                  "\nВаша сума для вкладу " + text + "\n" + "Відсоток: " + banks[i].percent_12month +
                               "\nДохід(Річний): " + Math.Round((Convert.ToDouble(text) * banks[i].percent_12month) / 100, 2),
                               "Найкращий банк за вашими критеріями(Cтрок 1 рік)");
            }
        }
    }
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}