using TestePleno.Models;
using TestePleno.Services;

namespace TestePleno.Controllers
{
	public class FareController
	{
		private readonly OperatorService _operatorService;
		private readonly FareService FareService;

		public FareController()
		{
			_operatorService = new OperatorService();
		}

		public void CreateFare(Fare fare, string operatorCode)
		{
			var selectedOperator = _operatorService.GetOperatorByCode(operatorCode);
			fare.OperatorId = selectedOperator.Id;

			FareService.Create(fare);
		}
	}
}
