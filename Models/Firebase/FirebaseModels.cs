namespace PulseXLibraries.Models.Firebase
{
    public class FirebaseItem<T>
    {
        public string StringId { get; set; }
        public int Id { get; set; }
        public T Item { get; set; }
    }
}