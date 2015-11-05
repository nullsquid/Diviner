using UnityEngine;
using System.Collections;
using Fungus;
public class BuildEnding : MonoBehaviour {
    public Flowchart first_sacrifice;
    public string theFirstSentence;
    public string theSecondSentence;
	// Use this for initialization
	void Start () {

       
	}
	
	// Update is called once per frame
	void Update () {
        //string organString = first_sacrifice.GetStringVariable("organString");
        //string commitmentString = first_sacrifice.GetStringVariable("commitmentString");
        //string nonAnswerString = first_sacrifice.GetStringVariable("nonAnswerString");
        //ConstructEnding(first_sacrifice.GetStringVariable("firstDivination"), first_sacrifice.GetStringVariable("firstAnswer"), first_sacrifice.GetStringVariable("committed"), first_sacrifice.GetIntegerVariable("numNoAnswer"), first_sacrifice.GetStringVariable("theOrganName"), first_sacrifice.GetBooleanVariable("talkedToOffering"));

    }
    public void GetEnding() {
        first_sacrifice.SetStringVariable("endingFirstSentence", theFirstSentence);
        first_sacrifice.SetStringVariable("endingSecondSentence", theSecondSentence);
    }
    

    public void ConstructEnding(string firstDivination, string firstAnswer,string commitment, int howManyNullAnswers, string firstOrganTouched, bool talkedToOffering) {
        if (firstDivination == "Stone" && firstAnswer == "prosperity") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "buried in the loam");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "under the leaves");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "embedded in the root of an oak");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "tied to an old gnarl");
            }
            ////////
            if (commitment == "commited") {
                first_sacrifice.SetStringVariable("commitmentString", "face up");
            }
            else if (commitment == "uncommited") {
                first_sacrifice.SetStringVariable("commitmentString", " face down");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", " on its side");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "a mole skull");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "an arrowhead");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organnString", "an ivory rook piece");
            }
            else if (firstOrganTouched == null) {
                first_sacrifice.SetStringVariable("organString", "a rusted coin");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It feels frozen.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", null);
            }

            theFirstSentence = "You found " + first_sacrifice.GetStringVariable("organString") + first_sacrifice.GetStringVariable("commitmentString") + "," + first_sacrifice.GetStringVariable("nonAnswerString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");

        }
        else if (firstDivination == "Stone" && firstAnswer == "dread") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "robe");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "foot");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "leg");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "brow");
            }
            ////////
            if (commitment == "commited") {
                first_sacrifice.SetStringVariable("commitmentString", "a vine");
            }
            else if (commitment == "uncommited") {
                first_sacrifice.SetStringVariable("commitmentString", "a sharp branch");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "a black root");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "and you dirty your hands breaking your fall");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "and you bruise your side");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organnString", "and you cut your right knee");
            }
            else if (firstOrganTouched == null) {
                first_sacrifice.SetStringVariable("organString", "and the autumn leaves cushion you");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "There are droplets of blood where you land.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", null);
            }

            theFirstSentence = "In the woods, " + first_sacrifice.GetStringVariable("commitmentString") + " catches your " + first_sacrifice.GetStringVariable("nonAnswerString") + ". You trip and " + first_sacrifice.GetStringVariable("organString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Stone" && firstAnswer == "death") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "In the dark");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "Under the moonlight");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "In the shadow of clouds");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "As the moon drops beneath the canopy");
            }
            ////////
            if (commitment == "commited") {
                first_sacrifice.SetStringVariable("commitmentString", "a large beetle");
            }
            else if (commitment == "uncommited") {
                first_sacrifice.SetStringVariable("commitmentString", "the corpse of something small");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "a rotten branch");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "and blood sticks to your boot");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "and it sighs");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organnString", "as it vanishes");
            }
            else if (firstOrganTouched == null) {
                first_sacrifice.SetStringVariable("organString", "and crunch it underfoot");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It smells like rust.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", null);
            }

            theFirstSentence = first_sacrifice.GetStringVariable("nonAnswerString") + " you step on " + first_sacrifice.GetStringVariable("commitmentString") + " " + first_sacrifice.GetStringVariable("organString") + ".";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Stone" && firstAnswer == "silence") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "and passes you by");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "and crawls in your wake");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "and escapes through the canopy");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "and then falls silent");
            }
            ////////
            if (commitment == "commited") {
                first_sacrifice.SetStringVariable("commitmentString", "whistle");
            }
            else if (commitment == "uncommited") {
                first_sacrifice.SetStringVariable("commitmentString", "flutter");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "wail");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "underneath the dead leaves");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "upon the river");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organnString", "breathes, rhythmically");
            }
            else if (firstOrganTouched == null) {
                first_sacrifice.SetStringVariable("organString", "betwixt the trees");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It moaned in apathy.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", null);
            }

            theFirstSentence = "You hear the wind " + first_sacrifice.GetStringVariable("commitmentString") + " " + first_sacrifice.GetStringVariable("organString") + ", " + first_sacrifice.GetStringVariable("nonAnswerString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Stone" && firstAnswer == "vision") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "bound away");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "continue fixating on you");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "cautiously leap into the nothing beyond");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "slowly close");
            }
            ////////
            if (commitment == "commited") {
                first_sacrifice.SetStringVariable("commitmentString", "meow");
            }
            else if (commitment == "uncommited") {
                first_sacrifice.SetStringVariable("commitmentString", "hiss");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "giggle");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "translucent");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "turquoise");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organnString", "iridescent");
            }
            else if (firstOrganTouched == null) {
                first_sacrifice.SetStringVariable("organString", "ember");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "They will never stop watching.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", null);
            }

            theFirstSentence = "You see a pair of " + first_sacrifice.GetStringVariable("organString") + " eyes consumed by the black. They " + first_sacrifice.GetStringVariable("commitmentString") + " and " + first_sacrifice.GetStringVariable("nonAnswerString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Castle" && firstAnswer == "prosperity") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "You cannot see its shadow");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "You feel uneasy under it");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "You cannot see its body");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "It fades as the light glints off its wings");
            }
            ////////
            if (commitment == "commited") {
                first_sacrifice.SetStringVariable("commitmentString", "");
            }
            else if (commitment == "uncommited") {
                first_sacrifice.SetStringVariable("commitmentString", "small");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "quiet");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "sugar glider");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "bat");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organnString", "butterfly");
            }
            else if (firstOrganTouched == null) {
                first_sacrifice.SetStringVariable("organString", "bird");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "You hear its wings utter pestilence");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", null);
            }

            theFirstSentence = "That night, you saw a " + first_sacrifice.GetStringVariable("commitmentString") + " " + first_sacrifice.GetStringVariable("organString") + ". " + first_sacrifice.GetStringVariable("nonAnswerString") + " ";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Castle" && firstAnswer == "dread") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "lit from behind");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "shrouded in ivy");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "in a pocket of shadow");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "surrounded by flies");
            }
            ////////
            if (commitment == "commited") {
                first_sacrifice.SetStringVariable("commitmentString", "stone");
            }
            else if (commitment == "uncommited") {
                first_sacrifice.SetStringVariable("commitmentString", "wood");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "straw");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "It fades when you try to look at it");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "Your sight dims when you look at it");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organnString", "Staring at it makes you nauseous");
            }
            else if (firstOrganTouched == null) {
                first_sacrifice.SetStringVariable("organString", "It does not move, but you cannot get any closer to it.");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "No one lives there");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", null);
            }

            theFirstSentence = "You see a " + first_sacrifice.GetStringVariable("commitmentString") + "house, " + first_sacrifice.GetStringVariable("nonAnswerString") + ". " + first_sacrifice.GetStringVariable("organString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Castle" && firstAnswer == "death") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "gazes");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "leers");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "hisses");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "glares");
            }
            ////////
            if (commitment == "commited") {
                first_sacrifice.SetStringVariable("commitmentString", "softly");
            }
            else if (commitment == "uncommited") {
                first_sacrifice.SetStringVariable("commitmentString", "nervously");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "unendingly");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "watches from the underbrush");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "dangles from a tree, barring your path");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organnString", "undulates after your footsteps");
            }
            else if (firstOrganTouched == null) {
                first_sacrifice.SetStringVariable("organString", "curls up before your feet");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It vows to never let you go");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", null);
            }

            theFirstSentence = "A serpent " + first_sacrifice.GetStringVariable("organString") + " and " + first_sacrifice.GetStringVariable("nonAnswerString") + " at you " + first_sacrifice.GetStringVariable("commitmentString") + ".";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Castle" && firstAnswer == "silence") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", " while it gaped open");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", " before it collapsed");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", " as it closed");
            }
            ////////
            if (commitment == "commited") {
                first_sacrifice.SetStringVariable("commitmentString", "echoes poured");
            }
            else if (commitment == "uncommited") {
                first_sacrifice.SetStringVariable("commitmentString", "mist wafted");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "milipedes crept");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "in a large rock");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "bored into a fir");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organnString", "in a dead fox");
            }
            else if (firstOrganTouched == null) {
                first_sacrifice.SetStringVariable("organString", "in the ground");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It isn't there anymore");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", null);
            }

            theFirstSentence = "You noticed a hole " + first_sacrifice.GetStringVariable("organString") + ", and " + first_sacrifice.GetStringVariable("commitmentString") + first_sacrifice.GetStringVariable("nonAnswerString") + ".";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Castle" && firstAnswer == "vision") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "turns to clouds");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "becomes smoke");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "burns away");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "turns to locusts");
            }
            ////////
            if (commitment == "commited") {
                first_sacrifice.SetStringVariable("commitmentString", "and beckons");
            }
            else if (commitment == "uncommited") {
                first_sacrifice.SetStringVariable("commitmentString", "and wards");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "in neglect");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "throbs");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "hums");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organnString", "smolders");
            }
            else if (firstOrganTouched == null) {
                first_sacrifice.SetStringVariable("organString", "glows");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It is still there somwehere, aimless and wary");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", null);
            }

            theFirstSentence = "You see a tower in the distance; its top " + first_sacrifice.GetStringVariable("organString") + " " + first_sacrifice.GetStringVariable("commitmentString") + " as it " + first_sacrifice.GetStringVariable("nonAnswerString") + ".";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Shadow" && firstAnswer == "prosperity") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "turns to clouds");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "becomes smoke");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "burns away");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "turns to locusts");
            }
            ////////
            if (commitment == "commited") {
                first_sacrifice.SetStringVariable("commitmentString", "You are alone");
            }
            else if (commitment == "uncommited") {
                first_sacrifice.SetStringVariable("commitmentString", "You are cold");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "You are asleep");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "a vulture");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "an owl");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organnString", "a fox kit");
            }
            else if (firstOrganTouched == null) {
                first_sacrifice.SetStringVariable("organString", "a rabbit");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It reverberates and is quickly snuffed out");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", null);
            }

            theFirstSentence = "You see a tower in the distance; its top " + first_sacrifice.GetStringVariable("organString") + " " + first_sacrifice.GetStringVariable("commitmentString") + " as it " + first_sacrifice.GetStringVariable("nonAnswerString") + ".";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Nothing" && firstAnswer == "prosperity") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "through the forest");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "across the barrens");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "along the shore");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "next to a river");
            }
            ////////
            if (commitment == "commited") {
                first_sacrifice.SetStringVariable("commitmentString", "a grinning");
            }
            else if (commitment == "uncommited") {
                first_sacrifice.SetStringVariable("commitmentString", "a sneering");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "a despondent");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "placed on");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "dug into");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organnString", "broken on");
            }
            else if (firstOrganTouched == null) {
                first_sacrifice.SetStringVariable("organString", "nailed to");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It looks as if it is judging you.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", null);
            }

            theFirstSentence = "Walking " + first_sacrifice.GetStringVariable("nonAnswerString") + " you find a " + first_sacrifice.GetStringVariable("commitmentString") + " mask " + first_sacrifice.GetStringVariable("organString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");

        }

        else if (firstDivination == "Nothing" && firstAnswer == "dread") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "through the forest");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "across the barrens");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "along the shore");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "next to a river");
            }
            ////////
            if (commitment == "commited") {
                first_sacrifice.SetStringVariable("commitmentString", "a grinning");
            }
            else if (commitment == "uncommited") {
                first_sacrifice.SetStringVariable("commitmentString", "a sneering");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "a despondent");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "placed on");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "dug into");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organnString", "broken on");
            }
            else if (firstOrganTouched == null) {
                first_sacrifice.SetStringVariable("organString", "nailed to");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It looks as if it is judging you.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", null);
            }

            theFirstSentence = "Walking " + first_sacrifice.GetStringVariable("nonAnswerString") + ", you find a " + first_sacrifice.GetStringVariable("commitmentString") + " mask " + first_sacrifice.GetStringVariable("organString") + " the ground";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
            

        }
        

    }
}
