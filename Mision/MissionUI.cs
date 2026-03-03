using UnityEngine;
using TMPro;

public class MissionUI : MonoBehaviour
{
    public TextMeshProUGUI missionText; // Arrastra aquí el objeto MissionText
    public GameObject MissionPanel;    // Arrastra aquí el MissionPanel (fondo negro)

    public void SetMissionActive(bool active, string newText = "")
    {
        if (MissionPanel != null) MissionPanel.SetActive(active);
        
        if (active && missionText != null)
        {
            missionText.text = newText; // Cambia el contenido del texto
        }
    }
}