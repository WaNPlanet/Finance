using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.ComponentModel.DataAnnotations;

namespace finance.Models{
    public class Expense{
                public int Id{
                    get; set;
                }
                public decimal Value{
                    get; set;
                }
                required
                public string? Description{
                    get; set;
                }
    }
}