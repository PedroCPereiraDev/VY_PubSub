namespace FormsApp;

partial class SubscriberForm
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
        InvoiceDataTable = new DataGridView();
        InvoiceNumberColumn = new DataGridViewTextBoxColumn();
        InvoiceValueColumn = new DataGridViewTextBoxColumn();
        PaidTaxesColumn = new DataGridViewTextBoxColumn();
        label1 = new Label();
        label2 = new Label();
        DisconnectBtn = new Button();
        ((System.ComponentModel.ISupportInitialize)InvoiceDataTable).BeginInit();
        SuspendLayout();
        // 
        // InvoiceDataTable
        // 
        InvoiceDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        InvoiceDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        InvoiceDataTable.Columns.AddRange(new DataGridViewColumn[] { InvoiceNumberColumn, InvoiceValueColumn, PaidTaxesColumn });
        InvoiceDataTable.Dock = DockStyle.Bottom;
        InvoiceDataTable.Location = new Point(0, 104);
        InvoiceDataTable.Name = "InvoiceDataTable";
        InvoiceDataTable.ReadOnly = true;
        InvoiceDataTable.RowHeadersWidth = 51;
        InvoiceDataTable.Size = new Size(790, 187);
        InvoiceDataTable.TabIndex = 0;
        // 
        // InvoiceNumberColumn
        // 
        InvoiceNumberColumn.HeaderText = "Invoice Number";
        InvoiceNumberColumn.MinimumWidth = 6;
        InvoiceNumberColumn.Name = "InvoiceNumberColumn";
        InvoiceNumberColumn.ReadOnly = true;
        // 
        // InvoiceValueColumn
        // 
        InvoiceValueColumn.HeaderText = "Invoice Value";
        InvoiceValueColumn.MinimumWidth = 6;
        InvoiceValueColumn.Name = "InvoiceValueColumn";
        InvoiceValueColumn.ReadOnly = true;
        // 
        // PaidTaxesColumn
        // 
        PaidTaxesColumn.HeaderText = "Paid Taxes";
        PaidTaxesColumn.MinimumWidth = 6;
        PaidTaxesColumn.Name = "PaidTaxesColumn";
        PaidTaxesColumn.ReadOnly = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        label1.Location = new Point(304, 9);
        label1.Name = "label1";
        label1.Size = new Size(208, 32);
        label1.TabIndex = 1;
        label1.Text = "INVOICE VIEWER";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 56);
        label2.Name = "label2";
        label2.Size = new Size(466, 20);
        label2.TabIndex = 2;
        label2.Text = "Here you can see a summary of the Invoices that are being submitted";
        // 
        // DisconnectBtn
        // 
        DisconnectBtn.Location = new Point(565, 52);
        DisconnectBtn.Name = "DisconnectBtn";
        DisconnectBtn.Size = new Size(213, 29);
        DisconnectBtn.TabIndex = 3;
        DisconnectBtn.Text = "DISCONNECT";
        DisconnectBtn.UseVisualStyleBackColor = true;
        DisconnectBtn.Click += DisconnectBtn_Click;
        // 
        // SubscriberForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(790, 291);
        Controls.Add(DisconnectBtn);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(InvoiceDataTable);
        MaximizeBox = false;
        Name = "SubscriberForm";
        Text = "Invoice Viewer";
        FormClosing += SubscriberForm_FormClosing;
        ((System.ComponentModel.ISupportInitialize)InvoiceDataTable).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView InvoiceDataTable;
    private DataGridViewTextBoxColumn InvoiceNumberColumn;
    private DataGridViewTextBoxColumn InvoiceValueColumn;
    private DataGridViewTextBoxColumn PaidTaxesColumn;
    private Label label1;
    private Label label2;
    private Button DisconnectBtn;
}
