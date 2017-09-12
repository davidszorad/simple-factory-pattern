using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    interface IFan
    {
        void SwitchOn();
        void SwitchOff();
    }
    class TableFan : IFan
    {
        public void SwitchOn()
        {
            // TODO: Logic goes here
            Console.WriteLine("Table fan is running....feeling awesome !!");
        }

        public void SwitchOff()
        {
            // TODO: Logic goes here            
        }
    }

    class CeilingFan : IFan
    {
        public void SwitchOn()
        {
            // TODO: Logic goes here           
        }

        public void SwitchOff()
        {
            // TODO: Logic goes here            
        }
    }

    class ExhaustFan : IFan
    {
        public void SwitchOn()
        {
            // TODO: Logic goes here           
        }

        public void SwitchOff()
        {
            // TODO: Logic goes here            
        }
    }
}
