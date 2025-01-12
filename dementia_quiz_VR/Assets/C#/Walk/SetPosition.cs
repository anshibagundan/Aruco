using UnityEngine;
using App.BaseSystem.DataStores.ScriptableObjects.Status;
using UnityEngine.Assertions.Must;

public class SetPosition : MonoBehaviour
{
    [SerializeField]
    StatusData statusData;

    void Start()
    {
        if (statusData.LR.Count > 0)
        {
            

            // 必要に応じて回転を設定
            Quaternion savedRotation = Quaternion.Euler(0, statusData.rotY, 0);
            transform.rotation = savedRotation;

            Debug.Log("Position reloaded");
        }
    }
}