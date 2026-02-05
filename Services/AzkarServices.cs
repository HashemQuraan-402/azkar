using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using اذكاري.Models;


namespace اذكاري.Services
{
    public class AzkarServices
    {

        public void detrmineTheCompletionOfAll(Azkar azkar)
        {
            
            azkar.indexsForNotCompleteZekers = new List<int>();
                azkar.Complete = true;
                for (int i = 0; i < azkar.zekers.Count; i++)
                {
                    if (!azkar.zekers[i].Complete)
                    {
                        azkar.indexsForNotCompleteZekers.Add(i);
                    }
                }


            if (azkar.indexsForNotCompleteZekers.Count > 0) { 
                azkar.Complete = false;
            }
            
        }

    }
}
