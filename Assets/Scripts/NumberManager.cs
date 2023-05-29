using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NumberManager : MonoBehaviour
{
    [SerializeField] private List<NumberSlot> _slotPrefabs;
    [SerializeField] private NumberPiece _piecePrefab;
    [SerializeField] private Transform _slotParent, _pieceParent;

    public static int gameProgress = 0;

    public GameObject endPanel;

    public void NextLevel() 
    {
        gameProgress = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        if (gameProgress == 10)
        {
            endPanel.SetActive(true);
            Invoke("NextLevel", 4f);
        }
    }

    void Spawn()
    {
        var randomSet = _slotPrefabs.OrderBy(s => Random.value).Take(10).ToList();

        for (int i = 0; i < randomSet.Count; i++)
        {
            var spawnedSlot = Instantiate(randomSet[i], _slotParent.GetChild(i).position, Quaternion.identity);

            var spawnedPiece = Instantiate(_piecePrefab, _pieceParent.GetChild(i).position, Quaternion.identity);
            spawnedPiece.Init(spawnedSlot);
        }
    }
        
}

