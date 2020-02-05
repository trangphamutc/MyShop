using MyShop.Model.Models;

namespace MyShop.Data.Infarstructure
{
    public interface IErrorRepository : IRepositoty<Error>
    {
    }

    public class ErrorRepository : Repository<Error>, IErrorRepository
    {
        public ErrorRepository(MovieDbContext context)
            : base(context)
        {
        }
    }
}