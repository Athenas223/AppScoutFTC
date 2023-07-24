using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneAuto : MonoBehaviour
{
    public void ChangeAuto(){
        SceneManager.LoadScene("TeleOpScene");
    }
}
