#pragma strict

var target :Collider;
var mySound : AudioClip;
private var numberOfHits : int = 0;
function OnTriggerEnter(cubeTrigger : Collider)
{

if(cubeTrigger == target)
{

GetComponent.<AudioSource>().PlayOneShot(mySound);
numberOfHits += 1;
print("bump" + numberOfHits +"times");



}





}