using Raven.Client.Documents;
using Raven.Client.Documents.Session;
using TodoApi.Models;
using TodoApi.RavenDb.Access;

namespace TodoApi.RavenDbManager
{
    public class RavenDbDataManager
    {
        private readonly IDocumentStore store;

        public RavenDbDataManager(IDocumentStoreHolder documentsStoreHolder)
        {
            store = documentsStoreHolder.Store;
        }


        public void GetDefaultData()
        {
            using (IDocumentSession session = store.OpenSession())
            {
                session.Store(new Customer {
                    FirstName = "John",
                    LastName = "Doe",
                    Phone = "111-222-333"
                });

                session.SaveChanges();
            }
        }
    }
}