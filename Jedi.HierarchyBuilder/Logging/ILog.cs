namespace Jedi.HierarchyBuilder.Logging
{
    public interface ILog
    {
        string LastLogMessage { get; }
        void Write(string log);
    }

    public delegate void LogWriter(string log);
}
