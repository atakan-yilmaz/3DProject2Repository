using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using secondProject.Abstracts.Utilities;

namespace secondProject.Managers
{
    public class GameManager : SingletonMonoBehaviorObject<GameManager>
    {
        private void Awake()
        {
            SingletonThisObject(this);
        }

        public void StopGame()
        {
            Time.timeScale = 0f;
        }
    }
}
