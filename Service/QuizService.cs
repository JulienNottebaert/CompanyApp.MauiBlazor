using System.Text.Json;
using CompanyApp.MauiBlazor.Models;

public class QuizService
{
    private readonly string filePath;

    public QuizService()
    {
        filePath = Path.Combine(FileSystem.AppDataDirectory, "quizzes.json");
    }

    public async Task SaveQuizzesAsync(List<Quiz> quizzes)
    {
        var json = JsonSerializer.Serialize(quizzes);
        await File.WriteAllTextAsync(filePath, json);
    }

    public async Task<List<Quiz>> LoadQuizzesAsync()
    {
        if (File.Exists(filePath))
        {
            var json = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<Quiz>>(json) ?? new List<Quiz>();
        }
        return new List<Quiz>();
    }
}
