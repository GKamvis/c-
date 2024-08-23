namespace web_api_anket_mvc.Models
{
    public class QuestionViewModel
    {
        public int QuestionId { get; set; }

        public int? StudentNumber { get; set; }

        public string? QuestionText { get; set; }

        public virtual ICollection<ResponseViewModel> Responses { get; set; } = new List<ResponseViewModel>();

    }
}
