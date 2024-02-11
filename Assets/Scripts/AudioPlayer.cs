using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Shooting")]
    [SerializeField] AudioClip shootingClip;
    [SerializeField] [Range(0f, 1f)] float shootingVolume = 1f;

    [Header("Damage")]
    [SerializeField] AudioClip hitDamage;
    [SerializeField] [Range(0f, 1f)] float DamageVolume = 1f;


    public void PlayShootingClip()
    {
        // if(shootingClip != null)
        // {
        //     AudioSource.PlayClipAtPoint(shootingClip,
        //                                 Camera.main.transform.position,
        //                                 shootingVolume);
        // }
        PlayClip(shootingClip, shootingVolume);
    }

    public void PlayHitDamage()
    {
        PlayClip(hitDamage, DamageVolume);
    }

    void PlayClip(AudioClip clip, float volume)
    {
        if(clip != null)
        {
            Vector3 camerapos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(clip, camerapos, volume);
        }
    }

}
