using ArmatSolutions.Code.Engine.Core;

namespace ArmatSolutions.Code.Engine.Tests.Unit
{
	public class TestAction : IAction<TestSubject>
	{
		public string Name { get; set; }

		public string Code { get; set; }
	}
}
