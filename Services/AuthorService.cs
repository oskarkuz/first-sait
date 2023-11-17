using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class AuthorService : ISongAuthor
    {
        public IEnumerable<Author> Authors() {
            List<Author> authors = new List<Author>();
            authors.Add(new Author {
                Id = 1,
                Name = "Test",
                Description = "Test",
                Albums = new List<Album> {
                    new Album {
                        Id = 2,
                        Title = "Test",
                        Description = "Test",
                        Songs = new List<Song> {
                            new Song { 
                                Id = 3,
                                Title = "Test",
                                Description = "Test",
                                Lyrics = "Test"
                            },
							new Song {
								Id = 4,
								Title = "Test",
								Description = "Test",
								Lyrics = "Test"
							}
						}
                    }
                }
            });
            return authors;
        }
    }
}
