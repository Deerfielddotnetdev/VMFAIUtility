using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace VMFAIUtility
{
    public class OllamaClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _model;

        public OllamaClient(string baseUrl, string model)
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(baseUrl) };
            _model = model;
        }

        public async Task<string> SummarizeEmail(string input)
        {
            string prompt = $"Summarize this email clearly and briefly:\n\n{input}";
            return await QueryModel(prompt);
        }

        public async Task<string> SuggestReply(string input)
        {
            string prompt = $"Suggest a professional and helpful reply to this email:\n\n{input}";
            return await QueryModel(prompt);
        }

        private async Task<string> QueryModel(string prompt)
        {
            var body = new { model = _model, prompt = prompt, stream = false };
            var content = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("/api/generate", content);
            string json = await response.Content.ReadAsStringAsync();

            using var doc = JsonDocument.Parse(json);
            return doc.RootElement.GetProperty("response").GetString();
        }
    }
}
