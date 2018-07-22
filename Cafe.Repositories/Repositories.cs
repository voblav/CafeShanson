using Cafe.AppContext.Code;
using Cafe.Entities.Code;
using Cafe.Repositories.Abstract;
using Cafe.Repositories.Generic;

namespace Cafe.Repositories
{
    public class CompositionsRepository : DbRepository<Composition>, ICompositionsRepository
    {
        public CompositionsRepository(MyAppDbContext context)
            : base(context)
        {

        }
    }

    public class IngredientsRepository : DbRepository<Ingredient>, IIngredientsRepository
    {
        public IngredientsRepository(MyAppDbContext context)
            : base(context)
        {

        }
    }

    public class OrdersRepository : DbRepository<Order>, IOrdersRepository
    {
        public OrdersRepository(MyAppDbContext context)
            : base(context)
        {

        }
    }

    public class OrderFromMenuesRepository : DbRepository<OrderFromMenu>, IOrderFromMenuesRepository
    {
        public OrderFromMenuesRepository(MyAppDbContext context)
            : base(context)
        {

        }
    }

    public class PurchasersRepository : DbRepository<Purchaser>, IPurchasersRepository
    {
        public PurchasersRepository(MyAppDbContext context)
            : base(context)
        {

        }
    }

    public class StewardsRepository : DbRepository<Steward>, IStewardsRepository
    {
        public StewardsRepository(MyAppDbContext context)
            : base(context)
        {

        }
    }

    public class SuppliesRepository : DbRepository<Supple>, ISuppliesRepository
    {
        public SuppliesRepository(MyAppDbContext context)
            : base(context)
        {

        }
    }

    public class DishesRepository : DbRepository<Dish>, IDishesRepository
    {
        public DishesRepository(MyAppDbContext context)
            : base(context)
        {

        }
    }
    }
