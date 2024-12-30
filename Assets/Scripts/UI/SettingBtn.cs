using UnityEngine;
using UnityEngine.UI;

namespace Roguelike
{
    public class SettingBtn : MonoBehaviour
    {
        [SerializeField] GameObject settingPanel;
        private Button btnSeeting;

        private void Awake()
        {
            btnSeeting = GetComponent<Button>();
            btnSeeting.onClick.AddListener(OpenSetting);
        }

        private void OnDestroy()
        {
            btnSeeting.onClick.RemoveListener(OpenSetting);
        }



        public void OpenSetting()
        {
            settingPanel.SetActive(true);
        }


    }
}