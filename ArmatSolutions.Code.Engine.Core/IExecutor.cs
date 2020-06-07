namespace ArmatSolutions.Code.Engine.Core
{
	/// <summary>
	/// Executes one or more actions against the subject
	/// </summary>
	/// <typeparam name="S">Subject of type S</typeparam>
	public interface IExecutor<S> : IExecutionContext where S : class
	{
		/// <summary>
		/// Subject of the action execution
		/// </summary>
		S Subject { get; set; }

		/// <summary>
		/// Execute the actions
		/// </summary>
		void Execute();
	}
}
