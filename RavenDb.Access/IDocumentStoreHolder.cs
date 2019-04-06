using Raven.Client.Documents;

namespace TodoApi.RavenDb.Access
{
    public interface IDocumentStoreHolder
    {
        IDocumentStore Store { get; }
    }
}