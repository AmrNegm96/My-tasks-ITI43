using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class MaxAge : ValidationAttribute
    {
        int Value;

        public MaxAge(int num) 
        { 
            Value = num;
        }

        public override bool IsValid(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            else
            {
                if(obj is int suppliedValue)
                {
                    if(suppliedValue < Value)
                    {
                        return true;
                    }
                    else
                    {
                        ErrorMessage = "Max age is " + Value;
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}