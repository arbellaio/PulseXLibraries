namespace PulseXLibraries.Models.Firebase
{
    public class FirebaseItem<T>
    {
        public int Id { get; set; }
        public T Item { get; set; }
    }
}