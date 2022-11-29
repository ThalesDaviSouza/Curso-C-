using System;

namespace TratamentoDeExcecoes.Entities.Exceptions {
    internal class AccountException : ApplicationException {
        public AccountException(string message) : base(message) { }
    }
}
