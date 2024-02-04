namespace FormsApp;

using FormsApp.EventHandling.Interface;

internal partial class StartForm : Form
{
    public IEventInvoiceBroker EventBroker { get; set; }

    public StartForm(IEventInvoiceBroker eventInvoiceBroker)
    {
        EventBroker = eventInvoiceBroker;

        InitializeComponent();
    }

    private void NewPubButton_Click(object sender, EventArgs e)
    {
        new PublisherForm(EventBroker).Show();
    }

    private void NewSubButton_Click(object sender, EventArgs e)
    {
        new SubscriberForm(EventBroker).Show();
    }
}
