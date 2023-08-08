using Add_people_info_entityrefresher.Data;
using Add_people_info_entityrefresher.Interface;
using Add_people_info_entityrefresher.Models;

namespace Add_people_info_entityrefresher.Repository
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly ApplicationDbContext _context;

        public PeopleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public bool Add(People people)
        {
            _context.Peoples.Add(people);
            return Save();
        }

        public bool Delete(People people)
        {
            _context.Peoples.Remove(people);
            return Save();
        }

        public IEnumerable<People> Getall()
        {
            var all_people = _context.Peoples.ToList();
            return all_people;
        }

        public People GetById(int id)
        {
            var Id_people = _context.Peoples.Single(x => x.Id == id);
            return Id_people;
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
