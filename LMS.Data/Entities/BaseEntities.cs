namespace LMS.Data.Entities;

public class BaseEntities
{
    public int Id { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? LastUpdatedDate { get; set; }
    public bool? IsActive { get; set; }
}