using PersonalWebsite.Models;
using PersonalWebsite.Data.Projects;
using PersonalWebsite.Factories;

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

        _ProjectsList = new List<Project>
        {
            ProjectFactory.CreatePokemonAutoBattler(),
            ProjectFactory.CreateMdello(),
            ProjectFactory.CreateNewsletterBackendAPI(),
            ProjectFactory.CreatePMDScraper(),
            ProjectFactory.CreateUNLTeamJumpQuest(),
            ProjectFactory.CreateTodoApp(),
            ProjectFactory.PersonalWebsite(),
        }
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

    public static List<string> GetFilterOptions()
    {
        var options = new List<string> { "Featured", "All" };
        var categories = GetAvailablePrimaryCategories().Select(c => c.ToString()).ToList();
        options.AddRange(categories);
        return options;
    }

    public static List<Project> GetFilteredProjects(PrimaryCategory? category = null, string sortOption = "Latest")
    {
        string? filterOption = category?.ToString();
        return GetFilteredProjects(filterOption, sortOption);
    }

    public static List<Project> GetFilteredProjects(string? filterOption, string sortOption = "Latest")
    {
        var projects = LoadProjects();

        if (!string.IsNullOrEmpty(filterOption))
        {
            if (filterOption == "Featured")
            {
                projects = projects.Where(p => p.IsFeatured).ToList();
            }
            else if (filterOption != "All" && Enum.TryParse<PrimaryCategory>(filterOption, out var category))
            {
                projects = projects.Where(p => p.PrimaryCategory == category).ToList();
            }
        }

        return sortOption switch
        {
            "Latest" => projects.OrderByDescending(p => p.DateStarted).ToList(),
            "Oldest" => projects.OrderBy(p => p.DateStarted).ToList(),
            "In Progress" => projects.Where(p => p.DateFinished == null).OrderByDescending(p => p.DateStarted).ToList(),
            "Completed" => projects.Where(p => p.DateFinished != null).OrderByDescending(p => p.DateFinished ?? p.DateStarted).ToList(),
            _ => projects
        };
    }
}
