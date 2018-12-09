using GameCycleSample.Config;
using Unidux.SceneTransition;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

namespace GameCycleSample.UI
{
    [RequireComponent(typeof(Button))]
    public class ReturnToTitleButtonDispatcher : MonoBehaviour
    {
        void Start()
        {
            this.GetComponent<Button>().OnClickAsObservable()
                .Select(_ => PageDuck<Page, Scene>.ActionCreator.Push(Page.TitlePage))
                .Subscribe(action => Unidux.Dispatch(action))
                .AddTo(this);
        }
    }
}
