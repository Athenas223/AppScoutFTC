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
        if (int.TryParse(HIGHInput.text, out int currentValue))
        {
            int newPoints = currentValue - 5;
            HIGHInput.text = newPoints.ToString();
        }
        else
        {
            HIGHInput.text = "5";
        }
    }
}
