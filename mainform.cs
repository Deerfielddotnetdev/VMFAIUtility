using System;
using System.Windows.Forms;

namespace VMFAIUtility
{
    public partial class MainForm : Form
    {
        private readonly OllamaClient ollama;

        public MainForm()
        {
            InitializeComponent();
            ollama = new OllamaClient("http://localhost:11434", "llama3"); // Adjust if needed
        }

        private async void btnSummarize_Click(object sender, EventArgs e)
        {
            string input = txtEmailInput.Text;
            string response = await ollama.SummarizeEmail(input);
            txtOutput.Text = response;
        }

        private async void btnSuggest_Click(object sender, EventArgs e)
        {
            string input = txtEmailInput.Text;
            string response = await ollama.SuggestReply(input);
            txtOutput.Text = response;
        }
    }
}
