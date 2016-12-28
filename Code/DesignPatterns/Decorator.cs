using System;
using System.Runtime.InteropServices;

namespace DesignPatterns
{
    public abstract class APersonnel
    {
        public virtual void CheckUp() { }
        protected CheckUp CheckupProcedure;
        public APersonnel(CheckUp checkupProcedure)
        {
            CheckupProcedure = checkupProcedure;
        }
    }

    //decorator item
    public class Personnel : APersonnel
    {
        private APersonnel _personnelToExtend; //decorated item

        public Personnel(APersonnel personnel, CheckUp checkupProcedure) : base(checkupProcedure)
        {
            _personnelToExtend = personnel;
        }

        //extended method
        public override void CheckUp()
        {
            _personnelToExtend?.CheckUp();

            Console.WriteLine(CheckupProcedure.CheckupProcedureNote);
        }
    }

    public class CheckUp
    {
        public CheckUp(string procNote)
        {
            CheckupProcedureNote = procNote;
        }
        public string CheckupProcedureNote { get; set; }
    }

    class TestDecor
    {
        public void Testing()
        {
            
            //Decorator 
            var Nurse = new Personnel(null, new CheckUp("Nurse CheckUp."));
            var Phisician = new Personnel(Nurse, new CheckUp("Phisician CheckUp."));
            var Oncologist = new Personnel(Phisician, new CheckUp("Oncologyst CheckUp."));

            Oncologist.CheckUp();
            //Output
            //Nurse CheckUp.
            //Phisician CheckUp.
            //Oncologyst CheckUp.



            //Inheritance
            //class Nurse:Personnel
            //class Phisician:Nurse
            //class Oncologist 
        }
    }

    //inheritance
    class Nurse
    {
        public Nurse()
        {
            //...
        }
        
        //...
    }

    class Phisician : Nurse
    {
        public Phisician() : base()
        {
            //...
        }

        //...
    }

    class Oncologyst : Phisician
    {
        public Oncologyst() : base()
        {
            //...
        }

        //...
    }
}
