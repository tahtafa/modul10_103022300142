using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul10_103022300142.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private static List<Movie> _movies = new List<Movie>
        {
            new Movie("The Shawshank Redemption", "Frank Darabont", new List<string>{"Tim Robbins", "Morgan Freeman", "Bob Gunton"}, "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new Movie("The Godfather", "Francis Ford Coppola", new List<string>{"Marlon Brando", "AI Pacino", "James Caan"}, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new Movie("The Dark Knight", "Christopher Nolan", new List<string>{"Christian Bale", "Heath Ledger", "Aaron Eckhart"}, "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.")
        };
        // GET: api/<MovieController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _movies;
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public ActionResult<Movie> Get(int id)
        {
            if (id < 0 || id >= _movies.Count)
            {
                return NotFound();
            }
            return _movies[id];
        }

        // POST api/<MovieController>
        [HttpPost]
        public void Post([FromBody] Movie m)
        {
            _movies.Add(m);
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id >= 0 && id < _movies.Count)
            {
                _movies.RemoveAt(id);
            }
        }
    }
}
