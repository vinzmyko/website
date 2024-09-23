namespace PersonalWebsite.Models;

public class Project
{
    public required string Name { get; set; }
    public required DateTime DateStarted { get; set; }
    public DateTime? DateFinished { get; set; }
    public required PrimaryCategory PrimaryCategory { get; set; }
    public List<SecondaryCategory>? SecondaryCategories { get; set; }
    public required List<Technology> Technologies { get; set; }
    public required List<ProjectAttribute> Attributes { get; set; }
    public required ProjectScale? Scale { get; set; }
}

public enum PrimaryCategory
{
    WebDevelopment,
    GameDevelopment,
    MobileDevelopment,
    DesktopApplications,
    ToolsAndUtilities,
    AiAndMachineLearning,
    DataScienceAndAnalytics
}

public enum SecondaryCategory
{
    // Web Development
    Frontend, Backend, FullStack,
    Godot, Unity, UnrealEngine,
    Multiplayer, GameAi,
    // Mobile Development
    Ios, Android, CrossPlatform,
    // AI/ML
    NaturalLanguageProcessing, ReinforcementLearning,
}

public enum Technology
{
    //Game Engine
    GDScript, Godot, Unity, UnrealEngine,
    // Programming Languages
    CSharp, Python, Rust, Javascript,
    // Frameworks
    DotNet, React, Azure,
    // SQL
    SqlServer, Sqlite, 
}

public enum ProjectAttribute
{
    TeamProject, SoloProject, OpenSourceContribution, ClientWork, AcademicProject, HackathonProject
}

public enum ProjectScale
{
    ProofOfConcept, Published, HighTrafficOrUsers
}