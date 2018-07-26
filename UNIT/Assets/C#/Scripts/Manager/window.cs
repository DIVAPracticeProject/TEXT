using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class window : MonoBehaviour
{
    private Rect windowPosition;//儲存不可被拖曳的window的位置
    private Rect windowPositionMove;//儲存可被拖曳的window的位置
    private Rect buttonPosition;//儲存button在window內的位置
    private bool openclose ;
    

    private void setWindowPosition()//設定window的位置
    {
        float windowWidth = 150f;
        float windowHeight = 150f;
        float windowLeft = Screen.width * 0.5f - windowWidth * 0.5f;//window和Game左邊的距離，目前設定的值會讓window顯示在螢幕正中央
        float windowTop = Screen.height * 0.5f - windowHeight * 0.5f;//window和Game上面的距離，目前設定的值會讓window顯示在螢幕正中央
        windowPositionMove = new Rect(windowLeft, windowTop, windowWidth, windowHeight);//將可被拖曳的視窗設定在Game中央

        windowPosition = new Rect(0, 0, windowWidth, windowHeight);//將不可被拖曳的window設定在Game左上角
    }

    public void OnClick()
    {
        setWindowPosition();
        setButtonPosition();
        openclose = true;
    }
    void OnGUI()
    {
        if (openclose == true)
        {
            windowPositionMove = GUI.Window(1, windowPositionMove, windowEvent, "資料錯誤");
        }
        
    }

    private void setButtonPosition()//設定windows內的button位置
    {
        float buttonWidth = 70f;//按鈕的寬度
        float buttonHeight = 70f;//按鈕的高度
        float buttonLeft = windowPosition.width * 0.5f - buttonWidth * 0.5f;//按鈕和window左邊的距離，目前的值會讓button顯示在window的正中央
        float buttonTop = windowPosition.height * 0.5f - buttonHeight * 0.5f;//按鈕和window上面的距離，目前的值會讓button顯示在window的正中央

        buttonPosition = new Rect(buttonLeft, buttonTop, buttonWidth, buttonHeight);//button將會顯示在window正中央
    }

    

    private void windowEvent(int id)//處理視窗裡面要顯示的文字、按鈕、事件處理。必須要有一個為int的傳入參數
    {
        if (GUI.Button(buttonPosition, "確認"))//在window上顯示按鈕
        {

            {
                Debug.Log("可被拖曳的window按鈕被按下");
                openclose = false;
            }
        }

        {
            GUI.DragWindow();
        }
    }
}

