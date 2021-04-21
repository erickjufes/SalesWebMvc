using System;

namespace SalesWebMVC.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string messaage) : base(messaage)
        {
        }
    }
}
