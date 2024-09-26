using PersonalWebsite.Models;

namespace PersonalWebsite.Data.Projects;

public class UNLTeamJumpQuest : Project
{
    public UNLTeamJumpQuest()
    {
        Name = "UNL Team Jump Quest";
        DateStarted = new DateTime(2024, 8, 3); 
        DateFinished = new DateTime(2024, 8, 30);
        PrimaryCategory = PrimaryCategory.GameDevelopment;
        SecondaryCategories = new List<SecondaryCategory> 
        { 
            SecondaryCategory.Godot,
        };
        Technologies = new List<Technology> 
        { 
            Technology.Godot
        };
        Attributes = new List<ProjectAttribute> 
        { 
            ProjectAttribute.TeamProject,
            ProjectAttribute.ClientWork
        };
        Scale = ProjectScale.Published;
        ProgrammingLanguages = new List<ProgrammingLanguage>
        {
            ProgrammingLanguage.Csharp
        };
    }
}