namespace Apricot.Core.Interfaces
{
    public interface IAppLogger<T>
    {
        void LogInfomation(string message, params object[] args);

        void LogWarning(string message, params object[] args);
    }
}