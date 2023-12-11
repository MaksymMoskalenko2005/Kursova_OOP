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
        {//                     Name           Adress       1m  3m   6m  1y ����� ��.
            banks.Add(new Bank("����������", "������� 10", 2.1,4.5, 12.9, 15.1, true));
            banks.Add(new Bank("��������","�������� 22", 2.3,  4.1, 13.1, 14.8, true));
            banks.Add(new Bank("���������", "������� 15", 2.2, 5.1, 11.3, 13.9, false));
            banks.Add(new Bank("����", "������� 88", 2.9, 4.9, 10.9, 12.3, false));
            banks.Add(new Bank("���������", "���� 39", 3.1, 4.4, 11.1, 11.9, false));
            banks.Add(new Bank("����������", "������� 9", 1.9, 5.3, 10.5, 12.2, false));
            banks.Add(new Bank("�������� ����", "������ 19", 2.5, 4.2, 12.4, 13.1, false));
            banks.Add(new Bank("��������� ����", "������� 17", 2.4, 5.4, 11.7, 12.7, false));
            banks.Add(new Bank("Otp ����", "�������� 66", 1.8, 4.8, 10.3, 10.9, false));
            banks.Add(new Bank("���� ������", "г��� 12", 2.6, 5.2, 10.8, 12.1, false));
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
                    // ��������� ����� ��������
                    if (banks[j].percent_1month < banks[j + 1].percent_1month)
                    {
                        // �������� ��������, ���� ���� � ������������� �������
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
                    // ��������� ����� ��������
                    if (banks[j].percent_3month < banks[j + 1].percent_3month)
                    {
                        // �������� ��������, ���� ���� � ������������� �������
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
                    // ��������� ����� ��������
                    if (banks[j].percent_6month < banks[j + 1].percent_6month)
                    {
                        // �������� ��������, ���� ���� � ������������� �������
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
                    // ��������� ����� ��������
                    if (banks[j].percent_12month < banks[j + 1].percent_12month)
                    {
                        // �������� ��������, ���� ���� � ������������� �������
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
                                   "�� �������: " + banks[i].adress +
                                  "\n���� ���� ��� ������ " + text + "\n" + "³������: " + banks[i].percent_1month +
                               "\n�����(г����): " + Math.Round((Convert.ToDouble(text) * banks[i].percent_1month) / 100, 2)+
                               "\n�����(1 �����):"+ Math.Round((Convert.ToDouble(text) * banks[i].percent_1month) / 100/12, 2),
                               "��������� ���� �� ������ ���������(C���� 1 �����)");
            }
            if (option == 2)
            {
                MessageBox.Show(banks[i].name + "\n______________________\n" +
                                   "�� �������: " + banks[i].adress +
                                  "\n���� ���� ��� ������ " + text + "\n" + "³������: " + banks[i].percent_3month +
                               "\n�����(г����): " + Math.Round((Convert.ToDouble(text) * banks[i].percent_3month) / 100, 2)+
                               "\n�����(3 �����):" +Math.Round((Convert.ToDouble(text) * banks[i].percent_3month) / 100/4, 2),
                               "��������� ���� �� ������ ���������(C���� 3 �����)");
            }
            if (option == 3)
            {
                MessageBox.Show(banks[i].name + "\n______________________\n" +
                                   "�� �������: " + banks[i].adress +
                                  "\n���� ���� ��� ������ " + text + "\n" + "³������: " + banks[i].percent_6month +
                               "\n�����(г����): " + Math.Round((Convert.ToDouble(text) * banks[i].percent_6month) / 100, 2) +
                               "\n�����(6 ������):" + Math.Round(((Convert.ToDouble(text) * banks[i].percent_6month) / 100)/2, 2),
                               "��������� ���� �� ������ ���������(C���� 6 ������)");
            }
            if (option == 4)
            {
                MessageBox.Show(banks[i].name + "\n______________________\n" +
                                   "�� �������: " + banks[i].adress +
                                  "\n���� ���� ��� ������ " + text + "\n" + "³������: " + banks[i].percent_12month +
                               "\n�����(г����): " + Math.Round((Convert.ToDouble(text) * banks[i].percent_12month) / 100, 2),
                               "��������� ���� �� ������ ���������(C���� 1 ��)");
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