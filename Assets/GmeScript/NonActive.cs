using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonActive : MonoBehaviour
{
    //�Փ˂����Ƃ�
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        //�I�u�W�F�N�g���A�N�e�B�u�ɂ���
        this.gameObject.SetActive(false);
    }
}