using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    private int score = 0;
    private float spawnRate = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            var index = Random.Range(0, targets.Count);
            Instantiate(targets[index].gameObject);
        }
    }

    public void UpdateScore(int scoreToAdd = 0)
    {
        score += scoreToAdd;
        scoreText.text = $"Score: {score}";
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }
}
