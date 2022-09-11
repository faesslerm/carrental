namespace CarRent.Common.Domain
{
    public abstract class Entity
    {
        public Guid Id { get; }

        protected Entity() : this(Guid.NewGuid()) { }

        internal Entity(Guid id)
        {
            Id = id;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not Entity)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (GetType() != obj.GetType())
            {
                return false;
            }

            var item = (Entity)obj;
            return item.Id == Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);

        }

        public static bool operator ==(Entity left, Entity right)
        {
            if (Equals(left, null))
            {
                return Equals(right, null);
            }
            else
            {
                return left.Equals(right);
            }
        }

        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }
    }
}
