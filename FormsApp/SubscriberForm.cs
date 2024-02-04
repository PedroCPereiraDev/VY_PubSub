namespace FormsApp;

using FormsApp.EventHandling;
using FormsApp.EventHandling.Interface;
using FormsApp.Extensions;

internal partial class SubscriberForm : Form
{
    public IEventInvoiceBrokerSubscriber EventBroker { get; set; }

    public SubscriberForm(IEventInvoiceBrokerSubscriber eventBroker)
    {
        EventBroker = eventBroker;

        EventBroker.Subscribe(InvoiceEventListener);

        InitializeComponent();
    }

    public void InvoiceEventListener(object? sender, EventInvoiceData data)
    {
        InvoiceDataTable.Rows.Add(data.InvoiceNumber, data.InvoiceValue.ParseAsCurrency(), data.TaxesValue.ParseAsCurrency());
    }

    private void SubscriberForm_FormClosing(object sender, FormClosingEventArgs e) => UnsubscribeToBroker();

    private void DisconnectBtn_Click(object sender, EventArgs e)
    {
        UnsubscribeToBroker();

        this.Text += " - DISCONNECTED";
        DisconnectBtn.Enabled = false;
    }

    private void UnsubscribeToBroker()
    {
        EventBroker.Unsubscribe(InvoiceEventListener);
    }
}
