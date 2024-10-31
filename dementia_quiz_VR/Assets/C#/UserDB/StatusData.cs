using UnityEngine;
using System.Collections.Generic;

namespace App.BaseSystem.DataStores.ScriptableObjects.Status
{
    /// <summary>
    /// �X�e�[�^�X�����I�u�W�F�N�g�̃f�[�^�Q (�Ώ�: �v���C���[�A�G�A�j��\�I�u�W�F�N�g�Ȃ�)
    /// </summary>
    [CreateAssetMenu(menuName = "ScriptableObject/Data/Status")]
    public class StatusData : BaseData
    {
        public List<float> QuizDiff
        {
            get => quizDiff;
            set => quizDiff = value;
        }
        [SerializeField]
        private List<float> quizDiff = new List<float>();

        public float ActDiff
        {
            get => actDiff;
            set => actDiff = value;
        }
        [SerializeField]
        private float actDiff;

        public string UUID
        {
            get => uuid;
            set => uuid = value;
        }
        [SerializeField]
        private string uuid;

        public List<float> LR
        {
            get => lr;
            set => lr = value;
        }
        [SerializeField]
        private List<float> lr = new List<float>();
    }
}