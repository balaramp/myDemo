using myDemo.Views; 

namespace myDemo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeRouting();
            InitializeComponent();
        }

        private void InitializeRouting()
        {
            Routing.RegisterRoute("Filter", typeof(MapsPage));
        }
    }
}
