using Raven.Client.Documents;
using Raven.Client.Documents.Session;
using TodoApi.Models;
using TodoApi.RavenDb.Access;

namespace TodoApi.RavenDbManager
{
    public class RavenDbDataManager: IRavenDbDataManager
    {
        private readonly IDocumentStore store;

        public RavenDbDataManager(IDocumentStoreHolder documentsStoreHolder)
        {
            store = documentsStoreHolder.Store;
        }


        public Customer CreateCustomer()
        {
            using (IDocumentSession session = store.OpenSession())
            {

                Customer cust = new Customer
                {
                    FirstName = "John",
                    LastName = "Doo",
                    Phone = "232-3231-23"
                };

                // session.Store(new Customer {
                //     cust.FirstName = "John",
                //     cust.LastName = "Doe",
                //     cust.Phone = "111-222-333"
                // });
                session.Store(cust);
                session.SaveChanges();

                return cust;
            }
        }
    }
}