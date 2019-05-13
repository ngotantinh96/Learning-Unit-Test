using System;

namespace TestNinJa.Fundamentals
{
    public class ErrorLogger
    {
        public string LastError { get; set; }

        public event EventHandler<Guid> ErrorLogged;

        public void Log(string error)
        {
            if (string.IsNullOrWhiteSpace(error))
                throw new ArgumentNullException();
            LastError = error;

            ErrorLogged?.Invoke(this, Guid.NewGuid());
        }
    }
}
