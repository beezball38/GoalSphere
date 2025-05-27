namespace GoalSettingApp.SharedKernel.Entities;

public abstract class BaseEntity
{
    public Guid Id { get; set; } = Ulid.NewUlid().ToGuid(); 
    public DateTime CreatedTime { get; set; }
}