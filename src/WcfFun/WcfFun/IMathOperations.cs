using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WcfFun
{
    using System.ServiceModel;

    [ServiceContract]
    interface IMathOperations
    {
        [OperationContract]
        int Sum(Operator input);

        [OperationContract]
        int Multiply(Operator input);
    }

    [DataContract]
    public class Operator
    {
        [DataMember]
        public List<int> Operators { get; set; }
    }
}
