using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public GameObject DifficultyToggles;
    public Toggle SingleToggle;
    public Toggle MultiToggle;

    private void Start()
    {
        MultiToggle.onValueChanged
            .AddListener(isMultiplayerOn => DifficultyToggles.SetActive(!isMultiplayerOn));

        MultiToggle.isOn = GameValues.IsMultiplayer;

        DifficultyToggles.transform.GetChild((int)GameValues.Difficulty).GetComponent<Toggle>().isOn = true;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("main");
    }

    public void SetMultiPlayer(bool isOn)
    {
        if (isOn)
            GameValues.player = GameValues.Players.Multi;
            GameValues.IsMultiplayer = true;
    }

    public void SetSinglePlayer(bool isOn)
    {
        if (isOn)
            GameValues.player = GameValues.Players.Single;
            GameValues.IsMultiplayer = false;   
    }

    #region Difficulty
    public void SetEasyDifficulty(bool isOn)
    {
        if (isOn)
            GameValues.Difficulty = GameValues.Difficulties.Easy;
    }

    public void SetMediumDifficulty(bool isOn)
    {
        if (isOn)
            GameValues.Difficulty = GameValues.Difficulties.Medium;
    }

    public void SetHardDifficulty(bool isOn)
    {
        if (isOn)
            GameValues.Difficulty = GameValues.Difficulties.Hard;
    }
    #endregion
}