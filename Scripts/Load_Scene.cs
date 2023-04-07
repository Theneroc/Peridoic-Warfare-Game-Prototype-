using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load_Scene : MonoBehaviour
{
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(OnClick);
    }  
    private void OnClick()
    {
        SceneManager.LoadScene("Main Scene");
    }
}
