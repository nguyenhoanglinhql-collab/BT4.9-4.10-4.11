namespace _4_10
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel _rootLayout;
        private GroupBox _entryGroup;
        private TableLayoutPanel _entryLayout;
        private FlowLayoutPanel _actionsPanel;
        private TableLayoutPanel _listPanel;
        private FlowLayoutPanel _searchPanel;
        private Label _titleLabel;
        private Label _receiptLabel;
        private Label _studentIdLabel;
        private Label _studentNameLabel;
        private Label _equipmentLabel;
        private Label _quantityLabel;
        private Label _checkoutDateLabel;
        private Label _dueDateLabel;
        private Label _returnDateLabel;
        private Label _statusLabel;
        private Label _searchLabel;
        private Label _filterLabel;
        private StatusStrip _statusStrip;
        private DataGridViewTextBoxColumn _receiptColumn;
        private DataGridViewTextBoxColumn _studentIdColumn;
        private DataGridViewTextBoxColumn _studentNameColumn;
        private DataGridViewTextBoxColumn _equipmentColumn;
        private DataGridViewTextBoxColumn _quantityColumn;
        private DataGridViewTextBoxColumn _checkoutDateColumn;
        private DataGridViewTextBoxColumn _dueDateColumn;
        private DataGridViewTextBoxColumn _returnDateColumn;
        private DataGridViewTextBoxColumn _statusColumn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            _rootLayout = new TableLayoutPanel();
            _titleLabel = new Label();
            _entryGroup = new GroupBox();
            _entryLayout = new TableLayoutPanel();
            _receiptLabel = new Label();
            _receiptIdTextBox = new TextBox();
            _studentIdLabel = new Label();
            _studentIdTextBox = new TextBox();
            _studentNameLabel = new Label();
            _studentNameTextBox = new TextBox();
            _equipmentLabel = new Label();
            _equipmentComboBox = new ComboBox();
            _quantityLabel = new Label();
            _quantityNumeric = new NumericUpDown();
            _checkoutDateLabel = new Label();
            _checkoutDatePicker = new DateTimePicker();
            _dueDateLabel = new Label();
            _dueDatePicker = new DateTimePicker();
            _returnDateLabel = new Label();
            _returnDatePicker = new DateTimePicker();
            _statusLabel = new Label();
            _statusValueLabel = new Label();
            _actionsPanel = new FlowLayoutPanel();
            _addButton = new Button();
            _updateButton = new Button();
            _deleteButton = new Button();
            _markReturnedButton = new Button();
            _clearButton = new Button();
            _exportButton = new Button();
            _listPanel = new TableLayoutPanel();
            _searchPanel = new FlowLayoutPanel();
            _searchLabel = new Label();
            _searchTextBox = new TextBox();
            _filterLabel = new Label();
            _statusFilterComboBox = new ComboBox();
            _recordsGrid = new DataGridView();
            _summaryLabel = new ToolStripStatusLabel();
            _statusStrip = new StatusStrip();
            _errorProvider = new ErrorProvider(components);
            _rootLayout.SuspendLayout();
            _entryGroup.SuspendLayout();
            _entryLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_quantityNumeric).BeginInit();
            _actionsPanel.SuspendLayout();
            _listPanel.SuspendLayout();
            _searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_recordsGrid).BeginInit();
            _statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_errorProvider).BeginInit();
            SuspendLayout();
            // 
            // _rootLayout
            // 
            _rootLayout.ColumnCount = 1;
            _rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            _rootLayout.Controls.Add(_titleLabel, 0, 0);
            _rootLayout.Controls.Add(_entryGroup, 0, 1);
            _rootLayout.Controls.Add(_actionsPanel, 0, 2);
            _rootLayout.Controls.Add(_listPanel, 0, 3);
            _rootLayout.Dock = DockStyle.Fill;
            _rootLayout.Location = new Point(0, 0);
            _rootLayout.Name = "_rootLayout";
            _rootLayout.Padding = new Padding(12);
            _rootLayout.RowCount = 4;
            _rootLayout.RowStyles.Add(new RowStyle());
            _rootLayout.RowStyles.Add(new RowStyle());
            _rootLayout.RowStyles.Add(new RowStyle());
            _rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _rootLayout.Size = new Size(1240, 738);
            _rootLayout.TabIndex = 0;
            // 
            // _titleLabel
            // 
            _titleLabel.AutoSize = true;
            _titleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _titleLabel.Location = new Point(12, 12);
            _titleLabel.Margin = new Padding(0, 0, 0, 10);
            _titleLabel.Name = "_titleLabel";
            _titleLabel.Size = new Size(310, 20);
            _titleLabel.TabIndex = 0;
            _titleLabel.Text = "Quản lý mượn trả thiết bị phòng thực hành";
            // 
            // _entryGroup
            // 
            _entryGroup.AutoSize = true;
            _entryGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _entryGroup.Controls.Add(_entryLayout);
            _entryGroup.Dock = DockStyle.Top;
            _entryGroup.Location = new Point(15, 45);
            _entryGroup.Name = "_entryGroup";
            _entryGroup.Padding = new Padding(10);
            _entryGroup.Size = new Size(1210, 176);
            _entryGroup.TabIndex = 1;
            _entryGroup.TabStop = false;
            _entryGroup.Text = "Thông tin phiếu mượn";
            // 
            // _entryLayout
            // 
            _entryLayout.AutoSize = true;
            _entryLayout.ColumnCount = 6;
            _entryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            _entryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            _entryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            _entryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            _entryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            _entryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            _entryLayout.Controls.Add(_receiptLabel, 0, 0);
            _entryLayout.Controls.Add(_receiptIdTextBox, 1, 0);
            _entryLayout.Controls.Add(_studentIdLabel, 2, 0);
            _entryLayout.Controls.Add(_studentIdTextBox, 3, 0);
            _entryLayout.Controls.Add(_studentNameLabel, 4, 0);
            _entryLayout.Controls.Add(_studentNameTextBox, 5, 0);
            _entryLayout.Controls.Add(_equipmentLabel, 0, 1);
            _entryLayout.Controls.Add(_equipmentComboBox, 1, 1);
            _entryLayout.Controls.Add(_quantityLabel, 2, 1);
            _entryLayout.Controls.Add(_quantityNumeric, 3, 1);
            _entryLayout.Controls.Add(_checkoutDateLabel, 4, 1);
            _entryLayout.Controls.Add(_checkoutDatePicker, 5, 1);
            _entryLayout.Controls.Add(_dueDateLabel, 0, 2);
            _entryLayout.Controls.Add(_dueDatePicker, 1, 2);
            _entryLayout.Controls.Add(_returnDateLabel, 2, 2);
            _entryLayout.Controls.Add(_returnDatePicker, 3, 2);
            _entryLayout.Controls.Add(_statusLabel, 4, 2);
            _entryLayout.Controls.Add(_statusValueLabel, 5, 2);
            _entryLayout.Dock = DockStyle.Top;
            _entryLayout.Location = new Point(10, 30);
            _entryLayout.Name = "_entryLayout";
            _entryLayout.Padding = new Padding(4);
            _entryLayout.RowCount = 3;
            _entryLayout.RowStyles.Add(new RowStyle());
            _entryLayout.RowStyles.Add(new RowStyle());
            _entryLayout.RowStyles.Add(new RowStyle());
            _entryLayout.Size = new Size(1190, 136);
            _entryLayout.TabIndex = 0;
            // 
            // _receiptLabel
            // 
            _receiptLabel.Anchor = AnchorStyles.Left;
            _receiptLabel.AutoSize = true;
            _receiptLabel.Location = new Point(7, 12);
            _receiptLabel.Margin = new Padding(3, 8, 3, 8);
            _receiptLabel.Name = "_receiptLabel";
            _receiptLabel.Size = new Size(74, 20);
            _receiptLabel.TabIndex = 0;
            _receiptLabel.Text = "Mã phiếu:";
            // 
            // _receiptIdTextBox
            // 
            _receiptIdTextBox.Dock = DockStyle.Fill;
            _receiptIdTextBox.Location = new Point(112, 8);
            _receiptIdTextBox.Margin = new Padding(3, 4, 12, 4);
            _receiptIdTextBox.Name = "_receiptIdTextBox";
            _receiptIdTextBox.Size = new Size(273, 27);
            _receiptIdTextBox.TabIndex = 1;
            // 
            // _studentIdLabel
            // 
            _studentIdLabel.Anchor = AnchorStyles.Left;
            _studentIdLabel.AutoSize = true;
            _studentIdLabel.Location = new Point(400, 12);
            _studentIdLabel.Margin = new Padding(3, 8, 3, 8);
            _studentIdLabel.Name = "_studentIdLabel";
            _studentIdLabel.Size = new Size(94, 20);
            _studentIdLabel.TabIndex = 2;
            _studentIdLabel.Text = "Mã sinh viên:";
            // 
            // _studentIdTextBox
            // 
            _studentIdTextBox.Dock = DockStyle.Fill;
            _studentIdTextBox.Location = new Point(505, 8);
            _studentIdTextBox.Margin = new Padding(3, 4, 12, 4);
            _studentIdTextBox.Name = "_studentIdTextBox";
            _studentIdTextBox.Size = new Size(273, 27);
            _studentIdTextBox.TabIndex = 3;
            // 
            // _studentNameLabel
            // 
            _studentNameLabel.Anchor = AnchorStyles.Left;
            _studentNameLabel.AutoSize = true;
            _studentNameLabel.Location = new Point(793, 12);
            _studentNameLabel.Margin = new Padding(3, 8, 3, 8);
            _studentNameLabel.Name = "_studentNameLabel";
            _studentNameLabel.Size = new Size(57, 20);
            _studentNameLabel.TabIndex = 4;
            _studentNameLabel.Text = "Họ tên:";
            // 
            // _studentNameTextBox
            // 
            _studentNameTextBox.Dock = DockStyle.Fill;
            _studentNameTextBox.Location = new Point(898, 8);
            _studentNameTextBox.Margin = new Padding(3, 4, 12, 4);
            _studentNameTextBox.Name = "_studentNameTextBox";
            _studentNameTextBox.Size = new Size(276, 27);
            _studentNameTextBox.TabIndex = 5;
            // 
            // _equipmentLabel
            // 
            _equipmentLabel.Anchor = AnchorStyles.Left;
            _equipmentLabel.AutoSize = true;
            _equipmentLabel.Location = new Point(7, 48);
            _equipmentLabel.Margin = new Padding(3, 8, 3, 8);
            _equipmentLabel.Name = "_equipmentLabel";
            _equipmentLabel.Size = new Size(62, 20);
            _equipmentLabel.TabIndex = 6;
            _equipmentLabel.Text = "Thiết bị:";
            // 
            // _equipmentComboBox
            // 
            _equipmentComboBox.Dock = DockStyle.Fill;
            _equipmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _equipmentComboBox.Items.AddRange(new object[] { "Laptop", "Máy chiếu", "Bộ Arduino", "Đồng hồ vạn năng", "Máy ảnh" });
            _equipmentComboBox.Location = new Point(112, 44);
            _equipmentComboBox.Margin = new Padding(3, 4, 12, 4);
            _equipmentComboBox.Name = "_equipmentComboBox";
            _equipmentComboBox.Size = new Size(273, 28);
            _equipmentComboBox.TabIndex = 7;
            // 
            // _quantityLabel
            // 
            _quantityLabel.Anchor = AnchorStyles.Left;
            _quantityLabel.AutoSize = true;
            _quantityLabel.Location = new Point(400, 48);
            _quantityLabel.Margin = new Padding(3, 8, 3, 8);
            _quantityLabel.Name = "_quantityLabel";
            _quantityLabel.Size = new Size(72, 20);
            _quantityLabel.TabIndex = 8;
            _quantityLabel.Text = "Số lượng:";
            // 
            // _quantityNumeric
            // 
            _quantityNumeric.Dock = DockStyle.Fill;
            _quantityNumeric.Location = new Point(505, 44);
            _quantityNumeric.Margin = new Padding(3, 4, 12, 4);
            _quantityNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            _quantityNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            _quantityNumeric.Name = "_quantityNumeric";
            _quantityNumeric.Size = new Size(273, 27);
            _quantityNumeric.TabIndex = 9;
            _quantityNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // _checkoutDateLabel
            // 
            _checkoutDateLabel.Anchor = AnchorStyles.Left;
            _checkoutDateLabel.AutoSize = true;
            _checkoutDateLabel.Location = new Point(793, 48);
            _checkoutDateLabel.Margin = new Padding(3, 8, 3, 8);
            _checkoutDateLabel.Name = "_checkoutDateLabel";
            _checkoutDateLabel.Size = new Size(90, 20);
            _checkoutDateLabel.TabIndex = 10;
            _checkoutDateLabel.Text = "Ngày mượn:";
            // 
            // _checkoutDatePicker
            // 
            _checkoutDatePicker.Dock = DockStyle.Fill;
            _checkoutDatePicker.Format = DateTimePickerFormat.Short;
            _checkoutDatePicker.Location = new Point(898, 44);
            _checkoutDatePicker.Margin = new Padding(3, 4, 12, 4);
            _checkoutDatePicker.Name = "_checkoutDatePicker";
            _checkoutDatePicker.Size = new Size(276, 27);
            _checkoutDatePicker.TabIndex = 11;
            // 
            // _dueDateLabel
            // 
            _dueDateLabel.Anchor = AnchorStyles.Left;
            _dueDateLabel.AutoSize = true;
            _dueDateLabel.Location = new Point(7, 94);
            _dueDateLabel.Margin = new Padding(3, 8, 3, 8);
            _dueDateLabel.Name = "_dueDateLabel";
            _dueDateLabel.Size = new Size(61, 20);
            _dueDateLabel.TabIndex = 12;
            _dueDateLabel.Text = "Hạn trả:";
            // 
            // _dueDatePicker
            // 
            _dueDatePicker.Dock = DockStyle.Fill;
            _dueDatePicker.Format = DateTimePickerFormat.Short;
            _dueDatePicker.Location = new Point(112, 80);
            _dueDatePicker.Margin = new Padding(3, 4, 12, 4);
            _dueDatePicker.Name = "_dueDatePicker";
            _dueDatePicker.Size = new Size(273, 27);
            _dueDatePicker.TabIndex = 13;
            // 
            // _returnDateLabel
            // 
            _returnDateLabel.Anchor = AnchorStyles.Left;
            _returnDateLabel.AutoSize = true;
            _returnDateLabel.Location = new Point(400, 84);
            _returnDateLabel.Margin = new Padding(3, 8, 3, 8);
            _returnDateLabel.Name = "_returnDateLabel";
            _returnDateLabel.Size = new Size(99, 40);
            _returnDateLabel.TabIndex = 14;
            _returnDateLabel.Text = "Ngày trả thực tế:";
            // 
            // _returnDatePicker
            // 
            _returnDatePicker.Checked = false;
            _returnDatePicker.Dock = DockStyle.Fill;
            _returnDatePicker.Format = DateTimePickerFormat.Short;
            _returnDatePicker.Location = new Point(505, 80);
            _returnDatePicker.Margin = new Padding(3, 4, 12, 4);
            _returnDatePicker.Name = "_returnDatePicker";
            _returnDatePicker.ShowCheckBox = true;
            _returnDatePicker.Size = new Size(273, 27);
            _returnDatePicker.TabIndex = 15;
            // 
            // _statusLabel
            // 
            _statusLabel.Anchor = AnchorStyles.Left;
            _statusLabel.AutoSize = true;
            _statusLabel.Location = new Point(793, 94);
            _statusLabel.Margin = new Padding(3, 8, 3, 8);
            _statusLabel.Name = "_statusLabel";
            _statusLabel.Size = new Size(79, 20);
            _statusLabel.TabIndex = 16;
            _statusLabel.Text = "Tình trạng:";
            // 
            // _statusValueLabel
            // 
            _statusValueLabel.Anchor = AnchorStyles.Left;
            _statusValueLabel.AutoSize = true;
            _statusValueLabel.Location = new Point(898, 94);
            _statusValueLabel.Margin = new Padding(3, 8, 3, 8);
            _statusValueLabel.Name = "_statusValueLabel";
            _statusValueLabel.Size = new Size(88, 20);
            _statusValueLabel.TabIndex = 17;
            _statusValueLabel.Text = "Đang mượn";
            // 
            // _actionsPanel
            // 
            _actionsPanel.AutoSize = true;
            _actionsPanel.Controls.Add(_addButton);
            _actionsPanel.Controls.Add(_updateButton);
            _actionsPanel.Controls.Add(_deleteButton);
            _actionsPanel.Controls.Add(_markReturnedButton);
            _actionsPanel.Controls.Add(_clearButton);
            _actionsPanel.Controls.Add(_exportButton);
            _actionsPanel.Dock = DockStyle.Top;
            _actionsPanel.Location = new Point(15, 227);
            _actionsPanel.Name = "_actionsPanel";
            _actionsPanel.Padding = new Padding(0, 8, 0, 8);
            _actionsPanel.Size = new Size(1210, 48);
            _actionsPanel.TabIndex = 2;
            // 
            // _addButton
            // 
            _addButton.AutoSize = true;
            _addButton.Location = new Point(0, 8);
            _addButton.Margin = new Padding(0, 0, 8, 0);
            _addButton.MinimumSize = new Size(100, 32);
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(100, 32);
            _addButton.TabIndex = 0;
            _addButton.Text = "Thêm phiếu";
            // 
            // _updateButton
            // 
            _updateButton.AutoSize = true;
            _updateButton.Location = new Point(108, 8);
            _updateButton.Margin = new Padding(0, 0, 8, 0);
            _updateButton.MinimumSize = new Size(100, 32);
            _updateButton.Name = "_updateButton";
            _updateButton.Size = new Size(100, 32);
            _updateButton.TabIndex = 1;
            _updateButton.Text = "Cập nhật";
            // 
            // _deleteButton
            // 
            _deleteButton.AutoSize = true;
            _deleteButton.Location = new Point(216, 8);
            _deleteButton.Margin = new Padding(0, 0, 8, 0);
            _deleteButton.MinimumSize = new Size(100, 32);
            _deleteButton.Name = "_deleteButton";
            _deleteButton.Size = new Size(100, 32);
            _deleteButton.TabIndex = 2;
            _deleteButton.Text = "Xóa phiếu";
            // 
            // _markReturnedButton
            // 
            _markReturnedButton.AutoSize = true;
            _markReturnedButton.Location = new Point(324, 8);
            _markReturnedButton.Margin = new Padding(0, 0, 8, 0);
            _markReturnedButton.MinimumSize = new Size(100, 32);
            _markReturnedButton.Name = "_markReturnedButton";
            _markReturnedButton.Size = new Size(126, 32);
            _markReturnedButton.TabIndex = 3;
            _markReturnedButton.Text = "Đánh dấu đã trả";
            // 
            // _clearButton
            // 
            _clearButton.AutoSize = true;
            _clearButton.Location = new Point(458, 8);
            _clearButton.Margin = new Padding(0, 0, 8, 0);
            _clearButton.MinimumSize = new Size(100, 32);
            _clearButton.Name = "_clearButton";
            _clearButton.Size = new Size(100, 32);
            _clearButton.TabIndex = 4;
            _clearButton.Text = "Làm mới";
            // 
            // _exportButton
            // 
            _exportButton.AutoSize = true;
            _exportButton.Location = new Point(566, 8);
            _exportButton.Margin = new Padding(0, 0, 8, 0);
            _exportButton.MinimumSize = new Size(100, 32);
            _exportButton.Name = "_exportButton";
            _exportButton.Size = new Size(100, 32);
            _exportButton.TabIndex = 5;
            _exportButton.Text = "Xuất CSV";
            // 
            // _listPanel
            // 
            _listPanel.ColumnCount = 1;
            _listPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            _listPanel.Controls.Add(_searchPanel, 0, 0);
            _listPanel.Controls.Add(_recordsGrid, 0, 1);
            _listPanel.Dock = DockStyle.Fill;
            _listPanel.Location = new Point(15, 281);
            _listPanel.Name = "_listPanel";
            _listPanel.RowCount = 2;
            _listPanel.RowStyles.Add(new RowStyle());
            _listPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _listPanel.Size = new Size(1210, 442);
            _listPanel.TabIndex = 3;
            // 
            // _searchPanel
            // 
            _searchPanel.AutoSize = true;
            _searchPanel.Controls.Add(_searchLabel);
            _searchPanel.Controls.Add(_searchTextBox);
            _searchPanel.Controls.Add(_filterLabel);
            _searchPanel.Controls.Add(_statusFilterComboBox);
            _searchPanel.Dock = DockStyle.Fill;
            _searchPanel.Location = new Point(3, 3);
            _searchPanel.Name = "_searchPanel";
            _searchPanel.Padding = new Padding(0, 0, 0, 8);
            _searchPanel.Size = new Size(1204, 42);
            _searchPanel.TabIndex = 0;
            _searchPanel.WrapContents = false;
            // 
            // _searchLabel
            // 
            _searchLabel.AutoSize = true;
            _searchLabel.Location = new Point(3, 8);
            _searchLabel.Margin = new Padding(3, 8, 6, 3);
            _searchLabel.Name = "_searchLabel";
            _searchLabel.Size = new Size(144, 20);
            _searchLabel.TabIndex = 0;
            _searchLabel.Text = "Tìm mã SV / thiết bị:";
            // 
            // _searchTextBox
            // 
            _searchTextBox.Location = new Point(153, 3);
            _searchTextBox.Margin = new Padding(0, 3, 14, 3);
            _searchTextBox.Name = "_searchTextBox";
            _searchTextBox.Size = new Size(240, 27);
            _searchTextBox.TabIndex = 1;
            // 
            // _filterLabel
            // 
            _filterLabel.AutoSize = true;
            _filterLabel.Location = new Point(410, 8);
            _filterLabel.Margin = new Padding(3, 8, 6, 3);
            _filterLabel.Name = "_filterLabel";
            _filterLabel.Size = new Size(103, 20);
            _filterLabel.TabIndex = 2;
            _filterLabel.Text = "Lọc tình trạng:";
            // 
            // _statusFilterComboBox
            // 
            _statusFilterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _statusFilterComboBox.Items.AddRange(new object[] { "Tất cả", "Đang mượn", "Quá hạn", "Đã trả" });
            _statusFilterComboBox.Location = new Point(522, 3);
            _statusFilterComboBox.Name = "_statusFilterComboBox";
            _statusFilterComboBox.Size = new Size(160, 28);
            _statusFilterComboBox.TabIndex = 3;
            // 
            // _recordsGrid
            // 
            _recordsGrid.AllowUserToAddRows = false;
            _recordsGrid.AllowUserToDeleteRows = false;
            _recordsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _recordsGrid.ColumnHeadersHeight = 29;
            _recordsGrid.Dock = DockStyle.Fill;
            _recordsGrid.Location = new Point(3, 51);
            _recordsGrid.MultiSelect = false;
            _recordsGrid.Name = "_recordsGrid";
            _recordsGrid.ReadOnly = true;
            _recordsGrid.RowHeadersVisible = false;
            _recordsGrid.RowHeadersWidth = 51;
            _recordsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _recordsGrid.Size = new Size(1204, 388);
            _recordsGrid.TabIndex = 1;
            // 
            // _summaryLabel
            // 
            _summaryLabel.Name = "_summaryLabel";
            _summaryLabel.Size = new Size(1225, 16);
            _summaryLabel.Spring = true;
            _summaryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _statusStrip
            // 
            _statusStrip.ImageScalingSize = new Size(20, 20);
            _statusStrip.Items.AddRange(new ToolStripItem[] { _summaryLabel });
            _statusStrip.Location = new Point(0, 738);
            _statusStrip.Name = "_statusStrip";
            _statusStrip.Size = new Size(1240, 22);
            _statusStrip.TabIndex = 1;
            // 
            // _errorProvider
            // 
            _errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 760);
            Controls.Add(_rootLayout);
            Controls.Add(_statusStrip);
            MinimumSize = new Size(960, 640);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab Equipment Checkout";
            _rootLayout.ResumeLayout(false);
            _rootLayout.PerformLayout();
            _entryGroup.ResumeLayout(false);
            _entryGroup.PerformLayout();
            _entryLayout.ResumeLayout(false);
            _entryLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_quantityNumeric).EndInit();
            _actionsPanel.ResumeLayout(false);
            _actionsPanel.PerformLayout();
            _listPanel.ResumeLayout(false);
            _listPanel.PerformLayout();
            _searchPanel.ResumeLayout(false);
            _searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_recordsGrid).EndInit();
            _statusStrip.ResumeLayout(false);
            _statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
