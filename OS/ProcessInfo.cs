using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace OS
{
    internal class ProcessInfo
    {
        private string id;
        private int arrivalTime;
        private int burstTime;
        private int remainingTime;
        private int startTime;
        private int completionTime;

        public ProcessInfo(string id, int arrivalTime, int burstTime)
        {
            this.id = id;
            this.arrivalTime = arrivalTime;
            this.burstTime = burstTime;
            this.remainingTime = burstTime;
            this.startTime = -1;
            this.completionTime = 0;
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public int ArrivalTime
        {
            get { return arrivalTime; }
            set { arrivalTime = value; }
        }

        public int BurstTime
        {
            get { return burstTime; }
            set { burstTime = value; }
        }

        public int RemainingTime
        {
            get { return remainingTime; }
            set { remainingTime = value; }
        }

        public int StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        public int CompletionTime
        {
            get { return completionTime; }
            set { completionTime = value; }
        }


       // Turnaround Time = Completion - Arrival
        public int TurnaroundTime
        {
            get { return completionTime - arrivalTime; }
        }

        // Waiting Time = Turnaround - Burst
        public int WaitingTime
        {
            get { return TurnaroundTime - burstTime; }
        }

        //Response Time = Start - Arrival
        public int ResponseTime
        {
            get { return startTime - arrivalTime; }
        }
    }
}
