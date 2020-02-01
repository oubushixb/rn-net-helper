using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Net.Helper.RNNetHelper
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNNetHelperModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNNetHelperModule"/>.
        /// </summary>
        internal RNNetHelperModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNNetHelper";
            }
        }
    }
}
