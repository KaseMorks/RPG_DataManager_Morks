using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("怪物能力參數"),Range(0,10)]
    public float MovementSpeed = 3.5f; //移動參數
    [Range(0,500)]
    public ushort Attack = 100; //攻擊力
    [Range(0,5000)]
    public short Health = 350; //生命值
    [Range(0, 50)]
    public byte TrackingDistance = 30; //追蹤距離
    public Vector3 TrackDisplacement; //三維追蹤範圍

    [Header("掉落道具(GameObject)")]
    public GameObject Drop_Object; //掉落道具項目

    [Header("掉落道具機率"), Range(0, 1)]
    public float Drop_Chance = 1.0f; //掉落機率

    [Header("音效設置(AudioClip)")]
    public AudioClip Drop_SoundEffect; //道具掉落音效
    public AudioClip Hurt_SoundEffect; //受傷音效
    public AudioClip Attack_SoundEffect; //攻擊音效

    AudioSource audioSource;
    Rigidbody2D rigidbody;
    Animator animator;
}
