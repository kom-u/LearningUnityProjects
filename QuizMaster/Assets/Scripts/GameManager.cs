using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  Quiz quizScreen;
  End endScreen;

  void Awake()
  {
    quizScreen = FindObjectOfType<Quiz>();
    endScreen = FindObjectOfType<End>();
  }

  void Start()
  {
    quizScreen.gameObject.SetActive(true);
    endScreen.gameObject.SetActive(false);
  }

  void Update()
  {
    if (quizScreen.isComplete)
    {
      quizScreen.gameObject.SetActive(false);
      endScreen.gameObject.SetActive(true);
      endScreen.ShowFinalScore();
    }
  }

  public void OnReplayLevel()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
}
