namespace BlazorApp1.Data
{
    public class KhataEntry
    {
        public int Id { get; set; } 
        public DateTime Date { get; set; }
        public required string Title { get; set; }
        public required string Description { get;set; }
        public Bank Bank { get; set; }
    }

    public enum Bank
    {
        Kotak=1,
        ICICI=2,
        Paytm=3,
        SBI=4,
        Packet=5,
        Cash=6,
        Rent=7,
        Other=8
    }
}
