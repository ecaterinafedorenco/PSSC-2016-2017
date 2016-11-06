namespace Models.Generics
{
    public class Attendance
    {
        private int _count;
        public int Count { get; internal set; }

        public Attendance(int count)
        {
            _count = count;
        }
    }
}
