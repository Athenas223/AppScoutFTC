using UnityEngine;
using UnityEngine.UI;

public class SubPointsMEDC : MonoBehaviour
{
    public Button SubMED;
    public InputField MEDInput;

    private void Start()
    {
        SubMED.onClick.AddListener(SubFourPoints);
    }

    public void SubFourPoints()
    {
        // Verifica se o texto no InputField é um número inteiro válido
        if (int.TryParse(MEDInput.text, out int currentValue))
        {
            // Adiciona cinco pontos ao valor atual e atualiza o InputField com o novo valor
            int newPoints = currentValue - 4;
            MEDInput.text = newPoints.ToString();
        }
        else
        {
            // Se o texto não for um número inteiro válido, assume o valor inicial de 5
            MEDInput.text = "4";
        }
    }
}
