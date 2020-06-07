using ArmatSolutions.Code.Engine.Core;

namespace ArmatSolutions.Code.Engine.Compiler
{
	/// <summary>
	/// Compiler of actions into an executor
	/// </summary>
	/// <typeparam name="S">Subject type</typeparam>
	public interface ICompiler<S> where S : class
	{
		/// <summary>
		/// Compiles configuration containing actions and imports into an IExecutor object
		/// </summary>
		/// <param name="configuration">Compiler configuration</param>
		/// <returns>IExecutor object</returns>
		IExecutor<S> Compile(ICompilerConfiguration<S> configuration);
	}
}
