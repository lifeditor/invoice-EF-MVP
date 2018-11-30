namespace Invoice
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnCreate = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.dgvInvoiceList = new System.Windows.Forms.DataGridView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBookBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBookSale = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.InvoiceNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierINN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierKPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliverFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliverTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerINN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerKPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Option = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceList)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreate,
            this.btnEdit,
            this.btnDelete,
            this.toolStripSeparator1,
            this.btnPrint});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1103, 50);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSize = false;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 47);
            this.btnCreate.Text = "Создать";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = false;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 47);
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 47);
            this.btnDelete.Text = "Удалить";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSize = false;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 47);
            this.btnPrint.Text = "С/ф в Excel";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dgvInvoiceList
            // 
            this.dgvInvoiceList.AllowUserToAddRows = false;
            this.dgvInvoiceList.AllowUserToDeleteRows = false;
            this.dgvInvoiceList.AllowUserToResizeRows = false;
            this.dgvInvoiceList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInvoiceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoiceList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoiceList.ColumnHeadersHeight = 30;
            this.dgvInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInvoiceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceNum,
            this.InvoiceDate,
            this.Id,
            this.SupplierName,
            this.SupplierAddr,
            this.SupplierINN,
            this.SupplierKPP,
            this.DeliverFrom,
            this.DeliverTo,
            this.OrderNum,
            this.OrderDate,
            this.CustomerName,
            this.CustomerAddr,
            this.CustomerINN,
            this.CustomerKPP,
            this.OpCode,
            this.Option,
            this.Articles});
            this.dgvInvoiceList.ContextMenuStrip = this.contextMenu;
            this.dgvInvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInvoiceList.EnableHeadersVisualStyles = false;
            this.dgvInvoiceList.Location = new System.Drawing.Point(0, 74);
            this.dgvInvoiceList.MultiSelect = false;
            this.dgvInvoiceList.Name = "dgvInvoiceList";
            this.dgvInvoiceList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInvoiceList.RowHeadersWidth = 25;
            this.dgvInvoiceList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInvoiceList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            this.dgvInvoiceList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceList.ShowEditingIcon = false;
            this.dgvInvoiceList.Size = new System.Drawing.Size(1103, 529);
            this.dgvInvoiceList.TabIndex = 1;
            this.dgvInvoiceList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceList_CellDoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cnEdit,
            this.toolStripSeparator2,
            this.cnExport,
            this.toolStripSeparator3,
            this.cnDelete});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(195, 82);
            // 
            // cnEdit
            // 
            this.cnEdit.Image = ((System.Drawing.Image)(resources.GetObject("cnEdit.Image")));
            this.cnEdit.Name = "cnEdit";
            this.cnEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.cnEdit.Size = new System.Drawing.Size(194, 22);
            this.cnEdit.Text = "Редактировать";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // cnExport
            // 
            this.cnExport.Image = ((System.Drawing.Image)(resources.GetObject("cnExport.Image")));
            this.cnExport.Name = "cnExport";
            this.cnExport.Size = new System.Drawing.Size(194, 22);
            this.cnExport.Text = "С/ф в Excel";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(191, 6);
            // 
            // cnDelete
            // 
            this.cnDelete.Image = ((System.Drawing.Image)(resources.GetObject("cnDelete.Image")));
            this.cnDelete.Name = "cnDelete";
            this.cnDelete.Size = new System.Drawing.Size(194, 22);
            this.cnDelete.Text = "Удалить";
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInvoice,
            this.menuReport});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1103, 24);
            this.menuMain.TabIndex = 2;
            this.menuMain.Text = "MainMenu";
            // 
            // menuInvoice
            // 
            this.menuInvoice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.toolStripSeparator4,
            this.menuEdit,
            this.toolStripSeparator5,
            this.menuDelete});
            this.menuInvoice.Name = "menuInvoice";
            this.menuInvoice.Size = new System.Drawing.Size(95, 20);
            this.menuInvoice.Text = "Счет-фактура";
            // 
            // menuNew
            // 
            this.menuNew.Image = ((System.Drawing.Image)(resources.GetObject("menuNew.Image")));
            this.menuNew.Name = "menuNew";
            this.menuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNew.Size = new System.Drawing.Size(194, 22);
            this.menuNew.Text = "Создать";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(191, 6);
            // 
            // menuEdit
            // 
            this.menuEdit.Image = ((System.Drawing.Image)(resources.GetObject("menuEdit.Image")));
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuEdit.Size = new System.Drawing.Size(194, 22);
            this.menuEdit.Text = "Редактировать";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(191, 6);
            // 
            // menuDelete
            // 
            this.menuDelete.Image = ((System.Drawing.Image)(resources.GetObject("menuDelete.Image")));
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(194, 22);
            this.menuDelete.Text = "Удалить";
            // 
            // menuReport
            // 
            this.menuReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBookBuy,
            this.menuBookSale});
            this.menuReport.Name = "menuReport";
            this.menuReport.Size = new System.Drawing.Size(60, 20);
            this.menuReport.Text = "Отчеты";
            // 
            // menuBookBuy
            // 
            this.menuBookBuy.Name = "menuBookBuy";
            this.menuBookBuy.Size = new System.Drawing.Size(155, 22);
            this.menuBookBuy.Text = "Книга покупок";
            // 
            // menuBookSale
            // 
            this.menuBookSale.Name = "menuBookSale";
            this.menuBookSale.Size = new System.Drawing.Size(155, 22);
            this.menuBookSale.Text = "Книга продаж";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.progressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 581);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1103, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(23, 17);
            this.toolStripStatusLabel.Text = "OK";
            // 
            // progressBar
            // 
            this.progressBar.AutoSize = false;
            this.progressBar.ForeColor = System.Drawing.Color.SandyBrown;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(500, 16);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "New.ico");
            this.imageList.Images.SetKeyName(1, "Edit.ico");
            this.imageList.Images.SetKeyName(2, "Delete.ico");
            this.imageList.Images.SetKeyName(3, "Export.ico");
            this.imageList.Images.SetKeyName(4, "Print.ico");
            this.imageList.Images.SetKeyName(5, "Add.ico");
            this.imageList.Images.SetKeyName(6, "Remove.ico");
            this.imageList.Images.SetKeyName(7, "Save.ico");
            this.imageList.Images.SetKeyName(8, "Cancel.ico");
            this.imageList.Images.SetKeyName(9, "Find.ico");
            // 
            // InvoiceNum
            // 
            this.InvoiceNum.DataPropertyName = "InvoiceNum";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.InvoiceNum.DefaultCellStyle = dataGridViewCellStyle2;
            this.InvoiceNum.HeaderText = "Номер с/ф";
            this.InvoiceNum.Name = "InvoiceNum";
            this.InvoiceNum.ReadOnly = true;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.DataPropertyName = "InvoiceDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.InvoiceDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.InvoiceDate.HeaderText = "Дата с/ф";
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "Продавец";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.Width = 350;
            // 
            // SupplierAddr
            // 
            this.SupplierAddr.DataPropertyName = "SupplierAddr";
            this.SupplierAddr.HeaderText = "SupplierAddr";
            this.SupplierAddr.Name = "SupplierAddr";
            this.SupplierAddr.ReadOnly = true;
            this.SupplierAddr.Visible = false;
            // 
            // SupplierINN
            // 
            this.SupplierINN.DataPropertyName = "SupplierINN";
            this.SupplierINN.HeaderText = "SupplierINN";
            this.SupplierINN.Name = "SupplierINN";
            this.SupplierINN.ReadOnly = true;
            this.SupplierINN.Visible = false;
            // 
            // SupplierKPP
            // 
            this.SupplierKPP.DataPropertyName = "SupplierKPP";
            this.SupplierKPP.HeaderText = "SupplierKPP";
            this.SupplierKPP.Name = "SupplierKPP";
            this.SupplierKPP.ReadOnly = true;
            this.SupplierKPP.Visible = false;
            // 
            // DeliverFrom
            // 
            this.DeliverFrom.DataPropertyName = "DeliverFrom";
            this.DeliverFrom.HeaderText = "DeliverFrom";
            this.DeliverFrom.Name = "DeliverFrom";
            this.DeliverFrom.ReadOnly = true;
            this.DeliverFrom.Visible = false;
            // 
            // DeliverTo
            // 
            this.DeliverTo.DataPropertyName = "DeliverTo";
            this.DeliverTo.HeaderText = "DeliverTo";
            this.DeliverTo.Name = "DeliverTo";
            this.DeliverTo.ReadOnly = true;
            this.DeliverTo.Visible = false;
            // 
            // OrderNum
            // 
            this.OrderNum.DataPropertyName = "OrderNum";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OrderNum.DefaultCellStyle = dataGridViewCellStyle4;
            this.OrderNum.HeaderText = "Номер ордера";
            this.OrderNum.Name = "OrderNum";
            this.OrderNum.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OrderDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.OrderDate.HeaderText = "Дата ордера";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Покупатель";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // CustomerAddr
            // 
            this.CustomerAddr.DataPropertyName = "CustomerAddr";
            this.CustomerAddr.HeaderText = "CustomerAddr";
            this.CustomerAddr.Name = "CustomerAddr";
            this.CustomerAddr.ReadOnly = true;
            this.CustomerAddr.Visible = false;
            // 
            // CustomerINN
            // 
            this.CustomerINN.DataPropertyName = "CustomerINN";
            this.CustomerINN.HeaderText = "CustomerINN";
            this.CustomerINN.Name = "CustomerINN";
            this.CustomerINN.ReadOnly = true;
            this.CustomerINN.Visible = false;
            // 
            // CustomerKPP
            // 
            this.CustomerKPP.DataPropertyName = "CustomerKPP";
            this.CustomerKPP.HeaderText = "CustomerKPP";
            this.CustomerKPP.Name = "CustomerKPP";
            this.CustomerKPP.ReadOnly = true;
            this.CustomerKPP.Visible = false;
            // 
            // OpCode
            // 
            this.OpCode.DataPropertyName = "OpCode";
            this.OpCode.HeaderText = "OpCode";
            this.OpCode.Name = "OpCode";
            this.OpCode.ReadOnly = true;
            this.OpCode.Visible = false;
            // 
            // Option
            // 
            this.Option.DataPropertyName = "OptionField";
            this.Option.HeaderText = "Option";
            this.Option.Name = "Option";
            this.Option.ReadOnly = true;
            this.Option.Visible = false;
            // 
            // Articles
            // 
            this.Articles.DataPropertyName = "Articles";
            this.Articles.HeaderText = "Articles";
            this.Articles.Name = "Articles";
            this.Articles.ReadOnly = true;
            this.Articles.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 603);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.dgvInvoiceList);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoices";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceList)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.DataGridView dgvInvoiceList;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripButton btnCreate;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripMenuItem menuInvoice;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripMenuItem menuReport;
        private System.Windows.Forms.ToolStripMenuItem menuBookBuy;
        private System.Windows.Forms.ToolStripMenuItem menuBookSale;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem cnEdit;
        private System.Windows.Forms.ToolStripMenuItem cnExport;
        private System.Windows.Forms.ToolStripMenuItem cnDelete;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierINN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierKPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliverFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliverTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerINN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerKPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Option;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articles;
    }
}

