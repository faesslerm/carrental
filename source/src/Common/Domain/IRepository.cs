namespace CarRent.Common.Domain
{
    public interface IRepository<TAggregate>
        where TAggregate : Entity, IAggregateRoot
    {
        TAggregate GetById(Guid id);
        void Add(TAggregate car);

        void Update(TAggregate car);

        void Remove(TAggregate car);
    }
}
