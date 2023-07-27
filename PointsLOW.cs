using UnityEngine;
using UnityEngine.UI;

public class PointsLOW : MonoBehaviour
{
    public Button AddLOW;
    public Button SubLOW;
    public InputField LOWInput;
    private int currentPoints;

    private void Start()
    {
        AddLOW.onClick.AddListener(IncrementPoints);
        SubLOW.onClick.AddListener(DecrementPoints);
    }

    private void IncrementPoints()
    {
        currentPoints += 3;
        LOWInput.text = currentPoints.ToString();
    }

    private void DecrementPoints(){
        currentPoints -= 3;
        LOWInput.text = currentPoints.ToString();
    }

}