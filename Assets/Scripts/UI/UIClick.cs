using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIClick : MonoBehaviour,IPointerClickHandler//处理点击事件的接口
{
    private Button button;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("图片被点击了");
    }


}
