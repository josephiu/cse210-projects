public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetEventSpecificDetails()
    {
        return $"RSVP Email: {_rsvpEmail}";
        
    }

    public override string GenerateMarketingMessage()
    {
        return $"Full details - {GetEventDetails()}\n{GetEventSpecificDetails()}";
    }
}
