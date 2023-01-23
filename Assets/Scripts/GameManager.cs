using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void PlayerIsDead()
    {
        //afficher le game over screen
        _gameOverScreen.SetActive(true);
        GetComponent<AudioSource>().Stop();
    }

}
