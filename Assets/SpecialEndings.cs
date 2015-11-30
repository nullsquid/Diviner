using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SpecialEndings : MonoBehaviour {

    // Use this for initialization
    public Image red;
    public Image black;
    public Image white;
    

	

   public void ShowRedBadge() {
        red.enabled = true;

    }
    public void ShowBlackBadge() {
        black.enabled = true;

    }
    public void ShowWhiteBadge() {
        white.enabled = true;

    }
    public void HideRedBadge() {
        red.enabled = false;

    }
    public void HideBlackBadge() {
        black.enabled = false;

    }
    public void HideWhiteBadge() {
        white.enabled = false;

    }
}
