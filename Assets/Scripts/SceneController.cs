using System;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    [SerializeField] private Button level1;
    [SerializeField] private Button level2;
    [SerializeField] private bool isNeedToSubscribeButtons;
    private void Awake()
    {
        if(isNeedToSubscribeButtons)
            SubscribeButtons();
    }

    private void SubscribeButtons()
    {
        level1.onClick.AddListener(OnClickLevel1Btn);
        level2.onClick.AddListener(OnClickLevel2Btn);
    }

    public void OnClickLevel1Btn()
    {
        Debug.LogError("Нажата кнопка Level1");
    }
    
    public void OnClickLevel2Btn()
    {
        Debug.LogError("Нажата кнопка Level2");
    }
    

}
