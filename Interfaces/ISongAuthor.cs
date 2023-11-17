using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface ISongAuthor
    {
        IEnumerable<Author> Authors();
    }
}
