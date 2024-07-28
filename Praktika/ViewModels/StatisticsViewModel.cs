using System.Collections.Generic;

namespace Praktika.ViewModels

{
    public class StatisticsViewModel
    {
        public int TotalUsers { get; set; }
        public int TotalCompanies { get; set; }
        public decimal TotalInvestments { get; set; }
        public List<Recommendation> Recommendations { get; set; }
    }

    public class Recommendation
    {
        public string CompanyName { get; set; }
        public string RecommendationText { get; set; }
    }
}