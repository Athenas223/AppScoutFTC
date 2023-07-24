using UnityEngine;
using UnityEngine.UI;

public class SubPointsLOWC : MonoBehaviour
{
    public Button SubLOW;
    public InputField LOWInput;

    private void Start()
    {
        SubLOW.onClick.AddListener(SubthreePoints);
    }

    public void SubthreePoints()
    {
        if (int.TryParse(LOWInput.text, out int currentValue))
        {
            int newPoints = currentValue - 3;
            LOWInput.text = newPoints.ToString();
        }
        else
        {
            LOWInput.text = "3";
        }
    }
}
