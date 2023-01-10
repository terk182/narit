using System;
namespace App.SEC.Models.Responses
{
	public class ViewDirectExpenseMemoFormListResponses
	{
        public int no { get; set; }

        public DateTime date { get; set; }

        public string? Number { get; set; }

        public string? Order { get; set; }

        public string? Project { get; set; }

        public Double Balance { get; set; }


        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ParentPlanTypeId { get; set; }
        public int? ReferenceOldId { get; set; }
        public decimal Weight { get; set; }
    }
}

