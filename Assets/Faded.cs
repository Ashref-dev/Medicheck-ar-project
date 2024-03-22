using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faded : MonoBehaviour
{
public float max = 1f;
public float speed = 2f;
public GameObject trigger;
public SpriteRenderer sprite;

void Update () {


if(trigger.activeSelf){
    sprite.color = new Color(1f, 1f, 1f, Mathf.Lerp(sprite.color.a, 1f, speed *Time.deltaTime));
}

}

}

