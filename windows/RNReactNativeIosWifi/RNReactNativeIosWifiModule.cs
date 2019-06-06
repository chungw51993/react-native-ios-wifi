using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Ios.Wifi.RNReactNativeIosWifi
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeIosWifiModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeIosWifiModule"/>.
        /// </summary>
        internal RNReactNativeIosWifiModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeIosWifi";
            }
        }
    }
}
