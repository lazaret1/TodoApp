using Microsoft.Extensions.Options;
using Raven.Client.Documents;

namespace TodoApi.RavenDb.Access
{
    public class DocumentStoreHolder : IDocumentStoreHolder
    {
        public IDocumentStore Store { get; }

        public DocumentStoreHolder(IOptions<RavenDbSettings> ravenSettings)
        {
            var settings = ravenSettings.Value;

            Store = new DocumentStore
            {
                Urls = settings.Urls,
                Database = settings.Database
            }.Initialize();
        }

    }
}