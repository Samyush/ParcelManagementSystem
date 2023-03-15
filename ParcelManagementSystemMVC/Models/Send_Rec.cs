namespace ParcelManagementSystemMVC.Models
{
    public class Send_Rec
    {
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }

        public Sender Senders { get; set; }
        public Receiver Receivers { get; set; }

    }
}
