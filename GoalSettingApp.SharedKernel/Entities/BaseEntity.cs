namespace GoalSettingApp.SharedKernel.Entities;

public abstract class BaseEntity
{
    public Guid Id { get; set; } 
    public DateTime CreatedTime { get; set; }
}