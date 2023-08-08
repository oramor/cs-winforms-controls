using System.Windows.Input;

namespace MenuPrettify
{
    public class GuiCommand : ICommand
    {
        readonly Func<bool> _canExecuteDelegate = () => true;

        public GuiCommand(string text)
        {
            Text = text;
        }

        public GuiCommand(string text, Func<bool> canExecuteDelegate)
        {
            Text = text;
            _canExecuteDelegate = canExecuteDelegate;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return _canExecuteDelegate();
        }

        public void Execute(object? parameter)
        {
            // Do nothing
        }

        public string Text { get; init; }

        public void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
