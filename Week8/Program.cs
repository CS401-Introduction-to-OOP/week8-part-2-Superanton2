using Week8;

FileResource file = new FileResource("report.txt");
NetworkResource network = new NetworkResource("api.company.local");
ResourceManager<Resource> manager = new ResourceManager<Resource>();

// 1. Add resources to manager
manager.Add(file);
manager.Add(network);

// 2. Open all resources
manager.OpenAll();

// 3. Demonstrate using with one disposable resource
using(var res = new FileResource("file"))
{
    res.Open();
}

// 4. Close all resources
manager.CloseAll();

Console.WriteLine("Done.");