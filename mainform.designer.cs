namespace VMFAIUtility
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtEmailInput;
        private TextBox txtOutput;
        private Button btnSummarize;
        private Button btnSuggest;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtEmailInput = new TextBox();
            this.txtOutput = new TextBox();
            this.btnSummarize = new Button();
            this.btnSuggest = new Button();
            this.SuspendLayout();

            // txtEmailInput
            this.txtEmailInput.Multiline = true;
            this.txtEmailInput.ScrollBars = ScrollBars.Vertical;
            this.txtEmailInput.Location = new System.Drawing.Point(12, 12);
            this.txtEmailInput.Size = new System.Drawing.Size(460, 150);

            // btnSummarize
            this.btnSummarize.Location = new System.Drawing.Point(12, 170);
            this.btnSummarize.Size = new System.Drawing.Size(100, 30);
            this.btnSummarize.Text = "Summarize";
            this.btnSummarize.Click += new EventHandler(this.btnSummarize_Click);

            // btnSuggest
            this.btnSuggest.Location = new System.Drawing.Point(120, 170);
            this.btnSuggest.Size = new System.Drawing.Size(100, 30);
            this.btnSuggest.Text = "Suggest Reply";
            this.btnSuggest.Click += new EventHandler(this.btnSuggest_Click);

            // txtOutput
            this.txtOutput.Multiline = true;
            this.txtOutput.ScrollBars = ScrollBars.Vertical;
            this.txtOutput.Location = new System.Drawing.Point(12, 210);
            this.txtOutput.Size = new System.Drawing.Size(460, 150);

            // MainForm
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.txtEmailInput);
            this.Controls.Add(this.btnSummarize);
            this.Controls.Add(this.btnSuggest);
            this.Controls.Add(this.txtOutput);
            this.Text = "VisNetic MailFlow Assistant";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
