using Common.Logging;
using System;
using Topshelf;

namespace $safeprojectname$.Service
{
    internal class WinService 
    {

        public ILog Log { get; private set; }

        public WinService(ILog logger)
        {

            // IocModule.cs needs to be updated in case new paramteres are added to this constructor

            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            Log = logger;

        }

        public bool Start(HostControl hostControl)
        {   
                     
            Log.Info($"{nameof(WinService)} Start command received.");

            //TODO: Implement your service start routine.
            return true;

        }

        public bool Stop(HostControl hostControl)
        {

            Log.Trace($"{nameof(WinService)} Stop command received.");

            //TODO: Implement your service stop routine.
            return true;

        }

        public bool Pause(HostControl hostControl)
        {

            Log.Trace($"{nameof(WinService)} Pause command received.");

            //TODO: Implement your service start routine.
            return true;

        }

        public bool Continue(HostControl hostControl)
        {

            Log.Trace($"{nameof(WinService)} Continue command received.");

            //TODO: Implement your service stop routine.
            return true;

        }

        public bool Shutdown(HostControl hostControl)
        {

            Log.Trace($"{nameof(WinService)} Shutdown command received.");

            //TODO: Implement your service stop routine.
            return true;

        }

    }
}
