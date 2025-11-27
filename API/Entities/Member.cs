using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;
using System.Text.Json.Serialization;
using Microsoft.Net.Http.Headers;

namespace API.Entities;

public class Member
{
    public string Id { get; set; } = Guid.NewGuid().ToString(); 
    public string AppUserId { get; set; } = null!; 

    [JsonIgnore]
    [ForeignKey(nameof(Id))]
    public AppUser User { get; set; } = null!;
    public DateOnly DateOfBirth { get; set; }
    public string? ImageUrl { get; set; }
    public required string DisplayName { get; set; }
    public DateTime Created { get; set;} = DateTime.UtcNow;
    public DateTime LastActive {get;set; } = DateTime.UtcNow;
    public required string Gender { get; set; }
    public string? Description {get; set;}
    public required string City {get; set;}
    public required string Country {get; set; }

    [JsonIgnore]
    public List<Photo> Photos { get; set; } = [];

    [JsonIgnore]
    public List<MemberLike> LikedByMembers { get; set; } = [];
    [JsonIgnore]
    public List<MemberLike> LikedMembers { get; set; } = [];

    [JsonIgnore]
    public List<Message> MessagesSent { get; set; } = [];
    [JsonIgnore]
    public List<Message> MessagesReceived { get; set; } = [];

}
