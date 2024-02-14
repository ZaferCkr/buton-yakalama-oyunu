namespace buton_yakalama_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int i = 1;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ("tebrikler toplan puanýnýz=" + " " + Convert.ToString(i) + " " + ".");
            if (i <= 20)
            {
                i++;

            }
            else if (i > 20)
            {
                label1.Text = "Oyun bitti.";
            }

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            button1.Left = Convert.ToInt32(rnd.Next(Size.Width - button1.Size.Width));
            button1.Top = Convert.ToInt32(rnd.Next(Size.Height - (label2.Height + label3.Height)) - label2.Height);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text + " " + "beni yakalamaya çalýþ! ";

        }
    }
}
