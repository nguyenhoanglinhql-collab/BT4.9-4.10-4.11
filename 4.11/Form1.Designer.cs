namespace _4._11
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null!;
        private TableLayoutPanel _mainLayout = null!;
        private Panel _entryPanel = null!;
        private TableLayoutPanel _entryLayout = null!;
        private TableLayoutPanel _listPanel = null!;
        private FlowLayoutPanel _imagePanel = null!;
        private FlowLayoutPanel _actionButtons = null!;
        private FlowLayoutPanel _filterPanel = null!;
        private MenuStrip _menuStrip = null!;
        private ToolStripMenuItem _exportMenuItem = null!;
        private ToolStripMenuItem _exitMenuItem = null!;
        private StatusStrip _statusStrip = null!;
        private ToolStripStatusLabel _orderCountLabel = null!;
        private ToolStripStatusLabel _estimatedTotalLabel = null!;
        private Label _orderIdLabel = null!;
        private Label _customerNameLabel = null!;
        private Label _phoneLabel = null!;
        private Label _deviceTypeLabel = null!;
        private Label _faultDescriptionLabel = null!;
        private Label _receivedDateLabel = null!;
        private Label _estimatedCostLabel = null!;
        private Label _statusLabel = null!;
        private Label _deviceImageLabel = null!;
        private Label _searchLabel = null!;
        private Label _statusFilterLabel = null!;
        private TextBox _orderIdTextBox = null!;
        private TextBox _customerNameTextBox = null!;
        private TextBox _phoneTextBox = null!;
        private ComboBox _deviceTypeComboBox = null!;
        private TextBox _faultDescriptionTextBox = null!;
        private DateTimePicker _receivedDatePicker = null!;
        private TextBox _estimatedCostTextBox = null!;
        private ComboBox _statusComboBox = null!;
        private PictureBox _devicePictureBox = null!;
        private TextBox _searchTextBox = null!;
        private ComboBox _statusFilterComboBox = null!;
        private DataGridView _ordersGrid = null!;
        private Button _addButton = null!;
        private Button _updateButton = null!;
        private Button _deleteButton = null!;
        private Button _clearButton = null!;
        private Button _chooseImageButton = null!;
        private DataGridViewTextBoxColumn _orderIdColumn = null!;
        private DataGridViewTextBoxColumn _customerNameColumn = null!;
        private DataGridViewTextBoxColumn _phoneColumn = null!;
        private DataGridViewTextBoxColumn _deviceTypeColumn = null!;
        private DataGridViewTextBoxColumn _receivedDateColumn = null!;
        private DataGridViewTextBoxColumn _estimatedCostColumn = null!;
        private DataGridViewTextBoxColumn _statusColumn = null!;
        private BindingSource _bindingSource = null!;
        private ErrorProvider _errorProvider = null!;

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
            _mainLayout = new TableLayoutPanel();
            _entryPanel = new Panel();
            _entryLayout = new TableLayoutPanel();
            _orderIdLabel = new Label();
            _orderIdTextBox = new TextBox();
            _customerNameLabel = new Label();
            _customerNameTextBox = new TextBox();
            _phoneLabel = new Label();
            _phoneTextBox = new TextBox();
            _deviceTypeLabel = new Label();
            _deviceTypeComboBox = new ComboBox();
            _faultDescriptionLabel = new Label();
            _faultDescriptionTextBox = new TextBox();
            _receivedDateLabel = new Label();
            _receivedDatePicker = new DateTimePicker();
            _estimatedCostLabel = new Label();
            _estimatedCostTextBox = new TextBox();
            _statusLabel = new Label();
            _statusComboBox = new ComboBox();
            _deviceImageLabel = new Label();
            _imagePanel = new FlowLayoutPanel();
            _devicePictureBox = new PictureBox();
            _chooseImageButton = new Button();
            _actionButtons = new FlowLayoutPanel();
            _addButton = new Button();
            _updateButton = new Button();
            _deleteButton = new Button();
            _clearButton = new Button();
            _listPanel = new TableLayoutPanel();
            _filterPanel = new FlowLayoutPanel();
            _searchLabel = new Label();
            _searchTextBox = new TextBox();
            _statusFilterLabel = new Label();
            _statusFilterComboBox = new ComboBox();
            _ordersGrid = new DataGridView();
            _menuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            _exportMenuItem = new ToolStripMenuItem();
            _exitMenuItem = new ToolStripMenuItem();
            _statusStrip = new StatusStrip();
            _orderCountLabel = new ToolStripStatusLabel();
            _estimatedTotalLabel = new ToolStripStatusLabel();
            _bindingSource = new BindingSource(components);
            _errorProvider = new ErrorProvider(components);
            _mainLayout.SuspendLayout();
            _entryPanel.SuspendLayout();
            _entryLayout.SuspendLayout();
            _imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_devicePictureBox).BeginInit();
            _actionButtons.SuspendLayout();
            _listPanel.SuspendLayout();
            _filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_ordersGrid).BeginInit();
            _menuStrip.SuspendLayout();
            _statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_bindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_errorProvider).BeginInit();
            SuspendLayout();
            // 
            // _mainLayout
            // 
            _mainLayout.ColumnCount = 2;
            _mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.93651F));
            _mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.06349F));
            _mainLayout.Controls.Add(_entryPanel, 0, 0);
            _mainLayout.Controls.Add(_listPanel, 1, 0);
            _mainLayout.Dock = DockStyle.Fill;
            _mainLayout.Location = new Point(0, 28);
            _mainLayout.Name = "_mainLayout";
            _mainLayout.Padding = new Padding(10);
            _mainLayout.RowCount = 1;
            _mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _mainLayout.Size = new Size(1280, 726);
            _mainLayout.TabIndex = 0;
            // 
            // _entryPanel
            // 
            _entryPanel.AutoScroll = true;
            _entryPanel.Controls.Add(_entryLayout);
            _entryPanel.Dock = DockStyle.Fill;
            _entryPanel.Location = new Point(13, 13);
            _entryPanel.Name = "_entryPanel";
            _entryPanel.Padding = new Padding(0, 0, 10, 0);
            _entryPanel.Size = new Size(535, 700);
            _entryPanel.TabIndex = 0;
            // 
            // _entryLayout
            // 
            _entryLayout.AutoSize = true;
            _entryLayout.ColumnCount = 2;
            _entryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            _entryLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _entryLayout.Controls.Add(_orderIdLabel, 0, 0);
            _entryLayout.Controls.Add(_orderIdTextBox, 1, 0);
            _entryLayout.Controls.Add(_customerNameLabel, 0, 1);
            _entryLayout.Controls.Add(_customerNameTextBox, 1, 1);
            _entryLayout.Controls.Add(_phoneLabel, 0, 2);
            _entryLayout.Controls.Add(_phoneTextBox, 1, 2);
            _entryLayout.Controls.Add(_deviceTypeLabel, 0, 3);
            _entryLayout.Controls.Add(_deviceTypeComboBox, 1, 3);
            _entryLayout.Controls.Add(_faultDescriptionLabel, 0, 4);
            _entryLayout.Controls.Add(_faultDescriptionTextBox, 1, 4);
            _entryLayout.Controls.Add(_receivedDateLabel, 0, 5);
            _entryLayout.Controls.Add(_receivedDatePicker, 1, 5);
            _entryLayout.Controls.Add(_estimatedCostLabel, 0, 6);
            _entryLayout.Controls.Add(_estimatedCostTextBox, 1, 6);
            _entryLayout.Controls.Add(_statusLabel, 0, 7);
            _entryLayout.Controls.Add(_statusComboBox, 1, 7);
            _entryLayout.Controls.Add(_deviceImageLabel, 0, 8);
            _entryLayout.Controls.Add(_imagePanel, 1, 8);
            _entryLayout.Controls.Add(_actionButtons, 0, 9);
            _entryLayout.Dock = DockStyle.Top;
            _entryLayout.Location = new Point(0, 0);
            _entryLayout.Name = "_entryLayout";
            _entryLayout.Padding = new Padding(4);
            _entryLayout.RowCount = 10;
            _entryLayout.RowStyles.Add(new RowStyle());
            _entryLayout.RowStyles.Add(new RowStyle());
            _entryLayout.RowStyles.Add(new RowStyle());
            _entryLayout.RowStyles.Add(new RowStyle());
            _entryLayout.RowStyles.Add(new RowStyle());
            _entryLayout.RowStyles.Add(new RowStyle());
            _entryLayout.RowStyles.Add(new RowStyle());
            _entryLayout.RowStyles.Add(new RowStyle());
            _entryLayout.RowStyles.Add(new RowStyle());
            _entryLayout.RowStyles.Add(new RowStyle());
            _entryLayout.Size = new Size(525, 565);
            _entryLayout.TabIndex = 0;
            // 
            // _orderIdLabel
            // 
            _orderIdLabel.Anchor = AnchorStyles.Left;
            _orderIdLabel.AutoSize = true;
            _orderIdLabel.Location = new Point(7, 10);
            _orderIdLabel.Name = "_orderIdLabel";
            _orderIdLabel.Size = new Size(60, 20);
            _orderIdLabel.TabIndex = 0;
            _orderIdLabel.Text = "Mã đơn";
            // 
            // _orderIdTextBox
            // 
            _orderIdTextBox.Dock = DockStyle.Fill;
            _orderIdTextBox.Location = new Point(137, 7);
            _orderIdTextBox.Name = "_orderIdTextBox";
            _orderIdTextBox.Size = new Size(381, 27);
            _orderIdTextBox.TabIndex = 1;
            // 
            // _customerNameLabel
            // 
            _customerNameLabel.Anchor = AnchorStyles.Left;
            _customerNameLabel.AutoSize = true;
            _customerNameLabel.Location = new Point(7, 43);
            _customerNameLabel.Name = "_customerNameLabel";
            _customerNameLabel.Size = new Size(111, 20);
            _customerNameLabel.TabIndex = 2;
            _customerNameLabel.Text = "Tên khách hàng";
            // 
            // _customerNameTextBox
            // 
            _customerNameTextBox.Dock = DockStyle.Fill;
            _customerNameTextBox.Location = new Point(137, 40);
            _customerNameTextBox.Name = "_customerNameTextBox";
            _customerNameTextBox.Size = new Size(381, 27);
            _customerNameTextBox.TabIndex = 3;
            // 
            // _phoneLabel
            // 
            _phoneLabel.Anchor = AnchorStyles.Left;
            _phoneLabel.AutoSize = true;
            _phoneLabel.Location = new Point(7, 76);
            _phoneLabel.Name = "_phoneLabel";
            _phoneLabel.Size = new Size(97, 20);
            _phoneLabel.TabIndex = 4;
            _phoneLabel.Text = "Số điện thoại";
            // 
            // _phoneTextBox
            // 
            _phoneTextBox.Dock = DockStyle.Fill;
            _phoneTextBox.Location = new Point(137, 73);
            _phoneTextBox.Name = "_phoneTextBox";
            _phoneTextBox.Size = new Size(381, 27);
            _phoneTextBox.TabIndex = 5;
            // 
            // _deviceTypeLabel
            // 
            _deviceTypeLabel.Anchor = AnchorStyles.Left;
            _deviceTypeLabel.AutoSize = true;
            _deviceTypeLabel.Location = new Point(7, 110);
            _deviceTypeLabel.Name = "_deviceTypeLabel";
            _deviceTypeLabel.Size = new Size(88, 20);
            _deviceTypeLabel.TabIndex = 6;
            _deviceTypeLabel.Text = "Loại thiết bị";
            // 
            // _deviceTypeComboBox
            // 
            _deviceTypeComboBox.Dock = DockStyle.Fill;
            _deviceTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _deviceTypeComboBox.Items.AddRange(new object[] { "Điện thoại", "Máy tính", "Máy tính bảng", "Thiết bị gia dụng", "Khác" });
            _deviceTypeComboBox.Location = new Point(137, 106);
            _deviceTypeComboBox.Name = "_deviceTypeComboBox";
            _deviceTypeComboBox.Size = new Size(381, 28);
            _deviceTypeComboBox.TabIndex = 7;
            // 
            // _faultDescriptionLabel
            // 
            _faultDescriptionLabel.Anchor = AnchorStyles.Left;
            _faultDescriptionLabel.AutoSize = true;
            _faultDescriptionLabel.Location = new Point(7, 169);
            _faultDescriptionLabel.Name = "_faultDescriptionLabel";
            _faultDescriptionLabel.Size = new Size(69, 20);
            _faultDescriptionLabel.TabIndex = 8;
            _faultDescriptionLabel.Text = "Mô tả lỗi";
            // 
            // _faultDescriptionTextBox
            // 
            _faultDescriptionTextBox.Dock = DockStyle.Fill;
            _faultDescriptionTextBox.Location = new Point(137, 140);
            _faultDescriptionTextBox.Multiline = true;
            _faultDescriptionTextBox.Name = "_faultDescriptionTextBox";
            _faultDescriptionTextBox.ScrollBars = ScrollBars.Vertical;
            _faultDescriptionTextBox.Size = new Size(381, 78);
            _faultDescriptionTextBox.TabIndex = 9;
            // 
            // _receivedDateLabel
            // 
            _receivedDateLabel.Anchor = AnchorStyles.Left;
            _receivedDateLabel.AutoSize = true;
            _receivedDateLabel.Location = new Point(7, 227);
            _receivedDateLabel.Name = "_receivedDateLabel";
            _receivedDateLabel.Size = new Size(110, 20);
            _receivedDateLabel.TabIndex = 10;
            _receivedDateLabel.Text = "Ngày tiếp nhận";
            // 
            // _receivedDatePicker
            // 
            _receivedDatePicker.Dock = DockStyle.Fill;
            _receivedDatePicker.Format = DateTimePickerFormat.Short;
            _receivedDatePicker.Location = new Point(137, 224);
            _receivedDatePicker.Name = "_receivedDatePicker";
            _receivedDatePicker.Size = new Size(381, 27);
            _receivedDatePicker.TabIndex = 11;
            // 
            // _estimatedCostLabel
            // 
            _estimatedCostLabel.Anchor = AnchorStyles.Left;
            _estimatedCostLabel.AutoSize = true;
            _estimatedCostLabel.Location = new Point(7, 260);
            _estimatedCostLabel.Name = "_estimatedCostLabel";
            _estimatedCostLabel.Size = new Size(108, 20);
            _estimatedCostLabel.TabIndex = 12;
            _estimatedCostLabel.Text = "Chi phí dự kiến";
            // 
            // _estimatedCostTextBox
            // 
            _estimatedCostTextBox.Dock = DockStyle.Fill;
            _estimatedCostTextBox.Location = new Point(137, 257);
            _estimatedCostTextBox.Name = "_estimatedCostTextBox";
            _estimatedCostTextBox.Size = new Size(381, 27);
            _estimatedCostTextBox.TabIndex = 13;
            _estimatedCostTextBox.Text = "0";
            // 
            // _statusLabel
            // 
            _statusLabel.Anchor = AnchorStyles.Left;
            _statusLabel.AutoSize = true;
            _statusLabel.Location = new Point(7, 294);
            _statusLabel.Name = "_statusLabel";
            _statusLabel.Size = new Size(75, 20);
            _statusLabel.TabIndex = 14;
            _statusLabel.Text = "Trạng thái";
            // 
            // _statusComboBox
            // 
            _statusComboBox.Dock = DockStyle.Fill;
            _statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _statusComboBox.Items.AddRange(new object[] { "Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy" });
            _statusComboBox.Location = new Point(137, 290);
            _statusComboBox.Name = "_statusComboBox";
            _statusComboBox.Size = new Size(381, 28);
            _statusComboBox.TabIndex = 15;
            // 
            // _deviceImageLabel
            // 
            _deviceImageLabel.Anchor = AnchorStyles.Left;
            _deviceImageLabel.AutoSize = true;
            _deviceImageLabel.Location = new Point(7, 410);
            _deviceImageLabel.Name = "_deviceImageLabel";
            _deviceImageLabel.Size = new Size(86, 20);
            _deviceImageLabel.TabIndex = 16;
            _deviceImageLabel.Text = "Ảnh thiết bị";
            // 
            // _imagePanel
            // 
            _imagePanel.AutoSize = true;
            _imagePanel.Controls.Add(_devicePictureBox);
            _imagePanel.Controls.Add(_chooseImageButton);
            _imagePanel.Dock = DockStyle.Fill;
            _imagePanel.FlowDirection = FlowDirection.TopDown;
            _imagePanel.Location = new Point(137, 324);
            _imagePanel.Name = "_imagePanel";
            _imagePanel.Size = new Size(381, 192);
            _imagePanel.TabIndex = 17;
            _imagePanel.WrapContents = false;
            // 
            // _devicePictureBox
            // 
            _devicePictureBox.BorderStyle = BorderStyle.FixedSingle;
            _devicePictureBox.Location = new Point(3, 3);
            _devicePictureBox.Name = "_devicePictureBox";
            _devicePictureBox.Size = new Size(220, 150);
            _devicePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            _devicePictureBox.TabIndex = 0;
            _devicePictureBox.TabStop = false;
            // 
            // _chooseImageButton
            // 
            _chooseImageButton.AutoSize = true;
            _chooseImageButton.Location = new Point(3, 159);
            _chooseImageButton.Name = "_chooseImageButton";
            _chooseImageButton.Size = new Size(132, 30);
            _chooseImageButton.TabIndex = 1;
            _chooseImageButton.Text = "Chọn ảnh thiết bị";
            // 
            // _actionButtons
            // 
            _actionButtons.AutoSize = true;
            _entryLayout.SetColumnSpan(_actionButtons, 2);
            _actionButtons.Controls.Add(_addButton);
            _actionButtons.Controls.Add(_updateButton);
            _actionButtons.Controls.Add(_deleteButton);
            _actionButtons.Controls.Add(_clearButton);
            _actionButtons.Dock = DockStyle.Fill;
            _actionButtons.Location = new Point(7, 522);
            _actionButtons.Name = "_actionButtons";
            _actionButtons.Size = new Size(511, 36);
            _actionButtons.TabIndex = 18;
            // 
            // _addButton
            // 
            _addButton.AutoSize = true;
            _addButton.Location = new Point(3, 3);
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(75, 30);
            _addButton.TabIndex = 0;
            _addButton.Text = "Thêm";
            // 
            // _updateButton
            // 
            _updateButton.AutoSize = true;
            _updateButton.Location = new Point(84, 3);
            _updateButton.Name = "_updateButton";
            _updateButton.Size = new Size(78, 30);
            _updateButton.TabIndex = 1;
            _updateButton.Text = "Cập nhật";
            // 
            // _deleteButton
            // 
            _deleteButton.AutoSize = true;
            _deleteButton.Location = new Point(168, 3);
            _deleteButton.Name = "_deleteButton";
            _deleteButton.Size = new Size(75, 30);
            _deleteButton.TabIndex = 2;
            _deleteButton.Text = "Xóa";
            // 
            // _clearButton
            // 
            _clearButton.AutoSize = true;
            _clearButton.Location = new Point(249, 3);
            _clearButton.Name = "_clearButton";
            _clearButton.Size = new Size(77, 30);
            _clearButton.TabIndex = 3;
            _clearButton.Text = "Làm mới";
            // 
            // _listPanel
            // 
            _listPanel.ColumnCount = 1;
            _listPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _listPanel.Controls.Add(_filterPanel, 0, 0);
            _listPanel.Controls.Add(_ordersGrid, 0, 1);
            _listPanel.Dock = DockStyle.Fill;
            _listPanel.Location = new Point(554, 13);
            _listPanel.Name = "_listPanel";
            _listPanel.RowCount = 2;
            _listPanel.RowStyles.Add(new RowStyle());
            _listPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _listPanel.Size = new Size(713, 700);
            _listPanel.TabIndex = 1;
            // 
            // _filterPanel
            // 
            _filterPanel.AutoSize = true;
            _filterPanel.Controls.Add(_searchLabel);
            _filterPanel.Controls.Add(_searchTextBox);
            _filterPanel.Controls.Add(_statusFilterLabel);
            _filterPanel.Controls.Add(_statusFilterComboBox);
            _filterPanel.Dock = DockStyle.Fill;
            _filterPanel.Location = new Point(3, 3);
            _filterPanel.Name = "_filterPanel";
            _filterPanel.Padding = new Padding(0, 0, 0, 8);
            _filterPanel.Size = new Size(707, 42);
            _filterPanel.TabIndex = 0;
            // 
            // _searchLabel
            // 
            _searchLabel.AutoSize = true;
            _searchLabel.Location = new Point(3, 0);
            _searchLabel.Name = "_searchLabel";
            _searchLabel.Padding = new Padding(0, 8, 0, 0);
            _searchLabel.Size = new Size(70, 28);
            _searchLabel.TabIndex = 0;
            _searchLabel.Text = "Tìm kiếm";
            // 
            // _searchTextBox
            // 
            _searchTextBox.Location = new Point(79, 3);
            _searchTextBox.Name = "_searchTextBox";
            _searchTextBox.Size = new Size(220, 27);
            _searchTextBox.TabIndex = 1;
            // 
            // _statusFilterLabel
            // 
            _statusFilterLabel.AutoSize = true;
            _statusFilterLabel.Location = new Point(305, 0);
            _statusFilterLabel.Name = "_statusFilterLabel";
            _statusFilterLabel.Padding = new Padding(8, 8, 0, 0);
            _statusFilterLabel.Size = new Size(108, 28);
            _statusFilterLabel.TabIndex = 2;
            _statusFilterLabel.Text = "Lọc trạng thái";
            // 
            // _statusFilterComboBox
            // 
            _statusFilterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _statusFilterComboBox.Items.AddRange(new object[] { "Tất cả trạng thái", "Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy" });
            _statusFilterComboBox.Location = new Point(419, 3);
            _statusFilterComboBox.Name = "_statusFilterComboBox";
            _statusFilterComboBox.Size = new Size(121, 28);
            _statusFilterComboBox.TabIndex = 3;
            // 
            // _ordersGrid
            // 
            _ordersGrid.AllowUserToAddRows = false;
            _ordersGrid.AllowUserToDeleteRows = false;
            _ordersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _ordersGrid.ColumnHeadersHeight = 29;
            _ordersGrid.Dock = DockStyle.Fill;
            _ordersGrid.Location = new Point(3, 51);
            _ordersGrid.MultiSelect = false;
            _ordersGrid.Name = "_ordersGrid";
            _ordersGrid.ReadOnly = true;
            _ordersGrid.RowHeadersWidth = 51;
            _ordersGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _ordersGrid.Size = new Size(707, 646);
            _ordersGrid.TabIndex = 1;
            // 
            // _menuStrip
            // 
            _menuStrip.ImageScalingSize = new Size(20, 20);
            _menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu });
            _menuStrip.Location = new Point(0, 0);
            _menuStrip.Name = "_menuStrip";
            _menuStrip.Size = new Size(1280, 28);
            _menuStrip.TabIndex = 2;
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { _exportMenuItem, _exitMenuItem });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(48, 24);
            fileMenu.Text = "Tệp";
            // 
            // _exportMenuItem
            // 
            _exportMenuItem.Name = "_exportMenuItem";
            _exportMenuItem.Size = new Size(330, 26);
            _exportMenuItem.Text = "Xuất danh sách đang hiển thị ra CSV";
            // 
            // _exitMenuItem
            // 
            _exitMenuItem.Name = "_exitMenuItem";
            _exitMenuItem.Size = new Size(330, 26);
            _exitMenuItem.Text = "Thoát";
            // 
            // _statusStrip
            // 
            _statusStrip.ImageScalingSize = new Size(20, 20);
            _statusStrip.Items.AddRange(new ToolStripItem[] { _orderCountLabel, _estimatedTotalLabel });
            _statusStrip.Location = new Point(0, 754);
            _statusStrip.Name = "_statusStrip";
            _statusStrip.Size = new Size(1280, 26);
            _statusStrip.TabIndex = 1;
            // 
            // _orderCountLabel
            // 
            _orderCountLabel.Name = "_orderCountLabel";
            _orderCountLabel.Size = new Size(162, 20);
            _orderCountLabel.Text = "Số đơn đang hiển thị: 0";
            // 
            // _estimatedTotalLabel
            // 
            _estimatedTotalLabel.Name = "_estimatedTotalLabel";
            _estimatedTotalLabel.Size = new Size(206, 20);
            _estimatedTotalLabel.Text = "Tổng dự kiến chưa hoàn tất: 0";
            // 
            // _errorProvider
            // 
            _errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 780);
            Controls.Add(_mainLayout);
            Controls.Add(_statusStrip);
            Controls.Add(_menuStrip);
            MainMenuStrip = _menuStrip;
            MinimumSize = new Size(900, 620);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý đơn sửa chữa";
            _mainLayout.ResumeLayout(false);
            _entryPanel.ResumeLayout(false);
            _entryPanel.PerformLayout();
            _entryLayout.ResumeLayout(false);
            _entryLayout.PerformLayout();
            _imagePanel.ResumeLayout(false);
            _imagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_devicePictureBox).EndInit();
            _actionButtons.ResumeLayout(false);
            _actionButtons.PerformLayout();
            _listPanel.ResumeLayout(false);
            _listPanel.PerformLayout();
            _filterPanel.ResumeLayout(false);
            _filterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_ordersGrid).EndInit();
            _menuStrip.ResumeLayout(false);
            _menuStrip.PerformLayout();
            _statusStrip.ResumeLayout(false);
            _statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_bindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)_errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem fileMenu;
    }
}