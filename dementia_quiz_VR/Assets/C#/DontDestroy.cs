using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject); //シーンを切り替えても削除しない
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
