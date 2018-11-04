using System;
using System.Collections.Generic;

namespace Classes.ObjserverPatterms {
    public static class ObjserverPatterms {
        public static void DelegatePractice () {
            var mobile = new MobileApp ();
            var desktop = new DesktopApp ();
            var subject = new TempatureMonitorSubject ();

            subject.OnTempatureChanged += mobile.OnTempatureChanged;
            subject.OnTempatureChanged += desktop.OnTempatureChanged;

            subject.Tempature = 10;
            subject.Tempature = 20;

            subject.Tempature = 20;
            subject.OnTempatureChanged -= mobile.OnTempatureChanged;
            subject.Tempature = 30;
            subject.Tempature = 30;
        }
    }

    // ITempatureMonitorSubject.cs
    public interface ITempatureMonitorSubject {
        void RegisterObserver (ITempatureMonitorObserver observer);

        void UnregisterObserver (ITempatureMonitorObserver observer);

        void NotifyTempature ();
    }

    // ITempatureMonitorObserver.cs
    public interface ITempatureMonitorObserver {
        void OnTempatureChanged (double tempature);
    }

    public class TempatureMonitorSubject {
        public delegate void TempatureChanged (double tempature);
        public TempatureChanged OnTempatureChanged;
        private EventHandler OnTempatureOberserved;
        private double _Tempature;
        public double Tempature {
            get { return _Tempature; }
            set {
                if (_Tempature != value) {
                    _Tempature = value;

                    OnTempatureChanged.Invoke (value);
                } else {
                    Console.WriteLine ($"Temprature now is {_Tempature}");
                }
            }
        }
        public TempatureMonitorSubject () {
            OnTempatureChanged = TempatureChange;
        }

        private void TempatureChange (double tempature) {
            Console.WriteLine ($"Temprature is changing..{tempature}");
        }

        private void TempatureOberserved (object sendor, double tempature) {
            Console.WriteLine ($"Temprature now is {tempature}");
        }
    }

    // DesktopApp.cs
    public class DesktopApp : ITempatureMonitorObserver {
        public void OnTempatureChanged (double tempature) {
            Console.WriteLine ($"Desktop App被通知溫度變化了: {tempature}");
        }
    }

    // MobileApp.cs
    public class MobileApp : ITempatureMonitorObserver {
        public void OnTempatureChanged (double tempature) {
            Console.WriteLine ($"Mobile App被通知溫度變化了: {tempature}");
        }
    }
}