using GoalSettingApp.SharedKernel.Entities;

namespace GoalSettingApp.Core.Entities;

public class Goal: BaseEntity
{
    public required string Title { get; set; }
    public string? Description { get; set; }
}