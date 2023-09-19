using System;
namespace Resume.Presentation.Models.Entitis.Exprience
{
	public class Exprience
	{
		public int Id { get; set; }

		public string ExprienceTitle { get; set; }

		public string ExprienceDuration { get; set; }

		public string Description { get; set; }

        public string Company { get; set; }

        public string? CompanySite { get; set; }
    }
}

