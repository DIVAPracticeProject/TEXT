using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;

public class View02 : MonoBehaviour
{
    // 組件
    Button 註冊_B_AlreadyID;
    Button 註冊_B_create;

    // 
    InputField 註_InputUserName;
    InputField 註_InputE_mail;
    InputField 註_InputE_Password;

    



    void Awake()
    {
        // 抓取組件
        註冊_B_AlreadyID = this.transform.Find("註冊_B_AlreadyID").GetComponent<Button>();
        註冊_B_create = this.transform.Find("註冊_B_create").GetComponent<Button>();
        註_InputUserName = this.transform.Find("註_InputUserName").GetComponent<InputField>();
        註_InputE_mail = this.transform.Find("註_InputE_mail").GetComponent<InputField>();
        註_InputE_Password = this.transform.Find("註_InputE_Password").GetComponent<InputField>();
        
        // 給予按鈕事件

        // 給予按鈕事件
        註冊_B_AlreadyID.onClick.AddListener(() => UIManager.單例.ViewChange("登入資訊"));
        註冊_B_create.onClick.AddListener(() => UIManager.單例.ViewChange("登入資訊"));
    }

    void OnEnable()
    {
        // 判定有沒有Json檔
        
        // Json裡面有沒有按照格式

        // Json檔裡面有沒有資料

        // 讀取
        註_InputUserName.text = JsonNet.userData.UserName;
        註_InputE_mail.text = JsonNet.userData.Account;
        註_InputE_Password.text = JsonNet.userData.Password;
    }
    public void OnClickCreate()
    {
        // 註冊按鈕執行
        //UserUI user = new UserUI();
        JsonNet.userData.UserName = 註_InputUserName.text;
        JsonNet.userData.Account = 註_InputE_mail.text;
        JsonNet.userData.Password = 註_InputE_Password.text;
        //string output = JsonConvert.SerializeObject(user);
        //print(output);
    }

}

