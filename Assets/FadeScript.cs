using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScript : MonoBehaviour
{
[SerializeField] private float speed = 2;
[SerializeField] private CanvasGroup myUIGroup;
[SerializeField] private bool fadeIn = false; 
[SerializeField] private bool fadeOut = false;



public void ShowUI (){
if ((!fadeIn) && (!fadeOut)){
    
 
 fadeIn = true;
 
 }
}

public void HideUI (){
 if ((!fadeIn) && (!fadeOut)){
    
 
 fadeOut = true;
 
 }
}

private void Update (){

if (fadeIn) {

if (myUIGroup.alpha < 1){
myUIGroup.alpha += Time.deltaTime*speed;

myUIGroup.blocksRaycasts = true;
myUIGroup.interactable = true;

 if (myUIGroup.alpha >= 1){
fadeIn = false;}
}}
if (fadeOut) {
if (myUIGroup.alpha >= 0) {
myUIGroup.alpha -= Time.deltaTime*speed;
myUIGroup.blocksRaycasts = false;
myUIGroup.interactable = false;

 if (myUIGroup.alpha == 0) {
fadeOut = false;}
}}

}   

IEnumerator Example()
    {
        yield return new WaitForSecondsRealtime(2);
    }

}
