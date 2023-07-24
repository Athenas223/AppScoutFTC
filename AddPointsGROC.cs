using UnityEngine;
using UnityEngine.UI;

public class AddPointsGROC : MonoBehaviour
{
    public Button AddGRO;
    public InputField GROInput;

    private void Start()
    {
        AddGRO.onClick.AddListener(AddTwoPoints);
    }

    public void AddTwoPoints()
    {
        // Verifica se o texto no InputField é um número inteiro válido
        if (int.TryParse(GROInput.text, out int currentValue))
        {
            // Adiciona cinco pontos ao valor atual e atualiza o InputField com o novo valor
            int newPoints = currentValue + 2;
            GROInput.text = newPoints.ToString();
        }
        else
        {
            // Se o texto não for um número inteiro válido, assume o valor inicial de 5
            GROInput.text = "2";
        }
    }
}