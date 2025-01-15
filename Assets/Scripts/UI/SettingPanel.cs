using System.ComponentModel.Design;
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

        [SerializeField] Image musicBackground;
        [SerializeField] Image soundBackground;

        [SerializeField] RectTransform musicCheckMark;
        [SerializeField] RectTransform soundCheckMark;

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


            if (musicToggle.isOn)
            {
                musicCheckMark.anchoredPosition = new Vector2(20f, 0f);
                musicBackground.sprite = off;
                musicOn = false;

            }
            else
            {
                musicCheckMark.anchoredPosition = new Vector3(72f, 0f);
                musicBackground.sprite = on;
                musicOn = true;
            }
        }

        public void SoundToggle()
        {


            if (soundToggle.isOn)
            {
                soundCheckMark.anchoredPosition = new Vector2(20f, 0f);
                soundBackground.sprite = off;
                soundOn = false;
            }
            else
            {
                soundCheckMark.anchoredPosition = new Vector3(72f, 0f);
                soundBackground.sprite = on;
                soundOn = true;
            }
        }
    }
}