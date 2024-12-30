using Unity.VisualScripting.ReorderableList;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Roguelike
{
    public class MainScene : MonoBehaviour
    {
        [SerializeField] Button startButton;
        [SerializeField] Button exitButton;

        private void Awake()
        {
            startButton.onClick.AddListener(LoadVillageScene);
            exitButton.onClick.AddListener(ExitGame);
        }

        private void OnDestroy()
        {
            startButton.onClick.RemoveListener(LoadVillageScene);
            exitButton.onClick.RemoveListener(ExitGame);
        }




        public void LoadVillageScene()
        {
            SceneManager.LoadScene("VillageScene");
        }

        public void ExitGame()
        {
            Application.Quit();
        }


    }
}