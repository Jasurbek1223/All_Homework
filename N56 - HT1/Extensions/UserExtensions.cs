using N56___HT1.Models;

namespace N56___HT1.Extensions;

public static class UserExtensions
{
    public static void InitializeUserFoldersAsync(this User user)
    {
        // Path hosil qilyabmiz 
        var path = Path.Combine(Directory.GetCurrentDirectory(), "Storage", "User");

        // Agar yaratilmagan bo'lsa yaratamiz
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
    
        // UserId ni qo'shib Path manzilini olamiz
        var userPath = Path.Combine(path, user.Id.ToString());

        if (!Directory.Exists(userPath))
            Directory.CreateDirectory(userPath);

        // Bu yerda "Profile" va "Resume" nomli papkalar manzillarni olamiz
        var userProfilePath = Path.Combine(userPath, "Profile");
        var userResumePath = Path.Combine(userPath, "Resume");

        if (!Directory.Exists(userProfilePath))
            Directory.CreateDirectory(userProfilePath);
        
        if(!Directory.Exists(userResumePath))
            Directory.CreateDirectory(userResumePath);
    }
}
