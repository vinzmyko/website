using PersonalWebsite.Models;

namespace PersonalWebsite.Factories;

public static class ProjectFactory
{

    public static Project CreatePokemonAutoBattler()
    {
        return new Project
        {
            Name = "Multiplayer Battle Server",
            Description = "A real-time multiplayer game server and battle simulation engine built in Rust, creates asynchronous battles between connected clients via WebSockets. Uses Bevy ECS framework for it's modular and data driven design. Players interact with the world, position their units, and trigger real-time combat events. The server runs on Tokio for async I/O, supporting multiple concurrent sessions and maintaining synchronised game states across all connected clients.",
            IsFeatured = true,
            DateStarted = new DateTime(2025, 9, 24),
            Technologies = new List<Technology> { Technology.BevyECS, Technology.Tokio },
            PrimaryCategory = PrimaryCategory.Server,
            SecondaryCategories = new List<SecondaryCategory> { SecondaryCategory.Backend, SecondaryCategory.Multiplayer },
            Attributes = new List<ProjectAttribute> { ProjectAttribute.SoloProject},
            Scale = ProjectScale.Published,
            ProgrammingLanguages = new List<ProgrammingLanguage> { ProgrammingLanguage.Rust },
            VideoDemo = "https://www.youtube.com/watch?v=5FGJuli8KSY",
            ProjectManagementLink = "https://trello.com/b/6BsD5Ijg/pokemon-auto-battler",
        };
    }

    public static Project CreateMdello()
    {
        return new Project
        {
            Name = "mdello",
            Description = "mdello is a command-line tool that bridges the gap between Trello's web interface and developers' preferred markdown workflow. Users can edit their Trello boards using familiar markdown syntax, with boards represented as # headers, lists as ## subheaders, and cards as checkbox items that can be moved, labelled, and scheduled simply by reorganising the text. The tool supports advanced features like label management, due date formatting, and detailed editing modes for comprehensive board configuration. Built with Go, mdello enables developers to manage their project workflows entirely from the terminal using their favourite text editors.",
            IsFeatured = true,
            DateStarted = new DateTime(2025, 7, 9),
            DateFinished = new DateTime(2025, 7, 25),
            Technologies = new List<Technology> { Technology.NA },
            PrimaryCategory = PrimaryCategory.Tool,
            SecondaryCategories = new List<SecondaryCategory> { SecondaryCategory.CLI },
            Attributes = new List<ProjectAttribute> { ProjectAttribute.SoloProject},
            Scale = ProjectScale.Published,
            ProgrammingLanguages = new List<ProgrammingLanguage> { ProgrammingLanguage.Go },
            GitHubLink = "https://github.com/vinzmyko/mdello",
            VideoDemo = "https://www.youtube.com/watch?v=87xSqcBtu_c",
            ProjectManagementLink = "https://github.com/vinzmyko/mdello/blob/main/project-management.md",
        };
    }

    public static Project CreateNewsletterBackendAPI()
    {
        return new Project
        {
            Name = "Newsletter Backend",
            Description = "A comprehensive email newsletter management system built with Rust, showcasing modern backend architecture and development practices. Built using Actix-Web for the REST API framework, PostgreSQL for data persistence, and Redis for session storage. Key technical implementations include Argon2 password hashing for security, idempotency patterns to prevent duplicate operations, role-based access control for admin functionality, and asynchronous email delivery queues integrated with SendGrid. The system features comprehensive error handling, session-based authentication with automatic renewal, and a background worker process for reliable email dispatch. Deployed using Docker containerisation with automated CI/CD pipelines via GitHub Actions on Railway.",
            IsFeatured = true,
            DateStarted = new DateTime(2025, 5, 12),
            DateFinished = new DateTime(2025, 7, 3),
            PrimaryCategory = PrimaryCategory.Web,
            SecondaryCategories = new List<SecondaryCategory> { SecondaryCategory.Backend },
            Technologies = new List<Technology> { Technology.ActixWeb, Technology.PostgreSQL, Technology.Redis },
            Attributes = new List<ProjectAttribute> { ProjectAttribute.SoloProject },
            Scale = ProjectScale.ProofOfConcept,
            ProgrammingLanguages = new List<ProgrammingLanguage> { ProgrammingLanguage.Rust },
            GitHubLink = "https://github.com/vinzmyko/newsletter_backend",
            VideoDemo = "https://youtu.be/6PrxWx8jTBM",
        };
    }

    public static Project CreatePMDScraper()
    {
        return new Project
        {
            Name = "PMD Scraper",
            Description = "An in-progress ROM scraper for the second generation of Pokemon Mystery Dungeon games on the Nintendo DS. The technical documentation I used were GBATEK, Project Pokemon" +
            ", SkyTemple libraries and reverse engineering communities such as pret and SkyTemple. With information that was not recorded I would reverse engineer the game ROM with Ghidra and DeSmuME's" +
            " memory viewer and assembly disassembler. Current features include: Pokemon animation sprites extraction, Pokemon portrait sprite extraction, and move_id to effect sprite mapper.",
            IsFeatured = true,
            DateStarted = new DateTime(2025, 1, 10),
            PrimaryCategory = PrimaryCategory.Tool,
            SecondaryCategories = new List<SecondaryCategory> { SecondaryCategory.CLI, SecondaryCategory.Scraper },
            Technologies = new List<Technology> { Technology.NA },
            Attributes = new List<ProjectAttribute> { ProjectAttribute.SoloProject },
            Scale = ProjectScale.ProofOfConcept,
            ProgrammingLanguages = new List<ProgrammingLanguage> { ProgrammingLanguage.Rust },
            GitHubLink = "https://github.com/vinzmyko/pmd_scraper",
            ProjectManagementLink = "https://trello.com/b/6BsD5Ijg/pokemon-auto-battler",
            Images = new List<string> { "Images/Projects/PMDScraper/img/venusaur_sprite_atlas.png", "Images/Projects/PMDScraper/img/pokedex_portraits.png", "Images/Projects/PMDScraper/img/effect_sprites.png", "Images/Projects/PMDScraper/img/effects_json.png" },
        };
    }

    public static Project CreateUNLTeamJumpQuest()
    {
        return new Project
        {
            Name = "UNL Team Jump Quest",
            Description = "Commissioned by the owner of an online community, this project began as an experimental exploration of a livestreaming platform's API and evolved into an interactive " +
            "solution for a community's needs. The software enhances viewer engagement during match breaks by enabling real-time audience participation through chat commands. As " +
            "a custom-built tool for the client, it seamlessly integrates with their existing streaming setup, transforming downtime into an exciting, community-driven experience. This project " +
            "showcases my ability to adapt to client needs, leverage third-party APIs, and deliver engaging, real-time interactive solutions in the gaming and livestreaming space.",
            IsFeatured = true,
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
            Technologies = new List<Technology> { Technology.Blazor, Technology.Aspnet, Technology.Sqlite },
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
