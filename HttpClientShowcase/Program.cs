using HttpClientShowcase;
using HttpClientShowcase.Models;

Console.WriteLine("Http Client demo...\n");
var serializationDemo = new SerializationDemo();
//var jsonStrings = serializationDemo.RunSerialization();
//serializationDemo.RunDeserialization(jsonStrings);
var client = new HttpClient();
var httpClientDemo = new HttpClientDemo(client);
//var hello = await httpClientDemo.Hello("Mateusz");
//Console.WriteLine(hello);*/
await httpClientDemo.GetRandomjoke();
await httpClientDemo.GetRandomCatInfo();
await httpClientDemo.GetRandomDogImage();
await httpClientDemo.PredictGender("ala");

var email = new Email
{
    To = "qq118673@gmail.com",
    Subject = "App test.",
    Messege = "Hello"
};
await httpClientDemo.SendEmail(email);

await httpClientDemo.Activity();

await httpClientDemo.CurrentPriceResponse();


