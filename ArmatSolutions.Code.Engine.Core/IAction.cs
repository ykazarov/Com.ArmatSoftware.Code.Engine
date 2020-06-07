namespace ArmatSolutions.Code.Engine.Core
{
	/// <summary>
	/// Action that is taken against the subject
	/// </summary>
	/// <typeparam name="S">Subject of type S</typeparam>
	public interface IAction<S> where S : class
	{
		/// <summary>
		/// Meaningful name of the action
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// Source code of the action logic
		/// </summary>
		string Code { get; set; }
	}
}
