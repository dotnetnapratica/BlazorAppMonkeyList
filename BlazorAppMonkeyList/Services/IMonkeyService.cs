using BlazorAppMonkeyList.Models;

namespace BlazorAppMonkeyList.Services
{
    public interface IMonkeyService
    {
        Task<List<Monkey>> FindAll();
    }
}
