using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace MadGeekStudio.ProtectorOfAtemia.Core
{
    public class ItemInfoUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI itemName;
        [SerializeField] private TextMeshProUGUI itemDescription;
        [SerializeField] private TextMeshProUGUI itemCount;
        [SerializeField] private GameObject useButton;
        public event Action OnUse;
        public void Info(Item data)
        {
            if (data != null)
            {
                itemName.text = data.name;
                itemDescription.text = data.description;
                itemCount.text = data.count.ToString();
                useButton.SetActive(true);
            }
            else {
                itemName.text = "";
                itemDescription.text = "";
                itemCount.text = "";
                useButton.SetActive(false);
            }
        }
		public void Use()
        {
            OnUse?.Invoke();
        }
		private void OnDestroy()
		{
            OnUse = null;
		}
	}
}
