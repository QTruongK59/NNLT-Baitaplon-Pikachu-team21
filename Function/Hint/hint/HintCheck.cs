using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pikachu_team21
{
    class HintCheck
    {
            DataGamePlay dataGamePlay;

            LineCheck lineChecker;


            public int hint1, hint2;
            public bool hint = true;

            public HintCheck(DataGamePlay dataGamePlay, LineCheck lineChecker)
            {
                this.dataGamePlay = dataGamePlay;
                this.lineChecker = lineChecker;
            }

            public void LoadHint()
            {
                for (int i = 0; i < dataGamePlay.setCells.Count; i++)
                {
                    int index1 = dataGamePlay.setCells.ElementAt(i);
                    int value1 = dataGamePlay.GetValue(index1);
                    for (int j = i + 1; j < dataGamePlay.setCells.Count; j++)
                    {
                        int index2 = dataGamePlay.setCells.ElementAt(j);
                        int value2 = dataGamePlay.GetValue(index2);
                        if (value1 == value2)
                        {
                            var lines = lineChecker.GetLines(index1, index2);
                            if (lines.Count > 0)
                            {
                                hint1 = index1;
                                hint2 = index2;
                                return;
                            }
                        }
                    }
                }
                hint1 = int.MaxValue;
                hint2 = int.MaxValue;
                dataGamePlay.Shuffle();
            }
        
    }
}
