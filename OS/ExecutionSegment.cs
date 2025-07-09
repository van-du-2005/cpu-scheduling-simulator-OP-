using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    internal class ExecutionSegment
    {
        private string processName; // Tên tiến trình
        private int startTime; // Thời điểm bắt đầu chạy
        private int endTime;     // Thời điểm kết thúc chạy

        public ExecutionSegment(string _processName, int _startTime, int _endTime)
        {
            processName = _processName;
            startTime = _startTime;
            endTime = _endTime;
        }

        public string ProcessName
        {
            get { return processName; }
            set { processName = value; }
        }
        public int StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        public int EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
    }
}
