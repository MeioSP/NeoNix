using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using PlayFab;
using PlayFab.ClientModels;

public class Register : MonoBehaviour
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
        string repsw = GameObject.Find("repswinput").GetComponent<InputField>().text;
        string nickname = GameObject.Find("nicknameinput").GetComponent<InputField>().text;

        if (psw==repsw)
        {
            var request = new RegisterPlayFabUserRequest { Email = id, Password = psw, DisplayName=nickname};
            PlayFabClientAPI.RegisterPlayFabUser(request, RegisterSuccess, RegisterFailed);
        }
        
    }

    void RegisterSuccess(RegisterPlayFabUserResult result)
    {
        Debug.Log("가입 성공");
    }

    void RegisterFailed(PlayFabError error)
    {
        Debug.LogWarning("가입 실패");
        Debug.LogWarning(error.GenerateErrorReport());
    }
}
