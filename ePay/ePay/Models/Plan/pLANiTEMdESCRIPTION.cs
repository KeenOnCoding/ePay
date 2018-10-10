namespace ePay.Models.Plan
{
    public class PlanItemDescription
    {
        public int Id { get; set; }
        public int PlanItemId { get; set; }
        public string Period { get; set; }
        public string Step { get; set; }
        public decimal Price { get; set; }
        public Tarification Tarification { get; set; }
    }
}