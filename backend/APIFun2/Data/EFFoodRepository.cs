using System.Runtime.CompilerServices;

namespace APIFun2.Data
{
    public class EFFoodRepository : IFoodRepository
    {
        private FoodContext _foodContext;

        public EFFoodRepository(FoodContext temp)
        {
            _foodContext = temp;
        }
        public IEnumerable<MarriottFood> Foods => _foodContext.Foods;
    }
}
