using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler_PostQuizTF : MonoBehaviour
{
    public PostQuizTF quiztf;

    public String LorR;

    private Button button;



    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        quiztf.FetchData(LorR);
    }

}