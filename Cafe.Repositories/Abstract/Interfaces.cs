using Cafe.DomainAbstractions.Repositories;
using Cafe.Entities.Code;

namespace Cafe.Repositories.Abstract
{
    public interface IDishesRepository : IDbRepository<Dish>
    {
    }
    public interface ICompositionsRepository : IDbRepository<Composition>
    {
    }
    public interface IIngredientsRepository : IDbRepository<Ingredient>
    {
    }
    public interface IOrdersRepository : IDbRepository<Order>
    {
    }
    public interface IOrderFromMenuesRepository : IDbRepository<OrderFromMenu>
    {
    }
    public interface IPurchasersRepository : IDbRepository<Purchaser>
    {
    }
    public interface IStewardsRepository : IDbRepository<Steward>
    {
    }
    public interface ISuppliesRepository : IDbRepository<Supple>
    {
    }
}
