using Cafe.AppContext.Code;
using Cafe.Repositories;
using Cafe.Repositories.Abstract;

namespace Cafe.DataUnit
{
    public static class Unit
    {
        static MyAppDbContext _context;
        public static ICompositionsRepository CompositionsRepository { get; private set; }
        public static IDishesRepository DishesRepository { get; private set; }
        public static IIngredientsRepository IngredientsRepository { get; private set; }
        public static IOrdersRepository OrdersRepository { get; private set; }
        public static IOrderFromMenuesRepository OrderFromMenuesRepository { get; private set; }
        public static IPurchasersRepository PurchasersRepository { get; private set; }
        public static IStewardsRepository StewardsRepository { get; private set; }
        public static ISuppliesRepository SuppliesRepository { get; private set; }
        static Unit()
        {
            _context = new MyAppDbContext("DbRest");
            DishesRepository = new DishesRepository(_context);
            CompositionsRepository = new CompositionsRepository(_context);
            IngredientsRepository = new IngredientsRepository(_context);
            OrdersRepository = new OrdersRepository(_context);
            OrderFromMenuesRepository = new OrderFromMenuesRepository(_context);
            PurchasersRepository = new PurchasersRepository(_context);
            StewardsRepository = new StewardsRepository(_context);
            SuppliesRepository = new SuppliesRepository(_context);
        }
    }
}
