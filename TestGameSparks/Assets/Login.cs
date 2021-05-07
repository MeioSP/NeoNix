using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        string id = GameObject.Find("idinput").GetComponent<InputField>().text;
        string psw = GameObject.Find("pswinput").GetComponent<InputField>().text;
    }
}
