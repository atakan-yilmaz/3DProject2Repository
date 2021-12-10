using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using secondProject.Managers;

namespace secondProject.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButton()
        {
            GameManager.Instance.LoadScene("Game");
        }

        public void NoButton()
        {
            GameManager.Instance.LoadScene("Menu");
        }
    }
}

