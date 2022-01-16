namespace Integration.Engine.Step;

public interface IStep
{
    public string Name { get; set; }

    public void Run();

    public IStep NextStep();
}