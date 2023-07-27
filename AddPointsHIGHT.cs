using UnityEngine;
using UnityEngine.UI;

public class AddPointsHIGHT : MonoBehaviour
{
    public Button AddHIGH;
    public Button SubHIGH;
    public InputField HIGHInput;
    private int currentPoints;

    private void Start()
    {
        AddHIGH.onClick.AddListener(IncrementPoints);
        SubHIGH.onClick.AddListener(DecrementPoints);
    }

    private void IncrementPoints()
    {
        currentPoints += 5;
        HIGHInput.text = currentPoints.ToString();
    }

    private void DecrementPoints(){
        currentPoints -= 5;
        HIGHInput.text = currentPoints.ToString();
    }

}