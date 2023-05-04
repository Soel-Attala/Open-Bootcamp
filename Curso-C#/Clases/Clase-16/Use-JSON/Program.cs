//How to get a JSON file for an API and use the file content
using System.Net;

//we create a request and response to get the JSON file
HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://cat-fact.herokuapp.com/facts");
HttpWebResponse response = (HttpWebResponse)request.GetResponse()) ;
Stream stream = response.GetResponseStream();
StreamReader reader = new StreamReader(stream);


var json = reader.ReadToEnd();
Console.WriteLine(json);

