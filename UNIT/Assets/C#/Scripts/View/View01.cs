using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System;
using System.Text.RegularExpressions;

public class View01 : MonoBehaviour
{
    // 組件
    Button 登_B_Create;
    GameObject InputField;
    Button 登_B_ForgetPassword;
    InputField 註_InputUserName;
    InputField 註_InputE_mail;
    InputField 註_InputE_Password;

   public GameObject 確認帳戶;
   public GameObject 確認密碼;

    public static UserUI userData = new UserUI();
    void Awake()
    {
        // 抓取組件
        登_B_Create = this.transform.Find("登_B_Create").GetComponent<Button>();
        登_B_ForgetPassword = this.transform.Find("登_B_ForgetPassword").GetComponent<Button>();

        註_InputE_mail = this.transform.Find("登_InputE-mail").GetComponent<InputField>();
        註_InputE_Password = this.transform.Find("登_Password").GetComponent<InputField>();

        確認帳戶.SetActive(false);
        確認密碼.SetActive(false);



        // 註冊按鈕執行



        // 給予按鈕事件
        登_B_Create.onClick.AddListener(() => UIManager.單例.ViewChange("註冊頁面"));
        登_B_ForgetPassword.onClick.AddListener(() => UIManager.單例.ViewChange("忘記密碼頁面"));
    }
   public void OnClickLogIn()
    {
        // 如果帳號不等於創建時暫存的帳號的話
        if (註_InputE_mail.text != JsonNet.userData.Account)
        { 
            確認帳戶.SetActive(true);
            // 回傳跳出
            return;
        }
        else if(註_InputE_mail.text == JsonNet.userData.Account)
        {
            確認帳戶.SetActive(false);
        }
        // 如果帳號不等於創建時暫存的帳號的話
        if (註_InputE_Password.text != JsonNet.userData.Password)
        {   
            確認密碼.SetActive(true);
            // 回傳跳出
            return;
        }
        else if (註_InputE_Password.text == JsonNet.userData.Password)
        {
            確認密碼.SetActive(false);
        }

        // 切換頁面，如果前面的條件被觸發就會跳出，而不會執行到這段
        UIManager.單例.ViewChange("首頁");

        Debug.Log("Login");
    }
}
