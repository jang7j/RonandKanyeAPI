using Newtonsoft.Json.Linq;



for (var i = 0; i < 5; i++)
{
    var client = new HttpClient();

    var ron = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
    string ronSays = client.GetStringAsync(ron).Result;
    var ronObject = JArray.Parse(ronSays);



    var kanye = "https://api.kanye.rest";                      //URL                             
    string kanyeSays = client.GetStringAsync(kanye).Result;   //responses
    var kanyeObject = JObject.Parse(kanyeSays);

    Console.WriteLine($"Ron says: {ronObject[0]}");
    Console.WriteLine($"Ye says: {kanyeObject["quote"]}");
    Console.WriteLine();
}




























