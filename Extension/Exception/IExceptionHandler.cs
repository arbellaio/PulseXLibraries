using System.Runtime.CompilerServices;

namespace PulseXLibraries.Extension.Exception
{
    public interface IExceptionHandler
    {
        void HandleException(System.Exception e);

        void HandleError(string message, bool notifyUser = false,
            [CallerFilePath] string callerFilePath = null,
            [CallerMemberName] string callerName = null);
    }
}