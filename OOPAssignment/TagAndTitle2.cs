using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    public class Vehicle : TagAndTitle //the interface
    {
        public string vehicleColor { get; set; }
        public bool IsdriversLicense { get; set; }


        public string FirstStep()
        {
            if (IsdriversLicense)
            {
                return "proceed with next Document";
            }
            else
            {
                return "kindly provide your Driver's License";
            }

        }
        public bool Istitle { get; set; }

        public string Next()
        {
            if (Istitle)
            {
                return "proceed with next Document";
            }
            else
            {
                return "kindly provide the original title of your vehicle";
            }
        }
        public bool IsinsuranceInfo { get; set; }

        public string AlmostThere()
        {
            if (IsinsuranceInfo)
            {
                return "proceed with next Document";
            }
            else
            {
                return "kindly provide your vehicle insurance information";
            }
        }
        public bool IssafetyInspection { get; set; }

        public string FinalStep()
        {
            if (IssafetyInspection)
            {
                return "your documents will be processed, if there are no violations, your license will be issued to you in 48hrs";
            }
            else
            {
                return "kindly provide safety information or your registration will be terminated";
            }
        }
        //polymorphism
        public int driverId()
        {
            return 0;
        }
        public int driverId(int a, int b)
        {
            return 0;
        }

    }
    public abstract class Jeep //abstraction
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }


    }
    public class Bigcar : Jeep //inheritance
    {


        public override string Name { get; set; }

        public override string Description { get; set; }


    }

}
