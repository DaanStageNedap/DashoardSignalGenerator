using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashoardSignalGenerator.Model
{
  
    class DashboardModel
    {
        private int level;
        private double startFreq;
        private double stopFreq;
        private int increaseFreq;
        private double stepSeconds;

        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                if(value == 3 || value == 10)
                {
                    this.level = value;
                }
                else
                {
                    Console.WriteLine("verkeerde waarde");
                }
            }
        }

        public double StartFreq
        {
            get
            {
                return startFreq;
            }

            set
            {
                if (value >= 80 && value <= 1000)
                {
                    this.startFreq = value;
                }
                else
                {
                    Console.WriteLine("verkeerde waarde");
                }
             }
        }

        public double StopFreq
        {
            get
            {
                return stopFreq;
            }
            set
            {
                if (value >= 80 && value <= 1000)
                {
                    this.stopFreq = value;
                }
                else
                {
                    Console.WriteLine("verkeerde waarde");
                }
            }
        }

        public int IncreaseFreq
        {
            get
            {
                return increaseFreq;
            }

            set
            {
                this.increaseFreq = value;
            }
        }

        public double StepSeconds
        {
            get
            {
                return stepSeconds;
            }
            set
            {
                if (value >= 0.5)
                {
                    this.stepSeconds = value;
                }
                else
                {
                    Console.WriteLine("verkeerde waarde");
                }
            }

        }


    }
}
