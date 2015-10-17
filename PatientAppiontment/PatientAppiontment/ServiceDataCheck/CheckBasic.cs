using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientAppointment.ServiceDataCheck
{
    public class CheckBasic
    {
        public CheckResult NoEmptyString(string checkString)
        {
            return new CheckResult() { result = true, Message = "This string is not empty." };
        }
    }
}
