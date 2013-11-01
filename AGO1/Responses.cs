using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System;

namespace AGO1
{
  [DataContract]
  public class Response
  {
    [DataMember(Name = "username")]
    public string Username { get; set; }
    [DataMember(Name = "currentFolder")]
    public CurrentFoldr[] CurrentFolder { get; set; }
    [DataMember(Name = "items")]
    public Items[] Items { get; set; }
    [DataMember(Name = "folders")]
    public Folder[] Folders { get; set; }
  }


  [DataContract]
  public class CurrentFoldr
  {
      [DataMember(Name = "username")]
    public string Username { get; set; }
    [DataMember(Name = "id")]
    public string Id { get; set; }
    [DataMember(Name = "title")]
    public string Title { get; set; }
    [DataMember(Name = "created")]
    public long created { get; set; }
   }

  [DataContract]
  public class Items
  {
    [DataMember(Name = "id")]
    public string Id { get; set; }
    [DataMember(Name = "item")]
    public string Item { get; set; }
    [DataMember(Name = "itemType")]
    public string ItemType { get; set; }
    [DataMember(Name = "owner")]
    public string Owner { get; set; }
    [DataMember(Name = "uploaded")]
    public long Uploaded { get; set; }
    [DataMember(Name = "modified")]
    public long Modified { get; set; }
    [DataMember(Name = "name")]
    public string Name { get; set; }
    [DataMember(Name = "title")]
    public string Title { get; set; }
    [DataMember(Name = "type")]
    public string Type { get; set; }
    [DataMember(Name = "typeKeywords")]
    public Array TypeKeywords { get; set; }
    [DataMember(Name = "description")]
    public string Description { get; set; }
    [DataMember(Name = "tags")]
    public Array Tags { get; set; }
    [DataMember(Name = "documentation")]
    public string Documentation { get; set; }
//    [DataMember(Name = "extent")]
//    public Array Extent { get; set; }
    [DataMember(Name = "lastModified")]
    public long LastModified { get; set; }
    [DataMember(Name = "spatialRefernce")]
    public string SpatialReference { get; set; }
    [DataMember(Name = "accessInformation")]
    public string AccessInformation { get; set; }
    [DataMember(Name = "licenseInfo")]
    public string LicenseInfo { get; set; }
    [DataMember(Name = "culture")]
    public string Culture { get; set; }
    [DataMember(Name = "url")]
    public string Url { get; set; }
    [DataMember(Name = "access")]
    public string Access { get; set; }
    [DataMember(Name = "size")]
    public long Size { get; set; }
    [DataMember(Name = "numComments")]
    public long NumComments { get; set; } 
    [DataMember(Name = "numRatings")]
    public long NumRatings { get; set; }
    [DataMember(Name = "avgRating")]
    public double AvgRating { get; set; }
    [DataMember(Name = "numViews")]
    public long NumViews { get; set; }
   
  }
 

  [DataContract]
  public class Folder
  {
    [DataMember(Name = "username")]
    public string Username { get; set; }
    [DataMember(Name = "id")]
    public string Id { get; set; }
    [DataMember(Name = "title")]
    public string Title { get; set; }
    [DataMember(Name = "created")]
    public long Created { get; set; }
  }
  [DataContract]
  
  public class TokenResponse
  {
    [DataMember(Name = "token")]
    public string Token { get; set; }
    [DataMember(Name = "expires")]
    public long Expires { get; set; }
    [DataMember(Name = "ssl")]
    public bool Ssl { get; set; }
    
  }
  [DataContract]
  public class UsersResponse
  {
    [DataMember(Name = "total")]
    public long Total { get; set; }
    
     [DataMember(Name = "start")]
    public long Start { get; set; }
    [DataMember(Name = "num")]
    public long Num { get; set; }
    [DataMember(Name = "nextStart")]
    public long NextStart { get; set; }
   
    [DataMember(Name = "users")]
    public User[] Users { get; set; }
   
  }
  [DataContract]
  public class User
  {
     
    [DataMember(Name = "username")]
    public string Username { get; set; }
    [DataMember(Name = "fullName")]
    public string FullName { get; set; }
    [DataMember(Name = "preferredView")]
    public string PreferredView { get; set; }
    [DataMember(Name = "description")]
    public string Description { get; set; }
    [DataMember(Name = "email")]
    public string Email { get; set; }
    [DataMember(Name = "privacy")]
    public string Privacy { get; set; }
    [DataMember(Name = "access")]
    public string Access { get; set; }
    [DataMember(Name = "storageUsage")]
    public long StorageUsage { get; set; }
    [DataMember(Name = "storageQuota")]
    public long StorageQuota { get; set; }
    [DataMember(Name = "accountId")]
    public string AccountId { get; set; }
    [DataMember(Name = "role")]
    public string Role { get; set; }
    [DataMember(Name = "created")]
    public long Created { get; set; }
    [DataMember(Name = "modified")]
    public long Modified { get; set; }
    
  }

}
