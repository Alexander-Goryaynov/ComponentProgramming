using LibraryDatabase;
using LibraryDatabase.DbModels;
using LibraryDatabase.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;
using Type = LibraryDatabase.DbModels.Type;

namespace Library
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormBooks>());
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<BookServiceDB>(new
                HierarchicalLifetimeManager());
            currentContainer.RegisterType<TypeServiceDB>(new
                HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
