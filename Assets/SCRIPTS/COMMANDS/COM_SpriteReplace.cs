using UnityEngine;
using System.Collections;
using Fungus;

[CommandInfo("Sprite", "Sprite Replace", "Replaces sprite with a new sprite")]

public class COM_SpriteReplace : Command {
    public Sprite newSprite;
    public GameObject targetGameObject;

	public override void OnEnter() {
        if(targetGameObject.GetComponent<SpriteRenderer>() != null) {

            targetGameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
        Continue();
    }
}
