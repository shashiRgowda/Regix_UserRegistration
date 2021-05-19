using System;

namespace UserRegistration
{
    internal class Regex
    {
        private string exp;

        public Regex(string exp)
        {
            this.exp = exp;
        }

        internal bool IsMatch(string first_name)
        {
            throw new NotImplementedException();
        }
    }
}