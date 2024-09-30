using PersonalWebsite.Models;

namespace PersonalWebsite.Factories;

public static class ProjectFactory
{
    public static Project CreateUNLTeamJumpQuest()
    {
        return new Project
        {
            Name = "UNL Team Jump Quest",
            Description = "Beginning as an experimental exploration of a livestreaming platform's API evolving to become a practical solution for a competitive gaming community. " +
            "UNL Team Jump Quest allows for real-time audience participation through chat commands, enhancing viewer experience during breaks between matches.",
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
            Description = "Blazor Server, Engineered a full-stack Todo web app using Blazor frontend and ASP.NET backend with Minimal APIs to create a RESTful service, while Entity Framework " +
            "Core manages data persistence with SQLite and deployed using Microsoft Azure.",
            DateStarted = new DateTime(2024, 9, 11),
            DateFinished = new DateTime(2024, 9, 22),
            PrimaryCategory = PrimaryCategory.Web,
            SecondaryCategories = new List<SecondaryCategory> { SecondaryCategory.FullStack },
            Technologies = new List<Technology> { Technology.Blazor, Technology.Aspnet },
            Attributes = new List<ProjectAttribute> { ProjectAttribute.SoloProject },
            Scale = ProjectScale.ProofOfConcept,
            ProgrammingLanguages = new List<ProgrammingLanguage> { ProgrammingLanguage.Csharp, ProgrammingLanguage.Html, ProgrammingLanguage.Css },
            GitHubLink = "https://github.com/vinzmyko/todo-app",
            WebsiteLink = "https://vinz-todoapp-web.azurewebsites.net/"
        };
    }

    public static Project PersonalWebsite()
    {
        return new Project
        {
            Name = "Personal Website",
            Description = "Made using Blazor WebAssembly (WASM).",
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