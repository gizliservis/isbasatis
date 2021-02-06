using FluentValidation;
using Isbasatis.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isbasatis.Entities.Tools
{
   public static class ValidatorTool
    {
        public static bool Validate(IValidator validator,IEntity entity)
        {
            bool result = true;
            var ValidationResult = validator.Validate(entity);
            if (!ValidationResult.IsValid)
            {
                string message = null;
                foreach (var error in ValidationResult.Errors)
                {
                    message += error.ErrorMessage+System.Environment.NewLine;
                }
                MessageBox.Show(message);
                result = false;
            }

            return result;
        }
    }
}
