using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private ActorController[] players;

    [SerializeField]
    int nPlayers;

    [SerializeField]
    GameObject ia;

    [SerializeField]
    GameObject parentPoints;

    Transform[] points;

    [SerializeField]
    private float gameTime = 25F;

    public float CurrentGameTime { get; private set; }

    // Use this for initialization
    private IEnumerator Start()
    {
        nPlayers = Mathf.Clamp(nPlayers, 3, 5);

        points = parentPoints.GetComponentsInChildren<Transform>();

        for (int i = 0; i < nPlayers-1; i++)
        {
            Instantiate(ia, points[i + 1].position, Quaternion.identity);
        }

        CurrentGameTime = gameTime;

        // Sets the first random tagged player
        players = FindObjectsOfType<ActorController>();

        yield return new WaitForSeconds(0.5F);

        players[Random.Range(0, players.Length)].onActorTagged(true);
    }

    private void Update()
    {
        CurrentGameTime -= Time.deltaTime;

        if (CurrentGameTime <= 0F)
        {
            //TODO: Send GameOver event.
        }
    }
}