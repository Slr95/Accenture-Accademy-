using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaWebEmpleados.Validation
{
    public class EmailValid: ValidationAttribute
    {
        #region Constructores

        public EmailValid()
        {
            ErrorMessage = "Ingrese un Email Correcto";

        }
        #endregion


        public override bool IsValid(object value)
        {
            string email = (string)value;

            //email contiene @  --> email.Contains('@');
            if (email.Contains('@') == true)
            {
                if (email.Contains(".com")== true)
                {
                    return true;
                }
                else
                {
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