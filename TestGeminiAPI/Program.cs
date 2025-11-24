
using Mscc.GenerativeAI;

try
{
    // Replace with your actual API key
    string apiKey = "Your-API-KEY";

    // Start a conversation loop
    Console.WriteLine("Gemini AI - Type 'exit' to quit");
    while (true)
    {
        Console.Write("You: ");
        string userInput = Console.ReadLine();

        if (userInput.ToLower() == "exit")
            break;

        if (!string.IsNullOrWhiteSpace(userInput))
        {
            var googleAI = new GoogleAI(apiKey: apiKey);
            var model = googleAI.GenerativeModel(model: Model.Gemini20FlashThinkingExperimental0121);
            model.UseGrounding = true; // Enable grounding for the model

            var response = await model.GenerateContent(userInput);
            Console.WriteLine($"Gemini: {response.Text}");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
