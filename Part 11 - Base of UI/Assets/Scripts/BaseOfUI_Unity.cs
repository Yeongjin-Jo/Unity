using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseOfUI_Unity : MonoBehaviour
{
    [SerializeField] private Text txt_name;
    [SerializeField] private Image img_name;
    [SerializeField] private Sprite sprite;

    private bool isCoolTime = false;

    private float currentTime = 5f;
    private float delayTime = 5f;

    void Update()
    {

        //img_name.sprite 이미지 지정
        //img_name.color 색 조정

        if(isCoolTime)
        {
            currentTime -= Time.deltaTime;
            img_name.fillAmount = currentTime / delayTime;

            if(currentTime <= 0)
            {
                isCoolTime = false;
                currentTime = delayTime;
                img_name.fillAmount = currentTime;
            }
        }
    }

    public void change()
    {
        txt_name.text = "변경됨";
        isCoolTime = true;


    }
}
