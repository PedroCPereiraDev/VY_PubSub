namespace FormsApp;

partial class PublisherForm
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
        InvoiceNumberInput = new TextBox();
        InvoiceValueInput = new NumericUpDown();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        SubmitButton = new Button();
        ((System.ComponentModel.ISupportInitialize)InvoiceValueInput).BeginInit();
        SuspendLayout();
        // 
        // InvoiceNumberInput
        // 
        InvoiceNumberInput.Location = new Point(201, 91);
        InvoiceNumberInput.Name = "InvoiceNumberInput";
        InvoiceNumberInput.PlaceholderText = "Ex. FR/01 2004-22225FR";
        InvoiceNumberInput.Size = new Size(279, 27);
        InvoiceNumberInput.TabIndex = 0;
        // 
        // InvoiceValueInput
        // 
        InvoiceValueInput.DecimalPlaces = 2;
        InvoiceValueInput.Location = new Point(201, 158);
        InvoiceValueInput.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
        InvoiceValueInput.Name = "InvoiceValueInput";
        InvoiceValueInput.Size = new Size(279, 27);
        InvoiceValueInput.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 94);
        label1.Name = "label1";
        label1.Size = new Size(114, 20);
        label1.TabIndex = 2;
        label1.Text = "Invoice Number";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 160);
        label2.Name = "label2";
        label2.Size = new Size(133, 20);
        label2.TabIndex = 3;
        label2.Text = "Invoice Total Value";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        label3.Location = new Point(124, 9);
        label3.Name = "label3";
        label3.Size = new Size(239, 32);
        label3.TabIndex = 4;
        label3.Text = "INVOICE REPORTER";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(67, 51);
        label4.Name = "label4";
        label4.Size = new Size(360, 20);
        label4.TabIndex = 5;
        label4.Text = "Please use the following fields to report new Invoices";
        // 
        // SubmitButton
        // 
        SubmitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        SubmitButton.Location = new Point(12, 224);
        SubmitButton.Name = "SubmitButton";
        SubmitButton.Size = new Size(468, 29);
        SubmitButton.TabIndex = 6;
        SubmitButton.Text = "SUBMIT";
        SubmitButton.UseVisualStyleBackColor = true;
        SubmitButton.Click += SubmitButton_Click;
        // 
        // PublisherForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(492, 273);
        Controls.Add(SubmitButton);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(InvoiceValueInput);
        Controls.Add(InvoiceNumberInput);
        MaximizeBox = false;
        Name = "PublisherForm";
        Text = "Invoice Reporter";
        ((System.ComponentModel.ISupportInitialize)InvoiceValueInput).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox InvoiceNumberInput;
    private NumericUpDown InvoiceValueInput;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Button SubmitButton;
}