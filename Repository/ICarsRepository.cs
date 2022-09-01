using cars.Model;

namespace cars.Repository
{
    public interface ICarsRepository
    {
        IEnumerable<Cars> GetAll();
    }
}