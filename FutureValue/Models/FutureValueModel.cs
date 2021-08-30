using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutureValue.Models
{
    public class FutureValueModel
    {
        [Required(ErrorMessage = "Please enter a monthly investment.")]
        [Range(1, 500, ErrorMessage = "Monthly investment amount must be between 1 and 500.")]
        public decimal? MonthlyInvestment { get; set; }
        [Required]
        
        public decimal? YearlyInterestRate { get; set; }
        [Required(ErrorMessage ="You must enter a duration in years.")]
        public int? Years { get; set; }
        public decimal? CalculateFutureValue()
        {
            int? months = Years * 12;
            decimal? monthlyInterestRate = YearlyInterestRate / 12 / 100;
            decimal? futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;

            
        }
        public FutureValueModel()
        {
            MonthlyInvestment = 10m;
        }
    }
}
