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

            var cmd1 = new GuiCommand("Item 1", () => true);
            var cmd2 = new GuiCommand("Item 4", () => true);

            var item1 = new CustomToolStripMenuItem(cmd1) {
                Name = "Item1"
            };

            var item2 = new ToolStripMenuItem("Item 2") {
                Name = "Item2"
            };

            var item3 = new ToolStripMenuItem("Item 3") {
                Name = "Item3"
            };

            var item4 = new CustomToolStripMenuItem(cmd2) {
                Name = "Item4"
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
            customContextMenuStrip.Items.Add(item4);
        }
    }
}