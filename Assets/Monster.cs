using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("�Ǫ���O�Ѽ�"),Range(0,10)]
    public float MovementSpeed = 3.5f; //���ʰѼ�
    [Range(0,500)]
    public ushort Attack = 100; //�����O
    [Range(0,5000)]
    public short Health = 350; //�ͩR��
    [Range(0, 50)]
    public byte TrackingDistance = 30; //�l�ܶZ��
    public Vector3 TrackDisplacement; //�T���l�ܽd��

    [Header("�����D��(GameObject)")]
    public GameObject Drop_Object; //�����D�㶵��

    [Header("�����D����v"), Range(0, 1)]
    public float Drop_Chance = 1.0f; //�������v

    [Header("���ĳ]�m(AudioClip)")]
    public AudioClip Drop_SoundEffect; //�D�㱼������
    public AudioClip Hurt_SoundEffect; //���˭���
    public AudioClip Attack_SoundEffect; //��������

    AudioSource audioSource;
    Rigidbody2D rigidbody;
    Animator animator;
}
