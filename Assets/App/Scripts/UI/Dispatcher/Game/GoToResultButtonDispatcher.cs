using UnityEngine;
using GameCycleSample.Config;
using GameCycleSample.Struct;
using Unidux.SceneTransition;
using UniRx;
using UnityEngine.UI;

namespace GameCycleSample.UI
{
    [RequireComponent(typeof(Button))]
    public class GoToResultButtonDispatcher : MonoBehaviour
    {
        void Start()
        {
            this.GetComponent<Button>().OnClickAsObservable()
                .Select(_ =>
                    PageDuck<Page, Scene>.ActionCreator.Push(Page.ResultPage, new ResultPageData(Random.Range(0, 101))))
                .Subscribe(action => Unidux.Dispatch(action))
                .AddTo(this);
        }
    }
}