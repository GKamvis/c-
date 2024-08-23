namespace web_api_anket_mvc.Models
{
        public class StudentAverageScore

        {
            public int? StudentNumber { get; set; }
            public double? AverageScore
            {
                get { return _averageScore.HasValue ? _averageScore.Value : 0.0; }
                set { _averageScore = value; }
            }
            private double? _averageScore;
        }

    
}
