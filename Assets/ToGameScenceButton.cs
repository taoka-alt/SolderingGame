using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGameScenceButton : MonoBehaviour
{
 
    //Start�{�^���^�b�v���̏���
    public void OnClickToGameSceneButton()
    {
        SceneManager.LoadScene("GameScene");
    }
}
