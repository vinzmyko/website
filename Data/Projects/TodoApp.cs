using PersonalWebsite.Models;

namespace PersonalWebsite.Data.Projects;

public class TodoApp : Project
{
    public TodoApp()
    {
        Name = "TodoApp";
        DateStarted = new DateTime(2024, 9, 11); 
        DateFinished = new DateTime(2024, 9, 22);
        PrimaryCategory = PrimaryCategory.WebDevelopment;
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
            ProgrammingLanguage.Csharp
        };
    }
}