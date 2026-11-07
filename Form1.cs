using Microsoft.VisualBasic.Devices;

namespace K18
{
    public partial class Form1 : Form
    {
        private Keypad keypad;
        private Lockk lockInstance;
        private Control control;
        private SecuritySystem securitySystem;
        private Display display;

        public Form1()
        {
            InitializeComponent();
            display = new Display(labelDisplay);
            keypad = new Keypad(display);
            lockInstance = new Lockk();
            control = new Control();
            securitySystem = new SecuritySystem(keypad, lockInstance, control, display);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            keypad.PressButton("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            keypad.PressButton("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            keypad.PressButton("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            keypad.PressButton("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            keypad.PressButton("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            keypad.PressButton("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            keypad.PressButton("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            keypad.PressButton("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            keypad.PressButton("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            keypad.PressButton("0");
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            securitySystem.EnterAccessCode();
        }

        private void ButtonControl_Click(object sender, EventArgs e)
        {
            securitySystem.ChangeAccessCode();
        }

        private void ButtonCall_Click(object sender, EventArgs e)
        {
            securitySystem.RingBell();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelDisplay_Click(object sender, EventArgs e)
        {

        }

        private void cch_Click(object sender, EventArgs e)
        {
            securitySystem.ChangeControlCode();
        }


    }
}