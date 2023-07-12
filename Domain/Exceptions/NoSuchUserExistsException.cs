using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions {
    public class NoSuchUserExistsException : Exception {
        public string message { get; set; }

        public NoSuchUserExistsException(string message) : base(message) {
            this.message = message;
        }
    }
}
