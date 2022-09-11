namespace Composition
{
    public class GameObject
    {
        private string _id;
        protected Vector3 _position;

        public void MoveTo(Vector3 inPosition)
        {
            _position = inPosition;
        }

        public Vector3 GetPosition()
        {
            return _position;
        }

        private void UpdatePosition() {}
    }
}