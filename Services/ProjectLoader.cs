using System.Reflection;
using PersonalWebsite.Models;

namespace PersonalWebsite.Services;

public static class ProjectLoader
{
    private static List<Project>? _ProjectsList;

    public static List<Project> LoadProjects()
    {
        if (_ProjectsList != null)
        {
            return _ProjectsList;
        }

        _ProjectsList = Assembly.GetExecutingAssembly() // Get's all the code in project
            .GetTypes() // Find all the classes in project
            .Where(t => t.IsSubclassOf(typeof(Project)) && !t.IsAbstract) // Only find classes 
            // that are based around the 'Project' class and subclasses of it
            .Select(t => Activator.CreateInstance(t) as Project) // For each class found, create an instance
            // and treat is as a Project.
            .Where(project => project != null) // Removes null instances of project
            .Cast<Project>()
            .OrderByDescending(p => p.DateStarted)
            .ToList();

        return _ProjectsList;
    }

    public static IEnumerable<PrimaryCategory> GetAvailablePrimaryCategories()
    {
        return LoadProjects().Select(p => p.PrimaryCategory).Distinct();
    }

    public static IEnumerable<Technology> GetAvailableTechnologies()
    {
        return LoadProjects().SelectMany(p => p.Technologies).Distinct();
    }

    public static IEnumerable<ProjectScale> GetAvailableScales()
    {
        return LoadProjects()
            .Select(p => p.Scale)
            .Where(s => s.HasValue)
            .Select(s => s!.Value)
            .Distinct();
    }
}