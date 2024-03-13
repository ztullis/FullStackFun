namespace APIFun2.Data
{
    public interface IFoodRepository
    {
        IEnumerable<MarriottFood> Foods { get; }
    }
}
