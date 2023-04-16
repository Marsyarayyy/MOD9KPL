using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_1302213003.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mahasiswa2 : ControllerBase
    {
        public static List<Mahasiswa> a = new List<Mahasiswa>
        {
            new Mahasiswa ("Marsya Rayani Humaira", "1302213003"),
            new Mahasiswa ("Arya Frandika Daulay", "1302213069"),
            new Mahasiswa ("Fadel Alif Sadena", "1302210059"),
            new Mahasiswa ("Hilmi Fauziyyah S", "1302210081"),
            new Mahasiswa ("Ibrahim Mulyo Tsabit", "1302210022"),
            new Mahasiswa ("Muhammad Rizky Khomeini", "1302190039")

        };
        // GET: api/<Mahasiswa2>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return a;
        }

        // GET api/<Mahasiswa2>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            if (id < 0 || id >= a.Count)
            {
                NotFound();
            }
            return a[id];
        }

        // POST api/<Mahasiswa2>
        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            a.Add(value);
        }

        // DELETE api/<Mahasiswa2>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id < 0 || id >= a.Count)
            {
                NotFound();
            }
            a.RemoveAt(id);
        }
    }
}
