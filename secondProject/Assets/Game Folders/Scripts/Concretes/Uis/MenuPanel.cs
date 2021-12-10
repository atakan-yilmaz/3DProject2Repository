using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using secondProject.Managers;

namespace secondProject.Uis
{
    public class MenuPanel : MonoBehaviour
    {
       public void RedRunButton()
        {
            GameManager.Instance.LoadScene("Game");
        }

        public void GreenRunButton()
        {
            GameManager.Instance.ExitGame();
        }
    }
}

