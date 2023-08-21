using CsvHelper;
using Newtonsoft.Json;
using propertynow.com.au_scraper;
using System.Formats.Asn1;
using System.Globalization;
using System.Net.Http.Json;

var client = new HttpClient();
var request = new HttpRequestMessage(HttpMethod.Get, "https://api.propertynow.com.au/api/public-listings?status[]=active&status[]=under-offer&search=&order[createdAt]=desc&type=sale&itemsPerPage=5&property.propertyType.id=%2Fapi%2Fproperty-types%2F810ba2d8-f40d-4f9c-b731-75bde427f2ca");
var response = await client.SendAsync(request);
response.EnsureSuccessStatusCode();
var data = JsonConvert.DeserializeObject<Root>(await response.Content.ReadAsStringAsync());
List<DataModel> entries = new List<DataModel>();
foreach (var row in data.hydramember)
{
    DataModel model = new DataModel()
    {
        EmailAddress = row.contactDetail.email,
        MobileNumber = row.contactDetail.phone,
        Name = row.contactDetail.name,
        PropertyAddress = row.property.displayAddress
    };
    entries.Add(model);
    Console.WriteLine(model.PropertyAddress);
}

using (var writer = new StreamWriter("file.csv"))
using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
{
    csv.WriteRecords(entries);
    Console.WriteLine("File has been exported");
}

Console.WriteLine("Operation has been completed");
Console.ReadLine();