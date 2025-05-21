using System.Text.RegularExpressions;

namespace ContainRs.Domain.Models
{
    public class Email
    {
        private static readonly Regex EmailRegex = new Regex(
                @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public Email(string value)
        {
            if (!EmailRegex.IsMatch(value)){
                throw new ArgumentException("E-mail inválido.", nameof(value));
            }
            Value = value;
        }
        public string Value { get; }
    }
}
