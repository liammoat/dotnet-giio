using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LiamMoat.DotNet.GitIgnore.Services
{
	public class GitIgnoreService : IGitIgnoreService
	{
		private readonly HttpClient _client;

		public GitIgnoreService(HttpClient httpClient)
		{
			_client = httpClient;
		}

		public async Task<string> GetTemplateAsync(string[] types)
		{
			if (types.Length == 0) return string.Empty;

			return await _client.GetStringAsync(string.Join(',', types));
		}

		public async Task<List<string>> GetTypesAsync(string query)
		{
			var raw = await _client.GetStringAsync("list");
			raw = raw.Replace("\n", ",");
			var types = raw.Split(',').ToList();

			if (!string.IsNullOrWhiteSpace(query))
			{
				types = types.Where(type => type.StartsWith(query, true, CultureInfo.CurrentCulture)).ToList();
			}

			return types;
		}
	}
}
