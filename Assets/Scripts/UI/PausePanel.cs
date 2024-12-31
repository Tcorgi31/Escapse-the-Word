using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Roguelike
{
    public class PausePanel : MonoBehaviour
    {
        [SerializeField] Button resumeBtn;
        [SerializeField] Button homeBtn;
        [SerializeField] Button exitBtn;
        private void Awake()
        {
            resumeBtn.onClick.AddListener(ResumeGame);
            homeBtn.onClick.AddListener(BackHome);
            exitBtn.onClick.AddListener(ExitGame);
            gameObject.SetActive(false);
        }

        private void OnDestroy()
        {
            resumeBtn.onClick.RemoveListener(ResumeGame);
            homeBtn.onClick.RemoveListener(BackHome);
            exitBtn.onClick.RemoveListener(ExitGame);
        }

        public void ResumeGame()
        {
            Time.timeScale = 1;
            gameObject.SetActive(false);
        }

        public void BackHome()
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene("StartScene");
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}