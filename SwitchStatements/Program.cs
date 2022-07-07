Console.WriteLine("What is your favorite subject in school?");
string favSubject = Console.ReadLine();

switch (favSubject.ToLower())
{
    case "science":
        Console.WriteLine("Nice! I love science!");
        break;

    case "math":
        Console.WriteLine("Math is cool! Without math, nothing would exist!");
        break;

    case "english":
        Console.WriteLine("Really? Reading is for nerds! JK");
        break;

    case "history":
        Console.WriteLine("History is awesome! So much stuff happened in the past.");
        break;

    case "foreign language":
        Console.WriteLine("Being bilingual is impressive! Keep studying!");
        break;

    default:
        Console.WriteLine("I never took that subject, cheers to you for being different!");
        break;
}
