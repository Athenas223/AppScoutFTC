using UnityEngine;
using UnityEngine.UI;

public class AddPointsLOWC : MonoBehaviour
{
    public Button AddLOW;
    public InputField LOWInput;

    private void Start()
    {
        AddLOW.onClick.AddListener(AddthreePoints);
    }

    public void AddthreePoints()
    {
        if (int.TryParse(LOWInput.text, out int currentValue))
        {
            int newPoints = currentValue + 3;
            LOWInput.text = newPoints.ToString();
        }
        else
        {
            LOWInput.text = "3";
        }
    }
}
