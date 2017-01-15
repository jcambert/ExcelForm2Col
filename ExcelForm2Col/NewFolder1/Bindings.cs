
using Ninject.Modules;

using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelForm2Col
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IProject>().To<Project>();
            Bind<IField>().To<Field>();
            Bind<IMapping>().To<Mapping>();
            Bind<IEF2C>().To<EF2C>();
            Bind<IDestination>().To<Destination>();
            Bind<Excel.Application>().ToMethod(app => new Excel.Application());//.InSingletonScope();
            Bind<Project>().ToSelf();
        }
    }
}
