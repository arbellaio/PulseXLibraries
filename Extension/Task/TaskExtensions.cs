using PulseXLibraries.Extension.Exception;

namespace PulseXLibraries.Extension.Task
{
    public static class TaskExtensions
    {
#pragma warning disable RECS0165 // Asynchronous methods should return a Task instead of void
        public static async void FireAndForgetSafeAsync(this System.Threading.Tasks.Task task, IExceptionHandler handler = null)
#pragma warning restore RECS0165 // Asynchronous methods should return a Task instead of void
        {
            try
            {
                await task;
            }
            catch (System.Exception ex)
            {
                handler?.HandleException(ex);
            }
        }
    }
}