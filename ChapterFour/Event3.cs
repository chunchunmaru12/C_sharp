using System;
namespace Chapter4{
    //publisher
    public class Doorbell{
        public delegate void RingEventHandler(object sender, EventArgs e);
        public event RingEventHandler? Ring;
        public void Press(){
            Console.WriteLine("Doorbell pressed");
            if(Ring!=null){
                Ring(this, EventArgs.Empty);
            }
        }
    }
    //subscriber
    public class Resident{
        public void DoorbellRing(object sender, EventArgs e){
            Console.WriteLine("Resident: I'll get the door!");
        }
        public void InitiateCamRecorder(object sender, EventArgs e){
            Console.WriteLine("Camera: Start recording the door!");
        }
    }
    public class Event3{
        static void Main(string[] args){
            Doorbell doorbell = new Doorbell();
            Resident resident = new Resident();
            doorbell.Ring += resident.InitiateCamRecorder; // doorbell.Ring += new Doorbell.RingEventHandler(resident.InitiateCamRecorder);
            doorbell.Ring += resident.DoorbellRing; // doorbell.Ring += new Doorbell.RingEventHandler(resident.DoorbellRing);

            doorbell.Press();
        }

    }
}