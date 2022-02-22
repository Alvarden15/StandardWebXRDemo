using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class AppearPopUp : MonoBehaviour
{

    public RectTransform popTransform;

    public Image background;

    public TextMeshProUGUI text;

    Sequence sequence;

    // Start is called before the first frame update
    void Start()
    {
        CompleteSequence();
    }


    void CompleteSequence()
    {
        sequence = DOTween.Sequence();

        sequence.Append(background.DOFade(0.5f, 0.5f))
            .Join(popTransform.DOAnchorPosY(0,0.5f))
            .Join(DOTween.To(() => text.alpha, x => text.alpha = x,1f, 0.5f))
            .AppendInterval(5f)
            .Append(background.DOFade(0f, 0.5f))
            .Join(DOTween.To(() => text.alpha, x => text.alpha = x, 0f, 0.5f))
            .Join(popTransform.DOAnchorPosY(-437, 0.5f));
    }

 
}
