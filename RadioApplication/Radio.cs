using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Radio
    {
        public bool Power {
            get { return power; }

            set { }
        }
        public int Volume {
            get { return volume; }

            set
            {
                if (value < 0)
                {
                    volume = 0;                    
                }
                else if (value > 9)
                {
                    volume = 9;
                }
                else volume = value;
            }
        }
        public float Frequency {
            get { return frequency; }

            set
            {
                if (value < 2000.0f)
                {
                    frequency = 2000.0f;
                }
                else if (value > 26000.0f)
                {
                    frequency = 26000.0f;
                }
                else frequency = value;
            }
        }

        public void PowerOn()
        {
            power = true;
        }

        public void PowerOff()
        {
            power = false;
        }

        public void AdjustVolume()
        {
            Console.WriteLine("Adjust volume 0-9 > ");
            string line = Console.ReadLine();
            int number;
            bool result = int.TryParse(line, out number);
            if (result)
            {
                Volume = number;
            }
                        
        }

        public void AdjustFrequency()
        {
            Console.WriteLine("Adjust frequency 2000.0-26000.0 > ");
            string line = Console.ReadLine();
            int number;
            bool result = int.TryParse(line, out number);
            if (result)
            {
                Frequency = number;
            }

        }

        public void PrintData()
        {
            if (Power == true)
            {
                Console.WriteLine("Power: On ");
                Console.WriteLine("Volume: " + Volume);
                Console.WriteLine("Frequency: " + Frequency);
            }
            else Console.WriteLine("Power: Off ");
            
            Console.WriteLine();
        }

        private bool power = false;
        private int volume = 0;
        private float frequency = 2000.0f; 

    }
}
