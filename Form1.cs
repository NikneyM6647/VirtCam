namespace VirtCam
{
    public partial class Form1 : Form
    {
        private Logic logic = new Logic();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logic.startCam(pictureBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logic.stopCam();
        }
    }
}
