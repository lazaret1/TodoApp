using Microsoft.Extensions.Options;
using Raven.Client.Documents;

namespace TodoApi.RavenDb.Access
{
    public class DocumentStoreHolder : IDocumentStoreHolder
    {
        private static RavenDbSettings settings;

        public DocumentStoreHolder(IOptions<RavenDbSettings> ravenSettings)
        {
            settings = ravenSettings.Value;

            Store = new DocumentStore
            {
                Urls = settings.Urls,
                Database = settings.Database
            }.Initialize();
        }

        public IDocumentStore Store { get; }
    }
}