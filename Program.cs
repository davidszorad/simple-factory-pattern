using System;

namespace SimpleFactoryPattern
{
    /*
    Factory Pattern is "A factory is an object for creating other objects". 
    Simple Factory Pattern is a Factory class in its simplest form 
    (In comparison to Factory Method Pattern or Abstract Factory Pattern). 
    In another way, we can say: In simple factory pattern, we have a factory 
    class which has a method that returns different types of object based on given input.

    Let’s say in future, if FanFactory has to make a new type of fan called WallFan also. 
    To adopt this new requirement, we have to change CreateFan method and add one switch 
    case for WallFan type. If again new kind of Fan is introduced, then again one more case 
    needs to be added. This will be a violation of Open Close Principle of SOLID principles. 
    In the next article, we will see how we can overcome this violation issue with the help 
    of Factory Method Pattern.
    */

    class Program
    {
        static void Main(string[] args)
        {
            IFanFactory simpleFactory = new FanFactory();

            // Creation of a Fan using Simple Factory 
            IFan fan = simpleFactory.CreateFan(FanType.TableFan);

            // Use created object 
            fan.SwitchOn();

            Console.ReadLine();
        }
    }
}