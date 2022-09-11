namespace MultipleInheritance
{
    public class GameObject
    {
        private string _id;

        protected Vector3 Position { get; private set; }

        public void MoveTo(Vector3 InPosition)
        {
            Position = InPosition;
        }

        public void UpdatePosition() {}
    }
}