namespace Simple
{
    internal abstract class Prototype
    {
        private string _id;
        public string Id => _id;
        public Prototype(string id)
        {
            this._id = id;
        }

        public abstract Prototype Clone();
    }
}