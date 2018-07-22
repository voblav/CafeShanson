using System.Data.Entity;

namespace Cafe.AppContext.Code
{
    public class MyAppDbContextInitializer : DropCreateDatabaseIfModelChanges<MyAppDbContext>
    {
        protected override void Seed(MyAppDbContext context)
        {
        }
    }
}
