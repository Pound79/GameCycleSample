using GameCycleSample.Business;
using GameCycleSample.Struct;
using TMPro;
using UnityEngine;
using UniRx;

namespace GameCycleSample.UI
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class ScoreTextRenderer : MonoBehaviour
    {
        public TextMeshProUGUI ScoreText;

        void Start()
        {
            Unidux.Subject
                .Where(state => state.Page.IsReady && state.Page.IsStateChanged)
                .Where(state => state.Page.Data is ResultPageData) // Page.Dataの型チェック
                .StartWith(Unidux.State)
                .Subscribe(state => this.Render(state))
                .AddTo(this);
        }

        private void Render(State state)
        {
            ResultPageData pageData = state.Page.GetData<ResultPageData>();
            this.ScoreText.text = pageData.Score.ToString();
        }
    }
}
