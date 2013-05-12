namespace _12306_Helper
{
    partial class formPassengersEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPassenger = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddPassenger = new System.Windows.Forms.Button();
            this.cboIDType = new System.Windows.Forms.ComboBox();
            this.txtIDCode = new System.Windows.Forms.TextBox();
            this.txtMobileNO = new System.Windows.Forms.TextBox();
            this.cboTicketType = new System.Windows.Forms.ComboBox();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblMini = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.passenger_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passenger_type_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.passenger_id_type_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.card_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caozuo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassenger)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.dgvPassenger);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(5, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 304);
            this.panel1.TabIndex = 0;
            // 
            // dgvPassenger
            // 
            this.dgvPassenger.AllowUserToAddRows = false;
            this.dgvPassenger.AllowUserToDeleteRows = false;
            this.dgvPassenger.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.dgvPassenger.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPassenger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPassenger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPassenger.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassenger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.passenger_name,
            this.passenger_type_name,
            this.passenger_id_type_name,
            this.card_no,
            this.mobile_no,
            this.caozuo});
            this.dgvPassenger.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvPassenger.Location = new System.Drawing.Point(4, 53);
            this.dgvPassenger.MultiSelect = false;
            this.dgvPassenger.Name = "dgvPassenger";
            this.dgvPassenger.RowHeadersVisible = false;
            this.dgvPassenger.RowTemplate.Height = 21;
            this.dgvPassenger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassenger.Size = new System.Drawing.Size(832, 247);
            this.dgvPassenger.TabIndex = 38;
            this.dgvPassenger.DataSourceChanged += new System.EventHandler(this.dgvPassenger_DataSourceChanged);
            this.dgvPassenger.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPassenger_CellClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAddPassenger);
            this.panel3.Controls.Add(this.cboIDType);
            this.panel3.Controls.Add(this.txtIDCode);
            this.panel3.Controls.Add(this.txtMobileNO);
            this.panel3.Controls.Add(this.cboTicketType);
            this.panel3.Controls.Add(this.txtPassengerName);
            this.panel3.Controls.Add(this.label30);
            this.panel3.Controls.Add(this.label31);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.label34);
            this.panel3.Controls.Add(this.label35);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(832, 43);
            this.panel3.TabIndex = 7;
            // 
            // btnAddPassenger
            // 
            this.btnAddPassenger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPassenger.Location = new System.Drawing.Point(750, 10);
            this.btnAddPassenger.Name = "btnAddPassenger";
            this.btnAddPassenger.Size = new System.Drawing.Size(67, 23);
            this.btnAddPassenger.TabIndex = 25;
            this.btnAddPassenger.Text = "添加";
            this.btnAddPassenger.UseVisualStyleBackColor = true;
            // 
            // cboIDType
            // 
            this.cboIDType.FormattingEnabled = true;
            this.cboIDType.Items.AddRange(new object[] {
            "二代身份证",
            "一代身份证",
            "港澳通行证",
            "台湾通行证",
            "护照"});
            this.cboIDType.Location = new System.Drawing.Point(311, 11);
            this.cboIDType.Name = "cboIDType";
            this.cboIDType.Size = new System.Drawing.Size(84, 20);
            this.cboIDType.TabIndex = 24;
            this.cboIDType.Text = "二代身份证";
            // 
            // txtIDCode
            // 
            this.txtIDCode.Location = new System.Drawing.Point(453, 11);
            this.txtIDCode.MaxLength = 18;
            this.txtIDCode.Name = "txtIDCode";
            this.txtIDCode.Size = new System.Drawing.Size(123, 21);
            this.txtIDCode.TabIndex = 23;
            // 
            // txtMobileNO
            // 
            this.txtMobileNO.Location = new System.Drawing.Point(629, 11);
            this.txtMobileNO.MaxLength = 11;
            this.txtMobileNO.Name = "txtMobileNO";
            this.txtMobileNO.Size = new System.Drawing.Size(99, 21);
            this.txtMobileNO.TabIndex = 22;
            // 
            // cboTicketType
            // 
            this.cboTicketType.FormattingEnabled = true;
            this.cboTicketType.Items.AddRange(new object[] {
            "成人",
            "儿童",
            "学生",
            "残军"});
            this.cboTicketType.Location = new System.Drawing.Point(168, 11);
            this.cboTicketType.Name = "cboTicketType";
            this.cboTicketType.Size = new System.Drawing.Size(76, 20);
            this.cboTicketType.TabIndex = 19;
            this.cboTicketType.Text = "成人票";
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(50, 11);
            this.txtPassengerName.MaxLength = 20;
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(77, 21);
            this.txtPassengerName.TabIndex = 18;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(15, 14);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(29, 12);
            this.label30.TabIndex = 17;
            this.label30.Text = "姓名";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(582, 15);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(41, 12);
            this.label31.TabIndex = 16;
            this.label31.Text = "手机号";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(406, 14);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(41, 12);
            this.label33.TabIndex = 14;
            this.label33.Text = "证件号";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(252, 16);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(53, 12);
            this.label34.TabIndex = 13;
            this.label34.Text = "证件类型";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(133, 15);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(29, 12);
            this.label35.TabIndex = 12;
            this.label35.Text = "票种";
            // 
            // lblTop
            // 
            this.lblTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTop.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.lblTop.ForeColor = System.Drawing.Color.Blue;
            this.lblTop.Location = new System.Drawing.Point(0, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(850, 29);
            this.lblTop.TabIndex = 49;
            this.lblTop.Text = "编 辑 联 系 人";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTop_MouseDown);
            // 
            // lblMini
            // 
            this.lblMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblMini.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMini.ForeColor = System.Drawing.Color.White;
            this.lblMini.Location = new System.Drawing.Point(810, 6);
            this.lblMini.Name = "lblMini";
            this.lblMini.Size = new System.Drawing.Size(16, 16);
            this.lblMini.TabIndex = 53;
            this.lblMini.Text = "－";
            this.lblMini.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMini.Click += new System.EventHandler(this.lblMini_Click);
            this.lblMini.MouseEnter += new System.EventHandler(this.lblMini_MouseEnter);
            this.lblMini.MouseLeave += new System.EventHandler(this.lblMini_MouseLeave);
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(828, 6);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(16, 16);
            this.lblClose.TabIndex = 52;
            this.lblClose.Text = "×";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // passenger_name
            // 
            this.passenger_name.DataPropertyName = "passenger_name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.passenger_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.passenger_name.HeaderText = "姓名";
            this.passenger_name.MaxInputLength = 10;
            this.passenger_name.Name = "passenger_name";
            // 
            // passenger_type_name
            // 
            this.passenger_type_name.DataPropertyName = "passenger_type_name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.passenger_type_name.DefaultCellStyle = dataGridViewCellStyle3;
            this.passenger_type_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passenger_type_name.HeaderText = "票种";
            this.passenger_type_name.Items.AddRange(new object[] {
            "成人",
            "儿童",
            "学生",
            "残军"});
            this.passenger_type_name.Name = "passenger_type_name";
            // 
            // passenger_id_type_name
            // 
            this.passenger_id_type_name.DataPropertyName = "passenger_id_type_name";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.passenger_id_type_name.DefaultCellStyle = dataGridViewCellStyle4;
            this.passenger_id_type_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passenger_id_type_name.HeaderText = "证件类型";
            this.passenger_id_type_name.Items.AddRange(new object[] {
            "二代身份证",
            "一代身份证",
            "港澳通行证",
            "台湾通行证",
            "护照"});
            this.passenger_id_type_name.Name = "passenger_id_type_name";
            // 
            // card_no
            // 
            this.card_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.card_no.DataPropertyName = "card_no";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.card_no.DefaultCellStyle = dataGridViewCellStyle5;
            this.card_no.HeaderText = "证件号";
            this.card_no.MaxInputLength = 18;
            this.card_no.Name = "card_no";
            // 
            // mobile_no
            // 
            this.mobile_no.DataPropertyName = "mobile_no";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.mobile_no.DefaultCellStyle = dataGridViewCellStyle6;
            this.mobile_no.HeaderText = "手机号";
            this.mobile_no.MaxInputLength = 11;
            this.mobile_no.Name = "mobile_no";
            // 
            // caozuo
            // 
            this.caozuo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.caozuo.HeaderText = "操作";
            this.caozuo.Name = "caozuo";
            this.caozuo.Text = "保存";
            this.caozuo.UseColumnTextForButtonValue = true;
            this.caozuo.Width = 80;
            // 
            // formPassengersEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(850, 341);
            this.Controls.Add(this.lblMini);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPassengersEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPassengersEdit";
            this.Load += new System.EventHandler(this.formPassengersEdit_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassenger)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddPassenger;
        private System.Windows.Forms.ComboBox cboIDType;
        private System.Windows.Forms.TextBox txtIDCode;
        private System.Windows.Forms.TextBox txtMobileNO;
        private System.Windows.Forms.ComboBox cboTicketType;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblMini;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.DataGridView dgvPassenger;
        private System.Windows.Forms.DataGridViewTextBoxColumn passenger_name;
        private System.Windows.Forms.DataGridViewComboBoxColumn passenger_type_name;
        private System.Windows.Forms.DataGridViewComboBoxColumn passenger_id_type_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile_no;
        private System.Windows.Forms.DataGridViewButtonColumn caozuo;

    }
}