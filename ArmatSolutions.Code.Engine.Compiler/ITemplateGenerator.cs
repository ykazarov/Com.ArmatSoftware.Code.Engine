namespace ArmatSolutions.Code.Engine.Compiler
{
	public interface ITemplateGenerator<S> where S : class
	{
		string Generate(ICompilerConfiguration<S> configuration);
	}
}
