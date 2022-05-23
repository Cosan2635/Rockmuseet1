using System;
using System.Collections.Generic;
using Rockmuseet.models;
using System.Linq;
using System.Threading.Tasks;

namespace Rockmuseet.Interfaces
{
    public interface IHistoryRepository
    {
        public List<History> GetAllHistories();
        public void AddHistory(History history);
        public void UpdateHistory(History history);
        public void DeleteHistory(History history);
        public History GetHistory(int Id);

    }
}