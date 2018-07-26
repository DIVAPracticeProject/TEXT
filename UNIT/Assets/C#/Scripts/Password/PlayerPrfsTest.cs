using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

public class PlayerPrfsTest : MonoBehaviour
{

    public InputField NameField;

    public InputField PwdField;

    void Start()
    {

        //判断有没有叫name的key

        if (PlayerPrefs.HasKey("name"))
        {

            //有的话，获取name的值

            NameField.text = PlayerPrefs.GetString("name");
            
        }

        if (PlayerPrefs.HasKey("password"))
        {

            PwdField.text = PlayerPrefs.GetString("password");

        }

        //删除

        //PlayerPrefs.DeleteKey ("name");

        //PlayerPrefs.DeleteAll();

    }

    public void LoginClick()
    {

        //一系列的判断+登录操作

        //......

        //用户名密码保存下来

        PlayerPrefs.SetString("name", NameField.text);
        Debug.Log("儲存用戶");
        PlayerPrefs.SetString("password", PwdField.text);
        Debug.Log("儲存密碼");
    }

}


