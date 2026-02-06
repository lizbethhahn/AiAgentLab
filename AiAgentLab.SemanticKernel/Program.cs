using Microsoft.Extensions.Configuration;

namespace SemanticKernelAgent
{
	class Program
	{
		static void Main(string[] args)
		{
			// Build configuration
			var configuration = new ConfigurationBuilder()
				.AddEnvironmentVariables()
				.AddUserSecrets<Program>()
				.Build();
                
			// Retrieve GitHub token
			string? githubToken = configuration["GITHUB_TOKEN"];

			if (string.IsNullOrEmpty(githubToken))
			{
				Console.WriteLine("❌ Error: GITHUB_TOKEN not found in configuration.");
				Console.WriteLine("💡 Tip: Ensure the token is set as an environment variable or in user secrets.");
			}
			else
			{
				Console.WriteLine("✅ GITHUB_TOKEN loaded successfully.");
			}
		}
	}
}
