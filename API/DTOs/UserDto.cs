using System;
using System.Security.AccessControl;

namespace API.DTOs;

public class UserDto
{
public required string Id { get; set; }
public string MemberId { get; set; } = null!;
public required string Email { get; set; }
public required string DisplayName { get; set; }
public string? ImageUrl { get; set; }
public required string Token { get; set; }
}
