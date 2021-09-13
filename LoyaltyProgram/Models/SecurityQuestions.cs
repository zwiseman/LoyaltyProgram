using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace LoyaltyProgram.Models
{
    public static class SecurityQuestions
    {
        public static IEnumerable<SelectListItem> GetSecurityQuestions()
        {
            return new[]
            {
                new SelectListItem { Value = "What street did you live on in 6th grade?", Text = "What street did you live on in 6th grade?"},
                new SelectListItem { Value = "What was your childhood nickname?", Text = "What was your childhood nickname?"},
                new SelectListItem { Value = "In what city did your mother and father meet?", Text = "In what city did your mother and father meet?"},
                new SelectListItem { Value = "What school did you attend for sixth grade?", Text = "What school did you attend for sixth grade?"},
                new SelectListItem { Value = "What was the last name of your third grade teacher?", Text = "What was the last name of your third grade teacher?"},
                new SelectListItem { Value = "What was the name of your first stuffed animal?", Text = "What was the name of your first stuffed animal?"},
            };
        }
    }
}
