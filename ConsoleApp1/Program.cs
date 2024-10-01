HttpClient client = new();

HttpResponseMessage response =
	await client.GetAsync("https://ecourier.iasghana.com/");

Console.WriteLine(response.Content.ReadAsStringAsync().Result);
Console.Read();
