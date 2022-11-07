using RoleplayGame.Scenarios;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            ChapterOne scenario = new ChapterOne();
            scenario.Setup();
            scenario.Run();
        }
    }
}
