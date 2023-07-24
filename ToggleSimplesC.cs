using UnityEngine;
using UnityEngine.UI;

public class ToggleSimplesC : MonoBehaviour
{
    public Toggle ConeSimples;
    public int PointEstacioSimples = 10;
    public Text ToggleSText; 

   private void Start()
    {
        ConeSimples.onValueChanged.AddListener(Simples);
    }


    public void Simples (bool isOn)
    {
        if (isOn){
            ToggleSText.text = PointEstacioSimples.ToString();
        }
        else {
            ToggleSText.text = string.Empty;
        }
    }
}