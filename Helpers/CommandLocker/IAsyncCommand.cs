using System.Threading.Tasks;
using System.Windows.Input;

namespace PulseXLibraries.Helpers.CommandLocker
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync();

        void RaiseCanExecuteChanged();

        bool CanExecute();
    }

    public interface IAsyncCommand<T> : ICommand
    {
        Task ExecuteAsync(T parameter);

        bool CanExecute(T parameter);
    }
}