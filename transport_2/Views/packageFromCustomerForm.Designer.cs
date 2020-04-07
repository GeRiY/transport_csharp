namespace transport_2.Views
{
    partial class packageFromCustomerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OsszesLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PrevButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mentestoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.keresestoolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.KeresestoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.szerkesztesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugyfelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.target_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transfer_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ugyfelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OsszesLabel);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 43);
            this.panel1.TabIndex = 7;
            // 
            // OsszesLabel
            // 
            this.OsszesLabel.AutoSize = true;
            this.OsszesLabel.Location = new System.Drawing.Point(12, 12);
            this.OsszesLabel.Name = "OsszesLabel";
            this.OsszesLabel.Size = new System.Drawing.Size(79, 17);
            this.OsszesLabel.TabIndex = 3;
            this.OsszesLabel.Text = "Összesen: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.PrevButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FirstButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LastButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.NextButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(302, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 42);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // PrevButton
            // 
            this.PrevButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrevButton.Location = new System.Drawing.Point(86, 9);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(58, 23);
            this.PrevButton.TabIndex = 1;
            this.PrevButton.Text = "<";
            this.PrevButton.UseVisualStyleBackColor = true;
            // 
            // FirstButton
            // 
            this.FirstButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstButton.Location = new System.Drawing.Point(9, 9);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(58, 23);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.Text = "<<";
            this.FirstButton.UseVisualStyleBackColor = true;
            // 
            // LastButton
            // 
            this.LastButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastButton.Location = new System.Drawing.Point(318, 9);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(58, 23);
            this.LastButton.TabIndex = 3;
            this.LastButton.Text = ">>";
            this.LastButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextButton.Location = new System.Drawing.Point(240, 9);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(58, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "0/0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mentestoolStripButton,
            this.toolStripSeparator1,
            this.keresestoolStripTextBox,
            this.KeresestoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(986, 27);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mentestoolStripButton
            // 
            this.mentestoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mentestoolStripButton.Name = "mentestoolStripButton";
            this.mentestoolStripButton.Size = new System.Drawing.Size(82, 24);
            this.mentestoolStripButton.Text = "Módosítás";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // keresestoolStripTextBox
            // 
            this.keresestoolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.keresestoolStripTextBox.Name = "keresestoolStripTextBox";
            this.keresestoolStripTextBox.Size = new System.Drawing.Size(200, 27);
            // 
            // KeresestoolStripButton
            // 
            this.KeresestoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.KeresestoolStripButton.Name = "KeresestoolStripButton";
            this.KeresestoolStripButton.Size = new System.Drawing.Size(63, 24);
            this.KeresestoolStripButton.Text = "Keresés";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.target_address,
            this.transfer_status,
            this.handler,
            this.owner,
            this.courier,
            this.width,
            this.height,
            this.length});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.ugyfelBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(986, 431);
            this.dataGridView1.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerkesztesToolStripMenuItem,
            this.torlesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 52);
            // 
            // szerkesztesToolStripMenuItem
            // 
            this.szerkesztesToolStripMenuItem.Name = "szerkesztesToolStripMenuItem";
            this.szerkesztesToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.szerkesztesToolStripMenuItem.Text = "Szerkesztés";
            // 
            // torlesToolStripMenuItem
            // 
            this.torlesToolStripMenuItem.Name = "torlesToolStripMenuItem";
            this.torlesToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.torlesToolStripMenuItem.Text = "Törlés";
            // 
            // ugyfelBindingSource
            // 
            this.ugyfelBindingSource.DataSource = typeof(transport_2.Models.package);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // target_address
            // 
            this.target_address.DataPropertyName = "target_address";
            this.target_address.HeaderText = "target_address";
            this.target_address.MinimumWidth = 6;
            this.target_address.Name = "target_address";
            // 
            // transfer_status
            // 
            this.transfer_status.DataPropertyName = "transfer_status";
            this.transfer_status.HeaderText = "transfer_status";
            this.transfer_status.MinimumWidth = 6;
            this.transfer_status.Name = "transfer_status";
            // 
            // handler
            // 
            this.handler.DataPropertyName = "handler";
            this.handler.HeaderText = "handler";
            this.handler.MinimumWidth = 6;
            this.handler.Name = "handler";
            // 
            // owner
            // 
            this.owner.DataPropertyName = "owner";
            this.owner.HeaderText = "owner";
            this.owner.MinimumWidth = 6;
            this.owner.Name = "owner";
            // 
            // courier
            // 
            this.courier.DataPropertyName = "courier";
            this.courier.HeaderText = "courier";
            this.courier.MinimumWidth = 6;
            this.courier.Name = "courier";
            // 
            // width
            // 
            this.width.DataPropertyName = "width";
            this.width.HeaderText = "width";
            this.width.MinimumWidth = 6;
            this.width.Name = "width";
            // 
            // height
            // 
            this.height.DataPropertyName = "height";
            this.height.HeaderText = "height";
            this.height.MinimumWidth = 6;
            this.height.Name = "height";
            // 
            // length
            // 
            this.length.DataPropertyName = "length";
            this.length.HeaderText = "length";
            this.length.MinimumWidth = 6;
            this.length.Name = "length";
            // 
            // packageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(986, 502);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "packageForm";
            this.Text = "Felhasználók";
            this.Load += new System.EventHandler(this.packageForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ugyfelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mentestoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox keresestoolStripTextBox;
        private System.Windows.Forms.ToolStripButton KeresestoolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vezeteknevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keresztnevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn irszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ugyfelBindingSource;
        private System.Windows.Forms.Label OsszesLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem szerkesztesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torlesToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn target_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn transfer_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn handler;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn courier;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn height;
        private System.Windows.Forms.DataGridViewTextBoxColumn length;
    }
}