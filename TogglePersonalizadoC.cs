using UnityEngine;
using UnityEngine.UI;

public class TogglePersonalizadoC : MonoBehaviour
{
    public Toggle ConePerso;
    public int PointEstacioPerso = 20;
    public Text TogglePText; 

   private void Start()
    {
        ConePerso.onValueChanged.AddListener(Personalizado);
    }


    public void Personalizado (bool isOn)
    {
        if (isOn){
            TogglePText.text = PointEstacioPerso.ToString();
        }
        else {
            TogglePText.text = string.Empty;
        }
    }
}
