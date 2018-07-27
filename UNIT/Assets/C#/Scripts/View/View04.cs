using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View04 : MonoBehaviour
{

    Button 返回;


    void Awake()
    {
        返回 = this.transform.Find("返回").GetComponent<Button>();


        返回.onClick.AddListener(() => UIManager.單例.ViewChange("首頁"));
    }
}
