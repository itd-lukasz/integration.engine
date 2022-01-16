using Integration.Engine.Message;

namespace Integration.Engine.Storage
{
    public interface IData
    {
        public List<IMessage> GetMessages()
        {
            throw new NotImplementedException();
        }

        public IMessage GetNextMessage()
        {
            throw new NotImplementedException();
        }

        public void UpdateMessage(IMessage message)
        {
            throw new NotImplementedException();
        }

        public void AddMessage(IMessage message)
        {
            throw new NotImplementedException();
        }

        public void DeleteMessage(IMessage message)
        {
            throw new NotImplementedException();
        }
    }
}