using _06_EF_CodeFirst;
using _06_EF_CodeFirst.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        CompanyDB context = new CompanyDB();

        // add countries
        /*context.Countries.Add(new Country() { Name = "Ukraine" });
        context.Countries.Add(new Country() { Name = "Poland" });
        context.Countries.Add(new Country() { Name = "USA" });
        context.SaveChanges();

        // add departmens
        context.Departments.Add(new Department() { Name = "Management", Phone = "14-85-96" });
        context.Departments.Add(new Department() { Name = "Programming", Phone = "74-85-96" });
        context.Departments.Add(new Department() { Name = "Design", Phone = "12-96-54" });
        context.SaveChanges();

        //Workers
        var w1 = new Worker()
        {
            Name = "Emma",
            Surname = "Miller",
            Salary = 2500,
            Birthdate = new DateTime(2005, 2, 3),
            Country = context.Countries.FirstOrDefault(c => c.Name == "Ukraine")!,
            Department = context.Departments.FirstOrDefault(d => d.Name == "Design")!
        };
        var w2 = new Worker()
        {
            Name = "Oleg",
            Surname = "King",
            Salary = 3300,
            Birthdate = new DateTime(2007, 4, 23),
            Country = context.Countries.FirstOrDefault(c => c.Name == "Poland")!,
            Department = context.Departments.FirstOrDefault(d => d.Name == "Management")!
        };
        var w3 = new Worker()
        {
            Name = "Tomm",
            Surname = "Joe",
            Salary = 4300,
            Birthdate = new DateTime(2002, 12, 12),
            Country = context.Countries.FirstOrDefault(c => c.Name == "USA")!,
            Department = context.Departments.FirstOrDefault(d => d.Name == "Programming")!
        };
        //Projects
        var p1 = new Project() { Name = "Tetris", LaunchDate = new DateTime(1982, 12, 12) };
        var p2 = new Project() { Name = "PacMan", LaunchDate = new DateTime(2003, 12, 12) };
        var p3 = new Project() { Name = "CS", LaunchDate = new DateTime(2012, 12, 12) };

        context.Projects.AddRange(new[] { p1, p2, p3 });
        context.Workers.AddRange(new[] { w1, w2, w3 });
        context.SaveChanges();

        //w1.Country = context.Countries.FirstOrDefault(c => c.Name == "Ukraine");
        w1.Projects.Add(p1);
        w1.Projects.Add(p2);

        w2.Projects.Add(p3);
        w2.Projects.Add(p2);

        w3.Projects.Add(p3);
        w3.Projects.Add(p1);



        context.SaveChanges();
        var w = context.Workers.FirstOrDefault(w => w.Name == "Emma");
        var p = context.Projects.FirstOrDefault(p => p.Name == "Tetris");
        w.Projects.Add(p);
        context.SaveChanges();

        Console.WriteLine(context.Projects.First().Workers.Count());*/



        /*foreach (var work in context.Workers)
        {
            Console.WriteLine($"\n\n {new string('-', 50)}");
            Console.WriteLine($"---------- User {work.Id} {work.FullName} \n Department : {work.DepartmentId} {work.Salary} \n Birthdate :: {(work.Birthdate.HasValue ? work.Birthdate.Value.ToShortDateString() : "No Birth Date")}");
            Console.WriteLine($" Country :: {work.CountryId}");
            foreach (var item in work.Projects)
            {
                Console.WriteLine($"Project {item.Name} from {item.LaunchDate.ToShortDateString()}");
            }
        }*/
       /* Worker worker = context.Workers.Find(1);
        if (worker == null)
        {
            Console.WriteLine("Worker not found");
            return;
        }
        // Load Reference
        context.Entry(worker).Reference(nameof(Worker.Department)).Load();
        Console.WriteLine($"---- Worker [{worker.Id}] {worker.Name}");
        Console.WriteLine($"Department :: {worker.Department?.Name}"); // department reference

        // load Collection
        context.Entry(worker).Collection(nameof(Worker.Projects)).Load();
        foreach (var item in worker.Projects)
        {
            Console.WriteLine($"\t Project :: {item.Name}");
        }
*/

    }
}