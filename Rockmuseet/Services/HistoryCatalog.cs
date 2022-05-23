using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rockmuseet.models;

namespace Rockmuseet.Services
{
    public class HistoryCatalog
    {
        private List<History> histories { get; }
        List<History> _historyItems;
        public HistoryCatalog()
        {
            _historyItems = new List<History>();

        }

        public void Add(History history)
        {
            _historyItems.Add(history);
        }



        public void UpdatHistory(History history)
        {
            foreach (var h in histories)
            {
                if (h.Id == history.Id)
                {
                    h.Name = history.Name;
                    h.Image = history.Image;
                    h.Description = history.Description;
                    h.MusicAudioId = history.MusicAudioId;
                    h.MusicAudio = history.MusicAudio;
                    h.HistoryAudioId = history.HistoryAudioId;
                    h.HistoryAudio = history.HistoryAudio;
                }
            }





        }
        public void RemoveHistory()
        {
            foreach (var history in _historyItems)
            {
                _historyItems.Remove(history);
                break;
            }

        }


    }
}
