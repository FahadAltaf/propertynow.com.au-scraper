using CsvHelper;
using Newtonsoft.Json;
using propertynow.com.au_scraper;
using System.Formats.Asn1;
using System.Globalization;

var text = File.ReadAllText("data.json");

var data = JsonConvert.DeserializeObject<Root>(text);
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
}

using (var writer = new StreamWriter("file.csv"))
using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
{
    csv.WriteRecords(entries);
}

Console.WriteLine("Operation has been completed");
Console.ReadLine();