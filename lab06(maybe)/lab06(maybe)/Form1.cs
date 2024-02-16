using System.Windows.Forms;

namespace lab06_maybe_
{
    public partial class Form1 : Form
    {
        ClassControl control = new ClassControl();
        public Form1()
        {
            InitializeComponent();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {

            control.AddMember("Mickey", "001", 2000);
            control.AddMember("Minnie", "002", 2000);
            bool result = control.SaveToFile();
            if (result)
            {
            }
            else
            {
            }
        }

        private void Rend_From_File_button_Click(object sender, EventArgs e)
        {
            ClassControl classControl = new ClassControl();
            classControl.ReadFromFile();
        }
    }
}
