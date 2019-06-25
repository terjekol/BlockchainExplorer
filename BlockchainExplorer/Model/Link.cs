namespace BlockchainExplorer.Model
{
    public class Link
    {
        public string Type;
        public string PropertyName;
        public string ActionName;

        public Link(string type, string propertyName, string actionName)
        {
            Type = type;
            PropertyName = propertyName;
            ActionName = actionName;
        }
    }
}
