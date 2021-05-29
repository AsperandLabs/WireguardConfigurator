namespace WireguardConfigurator.Domain.Services
{
    public interface IUserPromptService
    {
        string PromptPassword(string message);
        string PromptInput(string message);
        void Notify(string message);
        bool AskQuestion(string question);
        void DisplayError(string message);
    }
}