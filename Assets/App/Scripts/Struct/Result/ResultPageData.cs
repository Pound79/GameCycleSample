using System;
using Unidux.SceneTransition;

namespace GameCycleSample.Struct
{
    [Serializable]
    public class ResultPageData : IPageData
    {
        public int Score;

        public ResultPageData()
        {
        }

        public ResultPageData(int score)
        {
            this.Score = score;
        }
    }
}