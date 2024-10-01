using PersonalWebsite.Models;

namespace PersonalWebsite.Factories;

public static class ProjectFactory
{
    public static Project CreateUNLTeamJumpQuest()
    {
        return new Project
        {
            Name = "UNL Team Jump Quest",
            Description = "Commissioned by the owner of an online community, this project began as an experimental exploration of a livestreaming platform's API and evolved into an interactive " +
            "solution for a community's needs. The software enhances viewer engagement during match breaks by enabling real-time audience participation through chat commands. As " +
            "a custom-built tool for the client, it seamlessly integrates with their existing streaming setup, transforming downtime into an exciting, community-driven experience. This project " +
            "showcases my ability to adapt to client needs, leverage third-party APIs, and deliver engaging, real-time interactive solutions in the gaming and livestreaming space.",
            DateStarted = new DateTime(2024, 8, 3),
            DateFinished = new DateTime(2024, 8, 31),
            PrimaryCategory = PrimaryCategory.Game,
            SecondaryCategories = new List<SecondaryCategory> { SecondaryCategory.Godot },
            Technologies = new List<Technology> { Technology.Godot },
            Attributes = new List<ProjectAttribute> { ProjectAttribute.TeamProject, ProjectAttribute.ClientWork },
            Scale = ProjectScale.Published,
            ProgrammingLanguages = new List<ProgrammingLanguage> { ProgrammingLanguage.Csharp },
            VideoDemo = "https://www.youtube.com/watch?v=A2n6WIh7ekM",
            GitHubLink = "https://github.com/vinzmyko/twitch-jump-quest"
        };
    }

    public static Project CreateTodoApp()
    {
        return new Project
        {
            Name = "TodoApp",
            Description = "Developed a full-stack Todo web app using Blazor Server frontend using the CSS framework TailwindCSS. A RESTful API using ASP.NET, Minimal API, and Entity" +
            " Framework Core for efficient data management and persistence with SQLite. The web application was deployed to Microsoft Azure.", 
            DateStarted = new DateTime(2024, 9, 11),
            DateFinished = new DateTime(2024, 9, 22),
            PrimaryCategory = PrimaryCategory.Web,
            SecondaryCategories = new List<SecondaryCategory> { SecondaryCategory.FullStack },
            Technologies = new List<Technology> { Technology.Blazor, Technology.Aspnet },
            Attributes = new List<ProjectAttribute> { ProjectAttribute.SoloProject },
            Scale = ProjectScale.ProofOfConcept,
            ProgrammingLanguages = new List<ProgrammingLanguage> { ProgrammingLanguage.Csharp, ProgrammingLanguage.Html, ProgrammingLanguage.Css },
            GitHubLink = "https://github.com/vinzmyko/todo-app",
            WebsiteLink = "https://vinz-todoapp-web.azurewebsites.net/",
            Images = new List<string> { "Images/Projects/TodoApp/img/TodoAppApiDbSchema.png" }
        };
    }

    public static Project PersonalWebsite()
    {
        return new Project
        {
            Name = "Personal Website",
            Description = "Crafted using Blazor WebAssembly (WASM) and using the CSS framework TailwindCSS. The site features a modern design with custom components for project displays, filtering, and modal views. Built " +
            "with performance and scalability in mind, as it's very easy to create, remove, and update projects.",
            DateStarted = new DateTime(2024, 9, 23),
            DateFinished = new DateTime(2024, 9, 30),
            PrimaryCategory = PrimaryCategory.Web,
            SecondaryCategories = new List<SecondaryCategory> { SecondaryCategory.Frontend },
            Technologies = new List<Technology> { Technology.Blazor },
            Attributes = new List<ProjectAttribute> { ProjectAttribute.SoloProject },
            Scale = ProjectScale.ProofOfConcept,
            ProgrammingLanguages = new List<ProgrammingLanguage> { ProgrammingLanguage.Csharp, ProgrammingLanguage.Html, ProgrammingLanguage.Css },
            GitHubLink = "https://github.com/vinzmyko/website",
        };
    }
}