using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientAppiontment.Data
{
    public class ConnectionToDataBase
    {
        public string defaultConnectionString
        {
            get { return @"Driver = {SQL Server}; Server = 192.168.1.70; UID = zhangkai365; PWD = @Zhangkai851983; Database = engchaosheng; "; }
        }
    }
}
