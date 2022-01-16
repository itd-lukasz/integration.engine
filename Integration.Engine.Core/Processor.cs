namespace Integration.Engine.Core
{
    public class Processor
    {
        public Processor()
        {
            LoadPlugins("");
        }

        private void RunProcesses()
        {
            List<Process.Process> processes = new();
            foreach (Process.Process process in processes)
            {
                process.Run();
            }
        }

        private void LoadPlugins(string path)
        {
        }
    }
}