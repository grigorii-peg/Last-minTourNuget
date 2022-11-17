namespace Last_min_TourNu
{
    public class Tours<T> where T : class
    {
        private List<T> tours = new List<T>();

        public Tours() { }
        public List<T> GetList()
        {
            return tours;
        }
        public void Add(T arg)
        {
            tours.Add(arg);
        }
        public void Edit(T id, T arg)
        {
            var index = tours.IndexOf(id);
            tours[index] = arg;
        }
        public void Delete(T arg)
        {
            tours.Remove(arg);
        }
    }
}