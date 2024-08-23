namespace car_operations.Models
{
    public class OperationsModel
    {


     
            public int Id { get; set; }
            public int OperationType { get; set; }
            public int Car_id { get; set; }
            public string Item { get; set; }
            public float Amount { get; set; }
            public DateTime OperationDate { get; set; }
       

    }
}
