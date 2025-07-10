namespace DynamicQuery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Database db = new();
            string[] fields = {"Name", "Age"};
            string[] values = { "John", "30" };
            MessageBox.Show(db.Insert("Users", fields, values));
        }
    }
}