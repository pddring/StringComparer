using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringComparer
{
    class ValidationResult
    {
        public bool ValidationSuccess;
        public string Message;

        /// <summary>
        /// Check user input for presence check, length check (1024 characters max) 
        /// and pattern check (ASCII only)
        /// </summary>
        /// <param name="userInput">Data entered by the user</param>
        /// <returns>true if all checks pass. Message attribute describes any failed tests</returns>
        public bool ValidateUserInput(string userInput)
        {
            // presence check
            if(userInput.Length == 0)
            {
                Message = "You need at least 1 character";
                return false;
            }

            // length check
            if(userInput.Length > 1024)
            {
                Message = "There should be no more than 1024 characters";
                return false;
            }
            return true;
        }
    }
}
