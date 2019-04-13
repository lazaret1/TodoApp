using TodoApi.Models;

namespace TodoApi.RavenDbManager
{
    public interface IRavenDbDataManager
    {
        Customer CreateCustomer();
    }
}