﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamplesCSharp
{
    public abstract class Computer
    {
        private string name = "Unknown";
        public bool IsOn { get; private set; }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public Computer(string name)
        {
            this.Name = name;
        }

        protected void TurnOn()
        {
            IsOn = true;
        }

        protected void TurnOff()
        {
            IsOn = false;
        }

        public virtual void TogglePower()
        {
            if (IsOn == true)
            {
                TurnOff();
            }
            else
            {
                TurnOn();
            }
        }
    }
}
