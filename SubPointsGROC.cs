using UnityEngine;
using UnityEngine.UI;

public class SubPointsGROC : MonoBehaviour
{
    public Button SubGRO;
    public InputField GROInput;

    private void Start()
    {
        SubGRO.onClick.AddListener(SubTwoPoints);
    }

    public void SubTwoPoints()
    {
        if (int.TryParse(GROInput.text, out int currentValue))
        {
            int newPoints = currentValue - 2;
            GROInput.text = newPoints.ToString();
        }
        else
        {
            GROInput.text = "2";
        }
    }
}
