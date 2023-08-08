namespace MenuPrettify
{
    public partial class CustomToolStripMenuItem : ToolStripMenuItem
    {
        readonly GuiCommand _command;

        public CustomToolStripMenuItem(GuiCommand command)
        {
            InitializeComponent();
            Text = command.Text;
            Available = command.CanExecute(this);
            _command = command;
        }

        new public GuiCommand? Command
        {
            get => _command;
        }
    }
}
