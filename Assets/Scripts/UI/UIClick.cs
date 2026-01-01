using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIClick : MonoBehaviour,IPointerClickHandler//处理点击事件的接口
{
    private Button button;
    public GameObject ChargerScene;
    public GameObject ChargerParent;
    private void Start()
    {
        ChargerParent = GameObject.Find("ChargerParent");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Vector3 ChargerPosition = this.transform.position;
        Quaternion ChargerRotation = this.transform.rotation;
        Debug.Log("图片被点击了");
        Instantiate(ChargerScene,ChargerPosition,ChargerRotation,ChargerParent.transform);
    }


}
