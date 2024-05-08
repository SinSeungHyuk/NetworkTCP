using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chat : MonoBehaviour
{
    public static Chat instance; // 싱글톤
    private void Awake()
    {
        instance = this;
    }

    [SerializeField] private InputField SendInput;
    [SerializeField] private RectTransform ChatContent;
    [SerializeField] private Text ChatText;
    [SerializeField] private ScrollRect ChatScrollRect;

    public void ShowMessage(string data)
    {
        ChatText.text += (ChatText.text == "" ? data : "\n" + data);

        Fit(ChatText.GetComponent<RectTransform>());
        Fit(ChatContent);
        Invoke("ScrollDelay", 0.03f);
    }

    private void Fit(RectTransform rect)
    {
        // 버그 방지를 위한 강제 업데이트
        LayoutRebuilder.ForceRebuildLayoutImmediate(rect);
    }
    private void ScrollDelay()
    {
        // 항상 스크롤 밑으로 내리기
        ChatScrollRect.verticalScrollbar.value = 0; 
    }
}
