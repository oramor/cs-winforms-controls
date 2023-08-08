namespace MenuPrettify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitContextMenu();
        }

        void InitContextMenu()
        {
            customContextMenuStrip.Items.Clear();

            var unavailCommand = new GuiCommand("Item 1", () => true);

            var item1 = new CustomToolStripMenuItem(unavailCommand) {
                Name = "Item1"
            };

            var item2 = new ToolStripMenuItem("Item 2") {
                Name = "Item2"
            };

            var item3 = new ToolStripMenuItem("Item 3") {
                Name = "Item3"
            };

            customContextMenuStrip.Items.Add(new ToolStripSeparator());
            customContextMenuStrip.Items.Add(new ToolStripSeparator());
            customContextMenuStrip.Items.Add(new ToolStripSeparator());
            customContextMenuStrip.Items.Add(item1);
            customContextMenuStrip.Items.Add(item2);
            customContextMenuStrip.Items.Add(new ToolStripSeparator());
            customContextMenuStrip.Items.Add(new ToolStripSeparator());
            customContextMenuStrip.Items.Add(item3);
            customContextMenuStrip.Items.Add(new ToolStripSeparator());
        }
    }
}