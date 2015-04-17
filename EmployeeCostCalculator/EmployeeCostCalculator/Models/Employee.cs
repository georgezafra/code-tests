using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeCostCalculator.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public virtual List<Dependent> Dependents { get; set; }

        [Display(Name = "Cost Of Benefits")]
        public double CostofBenefits { get; set; }

        [Display(Name = "Total Cost of Benefits")]
        public double TotalCostOfBenefits { get; set; }

        public int Salary { get; set; }

    }
}