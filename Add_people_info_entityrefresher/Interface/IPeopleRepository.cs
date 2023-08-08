using Add_people_info_entityrefresher.Models;

namespace Add_people_info_entityrefresher.Interface
{
    public interface IPeopleRepository
    {
        bool Add(People people);
        bool Update();
        bool Delete();
        bool Save();
    }
}
