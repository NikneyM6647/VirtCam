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
            logic.startCam(imageBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logic.stopCam();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Logic.initcb1(comboBox1, textBox1);
            Logic.initcb2(comboBox2, textBox1);
        }
    }
}
