namespace cs_vending
{
  class Message
  {

    public Message(string body)
    {
      Body = body;
    }

    public string Body { get; set; }
  }
}