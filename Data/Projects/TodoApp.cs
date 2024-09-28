using PersonalWebsite.Models;

namespace PersonalWebsite.Data.Projects;

public class TodoApp : Project
{
    public TodoApp()
    {
        Name = "TodoApp";
        Description = "Engineered a full-stack Todo web app using Blazor frontend and ASP.NET backend with Minimal APIs to create " +
        "a RESTful service, while Entity Framework Core manages data persistence with SQLite and deployed using Microsoft Azure.";
        DateStarted = new DateTime(2024, 9, 11); 
        DateFinished = new DateTime(2024, 9, 22);
        PrimaryCategory = PrimaryCategory.Web;
        GitHubLink = "https://github.com/vinzmyko/todo-app";
        WebsiteLink = "https://vinz-todoapp-web.azurewebsites.net/";
        SecondaryCategories = new List<SecondaryCategory> 
        { 
            SecondaryCategory.FullStack,
        };
        Technologies = new List<Technology> 
        { 
            Technology.Blazor,
            Technology.Aspnet
        };
        Attributes = new List<ProjectAttribute> 
        { 
            ProjectAttribute.SoloProject,
        };
        Scale = ProjectScale.ProofOfConcept;
        ProgrammingLanguages = new List<ProgrammingLanguage>
        {
            ProgrammingLanguage.Csharp,
            ProgrammingLanguage.Html,
            ProgrammingLanguage.Css,
        };
    }
}