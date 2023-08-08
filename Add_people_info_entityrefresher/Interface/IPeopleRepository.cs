using Add_people_info_entityrefresher.Models;

namespace Add_people_info_entityrefresher.Interface
{
    public interface IPeopleRepository
    {
        bool Add(People people);
        public IEnumerable<People> Getall();
        public People GetById(int id);
        bool Update();
        bool Delete(People people);
        bool Save();
    }
}
