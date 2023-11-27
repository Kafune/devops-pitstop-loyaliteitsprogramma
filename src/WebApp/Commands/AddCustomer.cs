using System.Net.Mail;
using System.Net;
using System.Xml.Linq;

namespace Pitstop.WebApp.Commands;

public class AddCustomer : Command 
{
    public readonly string CustomerId;

    public AddCustomer(Guid messageId, string customerId) : base(messageId)
    {
        CustomerId = customerId;

    }
}
