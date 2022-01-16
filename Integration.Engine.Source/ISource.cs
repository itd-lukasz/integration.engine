using Integration.Engine.Message;
namespace Integration.Engine.Source;

public interface ISource
{
    public IMessage GetMessage();
}