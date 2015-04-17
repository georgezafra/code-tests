using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace EmployeeCostCalculator.Models
{
    public class Dependent
    {
        public int DependentId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        [Display(Name = "Cost of Benefits")]
        public double CostOfBenefits { get; set; }

    }
}
