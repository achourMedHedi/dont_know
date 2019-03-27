using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Core
{
    public class Service
    {
        protected ILogger Logger;
        public Service (ILogger logger)
        {
            Logger = logger;
        }
    }
}
