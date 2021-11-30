using System;

namespace TestePleno.Models
{
	public class Fare
	{
		public Guid Id { get; set; }
		public Guid OperatorId { get; set; }
		public int Status { get; set; }
		public decimal Value { get; set; }
	}
}
