using System;

using WatchKit;
using Foundation;

namespace Madn.WatchKitExtension
{
    public partial class InterfaceController : WKInterfaceController
    {
        public InterfaceController(IntPtr handle) : base(handle)
        {
        }

        public override void Awake(NSObject context)
        {
            base.Awake(context);

            NSUserDefaults shared = new NSUserDefaults(
                                        "group.com.flowpilots.debug",
                                        NSUserDefaultsType.SuiteName);

            // get values
            shared.Synchronize();
            var count = shared.IntForKey("count");
            LblHelloWorld.SetText($"Count= {count}");
        }

        public override void WillActivate()
        {
            
        }

        public override void DidDeactivate()
        {
            
        }
    }
}

