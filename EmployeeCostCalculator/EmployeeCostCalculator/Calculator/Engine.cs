using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeCostCalculator.Models;

namespace EmployeeCostCalculator.Calculator
{
    public static class Engine
    {
        /// <summary>
        /// Calculates the total cost of an employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public static double CalculateEmployeeCost(Employee employee)
        {
            double totalCost = 0;
            double cost = 0;

            if(employee.FirstName.StartsWith("A"))
            {
                cost = employee.CostofBenefits - (employee.CostofBenefits * 0.1);
                totalCost += cost;
            }
            else
            {
                totalCost += employee.CostofBenefits;
            }

            foreach(Dependent dependent in employee.Dependents)
            {
                cost = 0;
                if (dependent.FirstName.StartsWith("A"))
                {
                    cost = dependent.CostOfBenefits - (dependent.CostOfBenefits * 0.1);
                    totalCost += cost;
                }
                else
                {
                    totalCost += dependent.CostOfBenefits;
                }
            }

            return totalCost;
        }

    }
}