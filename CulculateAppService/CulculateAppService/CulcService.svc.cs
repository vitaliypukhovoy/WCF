using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CulculateAppService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CulcService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CulcService.svc or CulcService.svc.cs at the Solution Explorer and start debugging.
    public class CulcService : ICulcService
    {
        public Int32 Add(Int32 param1, Int32 param2)
        {
            return param1 + param2;
        }

        public Int32 Subtract(Int32 param1, Int32 param2)
        {
            return param1 - param2;
        }

        public Int32 Multiply(Int32 param1, Int32 param2)
        {
            return param1 * param2;
        }

        public Int32 Divide(Int32 param1, Int32 param2)
        {
            if (param2 != 0)
                return param1 / param2;
            else return 0;
        }
    
    }


}
