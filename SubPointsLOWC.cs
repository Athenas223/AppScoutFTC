using UnityEngine;
using UnityEngine.UI;

public class SubPointsLOWC : MonoBehaviour
{
    public Button SubLOW;
    public InputField LOWInput;

    private void Start()
    {
        SubLOW.onClick.AddListener(SubFourPoints);
    }

    public void SubFourPoints()
    {
        // Verifica se o texto no InputField é um número inteiro válido
        if (int.TryParse(LOWInput.text, out int currentValue))
        {
            // Adiciona cinco pontos ao valor atual e atualiza o InputField com o novo valor
            int newPoints = currentValue - 3;
            LOWInput.text = newPoints.ToString();
        }
        else
        {
            // Se o texto não for um número inteiro válido, assume o valor inicial de 5
            LOWInput.text = "3";
        }
    }
}
