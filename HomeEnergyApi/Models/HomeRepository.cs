namespace HomeEnergyApi.Models
{
    public class HomeRepository
    {
        public List<Home> HomesList;

        public HomeRepository()
        {
            HomesList = new List<Home>();
        }

        public Home Save(Home newHome)
        {
            HomesList.Add(newHome);
            return newHome;
        }

        public Home Update(int id, Home updatedHome)
        {
            HomesList[id] = updatedHome;
            return updatedHome;
        }

        public List<Home> FindAll()
        {
            return HomesList;
        }

        public Home FindById(int id)
        {
            return HomesList[id];
        }

        public Home RemoveById(int id)
        {
            var removedHome = HomesList[id];
            HomesList.Remove(removedHome);
            return removedHome;
        }
    }
}