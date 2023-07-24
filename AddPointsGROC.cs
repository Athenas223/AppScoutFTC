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
        if (int.TryParse(GROInput.text, out int currentValue))
        {
            int newPoints = currentValue + 2;
            GROInput.text = newPoints.ToString();
        }
        else
        {
            GROInput.text = "2";
        }
    }
}
