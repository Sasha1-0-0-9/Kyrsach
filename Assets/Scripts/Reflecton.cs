using UnityEditor;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
using Gizmos = Popcron.Gizmos;

public class Reflecton : MonoBehaviour
{
    private float maxDist = 200;

   public GameObject WinMenuUI; // Задаємо GameObject

   private void Start()
    {
        WinMenuUI.SetActive(false); // Робимо GameOblect не активним при запуску сцени
    }
    void Update()
    {
        ReflectLaser(transform.position + transform.forward, transform.forward);

    }

    private void ReflectLaser(Vector3 position, Vector3 direction)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 startingPosition = position;

            Ray ray = new Ray(position, direction);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, maxDist))
            {
                direction = Vector3.Reflect(direction, hit.normal);
                position = hit.point;
            }
            else
            {
                position += direction * maxDist;
            }

            Gizmos.Enabled = true;
            Gizmos.Line(startingPosition, position, Color.green, false);
            if(hit.collider.tag == "Exit")
            {
                WinMenuUI.SetActive(true); // активує меню
                Time.timeScale = 0f; //Зупиняє всі рухомі об'єкти на сцені, якщо вони є 
            }

            if (hit.collider.tag == "Mirrors")
            {
                ReflectLaser(position, direction);
            }

            else
            {
                return;
            }
        }

    }
}