using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiamMoat.DotNet.GitIgnore.Services
{
	public interface IGitIgnoreService
	{
		Task<string> GetTemplateAsync(string[] types);
		Task<List<string>> GetTypesAsync(string query);
	}
}
