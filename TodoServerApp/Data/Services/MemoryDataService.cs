using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataService
    {
        public static IEnumerable<TaskItem> tasks { get; } = [
            new(){ ID = 1, Title="Задание 1", Description="Описание задачи 1", CratedDate=DateTime.Now },
            new (){ ID = 2, Title="Задание 2", Description="Описание задачи 2", CratedDate=DateTime.Now },
            new (){ ID = 3, Title="Задание 3", Description="Описание задачи 3", CratedDate=DateTime.Now },
        ];


        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(tasks);
        }
    }
}
