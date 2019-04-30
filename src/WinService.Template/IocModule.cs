using Common.Logging;

namespace $safeprojectname$
{
    internal class IocModule : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {

            Bind<ILog>().ToMethod(ctx =>
            {
                var type = ctx.Request.ParentContext?.Request.Service;
                return LogManager.GetLogger(type);
            });

            Bind<Service.WinService>().ToSelf();

        }
    }
}

