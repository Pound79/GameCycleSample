using System.Collections.Generic;
using Unidux.SceneTransition;

namespace GameCycleSample.Config
{
    public class SceneConfig : ISceneConfig<Scene, Page>
    {
        private IDictionary<Scene, int> _categoryMap;
        private IDictionary<Page, Scene[]> _pageMap;

        public IDictionary<Scene, int> CategoryMap
        {
            get
            {
                return this._categoryMap = this._categoryMap ?? new Dictionary<Scene, int>()
                {
                    {Scene.Base, SceneCategory.Permanent},
                    {Scene.Title, SceneCategory.Page},
                    {Scene.Game, SceneCategory.Page},
                    {Scene.Result, SceneCategory.Page},
                };
            }
        }

        public IDictionary<Page, Scene[]> PageMap
        {
            get
            {
                return this._pageMap = this._pageMap ?? new Dictionary<Page, Scene[]>()
                {
                    {Page.TitlePage, new[] {Scene.Title}},
                    {Page.GamePage, new[] {Scene.Game}},
                    {Page.ResultPage, new[] {Scene.Result}},
                };
            }
        }
    }
}