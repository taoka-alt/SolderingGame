using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSm : MonoBehaviour
{
    //�X�R�A��Scoretext���A�^�b�`���Ă���scorecounttext���i�[����
    public Scoretext Sm;

    // Start is called before the first frame update
    void Start()
    {
        //�R���|�[�l���g����scorecounttext�����o����
        Sm = GameObject.Find("scorecounttext").GetComponent<Scoretext>();
    }

    //�Փ˂�����
    private void OnCollisionEnter(Collision collision)
    {
        //�X�R�A��0��"Player"�^�O�̃I�u�W�F�N�g�ɏՓ˂����ꍇ
        if (collision.gameObject.tag == "Player")
        {
            //�X�R�A20��������
            Sm.Score += 20;
        }
    }
}