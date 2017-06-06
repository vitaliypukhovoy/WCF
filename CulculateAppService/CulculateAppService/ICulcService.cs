using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CulculateAppService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICulcService" in both code and config file together.
    [ServiceContract]
    public interface ICulcService
    {
        [OperationContract]
         Int32 Add(Int32 param1, Int32 param2);

        [OperationContract]
         Int32 Subtract(Int32 param1, Int32 param2);
        [OperationContract]
         Int32 Multiply(Int32 param1, Int32 param2);
        [OperationContract]
         Int32 Divide(Int32 param1, Int32 param2);
    }
}
