using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PrimeCalculator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool IsPrime(ulong num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            var bounds = (ulong)Math.Floor(Math.Sqrt(num));
            for (ulong i = 3; i <= bounds; i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
            
        }

        private void CheckIfPrime(object num)
        {
            if (IsPrime((ulong)num))
            {
                PrimeLabel.Invoke(new MethodInvoker(() => SetLabel(string.Join(" ", num, "Is Prime"), Color.Red, true)));
            }
            else
            {
                PrimeLabel.Invoke(new MethodInvoker(() => SetLabel(string.Join(" ", num, "Is Not Prime"), Color.Red, true)));
            }
        }

        public void SetLabel(string text, Color color, bool isVisible)
        {
            PrimeLabel.Text = text;
            PrimeLabel.ForeColor = color;
            PrimeLabel.Visible = isVisible;
            PrimeNumTextBox.Text = "";
        }

        private void CheckPrimeBtn_Click(object sender, EventArgs e)
        {
            PrimeLabel.Visible = false;
            string boxText = PrimeNumTextBox.Text;
            ulong num = 0;
            try
            {
                num = ulong.Parse(boxText);
            }
            catch
            {
                SetLabel("Enter an Integer", Color.Red, true);
                return;
            }
            if(num < 0)
            {
                SetLabel("Enter an Integer Greater or Equal to 0", Color.Red, true);
                return;
            }

            Thread IsPrimeThread = new Thread(CheckIfPrime);
            IsPrimeThread.Start(num);
        }
    }
}
