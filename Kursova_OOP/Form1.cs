namespace Kursova_OOP
{
    public partial class Form1 : Form
    {
        private DataBase data = new DataBase();
        private SortMethods sortData = new SortMethods();
        private OutputMethods output = new OutputMethods();
        public Form1()
        {
            InitializeComponent();
            data.BanksData();
            for (int i = 0; i < DataBase.banks.Count; i++)
            {
                int rowIndex = this.dataGridView1.Rows.Add();
                var row = this.dataGridView1.Rows[rowIndex];
                row.Cells[0].Value = DataBase.banks[i].name;
                row.Cells[1].Value = "���." + DataBase.banks[i].adress;
                row.Cells[2].Value = DataBase.banks[i].percent_1month + "%";
                row.Cells[3].Value = DataBase.banks[i].percent_3month + "%";
                row.Cells[4].Value = DataBase.banks[i].percent_6month + "%";
                row.Cells[5].Value = DataBase.banks[i].percent_12month + "%";
                if (DataBase.banks[i].isGovermental == true)
                {
                    row.Cells[6].Value = "���������";
                }
                else row.Cells[6].Value = "���������";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("������ ����");
                return;
            }
            int option = 1;
            //���������� ������
            if (radioButton1.Checked)
            {
                sortData.SortByPercent_1month();
                option = 1;
            }
            if (radioButton2.Checked)
            {
                sortData.SortByPercent_3month();
                option = 2;
            }
            if (radioButton3.Checked)
            {
                sortData.SortByPercent_6month();
                option = 3;
            }
            if (radioButton4.Checked)
            {
                sortData.SortByPercent_12month();
                option = 4;
            }
            //�� ��������� � �� ���������
            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("������� ����� ��������");
            }
            //��������� � ���������
            if (checkBox1.Checked && checkBox2.Checked)
            {
                output.ShowResult(0, textBox1.Text,option);
            }
            //���������
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                for(int i = 0; i < DataBase.banks.Count; i++)
                {
                    if(DataBase.banks[i].isGovermental == true)
                    {
                        output.ShowResult(i, textBox1.Text, option);
                        break;
                    }
                }
            }
            //���������
            if (!checkBox1.Checked && checkBox2.Checked)
            {
                for (int i = 0; i < DataBase.banks.Count; i++)
                {
                    if (DataBase.banks[i].isGovermental == false)
                    {
                        output.ShowResult(i, textBox1.Text, option);
                        break;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9,]"))
                {
                    MessageBox.Show("������ ������ �����(��� ������ �� ������ �������)\n" +
                        "���� ����� ������ ������ �����, �� �������������: ','");
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            }
        }
    }
}
