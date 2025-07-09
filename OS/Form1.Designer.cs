namespace OS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            grbInput = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            grpSelectAlgorithm = new GroupBox();
            TB_Quantum = new TextBox();
            lb_Quantum = new Label();
            RaB_RoundRobin = new RadioButton();
            RaB_SRTF = new RadioButton();
            RaB_SJF = new RadioButton();
            RaB_FCFS = new RadioButton();
            btn_Run = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            srpTime = new GroupBox();
            tbt_CPU = new TextBox();
            lbl_CPU = new Label();
            tbt_turnTB = new TextBox();
            tbt_waitTB = new TextBox();
            lbl_ResTB = new Label();
            lbl_TurnTB = new Label();
            tbt_ResTB = new TextBox();
            lbl_waitTB = new Label();
            dataGridView3 = new DataGridView();
            srpSimulator = new GroupBox();
            dataGridView2 = new DataGridView();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            btn_FixInfor = new Button();
            btn_AddInfor = new Button();
            lbl_selectProcessFix = new Label();
            cmb_ProcessFix = new ComboBox();
            lbl_BurstFix = new Label();
            lbl_arrivalFix = new Label();
            lbl_ProcessNameFix = new Label();
            btn_Delete = new Button();
            btn_Fix = new Button();
            btn_add = new Button();
            tbt_Bust = new TextBox();
            tbt_Arrival = new TextBox();
            lbl_BurstCPU = new Label();
            lbl_Arrival = new Label();
            tbt_ProccesName = new TextBox();
            lbl_ProccesName = new Label();
            panel4 = new Panel();
            grbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpSelectAlgorithm.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            srpTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            srpSimulator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // grbInput
            // 
            grbInput.Controls.Add(dataGridView1);
            grbInput.Dock = DockStyle.Top;
            grbInput.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbInput.ForeColor = Color.Black;
            grbInput.Location = new Point(0, 0);
            grbInput.Name = "grbInput";
            grbInput.Size = new Size(742, 316);
            grbInput.TabIndex = 0;
            grbInput.TabStop = false;
            grbInput.Text = "Hiển thị tiến trình đã nhập";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.FromArgb(250, 250, 250);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(736, 286);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tiến trình";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            Column2.HeaderText = "Thời điểm vào ready";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            Column3.HeaderText = "Thời gian sử dụng CPU";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // grpSelectAlgorithm
            // 
            grpSelectAlgorithm.Controls.Add(TB_Quantum);
            grpSelectAlgorithm.Controls.Add(lb_Quantum);
            grpSelectAlgorithm.Controls.Add(RaB_RoundRobin);
            grpSelectAlgorithm.Controls.Add(RaB_SRTF);
            grpSelectAlgorithm.Controls.Add(RaB_SJF);
            grpSelectAlgorithm.Controls.Add(RaB_FCFS);
            grpSelectAlgorithm.Controls.Add(btn_Run);
            grpSelectAlgorithm.Dock = DockStyle.Bottom;
            grpSelectAlgorithm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpSelectAlgorithm.ForeColor = Color.Black;
            grpSelectAlgorithm.Location = new Point(0, 341);
            grpSelectAlgorithm.Name = "grpSelectAlgorithm";
            grpSelectAlgorithm.Size = new Size(742, 297);
            grpSelectAlgorithm.TabIndex = 1;
            grpSelectAlgorithm.TabStop = false;
            grpSelectAlgorithm.Text = "Thuật toán định thời CPU";
            // 
            // TB_Quantum
            // 
            TB_Quantum.BackColor = Color.White;
            TB_Quantum.ForeColor = Color.Black;
            TB_Quantum.Location = new Point(273, 173);
            TB_Quantum.Name = "TB_Quantum";
            TB_Quantum.Size = new Size(125, 34);
            TB_Quantum.TabIndex = 6;
            TB_Quantum.Visible = false;
            // 
            // lb_Quantum
            // 
            lb_Quantum.AutoSize = true;
            lb_Quantum.ForeColor = Color.Black;
            lb_Quantum.Location = new Point(162, 176);
            lb_Quantum.Name = "lb_Quantum";
            lb_Quantum.Size = new Size(105, 28);
            lb_Quantum.TabIndex = 5;
            lb_Quantum.Text = "Quantum:";
            lb_Quantum.Visible = false;
            // 
            // RaB_RoundRobin
            // 
            RaB_RoundRobin.AutoSize = true;
            RaB_RoundRobin.BackColor = Color.FromArgb(250, 250, 250);
            RaB_RoundRobin.ForeColor = Color.Black;
            RaB_RoundRobin.Location = new Point(12, 172);
            RaB_RoundRobin.Name = "RaB_RoundRobin";
            RaB_RoundRobin.Size = new Size(149, 32);
            RaB_RoundRobin.TabIndex = 4;
            RaB_RoundRobin.TabStop = true;
            RaB_RoundRobin.Text = "RoundRobin";
            RaB_RoundRobin.UseVisualStyleBackColor = false;
            RaB_RoundRobin.CheckedChanged += RaB_RoundRobin_CheckedChanged;
            // 
            // RaB_SRTF
            // 
            RaB_SRTF.AutoSize = true;
            RaB_SRTF.BackColor = Color.FromArgb(250, 250, 250);
            RaB_SRTF.ForeColor = Color.Black;
            RaB_SRTF.Location = new Point(12, 131);
            RaB_SRTF.Name = "RaB_SRTF";
            RaB_SRTF.Size = new Size(79, 32);
            RaB_SRTF.TabIndex = 3;
            RaB_SRTF.TabStop = true;
            RaB_SRTF.Text = "SRTF";
            RaB_SRTF.UseVisualStyleBackColor = false;
            RaB_SRTF.CheckedChanged += RaB_SRTF_CheckedChanged;
            // 
            // RaB_SJF
            // 
            RaB_SJF.AutoSize = true;
            RaB_SJF.BackColor = Color.FromArgb(250, 250, 250);
            RaB_SJF.ForeColor = Color.Black;
            RaB_SJF.Location = new Point(12, 86);
            RaB_SJF.Name = "RaB_SJF";
            RaB_SJF.Size = new Size(63, 32);
            RaB_SJF.TabIndex = 2;
            RaB_SJF.TabStop = true;
            RaB_SJF.Text = "SJF";
            RaB_SJF.UseVisualStyleBackColor = false;
            RaB_SJF.CheckedChanged += RaB_SJF_CheckedChanged;
            // 
            // RaB_FCFS
            // 
            RaB_FCFS.AutoSize = true;
            RaB_FCFS.BackColor = Color.FromArgb(250, 250, 250);
            RaB_FCFS.ForeColor = Color.Black;
            RaB_FCFS.Location = new Point(12, 42);
            RaB_FCFS.Name = "RaB_FCFS";
            RaB_FCFS.Size = new Size(76, 32);
            RaB_FCFS.TabIndex = 1;
            RaB_FCFS.TabStop = true;
            RaB_FCFS.Text = "FCFS";
            RaB_FCFS.UseVisualStyleBackColor = false;
            RaB_FCFS.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btn_Run
            // 
            btn_Run.AutoSize = true;
            btn_Run.BackColor = Color.FromArgb(33, 150, 243);
            btn_Run.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Run.ForeColor = Color.White;
            btn_Run.Location = new Point(241, 242);
            btn_Run.Name = "btn_Run";
            btn_Run.Size = new Size(94, 38);
            btn_Run.TabIndex = 0;
            btn_Run.Text = "RUN";
            btn_Run.UseVisualStyleBackColor = false;
            btn_Run.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(grpSelectAlgorithm);
            panel1.Controls.Add(grbInput);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 638);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(srpTime);
            panel2.Controls.Add(srpSimulator);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(796, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(811, 638);
            panel2.TabIndex = 1;
            // 
            // srpTime
            // 
            srpTime.Controls.Add(tbt_CPU);
            srpTime.Controls.Add(lbl_CPU);
            srpTime.Controls.Add(tbt_turnTB);
            srpTime.Controls.Add(tbt_waitTB);
            srpTime.Controls.Add(lbl_ResTB);
            srpTime.Controls.Add(lbl_TurnTB);
            srpTime.Controls.Add(tbt_ResTB);
            srpTime.Controls.Add(lbl_waitTB);
            srpTime.Controls.Add(dataGridView3);
            srpTime.Dock = DockStyle.Bottom;
            srpTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            srpTime.ForeColor = Color.Black;
            srpTime.Location = new Point(0, 341);
            srpTime.Name = "srpTime";
            srpTime.Size = new Size(811, 297);
            srpTime.TabIndex = 1;
            srpTime.TabStop = false;
            srpTime.Text = "Thời gian xử lý";
            // 
            // tbt_CPU
            // 
            tbt_CPU.ForeColor = Color.Black;
            tbt_CPU.Location = new Point(581, 251);
            tbt_CPU.Name = "tbt_CPU";
            tbt_CPU.Size = new Size(198, 34);
            tbt_CPU.TabIndex = 8;
            // 
            // lbl_CPU
            // 
            lbl_CPU.AutoSize = true;
            lbl_CPU.BackColor = Color.White;
            lbl_CPU.ForeColor = Color.Black;
            lbl_CPU.Location = new Point(581, 220);
            lbl_CPU.Name = "lbl_CPU";
            lbl_CPU.Size = new Size(160, 28);
            lbl_CPU.TabIndex = 7;
            lbl_CPU.Text = "CPU Utilization:";
            // 
            // tbt_turnTB
            // 
            tbt_turnTB.ForeColor = Color.Black;
            tbt_turnTB.Location = new Point(581, 183);
            tbt_turnTB.Name = "tbt_turnTB";
            tbt_turnTB.Size = new Size(198, 34);
            tbt_turnTB.TabIndex = 6;
            // 
            // tbt_waitTB
            // 
            tbt_waitTB.ForeColor = Color.Black;
            tbt_waitTB.Location = new Point(581, 119);
            tbt_waitTB.Name = "tbt_waitTB";
            tbt_waitTB.Size = new Size(198, 34);
            tbt_waitTB.TabIndex = 5;
            // 
            // lbl_ResTB
            // 
            lbl_ResTB.AutoSize = true;
            lbl_ResTB.BackColor = Color.White;
            lbl_ResTB.ForeColor = Color.Black;
            lbl_ResTB.Location = new Point(581, 25);
            lbl_ResTB.Name = "lbl_ResTB";
            lbl_ResTB.Size = new Size(158, 28);
            lbl_ResTB.TabIndex = 4;
            lbl_ResTB.Text = "Res Trung bình:";
            // 
            // lbl_TurnTB
            // 
            lbl_TurnTB.AutoSize = true;
            lbl_TurnTB.BackColor = Color.White;
            lbl_TurnTB.ForeColor = Color.Black;
            lbl_TurnTB.Location = new Point(581, 152);
            lbl_TurnTB.Name = "lbl_TurnTB";
            lbl_TurnTB.Size = new Size(168, 28);
            lbl_TurnTB.TabIndex = 3;
            lbl_TurnTB.Text = "Turn Trung bình:";
            // 
            // tbt_ResTB
            // 
            tbt_ResTB.ForeColor = Color.Black;
            tbt_ResTB.Location = new Point(581, 56);
            tbt_ResTB.Name = "tbt_ResTB";
            tbt_ResTB.Size = new Size(198, 34);
            tbt_ResTB.TabIndex = 2;
            // 
            // lbl_waitTB
            // 
            lbl_waitTB.AutoSize = true;
            lbl_waitTB.BackColor = Color.White;
            lbl_waitTB.ForeColor = Color.Black;
            lbl_waitTB.Location = new Point(581, 88);
            lbl_waitTB.Name = "lbl_waitTB";
            lbl_waitTB.Size = new Size(169, 28);
            lbl_waitTB.TabIndex = 1;
            lbl_waitTB.Text = "Wait Trung bình:";
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView3.BackgroundColor = Color.FromArgb(250, 250, 250);
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView3.Dock = DockStyle.Left;
            dataGridView3.Location = new Point(3, 30);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(536, 264);
            dataGridView3.TabIndex = 0;
            // 
            // srpSimulator
            // 
            srpSimulator.Controls.Add(dataGridView2);
            srpSimulator.Dock = DockStyle.Top;
            srpSimulator.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            srpSimulator.ForeColor = Color.Black;
            srpSimulator.Location = new Point(0, 0);
            srpSimulator.Name = "srpSimulator";
            srpSimulator.Size = new Size(811, 316);
            srpSimulator.TabIndex = 0;
            srpSimulator.TabStop = false;
            srpSimulator.Text = "Mô tả dạng bảng";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView2.BackgroundColor = Color.FromArgb(250, 250, 250);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 30);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(805, 283);
            dataGridView2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1607, 125);
            panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_FixInfor);
            groupBox1.Controls.Add(btn_AddInfor);
            groupBox1.Controls.Add(lbl_selectProcessFix);
            groupBox1.Controls.Add(cmb_ProcessFix);
            groupBox1.Controls.Add(lbl_BurstFix);
            groupBox1.Controls.Add(lbl_arrivalFix);
            groupBox1.Controls.Add(lbl_ProcessNameFix);
            groupBox1.Controls.Add(btn_Delete);
            groupBox1.Controls.Add(btn_Fix);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(tbt_Bust);
            groupBox1.Controls.Add(tbt_Arrival);
            groupBox1.Controls.Add(lbl_BurstCPU);
            groupBox1.Controls.Add(lbl_Arrival);
            groupBox1.Controls.Add(tbt_ProccesName);
            groupBox1.Controls.Add(lbl_ProccesName);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1607, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin tiến trình tại đây";


            // 
            // btn_FixInfor
            // 
            btn_FixInfor.AutoSize = true;
            btn_FixInfor.BackColor = Color.FromArgb(33, 150, 243);
            btn_FixInfor.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btn_FixInfor.ForeColor = Color.White;
            btn_FixInfor.Location = new Point(1386, 52);
            btn_FixInfor.Name = "btn_FixInfor";
            btn_FixInfor.Size = new Size(94, 35);
            btn_FixInfor.TabIndex = 18;
            btn_FixInfor.Text = "Ok";
            btn_FixInfor.UseVisualStyleBackColor = false;
            btn_FixInfor.Visible = false;
            btn_FixInfor.Click += btn_FixInfor_Click;
            // 
            // btn_AddInfor
            // 
            btn_AddInfor.AutoSize = true;
            btn_AddInfor.BackColor = Color.FromArgb(33, 150, 243);
            btn_AddInfor.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btn_AddInfor.ForeColor = Color.White;
            btn_AddInfor.Location = new Point(1386, 48);
            btn_AddInfor.Name = "btn_AddInfor";
            btn_AddInfor.Size = new Size(94, 35);
            btn_AddInfor.TabIndex = 17;
            btn_AddInfor.Text = "Ok";
            btn_AddInfor.UseVisualStyleBackColor = false;
            btn_AddInfor.Visible = false;
            btn_AddInfor.Click += button1_Click;
            // 
            // lbl_selectProcessFix
            // 
            lbl_selectProcessFix.AutoSize = true;
            lbl_selectProcessFix.Location = new Point(101, 27);
            lbl_selectProcessFix.Name = "lbl_selectProcessFix";
            lbl_selectProcessFix.Size = new Size(234, 25);
            lbl_selectProcessFix.TabIndex = 16;
            lbl_selectProcessFix.Text = "Chọn tiến trình muốn sửa:";
            lbl_selectProcessFix.Visible = false;
            // 
            // cmb_ProcessFix
            // 
            cmb_ProcessFix.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_ProcessFix.FormattingEnabled = true;
            cmb_ProcessFix.Location = new Point(101, 52);
            cmb_ProcessFix.Name = "cmb_ProcessFix";
            cmb_ProcessFix.Size = new Size(234, 33);
            cmb_ProcessFix.TabIndex = 15;
            cmb_ProcessFix.Visible = false;
            cmb_ProcessFix.SelectedIndexChanged += cmb_ProcessFix_SelectedIndexChanged;
            // 
            // lbl_BurstFix
            // 
            lbl_BurstFix.AutoSize = true;
            lbl_BurstFix.Location = new Point(1076, 23);
            lbl_BurstFix.Name = "lbl_BurstFix";
            lbl_BurstFix.Size = new Size(262, 25);
            lbl_BurstFix.TabIndex = 14;
            lbl_BurstFix.Text = "nhập thời gian chạy thay thế:";
            lbl_BurstFix.Visible = false;
            // 
            // lbl_arrivalFix
            // 
            lbl_arrivalFix.AutoSize = true;
            lbl_arrivalFix.Location = new Point(694, 23);
            lbl_arrivalFix.Name = "lbl_arrivalFix";
            lbl_arrivalFix.Size = new Size(316, 25);
            lbl_arrivalFix.TabIndex = 13;
            lbl_arrivalFix.Text = "nhập thời điểm vào  ready thay thế:";
            lbl_arrivalFix.Visible = false;
            // 
            // lbl_ProcessNameFix
            // 
            lbl_ProcessNameFix.AutoSize = true;
            lbl_ProcessNameFix.Location = new Point(379, 23);
            lbl_ProcessNameFix.Name = "lbl_ProcessNameFix";
            lbl_ProcessNameFix.Size = new Size(251, 25);
            lbl_ProcessNameFix.TabIndex = 12;
            lbl_ProcessNameFix.Text = "Nhập tên tiến trình thay thế";
            lbl_ProcessNameFix.Visible = false;
            // 
            // btn_Delete
            // 
            btn_Delete.AutoSize = true;
            btn_Delete.BackColor = Color.FromArgb(33, 150, 243);
            btn_Delete.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btn_Delete.ForeColor = Color.White;
            btn_Delete.Location = new Point(970, 89);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(75, 35);
            btn_Delete.TabIndex = 11;
            btn_Delete.Text = "Xóa";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Fix
            // 
            btn_Fix.AutoSize = true;
            btn_Fix.BackColor = Color.FromArgb(33, 150, 243);
            btn_Fix.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btn_Fix.ForeColor = Color.White;
            btn_Fix.Location = new Point(694, 89);
            btn_Fix.Name = "btn_Fix";
            btn_Fix.Size = new Size(75, 35);
            btn_Fix.TabIndex = 9;
            btn_Fix.Text = "Sửa";
            btn_Fix.UseVisualStyleBackColor = false;
            btn_Fix.Click += btn_Fix_Click;
            // 
            // btn_add
            // 
            btn_add.AutoSize = true;
            btn_add.BackColor = Color.FromArgb(33, 150, 243);
            btn_add.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(466, 89);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 35);
            btn_add.TabIndex = 7;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // tbt_Bust
            // 
            tbt_Bust.Location = new Point(1076, 46);
            tbt_Bust.Name = "tbt_Bust";
            tbt_Bust.Size = new Size(258, 31);
            tbt_Bust.TabIndex = 6;
            tbt_Bust.Visible = false;
            // 
            // tbt_Arrival
            // 
            tbt_Arrival.Location = new Point(694, 46);
            tbt_Arrival.Name = "tbt_Arrival";
            tbt_Arrival.Size = new Size(316, 31);
            tbt_Arrival.TabIndex = 5;
            tbt_Arrival.Visible = false;
            // 
            // lbl_BurstCPU
            // 
            lbl_BurstCPU.AutoSize = true;
            lbl_BurstCPU.Location = new Point(1076, 23);
            lbl_BurstCPU.Name = "lbl_BurstCPU";
            lbl_BurstCPU.Size = new Size(258, 25);
            lbl_BurstCPU.TabIndex = 4;
            lbl_BurstCPU.Text = "Nhập thời gian sử dụng CPU:";
            lbl_BurstCPU.Visible = false;
            // 
            // lbl_Arrival
            // 
            lbl_Arrival.AutoSize = true;
            lbl_Arrival.Location = new Point(694, 23);
            lbl_Arrival.Name = "lbl_Arrival";
            lbl_Arrival.Size = new Size(233, 25);
            lbl_Arrival.TabIndex = 3;
            lbl_Arrival.Text = "Nhập thơi gian vào ready:";
            lbl_Arrival.Visible = false;
            // 
            // tbt_ProccesName
            // 
            tbt_ProccesName.Location = new Point(379, 52);
            tbt_ProccesName.Name = "tbt_ProccesName";
            tbt_ProccesName.Size = new Size(251, 31);
            tbt_ProccesName.TabIndex = 2;
            tbt_ProccesName.Visible = false;
            // 
            // lbl_ProccesName
            // 
            lbl_ProccesName.AutoSize = true;
            lbl_ProccesName.Location = new Point(379, 23);
            lbl_ProccesName.Name = "lbl_ProccesName";
            lbl_ProccesName.Size = new Size(180, 25);
            lbl_ProccesName.TabIndex = 1;
            lbl_ProccesName.Text = "Nhập tên tiến trình:";
            lbl_ProccesName.Visible = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 125);
            panel4.Name = "panel4";
            panel4.Size = new Size(1607, 638);
            panel4.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1607, 763);
            Controls.Add(panel4);
            Controls.Add(panel3);
            ForeColor = Color.FromArgb(33, 33, 33);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CPU Scheduling Simulator";
            FormClosed += Form1_FormClosed;
            grbInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpSelectAlgorithm.ResumeLayout(false);
            grpSelectAlgorithm.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            srpTime.ResumeLayout(false);
            srpTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            srpSimulator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInput;
        private GroupBox grpSelectAlgorithm;
        private Panel panel1;
        private Panel panel2;
        private GroupBox srpTime;
        private GroupBox srpSimulator;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button btn_Run;
        private RadioButton RaB_RoundRobin;
        private RadioButton RaB_SRTF;
        private RadioButton RaB_SJF;
        private RadioButton RaB_FCFS;
        private TextBox TB_Quantum;
        private Label lb_Quantum;
        private DataGridView dataGridView3;
        private TextBox tbt_turnTB;
        private TextBox tbt_waitTB;
        private Label lbl_ResTB;
        private Label lbl_TurnTB;
        private TextBox tbt_ResTB;
        private Label lbl_waitTB;
        private TextBox tbt_CPU;
        private Label lbl_CPU;
        private Panel panel3;
        private Panel panel4;
        private GroupBox groupBox1;
        private Label lbl_ProccesName;
        private TextBox tbt_Bust;
        private TextBox tbt_Arrival;
        private Label lbl_BurstCPU;
        private Label lbl_Arrival;
        private TextBox tbt_ProccesName;
        private Button btn_Delete;
        private Button btn_Fix;
        private Button btn_add;
        private Label lbl_ProcessNameFix;
        private Label lbl_BurstFix;
        private Label lbl_arrivalFix;
        private Label lbl_selectProcessFix;
        private ComboBox cmb_ProcessFix;
        private Button btn_AddInfor;
        private Button btn_FixInfor;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
