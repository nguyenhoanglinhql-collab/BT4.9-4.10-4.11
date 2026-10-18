namespace _4._9
{
    partial class Form1
    {
        private TextBox _appointmentIdTextBox = null!;
        private TextBox _patientNameTextBox = null!;
        private TextBox _phoneNumberTextBox = null!;
        private DateTimePicker _appointmentDateTimePicker = null!;
        private ComboBox _doctorComboBox = null!;
        private TextBox _reasonTextBox = null!;
        private ComboBox _statusComboBox = null!;
        private TextBox _searchTextBox = null!;
        private CheckBox _dateFilterCheckBox = null!;
        private DateTimePicker _filterDatePicker = null!;
        private ComboBox _filterStatusComboBox = null!;
        private DataGridView _appointmentsGrid = null!;
        private ToolStripStatusLabel _appointmentCountLabel = null!;
        private TableLayoutPanel _rootLayout = null!;
        private TableLayoutPanel _editorLayout = null!;
        private TableLayoutPanel _filterLayout = null!;
        private GroupBox _editorGroup = null!;
        private FlowLayoutPanel _buttonPanel = null!;
        private Button _addButton = null!;
        private Button _updateButton = null!;
        private Button _deleteButton = null!;
        private Button _clearButton = null!;
        private MenuStrip _menuStrip = null!;
        private ToolStripMenuItem _fileMenu = null!;
        private ToolStripMenuItem _exportMenuItem = null!;
        private StatusStrip _statusStrip = null!;
        private Label _appointmentIdLabel = null!;
        private Label _patientNameLabel = null!;
        private Label _phoneNumberLabel = null!;
        private Label _appointmentDateTimeLabel = null!;
        private Label _doctorLabel = null!;
        private Label _statusLabel = null!;
        private Label _reasonLabel = null!;
        private Label _searchLabel = null!;
        private Label _filterStatusLabel = null!;
        private DataGridViewTextBoxColumn _appointmentIdColumn = null!;
        private DataGridViewTextBoxColumn _patientNameColumn = null!;
        private DataGridViewTextBoxColumn _phoneNumberColumn = null!;
        private DataGridViewTextBoxColumn _appointmentDateTimeColumn = null!;
        private DataGridViewTextBoxColumn _doctorColumn = null!;
        private DataGridViewTextBoxColumn _reasonColumn = null!;
        private DataGridViewTextBoxColumn _appointmentStatusColumn = null!;

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
            _appointmentIdTextBox = new TextBox();
            _patientNameTextBox = new TextBox();
            _phoneNumberTextBox = new TextBox();
            _appointmentDateTimePicker = new DateTimePicker();
            _doctorComboBox = new ComboBox();
            _reasonTextBox = new TextBox();
            _statusComboBox = new ComboBox();
            _searchTextBox = new TextBox();
            _dateFilterCheckBox = new CheckBox();
            _filterDatePicker = new DateTimePicker();
            _filterStatusComboBox = new ComboBox();
            _appointmentsGrid = new DataGridView();
            _appointmentCountLabel = new ToolStripStatusLabel();
            _rootLayout = new TableLayoutPanel();
            _editorGroup = new GroupBox();
            _editorLayout = new TableLayoutPanel();
            _appointmentIdLabel = new Label();
            _patientNameLabel = new Label();
            _phoneNumberLabel = new Label();
            _appointmentDateTimeLabel = new Label();
            _doctorLabel = new Label();
            _statusLabel = new Label();
            _reasonLabel = new Label();
            _buttonPanel = new FlowLayoutPanel();
            _addButton = new Button();
            _updateButton = new Button();
            _deleteButton = new Button();
            _clearButton = new Button();
            _filterLayout = new TableLayoutPanel();
            _searchLabel = new Label();
            _filterStatusLabel = new Label();
            _statusStrip = new StatusStrip();
            _menuStrip = new MenuStrip();
            _fileMenu = new ToolStripMenuItem();
            _exportMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)_appointmentsGrid).BeginInit();
            _rootLayout.SuspendLayout();
            _editorGroup.SuspendLayout();
            _editorLayout.SuspendLayout();
            _buttonPanel.SuspendLayout();
            _filterLayout.SuspendLayout();
            _statusStrip.SuspendLayout();
            _menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // _appointmentIdTextBox
            // 
            _appointmentIdTextBox.Dock = DockStyle.Fill;
            _appointmentIdTextBox.Location = new Point(127, 10);
            _appointmentIdTextBox.Margin = new Padding(3, 6, 8, 3);
            _appointmentIdTextBox.Name = "_appointmentIdTextBox";
            _appointmentIdTextBox.Size = new Size(432, 27);
            _appointmentIdTextBox.TabIndex = 1;
            // 
            // _patientNameTextBox
            // 
            _patientNameTextBox.Dock = DockStyle.Fill;
            _patientNameTextBox.Location = new Point(690, 10);
            _patientNameTextBox.Margin = new Padding(3, 6, 8, 3);
            _patientNameTextBox.Name = "_patientNameTextBox";
            _patientNameTextBox.Size = new Size(432, 27);
            _patientNameTextBox.TabIndex = 3;
            // 
            // _phoneNumberTextBox
            // 
            _phoneNumberTextBox.Dock = DockStyle.Fill;
            _phoneNumberTextBox.Location = new Point(127, 55);
            _phoneNumberTextBox.Margin = new Padding(3, 6, 8, 3);
            _phoneNumberTextBox.Name = "_phoneNumberTextBox";
            _phoneNumberTextBox.Size = new Size(432, 27);
            _phoneNumberTextBox.TabIndex = 5;
            // 
            // _appointmentDateTimePicker
            // 
            _appointmentDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            _appointmentDateTimePicker.Dock = DockStyle.Fill;
            _appointmentDateTimePicker.Format = DateTimePickerFormat.Custom;
            _appointmentDateTimePicker.Location = new Point(690, 52);
            _appointmentDateTimePicker.Name = "_appointmentDateTimePicker";
            _appointmentDateTimePicker.ShowUpDown = true;
            _appointmentDateTimePicker.Size = new Size(437, 27);
            _appointmentDateTimePicker.TabIndex = 7;
            _appointmentDateTimePicker.Value = new DateTime(2026, 10, 17, 13, 15, 35, 770);
            // 
            // _doctorComboBox
            // 
            _doctorComboBox.Dock = DockStyle.Fill;
            _doctorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _doctorComboBox.Items.AddRange(new object[] { "BS. Nguyễn Minh", "BS. Trần Lan", "BS. Lê Hoàng" });
            _doctorComboBox.Location = new Point(127, 98);
            _doctorComboBox.Margin = new Padding(3, 4, 8, 3);
            _doctorComboBox.Name = "_doctorComboBox";
            _doctorComboBox.Size = new Size(432, 28);
            _doctorComboBox.TabIndex = 9;
            // 
            // _reasonTextBox
            // 
            _editorLayout.SetColumnSpan(_reasonTextBox, 3);
            _reasonTextBox.Dock = DockStyle.Fill;
            _reasonTextBox.Location = new Point(127, 145);
            _reasonTextBox.Margin = new Padding(3, 6, 8, 3);
            _reasonTextBox.Name = "_reasonTextBox";
            _reasonTextBox.Size = new Size(995, 27);
            _reasonTextBox.TabIndex = 13;
            // 
            // _statusComboBox
            // 
            _statusComboBox.Dock = DockStyle.Fill;
            _statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _statusComboBox.Items.AddRange(new object[] { "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            _statusComboBox.Location = new Point(690, 98);
            _statusComboBox.Margin = new Padding(3, 4, 8, 3);
            _statusComboBox.Name = "_statusComboBox";
            _statusComboBox.Size = new Size(432, 28);
            _statusComboBox.TabIndex = 11;
            // 
            // _searchTextBox
            // 
            _searchTextBox.Dock = DockStyle.Fill;
            _searchTextBox.Location = new Point(73, 11);
            _searchTextBox.Margin = new Padding(3, 6, 8, 3);
            _searchTextBox.Name = "_searchTextBox";
            _searchTextBox.Size = new Size(602, 27);
            _searchTextBox.TabIndex = 1;
            // 
            // _dateFilterCheckBox
            // 
            _dateFilterCheckBox.Anchor = AnchorStyles.Left;
            _dateFilterCheckBox.AutoSize = true;
            _dateFilterCheckBox.Location = new Point(686, 9);
            _dateFilterCheckBox.Name = "_dateFilterCheckBox";
            _dateFilterCheckBox.Size = new Size(90, 24);
            _dateFilterCheckBox.TabIndex = 2;
            _dateFilterCheckBox.Text = "Lọc ngày";
            // 
            // _filterDatePicker
            // 
            _filterDatePicker.Dock = DockStyle.Fill;
            _filterDatePicker.Format = DateTimePickerFormat.Short;
            _filterDatePicker.Location = new Point(782, 8);
            _filterDatePicker.Name = "_filterDatePicker";
            _filterDatePicker.Size = new Size(134, 27);
            _filterDatePicker.TabIndex = 3;
            // 
            // _filterStatusComboBox
            // 
            _filterStatusComboBox.Dock = DockStyle.Fill;
            _filterStatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _filterStatusComboBox.Items.AddRange(new object[] { "Tất cả", "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            _filterStatusComboBox.Location = new Point(997, 9);
            _filterStatusComboBox.Margin = new Padding(3, 4, 8, 3);
            _filterStatusComboBox.Name = "_filterStatusComboBox";
            _filterStatusComboBox.Size = new Size(149, 28);
            _filterStatusComboBox.TabIndex = 5;
            // 
            // _appointmentsGrid
            // 
            _appointmentsGrid.AllowUserToAddRows = false;
            _appointmentsGrid.AllowUserToDeleteRows = false;
            _appointmentsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _appointmentsGrid.ColumnHeadersHeight = 29;
            _appointmentsGrid.Dock = DockStyle.Fill;
            _appointmentsGrid.Location = new Point(13, 344);
            _appointmentsGrid.MultiSelect = false;
            _appointmentsGrid.Name = "_appointmentsGrid";
            _appointmentsGrid.ReadOnly = true;
            _appointmentsGrid.RowHeadersVisible = false;
            _appointmentsGrid.RowHeadersWidth = 51;
            _appointmentsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _appointmentsGrid.Size = new Size(1154, 370);
            _appointmentsGrid.TabIndex = 2;
            // 
            // _appointmentCountLabel
            // 
            _appointmentCountLabel.Name = "_appointmentCountLabel";
            _appointmentCountLabel.Size = new Size(96, 19);
            _appointmentCountLabel.Text = "Số lịch hẹn: 0";
            // 
            // _rootLayout
            // 
            _rootLayout.ColumnCount = 1;
            _rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _rootLayout.Controls.Add(_editorGroup, 0, 0);
            _rootLayout.Controls.Add(_filterLayout, 0, 1);
            _rootLayout.Controls.Add(_appointmentsGrid, 0, 2);
            _rootLayout.Controls.Add(_statusStrip, 0, 3);
            _rootLayout.Dock = DockStyle.Fill;
            _rootLayout.Location = new Point(0, 28);
            _rootLayout.Name = "_rootLayout";
            _rootLayout.Padding = new Padding(10);
            _rootLayout.RowCount = 4;
            _rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 43F));
            _rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            _rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 57F));
            _rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            _rootLayout.Size = new Size(1180, 752);
            _rootLayout.TabIndex = 0;
            // 
            // _editorGroup
            // 
            _editorGroup.Controls.Add(_editorLayout);
            _editorGroup.Dock = DockStyle.Fill;
            _editorGroup.Location = new Point(13, 13);
            _editorGroup.Name = "_editorGroup";
            _editorGroup.Padding = new Padding(10);
            _editorGroup.Size = new Size(1154, 277);
            _editorGroup.TabIndex = 0;
            _editorGroup.TabStop = false;
            _editorGroup.Text = "Thông tin lịch hẹn";
            // 
            // _editorLayout
            // 
            _editorLayout.ColumnCount = 4;
            _editorLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            _editorLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            _editorLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            _editorLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            _editorLayout.Controls.Add(_appointmentIdLabel, 0, 0);
            _editorLayout.Controls.Add(_appointmentIdTextBox, 1, 0);
            _editorLayout.Controls.Add(_patientNameLabel, 2, 0);
            _editorLayout.Controls.Add(_patientNameTextBox, 3, 0);
            _editorLayout.Controls.Add(_phoneNumberLabel, 0, 1);
            _editorLayout.Controls.Add(_phoneNumberTextBox, 1, 1);
            _editorLayout.Controls.Add(_appointmentDateTimeLabel, 2, 1);
            _editorLayout.Controls.Add(_appointmentDateTimePicker, 3, 1);
            _editorLayout.Controls.Add(_doctorLabel, 0, 2);
            _editorLayout.Controls.Add(_doctorComboBox, 1, 2);
            _editorLayout.Controls.Add(_statusLabel, 2, 2);
            _editorLayout.Controls.Add(_statusComboBox, 3, 2);
            _editorLayout.Controls.Add(_reasonLabel, 0, 3);
            _editorLayout.Controls.Add(_reasonTextBox, 1, 3);
            _editorLayout.Controls.Add(_buttonPanel, 1, 4);
            _editorLayout.Dock = DockStyle.Fill;
            _editorLayout.Location = new Point(10, 30);
            _editorLayout.Name = "_editorLayout";
            _editorLayout.Padding = new Padding(4);
            _editorLayout.RowCount = 5;
            _editorLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            _editorLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            _editorLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            _editorLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            _editorLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            _editorLayout.Size = new Size(1134, 237);
            _editorLayout.TabIndex = 0;
            // 
            // _appointmentIdLabel
            // 
            _appointmentIdLabel.Anchor = AnchorStyles.Left;
            _appointmentIdLabel.AutoSize = true;
            _appointmentIdLabel.Location = new Point(7, 19);
            _appointmentIdLabel.Margin = new Padding(3, 8, 3, 3);
            _appointmentIdLabel.Name = "_appointmentIdLabel";
            _appointmentIdLabel.Size = new Size(88, 20);
            _appointmentIdLabel.TabIndex = 0;
            _appointmentIdLabel.Text = "Mã lịch hẹn:";
            // 
            // _patientNameLabel
            // 
            _patientNameLabel.Anchor = AnchorStyles.Left;
            _patientNameLabel.AutoSize = true;
            _patientNameLabel.Location = new Point(570, 12);
            _patientNameLabel.Margin = new Padding(3, 8, 3, 3);
            _patientNameLabel.Name = "_patientNameLabel";
            _patientNameLabel.Size = new Size(95, 34);
            _patientNameLabel.TabIndex = 2;
            _patientNameLabel.Text = "Họ tên bệnh nhân:";
            // 
            // _phoneNumberLabel
            // 
            _phoneNumberLabel.Anchor = AnchorStyles.Left;
            _phoneNumberLabel.AutoSize = true;
            _phoneNumberLabel.Location = new Point(7, 64);
            _phoneNumberLabel.Margin = new Padding(3, 8, 3, 3);
            _phoneNumberLabel.Name = "_phoneNumberLabel";
            _phoneNumberLabel.Size = new Size(100, 20);
            _phoneNumberLabel.TabIndex = 4;
            _phoneNumberLabel.Text = "Số điện thoại:";
            // 
            // _appointmentDateTimeLabel
            // 
            _appointmentDateTimeLabel.Anchor = AnchorStyles.Left;
            _appointmentDateTimeLabel.AutoSize = true;
            _appointmentDateTimeLabel.Location = new Point(570, 64);
            _appointmentDateTimeLabel.Margin = new Padding(3, 8, 3, 3);
            _appointmentDateTimeLabel.Name = "_appointmentDateTimeLabel";
            _appointmentDateTimeLabel.Size = new Size(101, 20);
            _appointmentDateTimeLabel.TabIndex = 6;
            _appointmentDateTimeLabel.Text = "Ngày giờ hẹn:";
            // 
            // _doctorLabel
            // 
            _doctorLabel.Anchor = AnchorStyles.Left;
            _doctorLabel.AutoSize = true;
            _doctorLabel.Location = new Point(7, 109);
            _doctorLabel.Margin = new Padding(3, 8, 3, 3);
            _doctorLabel.Name = "_doctorLabel";
            _doctorLabel.Size = new Size(50, 20);
            _doctorLabel.TabIndex = 8;
            _doctorLabel.Text = "Bác sĩ:";
            // 
            // _statusLabel
            // 
            _statusLabel.Anchor = AnchorStyles.Left;
            _statusLabel.AutoSize = true;
            _statusLabel.Location = new Point(570, 109);
            _statusLabel.Margin = new Padding(3, 8, 3, 3);
            _statusLabel.Name = "_statusLabel";
            _statusLabel.Size = new Size(78, 20);
            _statusLabel.TabIndex = 10;
            _statusLabel.Text = "Trạng thái:";
            // 
            // _reasonLabel
            // 
            _reasonLabel.Anchor = AnchorStyles.Left;
            _reasonLabel.AutoSize = true;
            _reasonLabel.Location = new Point(7, 158);
            _reasonLabel.Margin = new Padding(3, 8, 3, 3);
            _reasonLabel.Name = "_reasonLabel";
            _reasonLabel.Size = new Size(87, 20);
            _reasonLabel.TabIndex = 12;
            _reasonLabel.Text = "Lý do khám:";
            // 
            // _buttonPanel
            // 
            _editorLayout.SetColumnSpan(_buttonPanel, 3);
            _buttonPanel.Controls.Add(_addButton);
            _buttonPanel.Controls.Add(_updateButton);
            _buttonPanel.Controls.Add(_deleteButton);
            _buttonPanel.Controls.Add(_clearButton);
            _buttonPanel.Dock = DockStyle.Fill;
            _buttonPanel.Location = new Point(127, 196);
            _buttonPanel.Name = "_buttonPanel";
            _buttonPanel.Size = new Size(1000, 34);
            _buttonPanel.TabIndex = 14;
            _buttonPanel.WrapContents = false;
            // 
            // _addButton
            // 
            _addButton.Location = new Point(3, 3);
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(100, 30);
            _addButton.TabIndex = 0;
            _addButton.Text = "Thêm";
            // 
            // _updateButton
            // 
            _updateButton.Location = new Point(109, 3);
            _updateButton.Name = "_updateButton";
            _updateButton.Size = new Size(100, 30);
            _updateButton.TabIndex = 1;
            _updateButton.Text = "Cập nhật";
            // 
            // _deleteButton
            // 
            _deleteButton.Location = new Point(215, 3);
            _deleteButton.Name = "_deleteButton";
            _deleteButton.Size = new Size(100, 30);
            _deleteButton.TabIndex = 2;
            _deleteButton.Text = "Xóa";
            // 
            // _clearButton
            // 
            _clearButton.Location = new Point(321, 3);
            _clearButton.Name = "_clearButton";
            _clearButton.Size = new Size(100, 30);
            _clearButton.TabIndex = 3;
            _clearButton.Text = "Làm mới";
            // 
            // _filterLayout
            // 
            _filterLayout.ColumnCount = 6;
            _filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            _filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            _filterLayout.ColumnStyles.Add(new ColumnStyle());
            _filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            _filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            _filterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            _filterLayout.Controls.Add(_searchLabel, 0, 0);
            _filterLayout.Controls.Add(_searchTextBox, 1, 0);
            _filterLayout.Controls.Add(_dateFilterCheckBox, 2, 0);
            _filterLayout.Controls.Add(_filterDatePicker, 3, 0);
            _filterLayout.Controls.Add(_filterStatusLabel, 4, 0);
            _filterLayout.Controls.Add(_filterStatusComboBox, 5, 0);
            _filterLayout.Dock = DockStyle.Fill;
            _filterLayout.Location = new Point(13, 296);
            _filterLayout.Name = "_filterLayout";
            _filterLayout.Padding = new Padding(0, 5, 0, 5);
            _filterLayout.RowCount = 1;
            _filterLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            _filterLayout.Size = new Size(1154, 42);
            _filterLayout.TabIndex = 1;
            // 
            // _searchLabel
            // 
            _searchLabel.Anchor = AnchorStyles.Left;
            _searchLabel.AutoSize = true;
            _searchLabel.Location = new Point(3, 13);
            _searchLabel.Margin = new Padding(3, 8, 3, 3);
            _searchLabel.Name = "_searchLabel";
            _searchLabel.Size = new Size(44, 21);
            _searchLabel.TabIndex = 0;
            _searchLabel.Text = "Tìm kiếm:";
            // 
            // _filterStatusLabel
            // 
            _filterStatusLabel.Anchor = AnchorStyles.Left;
            _filterStatusLabel.AutoSize = true;
            _filterStatusLabel.Location = new Point(922, 5);
            _filterStatusLabel.Name = "_filterStatusLabel";
            _filterStatusLabel.Size = new Size(50, 32);
            _filterStatusLabel.TabIndex = 4;
            _filterStatusLabel.Text = "Trạng thái:";
            // 
            // _statusStrip
            // 
            _statusStrip.Dock = DockStyle.Fill;
            _statusStrip.ImageScalingSize = new Size(20, 20);
            _statusStrip.Items.AddRange(new ToolStripItem[] { _appointmentCountLabel });
            _statusStrip.Location = new Point(10, 717);
            _statusStrip.Name = "_statusStrip";
            _statusStrip.Size = new Size(1160, 25);
            _statusStrip.TabIndex = 3;
            // 
            // _menuStrip
            // 
            _menuStrip.ImageScalingSize = new Size(20, 20);
            _menuStrip.Items.AddRange(new ToolStripItem[] { _fileMenu });
            _menuStrip.Location = new Point(0, 0);
            _menuStrip.Name = "_menuStrip";
            _menuStrip.Size = new Size(1180, 28);
            _menuStrip.TabIndex = 1;
            // 
            // _fileMenu
            // 
            _fileMenu.DropDownItems.AddRange(new ToolStripItem[] { _exportMenuItem });
            _fileMenu.Name = "_fileMenu";
            _fileMenu.Size = new Size(48, 24);
            _fileMenu.Text = "Tệp";
            // 
            // _exportMenuItem
            // 
            _exportMenuItem.Name = "_exportMenuItem";
            _exportMenuItem.Size = new Size(339, 26);
            _exportMenuItem.Text = "Xuất danh sách đang hiển thị ra CSV...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 780);
            Controls.Add(_rootLayout);
            Controls.Add(_menuStrip);
            Font = new Font("Segoe UI", 9F);
            MainMenuStrip = _menuStrip;
            MinimumSize = new Size(900, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinic Appointment Manager";
            ((System.ComponentModel.ISupportInitialize)_appointmentsGrid).EndInit();
            _rootLayout.ResumeLayout(false);
            _rootLayout.PerformLayout();
            _editorGroup.ResumeLayout(false);
            _editorLayout.ResumeLayout(false);
            _editorLayout.PerformLayout();
            _buttonPanel.ResumeLayout(false);
            _filterLayout.ResumeLayout(false);
            _filterLayout.PerformLayout();
            _statusStrip.ResumeLayout(false);
            _statusStrip.PerformLayout();
            _menuStrip.ResumeLayout(false);
            _menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
