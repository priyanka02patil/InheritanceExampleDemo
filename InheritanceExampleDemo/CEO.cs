using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExampleDemo
{
    public class CEO : Employee
    {
        private double bonus;
        private string projectplan;
        private string carrierexperience;

        public CEO(string nm, double basic, Date date, string projectplan, double bonus, string carrierexperience) : base(nm, basic, date)
        {
            this.projectplan = projectplan;
            this.bonus = bonus;
            this.carrierexperience = carrierexperience;
        }

        public override void CalculateSalary()
        {
            hra = basic * 0.30;
            da = basic * 0.25;
            pf = basic * 0.12;
            gross = (basic + hra + da + bonus ) - pf;
        }

        public override string ToString() // overriding method from base class (object)
        {
            return $"CEO details : id = {id}, name ={name}, projectplan = {projectplan}, gross ={gross}  ";
        }
    }
}
