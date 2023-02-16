using BaltaPOO.ContentContext;
using BaltaPOO.SubscriptionContext;

namespace BaltaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .Net", "dotnet"));

            // foreach (var article in articles)
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);
            // }

            var courses = new List<Course>();

            var courseOOP = new Course("Fundamento OOP", "fundamento-oop");
            var courseCsharp = new Course("Fundamento C#", "fundamento-csharp");
            var courseAspNet = new Course("Fundamento .Net", "fundamento-dotnet");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careerDotNet = new Career("Especialista .Net", "especialista-dotnet");

            var careerItem = new CareerItem(1, "Comece por aqui", "", courseOOP);
            var careerItem3 = new CareerItem(2, "Aprenda C#", "", courseCsharp);
            var careerItem2 = new CareerItem(3, "Aprenda .Net", "", null);
            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem3);
            careerDotNet.Items.Add(careerItem);

            var careers = new List<Career>();
            careers.Add(careerDotNet);

            // foreach (var career in careers)
            // {
            //     Console.WriteLine(career.Title);

            //     foreach (var item in career.Items.OrderBy(x => x.Order))
            //     {
            //         Console.WriteLine($"{item.Order} - {item.Title}");
            //         Console.WriteLine(item.Course?.Title);
            //         Console.WriteLine(item.Course?.Level);

            //         foreach (var notification in item.Notifications)
            //         {
            //             Console.WriteLine($"{notification.Property} - {notification.Message}");
            //         }
            //     }
            // }

            var payPalSubscription = new PayPalSubscription();
            var student = new Student();

            student.CreateSubscription(payPalSubscription);
        }
    }
}