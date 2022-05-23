using System;
using System.Collections.Generic;
using Rockmuseet.models;
using Rockmuseet.Helpers;
using Rockmuseet.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace Rockmuseet.Services
{
    public class HistoryJson : IHistoryRepository
    {
        const string JsonFileName = @"Data\JsonHistory.json";


        public void AddHistory(History history)
        {
            List<History> histories = JsonFileReader.ReadJsonHistory(JsonFileName);
            histories.Add(history);
            JsonFileWritter.WriteToJsonHistory(histories, JsonFileName);
        }

        public List<History> GetAllHistories()
        {
            return JsonFileReader.ReadJsonHistory(JsonFileName);
        }

        public History GetHistory(int Id)
        {
            List<History> histories = JsonFileReader.ReadJsonHistory(JsonFileName);
            return histories[Id];
        }

        public void UpdateHistory(History history)
        {
            List<History> histories = JsonFileReader.ReadJsonHistory(JsonFileName);
            if (histories == null)
            {
                histories[history.Id] = history;
            }
            JsonFileWritter.WriteToJsonHistory(histories, JsonFileName);

        }
        public void DeleteHistory(History history)
        {
            List<History> histories = JsonFileReader.ReadJsonHistory(@"Data\JsonHistory.json");
            histories.Remove(history);
            JsonFileWritter.WriteToJsonHistory(histories, JsonFileName);

        }
    }
}
