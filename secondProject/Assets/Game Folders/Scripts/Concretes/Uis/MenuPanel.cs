using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using secondProject.Managers;

namespace secondProject.Uis
{
    public class MenuPanel : MonoBehaviour
    {
       public void StartButton()
        {
            GameManager.Instance.LoadScene();
        }

        public void ExitButton()
        {
            GameManager.Instance.ExitGame();
        }
    }
}

