using Avanade.Challenge.Domain.Base;

namespace Avanade.Challenge.Domain
{
    public class Person : EntityBase
    {
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public bool Active { get; set; }

        public override bool Validate()
        {
            return !string.IsNullOrWhiteSpace(Name);
        }
    }
}
