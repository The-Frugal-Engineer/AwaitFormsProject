using System.Threading.Tasks;
//Created by the Frugal Engineer 12/12/2022
namespace AwaitFormsProject
{
    public partial class Form1 : Form
    {
        int numberOfTimesPressed = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private async void calculate_ClickAsync(object sender, EventArgs e)
        {
            int value1Read = 0;
            int value2Read = 0;
            int delayRead = 0;
            result.Text = "";
            Int32.TryParse(value1.Text, out value1Read);
            Int32.TryParse(value2.Text, out value2Read);
            Int32.TryParse(delaySeconds.Text, out delayRead);
            Operations op = new Operations();
            Boolean isAsyncExecution = isAsync.Checked;

            
            Task<int> waitSomeTime1 = op.sumWithDelayAsync(value1Read, value2Read, delayRead, isAsyncExecution);
            int finalResult = await waitSomeTime1;

            result.Text= finalResult.ToString();

        }

        private void buttonPlusOne_Click(object sender, EventArgs e)
        {
            numberOfTimesPressed++;
            timesPressed.Text = numberOfTimesPressed.ToString();
        }
    }
}