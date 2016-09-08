using System;
using System.Collections.Generic;
using System.Text;

namespace fxcore2.com
{
    /// <summary>
    /// Special interface for Wrapper class that represents callback interface 
    /// for special instance initialization when it passed to API method as argument
    /// </summary>
    internal interface ICallbackEventSink
    {
        /// <summary>
        /// Setup Session object to instance of callback interface in methods which parameter marked as CallbackInterface
        /// </summary>
        /// <param name="session"></param>
        void SetupSession(Session session);
    }
}
