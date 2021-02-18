using Agilent.CommandExpert.ScpiNet.AgMXG_A_01_80;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashoardSignalGenerator
{


    public partial class View : Form
    {
        double[] frequencyArray = new double[100000];
        double answer;
        double index;
        double calculationValue;
        double currentFrequence;

        Model.DashboardModel dashboardmodel = new Model.DashboardModel();
        AgMXG SignalGenerator = new AgMXG("GPIB0::5::INSTR");
       
        public View()
        {
            InitializeComponent();

            for(int i = 0; i <= 254; i++)
            {
                answer = 80 * Math.Pow(1.01, i);
                frequencyArray[i] = Math.Round(answer, 3);
                frequencyArray[254] = 1000;
                i++;
            }

        }

        public void buttonstartt_Click(object sender, EventArgs e)
        {
            if (CheckBoxAutomatic.Checked)
            {
                labelstatus.Text = " werkt";
                dashboardmodel.Level = int.Parse(txtLevel.Text);
                dashboardmodel.StartFreq = double.Parse(txtStartFreq.Text);
                dashboardmodel.StopFreq = double.Parse(TxtStopFreq.Text);
                dashboardmodel.IncreaseFreq = 1;
                dashboardmodel.StepSeconds = double.Parse(TxtSpeedSecondsFreq.Text);

                currentFrequence = dashboardmodel.StartFreq;
              //  labelstatus.Text = dashboardmodel.StartFreq.ToString();

                calculateIndex();
                automaticModeAsync();               
            }
            else
            {
                Console.WriteLine("Isn't in automatic mode");
                labelstatus.Text = " werkt niet";
            }
        }

        public void calculateIndex ()
        {
            calculationValue = Convert.ToDouble(dashboardmodel.StartFreq) / 80;
            index = Math.Log(calculationValue) / Math.Log(1.01);
            label1.Text = Convert.ToInt32(index).ToString();
        }

        public async Task automaticModeAsync()
        {
            labelstatus.Text = frequencyArray[Convert.ToInt32(index)].ToString();

                while (CheckBoxAutomatic.Checked && currentFrequence < dashboardmodel.StopFreq)
                {
                        SignalGenerator.SCPI.SOURce.FREQuency.CW.Command(frequencyArray[Convert.ToInt32(index)], "MHZ");
                    currentFrequence = frequencyArray[Convert.ToInt32(index)];
                    this.index++;
                    lblIndex.Text = index.ToString();
                   lblCurrentFreq.Text = currentFrequence.ToString();
                  
              
               }
            await Task.Delay(3000);

        }

    }
}

