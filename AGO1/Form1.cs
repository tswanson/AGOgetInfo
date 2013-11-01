using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Net;
using System.IO;
using System.Collections;

namespace AGO1
{
  public partial class AGO_Org : Form
  {
    
    public AGO_Org()
    {
      InitializeComponent();
      
    }

    private void goBtn_Click(object sender, EventArgs e)
    {
      string orgToken = "";
      // create a writer and open the file
      TextWriter tw = new StreamWriter("c:\\Temp\\AGO_Org.csv",false);
      // write a line of text to the file
      logTxt.ScrollBars = ScrollBars.Vertical;
      tw.WriteLine("id,item,itemType,owner,folder,uploaded,modified,name,title,type,tags,access,size,numComments,numRatings,avgRatings,numViews");
        // Get a token for the organization site.
      try
      {
        string tokenURL = GetTokenUrl(orgTxt.Text, userTxt.Text, pwdTxt.Text);
      //  logTxt.Text += tokenURL + "\n";
        TokenResponse tokenResponse = MakeTokenRequest(tokenURL,logTxt);
        orgToken = ProcessTokenResponse(tokenResponse);
      }
      catch (Exception ex)
      {

        logTxt.Text += ex.Message + "\n";
        tw.Close();
      }

      //Find all the users of the org site
      ArrayList userList = new ArrayList();

      try
      {
        string getUsersURL = GetUsersUrl(orgTxt.Text, orgToken);
        logTxt.Text += getUsersURL + "\n";
        UsersResponse usersResponse = MakeUsersRequest(getUsersURL, logTxt);
        userList = ProcessUsersResponse(usersResponse);
      }
      catch (Exception ex)
      {
        logTxt.Text += ex.Message + "\n";
        tw.Close();
      }
      dataGridView1.DataSource = userList;

      for (int i = 0; i < userList.Count; i++)
      {
        try
        {
          User tempUser = (User)userList[i];
          string locationsRequest = GetUserUrl(orgTxt.Text, tempUser.Username, orgToken);
          logTxt.Text += locationsRequest + "\n";
          Response locationsResponse = MakeRequest(locationsRequest, logTxt);
          ProcessResponse(locationsResponse,"",tw);
          for (int j = 0; j < locationsResponse.Folders.Length; j++)
          {
            string folderRequest = GetFolderUrl(orgTxt.Text, tempUser.Username, orgToken,locationsResponse.Folders[j].Id);
            Response folderResponse = MakeRequest(folderRequest, logTxt);
            ProcessResponse(folderResponse, locationsResponse.Folders[j].Title, tw);
          }
        }
        catch (Exception ex)
        {
          logTxt.Text += ex.Message + "\n";
   //       tw.Close();
        }

      }
      tw.Close();
      logTxt.Text += "\nFinished" + "\n";
    }
    public static string GetTokenUrl(string org, string user, string pwd)
    {

      string UrlRequest = "https://"+
                           org+
                           ".maps.arcgis.com/sharing/generateToken?username=" +
                           user+
                           "&password="+
                           pwd+
                           "&referer=anything&expiration=1000&f=pjson";
      return (UrlRequest);
    }
    public static string GetUsersUrl(string org, string token)
    {

      string UrlRequest = "https://" +
                          org +
                          ".maps.arcgis.com/sharing/accounts/self/users?start=1&num=100&sortField=fullname&sortOrder=asc&f=pjson&token=" +
                          token;
      return (UrlRequest);
    }
    public static string GetUserUrl(string org, string user, string token)
  {
    
    string UrlRequest = "https://"+
                        org+
                        ".maps.arcgis.com/sharing/content/users/"+
                        user+
                        "//?f=pjson&token="+
                        token;
      return (UrlRequest);
  }
    public static string GetFolderUrl(string org, string user, string token, string folderId)
    {

      string UrlRequest = "https://" +
                          org +
                          ".maps.arcgis.com/sharing/content/users/" +
                          user +
                          "/"+
                          folderId+
                          "/?f=pjson&token=" +
                          token;
      return (UrlRequest);
    }

  public static Response MakeRequest(string requestUrl, TextBox logTxt)
  {
    try
    {
      HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
      using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
      {
        if (response.StatusCode != HttpStatusCode.OK)
          throw new Exception(String.Format(
          "Server error (HTTP {0}: {1}).",
          response.StatusCode,
          response.StatusDescription));
        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Response));
        object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
        Response jsonResponse
        = objResponse as Response;
        return jsonResponse;
      }
    }
    catch (Exception ex)
    {
      
      logTxt.Text += ex.Message+"\n";
      return null;
    }
  }

  public static TokenResponse MakeTokenRequest(string requestUrl, TextBox logTxt)
  {
    try
    {
      HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
      using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
      {
        if (response.StatusCode != HttpStatusCode.OK)
          throw new Exception(String.Format(
          "Server error (HTTP {0}: {1}).",
          response.StatusCode,
          response.StatusDescription));
        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(TokenResponse));
        object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
        TokenResponse jsonResponse
        = objResponse as TokenResponse;
        return jsonResponse;
      }
    }
    catch (Exception ex)
    {
      logTxt.Text += ex.Message + "\n";
      return null;
    }
  }
  public static UsersResponse MakeUsersRequest(string requestUrl, TextBox logTxt)
  {
    try
    {
      HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
      using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
      {
        if (response.StatusCode != HttpStatusCode.OK)
          throw new Exception(String.Format(
          "Server error (HTTP {0}: {1}).",
          response.StatusCode,
          response.StatusDescription));
       /* using (Stream stream = response.GetResponseStream())
        {
          StreamReader reader = new StreamReader(stream, Encoding.UTF8);
          String responseString = reader.ReadToEnd();
        }
        */
        DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(UsersResponse));
        
        object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
        UsersResponse jsonResponse
        = objResponse as UsersResponse;
        return jsonResponse;
      }
    }
    catch (Exception ex)
    {
      logTxt.Text += ex.Message + "\n";
      return null;
    }
  }
  static public void ProcessResponse(Response userResponse, string folder,TextWriter tw)
  {
    int itemsNum = userResponse.Items.Length;

    for (int i = 0; i < itemsNum; i++)
    {
       
    string id = quoteString(userResponse.Items[i].Id);
    string item = quoteString(userResponse.Items[i].Item);
    string itemType = quoteString(userResponse.Items[i].ItemType);
    string owner = quoteString(userResponse.Items[i].Owner);
    string uploaded = UnixMillisecondsTimeStampToDateTime(userResponse.Items[i].Uploaded);
    string modified = UnixMillisecondsTimeStampToDateTime(userResponse.Items[i].Modified);
    string name = quoteString(userResponse.Items[i].Name);
    string title = quoteString(userResponse.Items[i].Title);
    string type = quoteString(userResponse.Items[i].Type);
    string typeKeyword = quoteString(userResponse.Items[i].TypeKeywords);
    string description =quoteString( userResponse.Items[i].Description);
    string tags = quoteString(userResponse.Items[i].Tags);
    string documentation = quoteString(userResponse.Items[i].Documentation);
 //   Array extent = userResponse.Items[i].Extent;
    long lastModified = userResponse.Items[i].LastModified;
    string spatialReference = quoteString(userResponse.Items[i].SpatialReference);
    string accessInformation = quoteString(userResponse.Items[i].AccessInformation);
    string licenseInfo = quoteString(userResponse.Items[i].LicenseInfo);
    string culture = quoteString(userResponse.Items[i].Culture);
    string url = quoteString(userResponse.Items[i].Url);
    string access = quoteString(userResponse.Items[i].Access);
    double size = byteToMB(userResponse.Items[i].Size);
    long numComments = userResponse.Items[i].NumComments;
    long numRatings = userResponse.Items[i].NumRatings;
    double avgRatings = userResponse.Items[i].AvgRating;
    long numViews = userResponse.Items[i].NumViews;

    // write a line of text to the file
    tw.WriteLine(id + "," + item + "," + itemType + "," + owner + "," + folder + "," + uploaded + "," + modified + "," + name + "," + title + "," + type + "," +
                 tags+","+access+","+size+","+numComments+","+numRatings+","+avgRatings+","+numViews);
      
    }
    
  }
  static public string quoteString(string str)
  {
    return "\"" + str + "\"";
  }
  static public string quoteString(Array ar)
  {
    string str = "";
    foreach (string s in ar)
    {
      if (str.Equals(""))
        str = s;
      else
        str = str + "," + s;
    }
    return quoteString(str);
  }

  static public double byteToMB(long bytes)
  {
    
    return Math.Round(((double)bytes / 1048576.0),2);
  }
  static public string epochToDateTime(long epoch)
  {
    DateTime date = new DateTime(epoch, DateTimeKind.Utc);
    return date.ToString();

  }
  public static string UnixMillisecondsTimeStampToDateTime(long unixTimeStamp)
  {

     System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
    dtDateTime = dtDateTime.AddMilliseconds((double)unixTimeStamp).ToLocalTime();
    return dtDateTime.ToString();
  }
  static public string ProcessTokenResponse(TokenResponse Response)
  {
    return Response.Token;


  }
  static public ArrayList ProcessUsersResponse(UsersResponse usersResponse)
  {
    ArrayList ar = new ArrayList();
    int usersNum = usersResponse.Users.Length;

    for (int i = 0; i < usersNum; i++)
    {
      ar.Add(usersResponse.Users[i]);
    }
    
    return ar;
  }

  private void label5_Click(object sender, EventArgs e)
  {

  }

  
  }
}
