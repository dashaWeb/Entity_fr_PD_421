using _07_EF___data_annotation___fluent_api;

internal class Program
{
    private static void Main(string[] args)
    {
        CompanyDB context = new CompanyDB();
        /* context.Workers.FirstOrDefault(n => n.Name == "Emma").Projects.Add(context.Projects.FirstOrDefault(n => n.Name == "Tetris"));
         context.Workers.FirstOrDefault(n => n.Name == "Tomm").Projects.Add(context.Projects.FirstOrDefault(n => n.Name == "Tetris"));
         context.Workers.FirstOrDefault(n => n.Name == "Oleg").Projects.Add(context.Projects.FirstOrDefault(n => n.Name == "Tetris"));


         context.Workers.FirstOrDefault(n => n.Name == "Emma").Projects.Add(context.Projects.FirstOrDefault(n => n.Name == "PacMan"));
         context.Workers.FirstOrDefault(n => n.Name == "Oleg").Projects.Add(context.Projects.FirstOrDefault(n => n.Name == "PacMan"));

         context.SaveChanges();*/

        var workers = context.Workers.ToList();

        foreach (var worker in workers)
        {
            Console.WriteLine($"\n\n {new string('-', 50)}");
            Console.WriteLine($"\t {worker.Name,16} {worker.Surname,16}");
            Console.WriteLine($"\t\t Birthdate :: {worker.Birthdate.Value.ToShortDateString()}");
            Console.WriteLine($"\t\t Salary    :: {worker.Salary}$");
            context.Entry(worker).Reference(nameof(worker.Country)).Load();
            Console.WriteLine($"\t\t Country   :: {worker.Country.Name}");
            context.Entry(worker).Reference(nameof(worker.Department)).Load();
            Console.WriteLine($"\t\t Department:: {worker.Department.Name}");

            context.Entry(worker).Collection(nameof(worker.Projects)).Load();
            foreach (var item in worker.Projects)
            {
                Console.WriteLine($"\t\t{new string('-', 30)}");
                Console.WriteLine($"\t\t\t{item.Name}  {item.LaunchDate}");
            }
        }

    }
}