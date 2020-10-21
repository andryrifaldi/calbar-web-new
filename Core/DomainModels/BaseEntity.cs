namespace Core.DomainModels
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public abstract void UpdateValueFrom(BaseEntity source);
    }
}