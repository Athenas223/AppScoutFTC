using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : MonoBehaviour
{
  
    public int teamNumber { get; set; }
    public int round { get; set; }
    
  

    public Team(int teamNumber, int round)
    {
        this.teamNumber = teamNumber;
        this.round = round;
    }
}

