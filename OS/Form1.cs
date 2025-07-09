using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace OS
{
    public partial class Form1 : Form
    {
        List<ProcessInfo> dataInput = new List<ProcessInfo>();

        private int checkSelect = -1; // kiểm tra người dùng chon thuật toán FCFS, SJF, SRTF, Round Robin. (0, 1, 2, 3)

        public Form1()
        {
            InitializeComponent();
        }

        // xử lý event//
        
        // end form.
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                form.Close();
            }
        }

        // event chọn 1 tiến trình để sử trong comboBox
        private void cmb_ProcessFix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ProcessFix.SelectedItem != null)
            {
                string itemSelected = cmb_ProcessFix.SelectedItem.ToString(); // Lấy tên tiến trình đã chọn từ combobox
                foreach (ProcessInfo p in dataInput)
                {
                    if (p.Id == itemSelected)
                    {
                        tbt_ProccesName.Text = p.Id; // Hiển thị tên tiến trình trong textbox Process Name
                        tbt_Arrival.Text = p.ArrivalTime.ToString(); // Hiển thị thời điểm đến trong textbox Arrival Time
                        tbt_Bust.Text = p.BurstTime.ToString(); // Hiển thị thời gian chạy trong textbox Burst Time
                                                                // Hiển thị label thông tin sửa đổi
                        break;
                    }
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn tiến trình cần sửa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


        }

        // hàm kiểm tra thông tin đã nhập đủ chưa.
        private bool checkInfor(string process, string arrival, string burst)
        {
            string p = tbt_ProccesName.Text.Trim(); // Lấy tên tiến trình từ textbox
            string a = tbt_Arrival.Text.Trim(); // Lấy thời điểm đến từ textbox
            string b = tbt_Bust.Text.Trim(); // Lấy thời gian chạy từ textbox

            if (p == "" || a == "" || b == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tiến trình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                int numA;
                int numB;
                if (!int.TryParse(a, out numA) || !int.TryParse(b, out numB))
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ cho thời điểm đến và thời gian chạy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (numA < 0)
                {
                    MessageBox.Show("vui lòng nhập thơi điểm vào ready >= 0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (numB <= 0)
                {
                    MessageBox.Show("Vui lòng nhập thời gian chạy lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                process = p;
                arrival = a;
                burst = b;

                return true;


            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            tbt_Arrival.Text = ""; // Xóa giá trị trong textbox Arrival Time
            tbt_Bust.Text = ""; // Xóa giá trị trong textbox Burst Time 
            tbt_ProccesName.Text = ""; // Xóa giá trị trong textbox Process Name


            lbl_selectProcessFix.Visible = false; // ẩn label Select Process Fix
            lbl_ProcessNameFix.Visible = false; // ẩn  label Process Name Fix
            lbl_BurstFix.Visible = false; // ẩn  label Burst Time Fix
            lbl_arrivalFix.Visible = false; // ẩn  label Arrival Time Fix
            cmb_ProcessFix.Visible = false; // ẩn  combobox Process Fix


            lbl_Arrival.Visible = true; // hiển thị label Arrival Time
            lbl_BurstCPU.Visible = true; // hiển thị label Burst Time
            lbl_ProccesName.Visible = true; // hiển hiển thị label Process Name

            tbt_Arrival.Visible = true; // Hiển thị textbox Arrival Time
            tbt_Bust.Visible = true; // Hiển thị textbox Burst Time
            tbt_ProccesName.Visible = true; // Hiển thị textbox Process Name

            btn_FixInfor.Visible = false; // Ẩn nút sửa thông tin tiến trình
            btn_AddInfor.Visible = true;

        }

        private void btn_Fix_Click(object sender, EventArgs e)
        {

            lbl_Arrival.Visible = false; // ẩn thị label Arrival Time
            lbl_BurstCPU.Visible = false; // ẩn thị label Burst Time
            lbl_ProccesName.Visible = false; // ẩn hiển thị label Pro

            lbl_ProcessNameFix.Visible = true; // Hiển thị label Process Name Fix
            lbl_BurstFix.Visible = true; // Hiển thị label Burst Time Fix
            lbl_arrivalFix.Visible = true; // Hiển thị label Arrival Time Fix
            lbl_selectProcessFix.Visible = true; // Hiển thị label Select Process Fix
            cmb_ProcessFix.Visible = true; // Hiển thị combobox Process Fix

            tbt_ProccesName.Visible = true; // Ẩn textbox Process Name
            tbt_Arrival.Visible = true; // Ẩn textbox Arrival Time
            tbt_Bust.Visible = true; // Ẩn textbox Burst Time

            btn_AddInfor.Visible = false; // Ẩn nút thêm thông tin tiến trình
            btn_FixInfor.Visible = true; // Hiển thị nút sửa thông tin tiến trình

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa\n(click vào góc trái của bảng hiển thị thông tin đã nhập)\nrồi click xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow) // nếu không phải là dòng mới (dòng không có dữ liệu) thì xóa dòng đó. 
                {
                    dataGridView1.Rows.Remove(row); // Xóa dòng đã chọn
                }
            }

            // lấy tất cả  tên tiến trình đã nhập.
            ReadDataInput(); // Đọc dữ liệu từ DataGridView vào danh sách dataInput

            //  xóa dữ liệu combobox cũ.
            cmb_ProcessFix.Items.Clear(); // Xóa tất cả các mục trong combobox trước khi thêm mới

            // Thêm tên tiến trình vào combobox để sửa thông tin tiến trình.
            foreach (ProcessInfo p in dataInput)
            {
                cmb_ProcessFix.Items.Add(p.Id);
            }

        }

        // event ok add
        private void button1_Click(object sender, EventArgs e)
        {

            if (checkInfor(tbt_ProccesName.ToString().Trim(), tbt_Arrival.ToString().Trim(), tbt_Bust.ToString().Trim()))
            {
                dataGridView1.Rows.Add(tbt_ProccesName.Text.Trim(), tbt_Arrival.Text.ToString().Trim(), tbt_Bust.Text.Trim());

                // lấy tất cả  tên tiến trình đã nhập.
                ReadDataInput(); // Đọc dữ liệu từ DataGridView vào danh sách dataInput

                //  xóa dữ liệu combobox cũ.
                cmb_ProcessFix.Items.Clear(); // Xóa tất cả các mục trong combobox trước khi thêm mới

                // Thêm tên tiến trình vào combobox để sửa thông tin tiến trình.
                foreach (ProcessInfo p in dataInput)
                {
                    cmb_ProcessFix.Items.Add(p.Id);
                }

                tbt_ProccesName.Text = ""; // Xóa giá trị trong textbox Process Name
                tbt_Arrival.Text = ""; // Xóa giá trị trong textbox Arrival Time
                tbt_Bust.Text = ""; // Xóa giá trị trong textbox Burst Time

                lbl_Arrival.Visible = false; // ẩn thị label Arrival Time
                lbl_BurstCPU.Visible = false; // ẩn thị label Burst Time
                lbl_ProccesName.Visible = false; // ẩn hiển thị label Process Name

                tbt_ProccesName.Visible = false; // Ẩn textbox Process Name
                tbt_Arrival.Visible = false; // Ẩn textbox Arrival Time
                tbt_Bust.Visible = false; // Ẩn textbox Burst Time

                btn_AddInfor.Visible = false; // Ẩn nút thêm thông tin tiến trình
                btn_FixInfor.Visible = false; // Hiển thị nút sửa thông tin tiến trình

                MessageBox.Show("Thông tin tiến trình đã được thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        // event ok Fix
        private void btn_FixInfor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_ProcessFix.Text))
            {
                MessageBox.Show("Vui lòng chọn tiến trình cần sửa thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkInfor(tbt_ProccesName.ToString().Trim(), tbt_Arrival.ToString().Trim(), tbt_Bust.ToString().Trim()))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow && row.Cells[0].Value.ToString() == cmb_ProcessFix.SelectedItem.ToString())
                    {
                        row.Cells[0].Value = tbt_ProccesName.Text.Trim(); // Sửa tên tiến trình
                        row.Cells[1].Value = tbt_Arrival.Text.Trim(); // Sửa thời điểm đến
                        row.Cells[2].Value = tbt_Bust.Text.Trim(); // Sửa thời gian chạy
                        break; // Thoát vòng lặp sau khi sửa xong
                    }
                }



                // lấy tất cả  tên tiến trình đã nhập.
                ReadDataInput(); // Đọc dữ liệu từ DataGridView vào danh sách dataInput

                //  xóa dữ liệu combobox cũ.
                cmb_ProcessFix.Items.Clear(); // Xóa tất cả các mục trong combobox trước khi thêm mới

                // Thêm tên tiến trình vào combobox để sửa thông tin tiến trình.
                foreach (ProcessInfo p in dataInput)
                {
                    cmb_ProcessFix.Items.Add(p.Id);
                }

                tbt_ProccesName.Text = ""; // Xóa giá trị trong textbox Process Name.
                tbt_Arrival.Text = ""; // Xóa giá trị trong textbox Arrival Time.
                tbt_Bust.Text = ""; // Xóa giá trị trong textbox Burst Time.

                lbl_selectProcessFix.Visible = false; // ẩn label Select Process Fix
                lbl_ProcessNameFix.Visible = false; // ẩn  label Process Name Fix
                lbl_BurstFix.Visible = false; // ẩn  label Burst Time Fix
                lbl_arrivalFix.Visible = false; // ẩn  label Arrival Time Fix
                cmb_ProcessFix.Visible = false; // ẩn  combobox Process Fix

                tbt_Arrival.Visible = false; // Hiển thị textbox Arrival Time
                tbt_Bust.Visible = false; // Hiển thị textbox Burst Time
                tbt_ProccesName.Visible = false; // Hiển thị textbox Process Name

                btn_FixInfor.Visible = false; // Ẩn nút sửa thông tin tiến trình
                btn_AddInfor.Visible = false;

                cmb_ProcessFix.SelectedIndex = -1; // Xóa lựa chọn trong combobox sau khi sửa thông tin tiến trình

                MessageBox.Show("Thông tin tiến trình đã được sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        ///.

        // chọn FCFS, SJF, SRTF, Round Robin.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkSelect = 0; // Chọn FCFS
            lb_Quantum.Visible = false; // Ẩn label Quantum
            TB_Quantum.Visible = false; // Ẩn textbox Quantum
        }

        private void RaB_SJF_CheckedChanged(object sender, EventArgs e)
        {
            checkSelect = 1; // Chọn SJF
            lb_Quantum.Visible = false; // Ẩn label Quantum
            TB_Quantum.Visible = false; // Ẩn textbox Quantum
        }

        private void RaB_SRTF_CheckedChanged(object sender, EventArgs e)
        {
            checkSelect = 2; // Chọn SRTF
            lb_Quantum.Visible = false; // Ẩn label Quantum
            TB_Quantum.Visible = false; // Ẩn textbox Quantum
        }

        private void RaB_RoundRobin_CheckedChanged(object sender, EventArgs e)
        {
            TB_Quantum.Text = ""; // Xóa giá trị trong textbox Quantum
            checkSelect = 3; // Chọn Round Robin
            lb_Quantum.Visible = true; // Hiển thị label Quantum
            TB_Quantum.Visible = true; // Hiển thị textbox Quantum


        }

        // lấy dữ liệu đã nhập.
        void ReadDataInput()
        {
            dataInput.Clear(); // Xóa dữ liệu cũ trước khi đọc dữ liệu mới
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                // Bỏ qua dòng trống cuối cùng trong DataGridView
                if (row.IsNewRow) continue;

                string proccess = "";
                int arrivalTime;
                int burstTime;

                if (row.Cells[0].Value?.ToString() == null) continue;
                else proccess = row.Cells[0].Value.ToString();

                if (!int.TryParse(row.Cells[1].Value?.ToString(), out int at)) continue;
                else arrivalTime = at;

                if (!int.TryParse(row.Cells[2].Value?.ToString(), out int bt)) continue;
                else burstTime = bt;

                ProcessInfo item = new ProcessInfo(proccess, arrivalTime, burstTime);

                dataInput.Add(item);
            }
        }



        // đẩy dữ liệu lên table//

        // table các đoạn thời gian.
        private void pushTableSegment(List<ExecutionSegment> segments)
        {
            dataGridView2.DataSource = null;

            dataGridView2.Rows.Clear(); // Xóa dữ liệu cũ trước khi thêm mới
            dataGridView2.Columns.Clear(); // Xóa cột cũ trước khi thêm mới

            dataGridView2.ColumnCount = 3; // Thiết lập số cột
            dataGridView2.Columns[0].Name = "Tiến trình";
            dataGridView2.Columns[1].Name = "Thời gian bắt đầu";
            dataGridView2.Columns[2].Name = "Thời gian vào lại ready";

            dataGridView2.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable; // Không cho phép sắp xếp cột Tiến trình
            dataGridView2.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable; // Không cho phép sắp xếp cột Thời gian bắt đầu 
            dataGridView2.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable; // Không cho phép sắp xếp cột Thời gian vào lại ready

            int tmp = 0;
            int completed = 0;
            int n = segments.Count;
            while (completed < n)
            {
                if (tmp < segments[completed].StartTime)
                {
                    dataGridView2.Rows.Add("rãnh", tmp.ToString(), segments[completed].StartTime.ToString());
                    tmp = segments[completed].StartTime; // cập nhật thời gian hiện tại
                }
                dataGridView2.Rows.Add(
                    segments[completed].ProcessName,
                    segments[completed].StartTime.ToString(),
                    segments[completed].EndTime.ToString()
                );
                tmp = segments[completed].EndTime; // cập nhật thời gian hiện tại
                completed++; // tăng số tiến trình đã hoàn thành
            }
        }

        // bảng thời gian wait, res, turnaround (Trung Bình) của từng tiến trình.
        private void pushTableProccess()
        {
            dataGridView3.Rows.Clear(); // Xóa dữ liệu cũ trước khi thêm mới
            dataGridView3.Columns.Clear(); // Xóa cột cũ trước khi thêm mới

            dataGridView3.ColumnCount = 4; // Thiết lập số cột

            dataGridView3.Columns[0].Name = "Tiến trình";
            dataGridView3.Columns[1].Name = "Response Time";
            dataGridView3.Columns[2].Name = "Turnaround Time";
            dataGridView3.Columns[3].Name = "Waiting Time";

            dataGridView3.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView3.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView3.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView3.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            float resTB = 0; // TB tổng thời gian phản hồi
            float turnaroundTB = 0; // TB tổng thời gian quay vòng
            float waitingTB = 0; // TB tông thời gian chờ
            int tongBurstTime = 0; // tổng thời gian burst time
            int timeLine = 0;     // thơi gian kết thúc lớn nhất
            foreach (var p in dataInput)
            {
                tongBurstTime += p.BurstTime; // Tính tổng thời gian burst time
                timeLine = Math.Max(timeLine, p.CompletionTime); // Cập nhật thời gian kết thúc lớn nhất
                resTB += p.ResponseTime; // Tính tổng thời gian phản hồi
                turnaroundTB += p.TurnaroundTime; // Tính tổng thời gian quay vòng
                waitingTB += p.WaitingTime; // Tính tổng thời gian chờ

                // Thêm dữ liệu vào DataGridView
                dataGridView3.Rows.Add(
                    p.Id,
                    p.ResponseTime, // Response Time = Start Time - Arrival Time
                    p.TurnaroundTime, // Turnaround Time = Completion - Arrival
                    p.WaitingTime // Waiting Time = Turnaround - Burst
                );
            }

            // đẩy dữ liệu trung bình.
            if (dataInput.Count > 0)
            {
                int n = dataInput.Count; // Tổng số tiến trình
                resTB /= n; // Tính trung bình thời gian phản hồi
                turnaroundTB /= n; // Tính trung bình thời gian quay vòng
                waitingTB /= n; // Tính trung bình thời gian chờ

                tbt_ResTB.Text = resTB.ToString(); // Hiển thị thời gian phản hồi trung bình
                tbt_turnTB.Text = turnaroundTB.ToString(); // Hiển thị thời gian quay vòng trung bình
                tbt_waitTB.Text = waitingTB.ToString(); // Hiển thị thời gian chờ trung bình
                tbt_CPU.Text = $"{(((float)tongBurstTime / timeLine) * 100).ToString()}%";
            }
        }
        //.
        // code algoriothm.// 

        // FCFS
        private void FCFS()
        {
            if (dataInput.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu trước khi chạy thuật toán FCFS.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<ExecutionSegment> execuSegments = new List<ExecutionSegment>(); // danh sách lưu thời gian chạy từng đoạn.
            var proccessSorted = dataInput.OrderBy(p => p.ArrivalTime).ToList();


            int currentTime = proccessSorted[0].ArrivalTime; // Thời gian hiện tại bắt đầu từ thời điểm đến của tiến trình đầu tiên
            foreach (var procces in proccessSorted)
            {
                if (procces.ArrivalTime > currentTime)
                {
                    procces.StartTime = procces.ArrivalTime;
                    procces.CompletionTime = procces.ArrivalTime + procces.BurstTime;
                }
                else
                {
                    procces.StartTime = currentTime;
                    procces.CompletionTime = currentTime + procces.BurstTime;
                }

                execuSegments.Add(new ExecutionSegment(procces.Id, procces.StartTime, procces.CompletionTime));
                currentTime = procces.CompletionTime; // Cập nhật thời gian hiện tại
            }

            pushTableSegment(execuSegments);  // đẩy kết quả lên table
            pushTableProccess(); // đẩy kết quả lên bảng đoạn thời gian
        }

        //SJF
        private void SJF()
        {
            if (dataInput.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu trước khi chạy thuật toán SJF.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<ExecutionSegment> executionSegments = new List<ExecutionSegment>(); // danh sách lưu thời gian chạy từng đoạn.
            // Khởi tạo thời gian còn lại bằng burst time
            foreach (var p in dataInput)
            {
                p.RemainingTime = p.BurstTime;
            }

            int currentTime = 0; // Thời gian hiện tại
            int completed = 0; // Số tiến trình đã hoàn thành
            int n = dataInput.Count; // Tổng số tiến trình

            while (completed < n)
            {
                // lấy tất cả tiến trình đến thời gian chay, sort burst time
                var validProcces = dataInput
                    .Where(p => p.ArrivalTime <= currentTime && p.RemainingTime > 0)
                    .OrderBy(p => p.BurstTime)
                    .ThenBy(p => p.ArrivalTime)
                    .ToList();

                if (validProcces.Count == 0)
                {
                    currentTime++; // Không có tiến trình nào đến, thời gian trôi đi
                    continue;
                }

                var shorstProccces = validProcces.First(); // Lấy tiến trình có thời gian chạy ngắn nhất
                shorstProccces.StartTime = currentTime; // Ghi lại thời điểm bắt đầu chạy
                shorstProccces.CompletionTime = currentTime + shorstProccces.RemainingTime; // Tính thời điểm hoàn thành
                executionSegments.Add(new ExecutionSegment(shorstProccces.Id, shorstProccces.StartTime, shorstProccces.CompletionTime)); // Lưu đoạn thực thi
                currentTime = shorstProccces.CompletionTime; // Cập nhật thời gian hiện tại
                shorstProccces.RemainingTime = 0; // Đánh dấu tiến trình đã hoàn thành
                completed++; // Tăng số tiến trình đã hoàn thành
            }

            pushTableSegment(executionSegments);  // đẩy kết quả lên table
            pushTableProccess(); // đẩy kết quả lên bảng đoạn thời gian

        }

        //SRTF
        private void SRTF()
        {
            if (dataInput.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu trước khi chạy thuật toán SRTF.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<ExecutionSegment> excutionSegments = new List<ExecutionSegment>();  // danh sách lưu thời gian chạy từng đoạn.

            // Khởi tạo thời gian còn lại bằng burst time
            foreach (var p in dataInput)
            {
                p.RemainingTime = p.BurstTime;
            }


            int currentTime = 0;
            int completed = 0;
            int n = dataInput.Count;
            ProcessInfo currentProcess = null;
            int lastSwitchTime = 0;

            while (completed < n)
            {
                // Chọn process còn thời gian chạy nhỏ nhất trong những process đã tới
                var availableProcesses = dataInput
                    .Where(p => p.ArrivalTime <= currentTime && p.RemainingTime > 0)
                    .OrderBy(p => p.RemainingTime)
                    .ThenBy(p => p.ArrivalTime)
                    .ToList();

                if (availableProcesses.Count == 0)
                {
                    currentTime++;  // Không có process nào đến, time trôi đi
                    continue;
                }

                var shortestProcess = availableProcesses.First();

                // Nếu chuyển process khác, lưu lại thời gian chạy của process cũ
                if (currentProcess != shortestProcess)
                {
                    if (currentProcess != null)
                    {
                        // Kết thúc đoạn chạy trước đó
                        excutionSegments.Add(new ExecutionSegment(currentProcess.Id, lastSwitchTime, currentTime));
                    }

                    currentProcess = shortestProcess;

                    // Nếu process mới chạy lần đầu tiên thì đặt startTime
                    if (currentProcess.StartTime == -1)
                    {
                        currentProcess.StartTime = currentTime;
                    }

                    lastSwitchTime = currentTime;
                }

                // Giảm thời gian còn lại của process đang chạy
                currentProcess.RemainingTime--;
                currentTime++;

                // Nếu process hoàn thành
                if (currentProcess.RemainingTime == 0)
                {
                    // Kết thúc đoạn chạy cuối cùng
                    excutionSegments.Add(new ExecutionSegment(currentProcess.Id, lastSwitchTime, currentTime));

                    currentProcess.CompletionTime = currentTime;
                    completed++;
                    currentProcess = null;
                }
            }

            pushTableSegment(excutionSegments); // đẩy kết quả lên table
            pushTableProccess(); // đẩy kết quả lên bảng đoạn thời gian
        }

        // RounndRobin
        private void RoundRobin(int quanTum)
        {
            if (dataInput.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu trước khi chạy thuật toán RoundRobin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var process in dataInput)
            {
                process.RemainingTime = process.BurstTime;
            }

            List<ExecutionSegment> execuSegments = new List<ExecutionSegment>(); // lưu kết quả từng đoạn time]
            Queue<ProcessInfo> queue = new Queue<ProcessInfo>(); // hàng đợi tiến trình

            int currentTime = 0; // thời gian hiện tại
            int completed = 0; // số tiến trình đã hoàn thành
            int n = dataInput.Count; // tổng số tiến trình

            while (completed < n)
            {
                // Lấy tất cả các tiến trình đã đến và còn thời gian chạy
                var arrived = dataInput
                    .Where(p => p.ArrivalTime <= currentTime && p.RemainingTime > 0)
                    .OrderBy(p => p.ArrivalTime)
                    .ToList();

                // Thêm vào hàng đợi nếu chưa có
                foreach (var p in arrived)
                {
                    if (!queue.Contains(p))
                    {
                        queue.Enqueue(p);
                    }
                }

                // Nếu hàng đợi rỗng, thời gian trôi đi
                if (queue.Count == 0)
                {
                    currentTime++;
                    continue;
                }

                var currentProcess = queue.Dequeue();

                if (currentProcess.StartTime == -1)
                {
                    currentProcess.StartTime = currentTime;
                }

                int executeTime = Math.Min(quanTum, currentProcess.RemainingTime);
                execuSegments.Add(new ExecutionSegment(currentProcess.Id, currentTime, currentTime + executeTime));

                currentTime += executeTime;
                currentProcess.RemainingTime -= executeTime;

                // Sau khi chạy, kiểm tra xem process đã hoàn thành chưa
                if (currentProcess.RemainingTime == 0)
                {
                    currentProcess.CompletionTime = currentTime;
                    completed++;
                }
                else
                {
                    // Nếu chưa xong thì thêm lại vào cuối hàng đợi
                    // cập nhật tiến trình mới đến trong khoảng thời gian vừa chạy
                    var newArrived = dataInput
                        .Where(p => p.ArrivalTime > currentTime - executeTime && p.ArrivalTime <= currentTime && p.RemainingTime > 0)
                        .OrderBy(p => p.ArrivalTime)
                        .ToList();

                    foreach (var p in newArrived)
                    {
                        if (!queue.Contains(p))
                            queue.Enqueue(p);
                    }

                    queue.Enqueue(currentProcess); // thêm lại tiến trình chưa xong vào cuối hàng đợi
                }
            }

            pushTableSegment(execuSegments); // đẩy kết quả lên table
            pushTableProccess(); // đẩy kết quả lên bảng đoạn thời gian

        }
        //.


        // chọn thuật toán định thời//

        // xữ lý sự kiện  click của button Run (nút chạy thuật toán)
        private void selectedHandle()
        {
            if (checkSelect == -1)
            {
                MessageBox.Show("Vui lòng chọn thuật toán định thời trước khi chạy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (checkSelect == 0)
            {
                FCFS(); // Chạy thuật toán FCFS
            }
            else if (checkSelect == 1)
            {
                SJF(); // Chạy thuật toán FCFS
            }
            else if (checkSelect == 2)
            {
                SRTF(); // Chạy thuật toán SRTF
            }
            else if (checkSelect == 3)
            {
                if (TB_Quantum.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập giá trị Quantum trước khi chạy thuật toán Round Robin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int quanTum = 0;
                if (!int.TryParse(TB_Quantum.Text, out quanTum))
                {
                    MessageBox.Show("Vui lòng nhập số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (quanTum <= 0)
                {
                    MessageBox.Show("Vui lòng nhập giá trị Quantum lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                RoundRobin(quanTum); // Chạy thuật toán Round Robin
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadDataInput();
            selectedHandle(); // gọi hàm xử lý thuật toán đã chọn
        }

        //...

       
    }
}
