﻿namespace PersonalWebsite.Models;

public class Project
{
    public required string Name { get; set; }
    public required DateTime DateStarted { get; set; }
    public DateTime? DateFinished { get; set; }
    public required PrimaryCategory PrimaryCategory { get; set; }
    public List<SecondaryCategory>? SecondaryCategories { get; set; }
    public required List<ProgrammingLanguage> ProgrammingLanguages { get; set; }
    public required List<Technology> Technologies { get; set; }
    public required List<ProjectAttribute> Attributes { get; set; }
    public required ProjectScale? Scale { get; set; }

    public string GetProjectCardPNG()
    {
        string name = Name.ToLower().Replace(" ", "");
        return $"/Images/Projects/{Name.Replace(" ", "")}/{name}.png";
    }

    public string GetProjectCardWebP()
    {
        string name = Name.ToLower().Replace(" ", "");
        return $"/Images/Projects/{Name.Replace(" ", "")}/{name}.webp";
    }
}

public enum ProgrammingLanguage
{
    Csharp,
    Cplusplus,
    Python,
    Gdscript,
    Rust
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
    // Frameworks
    DotNet, Blazor, React, Azure, Aspnet,
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