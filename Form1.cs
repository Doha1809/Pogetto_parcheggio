namespace Parcheggio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Park parchggio = new Park(10);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}