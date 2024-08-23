namespace web_api_anket_mvc.Models
{
    public class ResponseViewModel
    {
        public int ResponseId { get; set; }

        public int? QuestionId { get; set; }

        public int? StudentNumber { get; set; }

        public double? Score { get; set; }

       public virtual QuestionViewModel? Question { get; set; }

    }
}
