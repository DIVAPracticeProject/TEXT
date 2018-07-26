using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 首頁 : MonoBehaviour {

    Button 專案圖片;
    Button 關於我們;

    void Awake()
    {
        專案圖片 = this.transform.Find("專案圖片").GetComponent<Button>();
        專案圖片.onClick.AddListener(() => UIManager.單例.ViewChange("登入資訊"));


        關於我們 = this.transform.Find("關於我們").GetComponent<Button>();
        關於我們.onClick.AddListener(() => UIManager.單例.ViewChange("登入資訊"));


    }



}
