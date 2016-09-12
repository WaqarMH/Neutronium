﻿using System.Threading.Tasks;
using Neutronium.Core.WebBrowserEngine.Window;

namespace Tests.Infra.HTMLEngineTesterHelper.Threading 
{
    public class DispatcherTaskFactory : TaskFactory
    {
        public DispatcherTaskFactory(IDispatcher dispatcher) 
            : base( new DispatcherContextTaskScheduler(dispatcher))
        {       
        }
    }
}
