using Ninject;
using Ninject.Extensions.Logging.NLog4;
using System.Reflection;

namespace ExcelForm2Col
{
    public static class Kernel
    {
        private static IKernel _kernel;

        static Kernel()
        {
            var settings = new NinjectSettings();
            settings.LoadExtensions = false;
            

            _kernel = new StandardKernel(settings,new NLogModule(),new Bindings());
        }
        public static IKernel Load()
        {
            
           // _kernel.Load(Assembly.GetExecutingAssembly());
            return _kernel;
        }


        public static IKernel InternalKernel => _kernel;
    }
}
