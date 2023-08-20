using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisionmusic : MonoBehaviour
{
    //���f�[�^�̍Đ����u���i�[����
    private new AudioSource audio;
    //���f�[�^���i�[����
    [SerializeField]
    private AudioClip sound;
    //Start is called before the first frame update
    private void Start()
    {
        //�R���|�[�l���g����Đ����u�����o����
        audio = gameObject.AddComponent<AudioSource>();

    }

    //�Փ˂����Ƃ�
    private void OnCollisionEnter(Collision collision)
    {
        //"Player"�^�O�����Ă���I�u�W�F�N�g�ɏՓ˂����ꍇ
        if (collision.gameObject.tag == "Player")
        {
            //����炷
            audio.PlayOneShot(sound);
            //0.2�b��ɃI�u�W�F�N�g��������
            Destroy(gameObject, 0.2f);
        }
    }
}