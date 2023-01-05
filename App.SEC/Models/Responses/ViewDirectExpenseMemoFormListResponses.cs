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
    }
}

