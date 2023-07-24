using UnityEngine;
using UnityEngine.UI;

public class SubPointsHIGHC : MonoBehaviour
{
    public Button SubHIGH;
    public InputField HIGHInput;

    private void Start()
    {
        SubHIGH.onClick.AddListener(SubFivePoints);
    }

    public void SubFivePoints()
    {
        // Verifica se o texto no InputField é um número inteiro válido
        if (int.TryParse(HIGHInput.text, out int currentValue))
        {
            // Adiciona cinco pontos ao valor atual e atualiza o InputField com o novo valor
            int newPoints = currentValue - 5;
            HIGHInput.text = newPoints.ToString();
        }
        else
        {
            // Se o texto não for um número inteiro válido, assume o valor inicial de 5
            HIGHInput.text = "5";
        }
    }
}