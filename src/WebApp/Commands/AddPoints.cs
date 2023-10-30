namespace Pitstop.WebApp.Commands
{
    public class AddPoints : Command
    {
        public readonly string CustomerId;
        public readonly int PointsToAdd;

        public AddPoints(Guid messageId, string customerId, int pointsToAdd) : base(messageId)
        {
            CustomerId = customerId;
            PointsToAdd = pointsToAdd;    
            

        }
    }
}
