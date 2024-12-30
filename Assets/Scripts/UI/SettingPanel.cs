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
            if (musicToggle.isOn)
            {
                musicToggle.image.sprite = off;
                musicOn = false;
            }
            else
            {
                musicToggle.image.sprite = on;
                musicOn = true;
            }
        }

        public void SoundToggle()
        {
            if (soundToggle.isOn)
            {
                soundToggle.image.sprite = off;
                soundOn = false;
            }
            else
            {
                soundToggle.image.sprite = on;
                soundOn = true;
            }
        }
    }
}