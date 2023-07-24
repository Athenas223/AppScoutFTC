using UnityEngine;
using UnityEngine.UI;

public class AddPointsLOWC : MonoBehaviour
{
    public Button AddLOW;
    public InputField LOWInput;

    private void Start()
    {
        AddLOW.onClick.AddListener(AddFourPoints);
    }

    public void AddFourPoints()
    {
        // Verifica se o texto no InputField é um número inteiro válido
        if (int.TryParse(LOWInput.text, out int currentValue))
        {
            // Adiciona cinco pontos ao valor atual e atualiza o InputField com o novo valor
            int newPoints = currentValue + 3;
            LOWInput.text = newPoints.ToString();
        }
        else
        {
            // Se o texto não for um número inteiro válido, assume o valor inicial de 5
            LOWInput.text = "3";
        }
    }
}
