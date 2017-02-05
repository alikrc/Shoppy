namespace Shoppy.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        bool Commit();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory _dbFactory;
        private EntityDataContext _context;

        public EntityDataContext Context
        {
            get { return _context ?? (_context = _dbFactory.Get()); }
        }

        public UnitOfWork(IDatabaseFactory dbFac)
        {
            this._dbFactory = dbFac;
        }

        public bool Commit()
        {
            return Context.SaveChanges() > 0; // .Commit();
        }
    }

}
