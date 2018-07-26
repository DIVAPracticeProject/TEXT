using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;


public class UserUI
{
    public string UserName { get; set; }
    public string Account { get; set; }
    public string Password { get; set; }
}

public class JsonNet : MonoBehaviour
{
    // 按照格式建立一個儲存用的
    public static UserUI userData = new UserUI();

    public void Awake()
    {
        // 註冊按鈕執行
        
        // 開啟登入畫面時執行
        /*UserUI user2 = JsonConvert.DeserializeObject<UserUI>(output);


        print("UserName : " + user2.UserName);
        userData.UserName = user2.UserName;
        print("Account : " + user2.Account);
        userData.Account = user2.Account;
        print("Password : " + user2.Password);
        userData.Password = user2.Password;
        Debug.Log(userData);*/

    }
    
    
}

