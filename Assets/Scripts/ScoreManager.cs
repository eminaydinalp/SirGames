using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
	[SerializeField] Text _scoreText;
	[SerializeField] Text _totalScoreText;

	int _score;
	private void Awake()
	{
		instance = this;
	}
	private void Start()
	{
		if(_totalScoreText != null)
		{
			_totalScoreText.text = "Total Score : " + PlayerPrefs.GetInt("Score");
		}
	}

	public void UpdateScore(int scoreAmountÝncreased, int finishScore)
	{
		_score += scoreAmountÝncreased;
		_scoreText.text = "Score : " + _score;

		if(_score >= finishScore)
		{
			PlayerPrefs.SetInt("Score", _score);
			GameManager.instance.Finish();
		}
	}


}
