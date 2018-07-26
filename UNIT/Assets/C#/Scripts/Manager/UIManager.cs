using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // 
    public static UIManager 單例 ;

    // List，用來存放UI頁面
    List<GameObject> View = new List<GameObject>();

    void Awake()
    {
        // 抓取單例
        單例 = this;

        // 掃底下的UI介面
        for (int i=0;i<this.transform.childCount;i++)
        {
            View.Add(this.transform.GetChild(i).gameObject);
        }
    }

    // 頁面切換事件
    public void ViewChange(string name)
    {
        // 用迴圈掃全部的View
        for (int i=0;i<View.Count;i++)
        {
            // 判定名稱，如果名稱為要切換的頁面就顯示，不是則隱藏
            if (View[i].name == name)
            {
                // 頁面開啟
                View[i].SetActive(true);
            }
            else
            {
                // 頁面關閉
                View[i].SetActive(false);
            }
        }
    }
}
