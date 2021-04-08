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

RUBRIC
Evaluate the code for style (descriptive names and proper capitalization for
variable names, appropriate commenting and blank lines) and implementation
approach (no unneeded variables, doesn't use significantly more code than it
should to solve the problem).

Although this portion
of the assignment isn't worth any points, your feedback to the author can
really help their learning. Helpful feedback could include comments about what
the author did well in their code and what they could do better in their code.


MUHAMMAD SARMAD ALI
In this portion you had to paste the code of Rock.cs script which makes the rock move

Jash Ratanghayra
perfect!

ANIKET SANTRA
good one
PROMPT
This portion of the assignment isn't worth any points, but it gives your
reviewers a chance to look at the code you wrote and give feedback to you about
that code. Reviewers also need to look at your source code to grade the
previous prompt.

Copy and paste your
entire RockSpawner.cs file into the text box below.

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
