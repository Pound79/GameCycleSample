using System;
using GameCycleSample.Type;
using Unidux.SceneTransition;

namespace GameCycleSample.Struct
{
    [Serializable]
    public class GamePageData : IPageData
    {
        public DifficultyType DifficultyType;

        public GamePageData()
        {
        }

        public GamePageData(DifficultyType difficultyType)
        {
            this.DifficultyType = difficultyType;
        }
    }
}