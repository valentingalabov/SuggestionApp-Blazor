namespace SuggestionAppLibrary.Models;

public class BasicUserMode
{
   [BsonId]
   [BsonRepresentation(BsonType.ObjectId)]
   public string Id { get; set; }

   public string DisplayName { get; set; }

   public BasicUserMode()
   {

   }

   public BasicUserMode(UserModel user)
   {
      Id = user.Id;
      DisplayName = user.DisplayName;
   }
}
