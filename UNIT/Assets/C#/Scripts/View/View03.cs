using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View03 : MonoBehaviour {

    Button 忘記_B_back;


    void Awake()
    {
        忘記_B_back = this.transform.Find("忘記_B_back").GetComponent<Button>();


        忘記_B_back.onClick.AddListener(() => UIManager.單例.ViewChange("登入資訊"));
    }
}
