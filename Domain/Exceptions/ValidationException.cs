using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions {
    public class ValidationException : Exception {
        public ValidationException(IReadOnlyDictionary<string, string[]> errorsDictionary)
            : base("Validation Failure") { 
            ErrorsDictionary = errorsDictionary;
        }
             
        public IReadOnlyDictionary<string, string[]> ErrorsDictionary { get; }
    }
}
