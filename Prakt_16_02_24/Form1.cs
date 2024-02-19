using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Prakt_16_02_24
{
    public partial class Form1 : Form
    {
        private List<Bank> banks = new List<Bank>();
        public SynchronizationContext context;
        Thread th;
        public Form1()
        {
            InitializeComponent();
            context = new SynchronizationContext();
        }

        private async void set_button_1_Click(object sender, EventArgs e)
        {
            int money = await Task.Run(() => GetMoney());
            string name = await Task.Run(() => GetName());
            int percent = await Task.Run(() => GetPercent());
 
            Bank bank = new Bank(money, name, percent);
            banks.Add(bank);
            RefreshListBox();
        }

        private int GetMoney()
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                return int.Parse(textBox1.Text);
            }
            return 0;
        }

        private string GetName()
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                return textBox2.Text;
            }
            return "no name";
        }

        private int GetPercent()
        {
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                return int.Parse(textBox3.Text);
            }
            return 0;
        }

        private void RefreshListBox()
        {
            listBox1.Items.Clear();

            foreach (var bank in banks)
            {
                listBox1.Items.Add($"Name: {bank.name}, Money: {bank.money}, Percent: {bank.percent}");
            }
        }
    }
}
