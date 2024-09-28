using PersonalWebsite.Models;

namespace PersonalWebsite.Data.Projects;

public class UNLTeamJumpQuest : Project
{
    public UNLTeamJumpQuest()
    {
        Name = "UNL Team Jump Quest";
        Description = "Beginning as an experimental exploration of a livestreaming platform's API evolving to become" +
        " a practical solution for a competitive gaming community. UNL Team Jump Quest allows for real-time audience" + 
        " participation through chat commands, enhancing viewer experience during breaks between matches.";
        DateStarted = new DateTime(2024, 8, 3); 
        DateFinished = new DateTime(2024, 8, 31);
        PrimaryCategory = PrimaryCategory.Game;
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
        VideoDemo = "https://www.youtube.com/watch?v=A2n6WIh7ekM";
        GitHubLink = "https://github.com/vinzmyko/twitch-jump-quest";
    }
}