using System;
using System.Windows.Input;

namespace BlazorPwa.Helpers
{
    public class BindingCommand : ICommand
    {
        public BindingCommand(Action<object> execute)
        {
            Action = execute;
        }

        public Action<object> Action { get; } = null;
        public void Execute(object parameter)
        {
            Action?.Invoke(parameter);
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }
#pragma warning disable CS0067 // justification implementing interface     
        public event EventHandler CanExecuteChanged;
#pragma warning restore CS0067
        
    }
}