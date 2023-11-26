namespace ödev_1575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dongu_say = 1;
            int toplam = 0;
            while (toplam <= 1000)
            {
                toplam = toplam + dongu_say;
                dongu_say += 1;
            }
            MessageBox.Show("Döngü toplam " + dongu_say.ToString() + " kez çalıştı");
        }
    }
}