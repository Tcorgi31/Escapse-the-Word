using UnityEngine;
using UnityEngine.UI;

namespace Roguelike
{
    public class PauseBtn : MonoBehaviour
    {
        Button pauseBtn;
        [SerializeField] GameObject pausePanel;
        private void Awake()
        {
            pauseBtn = GetComponent<Button>();
            pauseBtn.onClick.AddListener(PauseGame);
        }

        private void OnDestroy()
        {
            pauseBtn.onClick.RemoveListener(PauseGame);
        }

        public void PauseGame()
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }
    }
}