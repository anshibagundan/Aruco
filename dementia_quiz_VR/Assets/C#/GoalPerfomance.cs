using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPerfomance : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    public void GoalPerformance()
    {
        //音(sound1)を鳴らす
        audioSource.PlayOneShot(sound1);


    }
}
