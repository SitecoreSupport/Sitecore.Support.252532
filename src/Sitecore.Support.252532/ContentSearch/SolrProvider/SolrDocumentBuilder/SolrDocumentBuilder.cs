namespace Sitecore.Support.ContentSearch.SolrProvider
{
  using Sitecore.ContentSearch;
  public class SolrDocumentBuilder : Sitecore.ContentSearch.SolrProvider.SolrDocumentBuilder
  {
    public SolrDocumentBuilder(IIndexable indexable, IProviderUpdateContext context)
    : base(indexable, context) { }

    protected override void AddField(IIndexableDataField field)
    {

      if (string.IsNullOrEmpty(field.Name) && string.IsNullOrEmpty(field.TypeKey))
      {
        return;
      }

      base.AddField(field);
    }
  }
}