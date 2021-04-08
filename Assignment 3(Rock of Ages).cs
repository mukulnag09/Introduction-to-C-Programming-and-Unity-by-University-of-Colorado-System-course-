using UnityEngine;

public class RockSpawner : MonoBehaviour
{
// need for spawning
[SerializeField]
GameObject prefabRock;

//saved for efficiency
[SerializeField]
Sprite greenrock;
[SerializeField]
Sprite magentarock;
[SerializeField]
Sprite whiterock;

const float Delay = 1;
Timer SpawnTimer;
void Start()
{
SpawnTimer = gameObject.AddComponent<Timer>();
SpawnTimer.Duration = Delay;
SpawnTimer.Run();
}

// Update is called once per frame
void Update()
{
if (SpawnTimer.Finished)
{
GameObject[] Rock = GameObject.FindGameObjectsWithTag("Rock");
if (Rock == null || Rock.Length < 3)
{
SpawnRock();
}
SpawnTimer.Duration = Delay;
SpawnTimer.Run();
}
}
void SpawnRock()
{
Vector3 location = new Vector3(Screen.width / 2, Screen.height / 2, -Camera.main.transform.position.z);
Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
GameObject rock = Instantiate(prefabRock, worldLocation, Quaternion.identity);
rock.transform.position = worldLocation;

//set sprite for rock
SpriteRenderer spriteRenderer = rock.GetComponent<SpriteRenderer>();
int spriteNumber = Random.Range(0, 3);
if (spriteNumber == 0)
{
spriteRenderer.sprite = greenrock;
}
else if (spriteNumber == 1)
{
spriteRenderer.sprite = magentarock;
}
else
{
spriteRenderer.sprite = whiterock;
}
}
}

