﻿namespace KinoPoisk.KinoPoisk.BL.Users.Model;

public class UpdateUserModel
{
    public int Id { get; set; }
    
    public string? UserName { get; set; }
    
    public string? PasswordHash { get; set; }
}