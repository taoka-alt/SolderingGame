using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGameScenceButton : MonoBehaviour
{
 
    //Startボタンタップ時の処理
    public void OnClickToGameSceneButton()
    {
        SceneManager.LoadScene("GameScene");
    }
}
