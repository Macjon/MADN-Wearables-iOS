using System;

using UIKit;
using Foundation;

namespace Madn
{
    public partial class ViewController : UIViewController
    {
        #region Constructors

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        #endregion

        #region Lifecycle


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NSUserDefaults shared = new NSUserDefaults(
                                        "group.com.flowpilots.debug",
                                        NSUserDefaultsType.SuiteName);

            // set values
            shared.SetInt(2, "count");
            shared.Synchronize();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        #endregion

        #region IBOutlets

        partial void BtnLocalNotificationTouched(UIButton sender)
        {
            var notification = new UILocalNotification();

            notification.FireDate = NSDate.Now.AddSeconds(8);
            notification.TimeZone = NSTimeZone.DefaultTimeZone;
            notification.AlertTitle = "MADN";
            notification.AlertAction = "Alert Action";
            notification.AlertBody = "I love notifications!";
            notification.UserInfo = NSDictionary.FromObjectAndKey(new NSString("UserInfo for notification"), new NSString("Notification"));
            notification.SoundName = UILocalNotification.DefaultSoundName;

            UIApplication.SharedApplication.ScheduleLocalNotification(notification);
        }

        #endregion
    }
}

