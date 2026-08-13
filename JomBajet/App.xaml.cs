using System.Windows;
using JomBajet.Views;
using Prism.Ioc;
using Prism.Regions;

namespace JomBajet
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
        protected override void OnInitialized()
        {
            base.OnInitialized();

            var regionManager = Container.Resolve<IRegionManager>();

            regionManager.RegisterViewWithRegion(
                "HeaderRegion",
                typeof(HeaderInfoView));

            regionManager.RegisterViewWithRegion(
                "MenuRegion",
                typeof(MenuListView));

            regionManager.RegisterViewWithRegion(
               "ContentRegion",
               typeof(MonthlyBajetView));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Dependency Injection - OOP Abstraction


            // Register dialogs (Prism Dialog Service)


            // Register regions (Prism Region Manager)
            containerRegistry.RegisterForNavigation<HeaderInfoView>();
            containerRegistry.RegisterForNavigation<MenuListView>();
            containerRegistry.RegisterForNavigation<MonthlyBajetView>();
        }
    }
}
