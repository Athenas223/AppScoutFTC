using UnityEngine;
using UnityEngine.UI;

public class PointsGRO : MonoBehaviour
{
    public Button AddGRO;
    public Button SubGRO;
    public InputField GROInput;
    private int currentPoints;

    private void Start()
    {
        AddGRO.onClick.AddListener(IncrementPoints);
        SubGRO.onClick.AddListener(DecrementPoints);
    }

    private void IncrementPoints()
    {
        currentPoints += 2;
        GROInput.text = currentPoints.ToString();
    }

    private void DecrementPoints(){
        currentPoints -= 2;
        GROInput.text = currentPoints.ToString();
    }

}