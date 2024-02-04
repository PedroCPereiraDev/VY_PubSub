namespace FormsApp;

using FormsApp.EventHandling;
using FormsApp.EventHandling.Interface;
using FormsApp.InvoiceHelpers;

internal partial class PublisherForm : Form
{
    public IEventInvoiceBrokerPublisher EventBroker { get; set; }

    public PublisherForm(IEventInvoiceBrokerPublisher eventBroker)
    {
        EventBroker = eventBroker;

        InitializeComponent();
    }

    private void SubmitButton_Click(object sender, EventArgs e)
    {
        if (InputDataFieldsValid())
        {
            var data = new EventInvoiceData(
            InvoiceValueInput.Value,
            InvoiceProcessor.CalculateTax(InvoiceValueInput.Value),
            InvoiceProcessor.NormalizeInvoiceNumber(InvoiceNumberInput.Text));

            EventBroker.Publish(data);

            ClearFields();
        }
        else
        {
            MessageBox.Show("Please Fill The Fields Correctly");
        }
    }

    private void ClearFields()
    {
        InvoiceValueInput.Value = 0;
        InvoiceNumberInput.Clear();
    }

    private bool InputDataFieldsValid()
    {
        return InvoiceValueInput.Value > 0 && !string.IsNullOrWhiteSpace(InvoiceNumberInput.Text);
    }
}
