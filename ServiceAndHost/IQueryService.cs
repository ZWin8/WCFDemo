using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceAndHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IQueryService
    {
        [OperationContract]
        string GetFeedback(string greetings);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Author
    {
        public Author(string greetings)
        {
            _greetings = greetings;
        }

        private readonly string _greetings;

        public string Feedback()
        {
            return string.Format("{{\"Name\":{0},\"Age\":30}}", _greetings);
        }
    }
}
