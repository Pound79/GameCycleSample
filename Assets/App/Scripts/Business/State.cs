using System;
using GameCycleSample.Config;
using Unidux;
using Unidux.SceneTransition;

namespace GameCycleSample.Business
{
    [Serializable]
    public partial class State : StateBase
    {
        public SceneState<Scene> Scene = new SceneState<Scene>();
        public PageState<Page> Page = new PageState<Page>();
    }
}
