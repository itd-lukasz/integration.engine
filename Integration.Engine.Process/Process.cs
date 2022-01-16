using System.Reflection.Metadata;
using Integration.Engine.Step;

namespace Integration.Engine.Process;

public abstract class Process
{
    public Guid ID { get; }
    public string Name { get; }
    public DateTime Created { get; }
    public IStep FirstStep { get; init; }

    public Process(string file)
    {
        throw new NotImplementedException();
    }
    
    public Process(IStep firstStep, string name)
    {
        ID = Guid.NewGuid();
        Created = DateTime.Now;
        Name = name;
        FirstStep = firstStep;
    }
    
    public void Run()
    {
        IStep currentStep = FirstStep;
        while (currentStep != null)
        {
            currentStep.Run();
            currentStep = currentStep.NextStep();
        }
    }

    public void Save(string file)
    {
        throw new NotImplementedException();
    }
}