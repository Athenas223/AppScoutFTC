using UnityEngine;
using UnityEngine.UI;

public class AddPointsHIGHC : MonoBehaviour
{
    public Button AddHIGH;
    public InputField HIGHInput;

    private void Start()
    {
        AddHIGH.onClick.AddListener(AddFivePoints);
    }

    public void AddFivePoints()
    {
        if (int.TryParse(HIGHInput.text, out int currentValue))
        {
            int newPoints = currentValue + 5;
            HIGHInput.text = newPoints.ToString();
        }
        else
        {
            HIGHInput.text = "5";
        }
    }
}
