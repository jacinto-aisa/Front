using System.Collections.Generic;
using System.Threading.Tasks;
using Desaprendiendo.Services.SearchService.Model;

namespace Desaprendiendo.Services.SearchService
{
    public interface ISearchService
    {
        Task<IEnumerable<SearchResult>> Search(string searchedText);
    }
}