﻿using UnityEngine;
using UnityEngine.SceneManagement;
using App.BaseSystem.DataStores.ScriptableObjects.Status;

public class ChangeQuizScene : MonoBehaviour
{
    [SerializeField]
    StatusData statusData;

    private void OnTriggerEnter(Collider other)
    {
        //  v   C   [ ̌  ݂̈ʒu Ɖ ]   擾
        Vector3 currentPosition = other.transform.position;
        Quaternion currentRotation = other.transform.rotation;

        Debug.Log("OnTriggerEnter called");
        Debug.Log(statusData.LR.Count);

        if (other.gameObject.CompareTag("1st_QuizCollider") && statusData.LR.Count == 0)
        {
            CountDistance(statusData.PastPosition, transform.position);
            Debug.Log("1st_QuizCollider detected");
            UpdatePositionAndLoadQuiz(currentPosition, currentRotation);
        }
        if (other.gameObject.CompareTag("2nd_QuizCollider") && statusData.LR.Count == 1)
        {
            CountDistance(statusData.PastPosition, transform.position);
            Debug.Log("2nd_QuizCollider detected");
            UpdatePositionAndLoadQuiz(currentPosition, currentRotation);
        }
        if (other.gameObject.CompareTag("3rd_QuizCollider") && statusData.LR.Count == 2)
        {
            CountDistance(statusData.PastPosition, transform.position);
            UpdatePositionAndLoadQuiz(currentPosition, currentRotation);
            Debug.Log("3rd_QuizCollider detected");
        }
        else if (other.gameObject.CompareTag("Final_QuizCollider") && statusData.LR.Count == 3)
        {
            CountDistance(statusData.PastPosition, transform.position);
            Debug.Log("Final_QuizCollider detected");
            SceneManager.LoadScene("FinalQuizScene");
        }
    }

    void UpdatePositionAndLoadQuiz(Vector3 position, Quaternion rotation)
    {
        statusData.rotY = rotation.eulerAngles.y;
        SceneManager.LoadScene("QuizScene");
    }
    void CountDistance(Vector3 pastPosition, Vector3 currentPosition)
    {
        float distance = Vector3.Distance(pastPosition, currentPosition);


        statusData.Distance = (int)distance;

    }
}