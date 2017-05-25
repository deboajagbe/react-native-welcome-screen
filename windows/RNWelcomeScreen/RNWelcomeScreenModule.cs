using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Com.Reactlibrary.RNWelcomeScreen
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNWelcomeScreenModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNWelcomeScreenModule"/>.
        /// </summary>
        internal RNWelcomeScreenModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNWelcomeScreen";
            }
        }
    }
}
