namespace FormsApp.EventHandling.Interface;

// To follow ISP (Interface Segregation Principle) I have this interface to be used by subscribing classes
// that do not need to have knowledge of the implementations of how to publish 
internal interface IEventInvoiceBrokerSubscriber
{
    void Subscribe(EventHandler<EventInvoiceData> subscriber);
    void Unsubscribe(EventHandler<EventInvoiceData> subscriber);
}
