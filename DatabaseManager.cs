using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase.Database;

public class DatabaseManager : MonoBehaviour
{
    public InputField TeamNumber;
    public InputField Round;
    public Button SwitchLoginScene;

    private string TeamID;
    private DatabaseReference dbreference;

    void Start()
    {
        TeamID = SystemInfo.deviceUniqueIdentifier;
        dbreference = FirebaseDatabase.DefaultInstance.RootReference;
    }

    public void CreateTeam()
    {
        int teamNumber = int.Parse(TeamNumber.text);
        int round = int.Parse(Round.text);

        Team newTeam = new Team(teamNumber, round);
        newTeam.teamNumber= teamNumber;
        newTeam.round = round;
        string json = JsonUtility.ToJson(newTeam);

        dbreference.Child("Team").Child(TeamID).SetRawJsonValueAsync(json);
    }
}