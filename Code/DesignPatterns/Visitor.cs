using System;

namespace DesignPatterns
{
    //abstract object
    public interface IObject
    {
        //abstract accept method - accepting a visitor abstract object object
        bool Validate(IVisitor validator);
    }

    //concrete object
    public class Patient : IObject
    {
        //concrete accept method
        public bool Validate(IVisitor validator)
        {
            return validator.IsValid(this);
        }
    }

    //concrete object
    public class Doctor : IObject
    {
        //concrete accept method
        public bool Validate(IVisitor validator)
        {
            return validator.IsValid(this);
        }
    }

    //abstract visitor
    public interface IVisitor
    {
        //abstract visit methods
        bool IsValid(Patient pt);
        bool IsValid(Doctor dr);
    }

    //set of validating methods for each concrete object
    public class Validators : IVisitor
    {
        //concrete visit methods
        public bool IsValid(Doctor dr)
        {
            Console.WriteLine("Validating Doctor");
            return true; //dummy validation
        }

        public bool IsValid(Patient pt)
        {
            Console.WriteLine("Validating Patient");
            return true; //dummy validation
        }
    }
}
