
namespace ISYS325_Assignment2
{
    public partial class frmMain : Form
    {
        private CarColor selectedColor; 

        public frmMain()
        {
            InitializeComponent();
            selectedColor = CarColor.None;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yearBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (mamoListBox.SelectedItem == null)
                {
                   throw new Exception("make and model");
                }
                if(!int.TryParse(yearTextBox.Text, out int year))
                {
                    throw new Exception("year");
                }
                string color = "";
                switch (selectedColor)
                {
                    case CarColor.Red:
                        color = "red";
                        break;
                    case CarColor.Green:
                        color = "green";
                        break;
                    case CarColor.Blue:
                        color = "blue";
                        break;
                    case CarColor.Black:
                        color = "black";
                        break;
                    case CarColor.None:
                        throw new Exception("color");
                }
                string features = "";
                Boolean first = false;
                if(AirCondition_CheckBox.Checked)
                {
                    features = features + "AC";
                    first = true;
                }
                if (powwinCheckBox.Checked)
                {
                    if (first)
                    {
                        features = features + ", Power Windows";
                    }
                    else
                    {
                        features = features + "Power Windows";
                        first = true;
                    }
                }
                if (siriusCheckBox.Checked)
                {
                    if (first)
                    {
                        features = features + ", SiriusXM";
                    }
                    else
                    {
                        features = features + "SiriusXM";
                        first = true;
                    }
                }
                if (laneCheckBox.Checked)
                {
                    if (first)
                    {
                        features = features + ", Lane Assist";
                    }
                    else
                    {
                        features = features + "Lane Assist";
                        first = true;
                    }
                }
                if(!first)
                {
                    features = "no features";
                }

                sumLabel.Text = $"You have purchased a {color} {year} {mamoListBox.SelectedItem.ToString()} with {features}.";
            }
            catch (Exception ex)
            {
                sumLabel.Text = "Invalid input, there seems to be an issue with the " + ex.Message;
            }
               
        }
        private void red_CheckedChanged(object sender, EventArgs e)
        {
            if (Red_Radio.Checked)
                selectedColor = CarColor.Red;
        }

        private void blue_CheckedChanged(object sender, EventArgs e)
        {
            if (Blue_Radio.Checked)
                selectedColor = CarColor.Blue;
        }

        private void green_CheckedChanged(object sender, EventArgs e)
        {
            if (Green_Radio.Checked)
                selectedColor = CarColor.Green;
        }

        private void black_CheckedChanged(object sender, EventArgs e)
        {
            if (Black_Radio.Checked)
                selectedColor = CarColor.Black;
        }

    }

    public enum CarColor
    {
        None,
        Red,
        Blue,
        Green,
        Yellow,
        Black
    }
}

