namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Klick(object sender, EventArgs e)
        {
            MessageBox.Show("mitt f�rsta program", "medelande",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}