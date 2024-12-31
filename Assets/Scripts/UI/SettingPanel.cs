using UnityEngine;
using UnityEngine.UI;

namespace Roguelike
{
    public class SettingPanel : MonoBehaviour
    {
        [SerializeField] Button closeBtn;
        [SerializeField] Toggle musicToggle;
        [SerializeField] Toggle soundToggle;
        [SerializeField] Sprite on;
        [SerializeField] Sprite off;

        bool musicOn;

        bool soundOn;
        private void Awake()
        {
            closeBtn.onClick.AddListener(CloseSetting);
            musicToggle.onValueChanged.AddListener(delegate { MusicToggle(); });
            soundToggle.onValueChanged.AddListener(delegate { SoundToggle(); });
            gameObject.SetActive(false);

        }

        private void OnDestroy()
        {
            closeBtn.onClick.RemoveListener(CloseSetting);
            musicToggle.onValueChanged.RemoveListener(delegate { MusicToggle(); });
            soundToggle.onValueChanged.RemoveListener(delegate { SoundToggle(); });
        }



        public void CloseSetting()
        {
            gameObject.SetActive(false);
        }

        public void MusicToggle()
        {
            GameObject checkMark = musicToggle.transform.GetChild(0).GetChild(0).gameObject;
            RectTransform checkMarkRect = checkMark.GetComponent<RectTransform>();
            Sprite Background = musicToggle.transform.GetChild(0).GetComponent<Image>().sprite;
            if (musicToggle.isOn)
            {
                Background = off;
                musicOn = false;
                checkMarkRect.anchorMax = new Vector2(0f, 0.5f);
                checkMarkRect.anchorMin = new Vector2(0f, 0.5f);
                checkMarkRect.anchoredPosition = new Vector3(20f, 0f, 0f);

            }
            else
            {
                Background = on;
                musicOn = true;
                checkMarkRect.anchorMax = new Vector2(1f, 0.5f);
                checkMarkRect.anchorMin = new Vector2(1f, 0.5f);
                checkMarkRect.anchoredPosition = new Vector3(-20f, 0f, 0f);
            }
        }

        public void SoundToggle()
        {
            GameObject checkMark = soundToggle.transform.GetChild(0).GetChild(0).gameObject;
            RectTransform checkMarkRect = checkMark.GetComponent<RectTransform>();
            Sprite Background = soundToggle.transform.GetChild(0).GetComponent<Image>().sprite;
            if (soundToggle.isOn)
            {
                Background = off;
                soundOn = false;
                checkMarkRect.anchorMax = new Vector2(0f, 0.5f);
                checkMarkRect.anchorMin = new Vector2(0f, 0.5f);
                checkMarkRect.anchoredPosition = new Vector3(20f, 0f, 0f);
            }
            else
            {
                Background = on;
                soundOn = true;
                checkMarkRect.anchorMax = new Vector2(0f, 0.5f);
                checkMarkRect.anchorMin = new Vector2(0f, 0.5f);
                checkMarkRect.anchoredPosition = new Vector3(20f, 0f, 0f);
            }
        }
    }
}