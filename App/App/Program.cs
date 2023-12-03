using BusinessLogic;
using Contracts.BusinessLogicContracts;
using Contracts.StorageContracts;
using FileImplement;
using FileImplement.Implements;
using Unity;
using Unity.Lifetime;

namespace App
{
    internal static class Program
    {
        private static IUnityContainer container = null;
        public static IUnityContainer Container
        {
            get
            {
                if (container == null)
                {
                    container = BuildUnityContainer();
                }
                return container;
            }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FileDataListSingleton.GetFileDataListSingleton();
            Application.Run(Container.Resolve<FAuthorisation>());
            FileDataListSingleton.SaveFileDataListSingleton();
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IUserStorage, UserStorage>(new
            HierarchicalLifetimeManager());
            currentContainer.RegisterType<IUserLogic, UserLogic>(new
            HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}