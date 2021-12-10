using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using secondProject.Abstracts.Utilities;
using UnityEngine.SceneManagement;


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

        public void LoadScene(string sceneName)
        {
            StartCoroutine(LoadSceneAsync(sceneName));
        }

        private IEnumerator LoadSceneAsync(string sceneName) //coroutine 
        {
            Time.timeScale = 1f;
            yield return SceneManager.LoadSceneAsync(sceneName);
        }

        public void ExitGame()
        {
            Debug.Log("Exit on Clicked");
            Application.Quit();
        }
    }
}
