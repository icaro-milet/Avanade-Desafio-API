namespace Avanade.Challenge.Domain.Base
{
    public abstract class EntityBase
    {
        public int Id { get; set; }

        public abstract bool Validate();
    }
}
