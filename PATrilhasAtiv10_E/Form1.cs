namespace PATrilhasAtiv10_E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblFonte.Font = new Font("Showcard Gothic", 12, FontStyle.Regular);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblFonte.Font = new Font("Arial Narrow", 7, FontStyle.Italic);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblFonte.Font = new Font("Ink Free", 12, FontStyle.Bold);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
