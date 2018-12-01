namespace Invoice
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.eInvoiceNum = new System.Windows.Forms.TextBox();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eCustomerKPP = new System.Windows.Forms.TextBox();
            this.eCustomerINN = new System.Windows.Forms.TextBox();
            this.eCustomerAddr = new System.Windows.Forms.TextBox();
            this.eCustomerName = new System.Windows.Forms.TextBox();
            this.eOrderNum = new System.Windows.Forms.TextBox();
            this.eDeliverTo = new System.Windows.Forms.TextBox();
            this.eDeliverFrom = new System.Windows.Forms.TextBox();
            this.eSupplierKPP = new System.Windows.Forms.TextBox();
            this.eSupplierINN = new System.Windows.Forms.TextBox();
            this.eSupplierAddr = new System.Windows.Forms.TextBox();
            this.eSupplierName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvArticleList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eOpCode = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtInvoiceDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eInvoiceNum
            // 
            this.eInvoiceNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eInvoiceNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceNum", true));
            this.eInvoiceNum.Location = new System.Drawing.Point(239, 5);
            this.eInvoiceNum.Name = "eInvoiceNum";
            this.eInvoiceNum.Size = new System.Drawing.Size(100, 20);
            this.eInvoiceNum.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 451);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 54);
            this.panel1.TabIndex = 50;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(147, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Удалить товар";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(12, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Добавить товар";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(766, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(197, 39);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(557, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(197, 39);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(12, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 15);
            this.label14.TabIndex = 64;
            this.label14.Text = "ИНН покупателя";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(12, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 15);
            this.label13.TabIndex = 63;
            this.label13.Text = "Адрес покупателя";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(12, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 15);
            this.label12.TabIndex = 62;
            this.label12.Text = "Покупатель";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(603, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 15);
            this.label11.TabIndex = 61;
            this.label11.Text = "Код вида операции";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 15);
            this.label9.TabIndex = 60;
            this.label9.Text = "К платежно-расчетному док. №";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 15);
            this.label8.TabIndex = 59;
            this.label8.Text = "Грузополучатель и его адрес";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 15);
            this.label7.TabIndex = 58;
            this.label7.Text = "Грузоотправитель и его адрес";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(435, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 57;
            this.label6.Text = "КПП продавца";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 56;
            this.label5.Text = "ИНН продавца";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 55;
            this.label4.Text = "Адрес продавца";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "Продавец";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Счет-фактура №";
            // 
            // eCustomerKPP
            // 
            this.eCustomerKPP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eCustomerKPP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "CustomerKPP", true));
            this.eCustomerKPP.Location = new System.Drawing.Point(542, 238);
            this.eCustomerKPP.MaxLength = 9;
            this.eCustomerKPP.Name = "eCustomerKPP";
            this.eCustomerKPP.Size = new System.Drawing.Size(120, 20);
            this.eCustomerKPP.TabIndex = 15;
            // 
            // eCustomerINN
            // 
            this.eCustomerINN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eCustomerINN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "CustomerINN", true));
            this.eCustomerINN.Location = new System.Drawing.Point(239, 238);
            this.eCustomerINN.MaxLength = 12;
            this.eCustomerINN.Name = "eCustomerINN";
            this.eCustomerINN.Size = new System.Drawing.Size(120, 20);
            this.eCustomerINN.TabIndex = 14;
            // 
            // eCustomerAddr
            // 
            this.eCustomerAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eCustomerAddr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "CustomerAddr", true));
            this.eCustomerAddr.Location = new System.Drawing.Point(239, 212);
            this.eCustomerAddr.Name = "eCustomerAddr";
            this.eCustomerAddr.Size = new System.Drawing.Size(714, 20);
            this.eCustomerAddr.TabIndex = 13;
            // 
            // eCustomerName
            // 
            this.eCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "CustomerName", true));
            this.eCustomerName.Location = new System.Drawing.Point(239, 186);
            this.eCustomerName.Name = "eCustomerName";
            this.eCustomerName.Size = new System.Drawing.Size(714, 20);
            this.eCustomerName.TabIndex = 12;
            // 
            // eOrderNum
            // 
            this.eOrderNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eOrderNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "OrderNum", true));
            this.eOrderNum.Location = new System.Drawing.Point(239, 160);
            this.eOrderNum.Name = "eOrderNum";
            this.eOrderNum.Size = new System.Drawing.Size(81, 20);
            this.eOrderNum.TabIndex = 10;
            // 
            // eDeliverTo
            // 
            this.eDeliverTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eDeliverTo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "DeliverTo", true));
            this.eDeliverTo.Location = new System.Drawing.Point(239, 134);
            this.eDeliverTo.Name = "eDeliverTo";
            this.eDeliverTo.Size = new System.Drawing.Size(714, 20);
            this.eDeliverTo.TabIndex = 9;
            // 
            // eDeliverFrom
            // 
            this.eDeliverFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eDeliverFrom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "DeliverFrom", true));
            this.eDeliverFrom.Location = new System.Drawing.Point(239, 108);
            this.eDeliverFrom.Name = "eDeliverFrom";
            this.eDeliverFrom.Size = new System.Drawing.Size(714, 20);
            this.eDeliverFrom.TabIndex = 8;
            // 
            // eSupplierKPP
            // 
            this.eSupplierKPP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eSupplierKPP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "SupplierKPP", true));
            this.eSupplierKPP.Location = new System.Drawing.Point(542, 81);
            this.eSupplierKPP.MaxLength = 9;
            this.eSupplierKPP.Name = "eSupplierKPP";
            this.eSupplierKPP.Size = new System.Drawing.Size(115, 20);
            this.eSupplierKPP.TabIndex = 7;
            // 
            // eSupplierINN
            // 
            this.eSupplierINN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eSupplierINN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "SupplierINN", true));
            this.eSupplierINN.Location = new System.Drawing.Point(239, 82);
            this.eSupplierINN.MaxLength = 12;
            this.eSupplierINN.Name = "eSupplierINN";
            this.eSupplierINN.Size = new System.Drawing.Size(120, 20);
            this.eSupplierINN.TabIndex = 6;
            // 
            // eSupplierAddr
            // 
            this.eSupplierAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eSupplierAddr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "SupplierAddr", true));
            this.eSupplierAddr.Location = new System.Drawing.Point(239, 56);
            this.eSupplierAddr.Name = "eSupplierAddr";
            this.eSupplierAddr.Size = new System.Drawing.Size(714, 20);
            this.eSupplierAddr.TabIndex = 5;
            // 
            // eSupplierName
            // 
            this.eSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eSupplierName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "SupplierName", true));
            this.eSupplierName.Location = new System.Drawing.Point(239, 30);
            this.eSupplierName.Name = "eSupplierName";
            this.eSupplierName.Size = new System.Drawing.Size(714, 20);
            this.eSupplierName.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(357, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 15);
            this.label10.TabIndex = 66;
            this.label10.Text = "от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(357, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "от";
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "OrderDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.dtOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOrderDate.Location = new System.Drawing.Point(384, 160);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(102, 20);
            this.dtOrderDate.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(433, 243);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 15);
            this.label15.TabIndex = 68;
            this.label15.Text = "КПП покупателя";
            // 
            // dgvArticleList
            // 
            this.dgvArticleList.AccessibleName = "";
            this.dgvArticleList.AllowUserToAddRows = false;
            this.dgvArticleList.AllowUserToDeleteRows = false;
            this.dgvArticleList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvArticleList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticleList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvArticleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.InvoiceID,
            this.ArtName,
            this.Units,
            this.Quantity,
            this.Price,
            this.NetAmount,
            this.Tax,
            this.TaxRate,
            this.TaxAmount,
            this.GrossAmount,
            this.Country,
            this.CDNumber,
            this.Invoice});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticleList.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgvArticleList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvArticleList.EnableHeadersVisualStyles = false;
            this.dgvArticleList.Location = new System.Drawing.Point(0, 279);
            this.dgvArticleList.MultiSelect = false;
            this.dgvArticleList.Name = "dgvArticleList";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticleList.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvArticleList.RowHeadersWidth = 25;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White;
            this.dgvArticleList.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvArticleList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            this.dgvArticleList.RowTemplate.Height = 20;
            this.dgvArticleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvArticleList.ShowCellErrors = false;
            this.dgvArticleList.ShowRowErrors = false;
            this.dgvArticleList.Size = new System.Drawing.Size(975, 172);
            this.dgvArticleList.TabIndex = 16;
            this.dgvArticleList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvArticleList_DataError);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // InvoiceID
            // 
            this.InvoiceID.DataPropertyName = "InvoiceId";
            this.InvoiceID.HeaderText = "InvoiceId";
            this.InvoiceID.Name = "InvoiceID";
            this.InvoiceID.Visible = false;
            // 
            // ArtName
            // 
            this.ArtName.DataPropertyName = "ArtName";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ArtName.DefaultCellStyle = dataGridViewCellStyle17;
            this.ArtName.HeaderText = "Наименование товара";
            this.ArtName.Name = "ArtName";
            this.ArtName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ArtName.Width = 320;
            // 
            // Units
            // 
            this.Units.DataPropertyName = "Units";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Units.DefaultCellStyle = dataGridViewCellStyle18;
            this.Units.HeaderText = "Ед. изм.";
            this.Units.Name = "Units";
            this.Units.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Units.Width = 30;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle19;
            this.Quantity.HeaderText = "Кол-во";
            this.Quantity.Name = "Quantity";
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantity.Width = 50;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N2";
            dataGridViewCellStyle20.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle20;
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Price.Width = 60;
            // 
            // NetAmount
            // 
            this.NetAmount.DataPropertyName = "NetAmount";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "N2";
            dataGridViewCellStyle21.NullValue = null;
            this.NetAmount.DefaultCellStyle = dataGridViewCellStyle21;
            this.NetAmount.HeaderText = "Сумма без налога";
            this.NetAmount.Name = "NetAmount";
            this.NetAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NetAmount.Width = 60;
            // 
            // Tax
            // 
            this.Tax.DataPropertyName = "Tax";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N2";
            dataGridViewCellStyle22.NullValue = null;
            this.Tax.DefaultCellStyle = dataGridViewCellStyle22;
            this.Tax.HeaderText = "Акциз";
            this.Tax.Name = "Tax";
            this.Tax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Tax.Width = 60;
            // 
            // TaxRate
            // 
            this.TaxRate.DataPropertyName = "TaxRate";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.NullValue = null;
            this.TaxRate.DefaultCellStyle = dataGridViewCellStyle23;
            this.TaxRate.HeaderText = "Ставка налога";
            this.TaxRate.Name = "TaxRate";
            this.TaxRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TaxRate.Width = 60;
            // 
            // TaxAmount
            // 
            this.TaxAmount.DataPropertyName = "TaxAmount";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.Format = "N2";
            dataGridViewCellStyle24.NullValue = null;
            this.TaxAmount.DefaultCellStyle = dataGridViewCellStyle24;
            this.TaxAmount.HeaderText = "Сумма налога";
            this.TaxAmount.Name = "TaxAmount";
            this.TaxAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TaxAmount.Width = 60;
            // 
            // GrossAmount
            // 
            this.GrossAmount.DataPropertyName = "GrossAmount";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle25.Format = "N2";
            dataGridViewCellStyle25.NullValue = null;
            this.GrossAmount.DefaultCellStyle = dataGridViewCellStyle25;
            this.GrossAmount.HeaderText = "Сумма с налогом";
            this.GrossAmount.Name = "GrossAmount";
            this.GrossAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GrossAmount.Width = 60;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Country.DefaultCellStyle = dataGridViewCellStyle26;
            this.Country.HeaderText = "Страна происхождения";
            this.Country.Name = "Country";
            this.Country.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CDNumber
            // 
            this.CDNumber.DataPropertyName = "CDNumber";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CDNumber.DefaultCellStyle = dataGridViewCellStyle27;
            this.CDNumber.HeaderText = "№ таможенной декларации";
            this.CDNumber.Name = "CDNumber";
            this.CDNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CDNumber.Width = 75;
            // 
            // Invoice
            // 
            this.Invoice.DataPropertyName = "Invoice";
            this.Invoice.HeaderText = "Invoice";
            this.Invoice.Name = "Invoice";
            this.Invoice.Visible = false;
            // 
            // eOpCode
            // 
            this.eOpCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eOpCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "OpCode", true));
            this.eOpCode.Location = new System.Drawing.Point(728, 4);
            this.eOpCode.MaxLength = 2;
            this.eOpCode.Name = "eOpCode";
            this.eOpCode.Size = new System.Drawing.Size(26, 20);
            this.eOpCode.TabIndex = 3;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dtInvoiceDate
            // 
            this.dtInvoiceDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "InvoiceDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.dtInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInvoiceDate.Location = new System.Drawing.Point(384, 3);
            this.dtInvoiceDate.Name = "dtInvoiceDate";
            this.dtInvoiceDate.Size = new System.Drawing.Size(102, 20);
            this.dtInvoiceDate.TabIndex = 1;
            // 
            // EditForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(975, 505);
            this.Controls.Add(this.dtInvoiceDate);
            this.Controls.Add(this.eOpCode);
            this.Controls.Add(this.dgvArticleList);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtOrderDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eCustomerKPP);
            this.Controls.Add(this.eCustomerINN);
            this.Controls.Add(this.eCustomerAddr);
            this.Controls.Add(this.eCustomerName);
            this.Controls.Add(this.eOrderNum);
            this.Controls.Add(this.eDeliverTo);
            this.Controls.Add(this.eDeliverFrom);
            this.Controls.Add(this.eSupplierKPP);
            this.Controls.Add(this.eSupplierINN);
            this.Controls.Add(this.eSupplierAddr);
            this.Controls.Add(this.eSupplierName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.eInvoiceNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Invoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditForm_FormClosing);
            this.Shown += new System.EventHandler(this.EditForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eInvoiceNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.BindingSource articleBindingSource;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox eCustomerKPP;
        public System.Windows.Forms.TextBox eCustomerINN;
        public System.Windows.Forms.TextBox eCustomerAddr;
        public System.Windows.Forms.TextBox eCustomerName;
        public System.Windows.Forms.TextBox eOrderNum;
        public System.Windows.Forms.TextBox eDeliverTo;
        public System.Windows.Forms.TextBox eDeliverFrom;
        public System.Windows.Forms.TextBox eSupplierKPP;
        public System.Windows.Forms.TextBox eSupplierINN;
        public System.Windows.Forms.TextBox eSupplierAddr;
        public System.Windows.Forms.TextBox eSupplierName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvArticleList;
        private System.Windows.Forms.TextBox eOpCode;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice;
        private System.Windows.Forms.DateTimePicker dtInvoiceDate;
    }
}