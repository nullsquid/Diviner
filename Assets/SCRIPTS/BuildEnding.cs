using UnityEngine;
using System.Collections;
using Fungus;
public class BuildEnding : MonoBehaviour {
    public Flowchart first_sacrifice;
    public string theFirstSentence;
    public string theSecondSentence;



    public void GetEnding() {
        first_sacrifice.SetStringVariable("endingFirstSentence", theFirstSentence);
        first_sacrifice.SetStringVariable("endingSecondSentence", theSecondSentence);
    }


    public void ConstructEnding(string firstDivination, string firstAnswer, string commitment, int howManyNullAnswers, string firstOrganTouched, bool talkedToOffering) {

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
            if (commitment == "committed") {

                first_sacrifice.SetStringVariable("commitmentString", "face up");
            }
            else if (commitment == "uncommitted") {
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
                first_sacrifice.SetStringVariable("organString", "an ivory rook piece");
            }
            else if (firstOrganTouched =="") {
                first_sacrifice.SetStringVariable("organString", "a rusted coin");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It feels frozen.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You found " + first_sacrifice.GetStringVariable("organString") + " " + first_sacrifice.GetStringVariable("commitmentString") + "," + first_sacrifice.GetStringVariable("nonAnswerString");
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
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "a vine");
            }
            else if (commitment == "uncommitted") {
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
                first_sacrifice.SetStringVariable("organString", "and you cut your right knee");
            }
            else if (firstOrganTouched =="") {
                first_sacrifice.SetStringVariable("organString", "and the autumn leaves cushion you");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "There are droplets of blood where you land.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
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
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "a large beetle");
            }
            else if (commitment == "uncommitted") {
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
                first_sacrifice.SetStringVariable("organString", "as it vanishes");
            }
            else if (firstOrganTouched =="") {
                first_sacrifice.SetStringVariable("organString", "and crunch it underfoot");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It smells like rust.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = first_sacrifice.GetStringVariable("nonAnswerString") + " you step on " + first_sacrifice.GetStringVariable("commitmentString") + " " + first_sacrifice.GetStringVariable("organString") + ".";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Stone" && firstAnswer == "silence") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "and pass you by");
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
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "whistle");
            }
            else if (commitment == "uncommitted") {
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
                first_sacrifice.SetStringVariable("organString", "breathe, rhythmically");
            }
            else if (firstOrganTouched =="") {
                first_sacrifice.SetStringVariable("organString", "betwixt the trees");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It moans in apathy.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You hear the wind " + first_sacrifice.GetStringVariable("commitmentString") + ", " + first_sacrifice.GetStringVariable("organString") + ", " + first_sacrifice.GetStringVariable("nonAnswerString");
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
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "meow");
            }
            else if (commitment == "uncommitted") {
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
                first_sacrifice.SetStringVariable("organString", "iridescent");
            }
            else if (firstOrganTouched =="") {
                first_sacrifice.SetStringVariable("organString", "ember");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "They will never stop watching.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You see a pair of " + first_sacrifice.GetStringVariable("organString") + " eyes consumed by the black. They " + first_sacrifice.GetStringVariable("commitmentString") + " and " + first_sacrifice.GetStringVariable("nonAnswerString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Stone" && firstAnswer == "remorse") {
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
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "meow");
            }
            else if (commitment == "uncommitted") {
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
                first_sacrifice.SetStringVariable("organString", "iridescent");
            }
            else if (firstOrganTouched == "") {
                first_sacrifice.SetStringVariable("organString", "ember");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "They will never stop watching.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
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
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "");
            }
            else if (commitment == "uncommitted") {
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
                first_sacrifice.SetStringVariable("organString", "butterfly");
            }
            else if (firstOrganTouched =="") {
                first_sacrifice.SetStringVariable("organString", "bird");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "You hear its wings utter pestilence");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
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
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "stone");
            }
            else if (commitment == "uncommitted") {
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
                first_sacrifice.SetStringVariable("organString", "Staring at it makes you nauseous");
            }
            else if (firstOrganTouched =="") {
                first_sacrifice.SetStringVariable("organString", "It does not move, but you cannot get any closer to it.");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "No one lives there");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You see a " + first_sacrifice.GetStringVariable("commitmentString") + " house, " + first_sacrifice.GetStringVariable("nonAnswerString") + ". " + first_sacrifice.GetStringVariable("organString");
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
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "softly");
            }
            else if (commitment == "uncommitted") {
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
                first_sacrifice.SetStringVariable("organString", "undulates after your footsteps");
            }
            else if (firstOrganTouched =="") {
                first_sacrifice.SetStringVariable("organString", "curls up before your feet");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It vows to never let you go");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
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
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "echoes poured");
            }
            else if (commitment == "uncommitted") {
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
                first_sacrifice.SetStringVariable("organString", "in a dead fox");
            }
            else if (firstOrganTouched =="") {
                first_sacrifice.SetStringVariable("organString", "in the ground");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It isn't there anymore");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
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
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "and beckons");
            }
            else if (commitment == "uncommitted") {
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
                first_sacrifice.SetStringVariable("organString", "smolders");
            }
            else if (firstOrganTouched =="") {
                first_sacrifice.SetStringVariable("organString", "glows");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It is still there somwehere, aimless and wary");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You see a tower in the distance; its top " + first_sacrifice.GetStringVariable("organString") + " " + first_sacrifice.GetStringVariable("commitmentString") + " as it " + first_sacrifice.GetStringVariable("nonAnswerString") + ".";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Shadow" && firstAnswer == "prosperity") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "cry");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "whimper");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "scream");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "laugh");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "You are alone");
            }
            else if (commitment == "uncommitted") {
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
                first_sacrifice.SetStringVariable("organString", "a fox kit");
            }
            else if (firstOrganTouched =="") {
                first_sacrifice.SetStringVariable("organString", "a rabbit");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It reverberates and is quickly snuffed out");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = first_sacrifice.GetStringVariable("commitmentString") + " and hear " + first_sacrifice.GetStringVariable("organString") + " " + first_sacrifice.GetStringVariable("nonAnswerString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Shadow" && firstAnswer == "dread") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "and wandering");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", ", searching for your path");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "and standing still");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", ", waiting");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "lost");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "bemused");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "enervated");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "glow");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "bound away");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", "hide in the brush");
            }
            else if (firstOrganTouched == "") {
                first_sacrifice.SetStringVariable("organString", "skitter into the shade");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "Quickly, you are alone again.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You are " + first_sacrifice.GetStringVariable("commitmentString") + " " + first_sacrifice.GetStringVariable("nonAnswerString") + ". " + "You see something " + first_sacrifice.GetStringVariable("organString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Shadow" && firstAnswer == "death") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "in these woods");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "across that lake");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "from atop the trees");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "on the bottom of the river");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "watching");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "listening");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "mumbling");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "coldly");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "deliberately");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", "tenderly");
            }
            else if (firstOrganTouched == "") {
                first_sacrifice.SetStringVariable("organString", "softly");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It is lingering and quiet");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "There is something alone with you " + first_sacrifice.GetStringVariable("nonAnswerString") + "; " + first_sacrifice.GetStringVariable("commitmentString") + " " + first_sacrifice.GetStringVariable("organString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Shadow" && firstAnswer == "silence") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "hair");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "skin");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "ink");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "sugar");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "bitter");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "sweet");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "acrid");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "old trees groaning");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "insects fluttering");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", "wind dancing");
            }
            else if (firstOrganTouched == "") {
                first_sacrifice.SetStringVariable("organString", "leaves rustling");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "They wrap your senses and follow in toe.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You smell " + first_sacrifice.GetStringVariable("commitmentString") + " " + first_sacrifice.GetStringVariable("nonAnswerString") + " and hear the " + first_sacrifice.GetStringVariable("organString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Shadow" && firstAnswer == "vision") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "falling star");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "firefly");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "ghostly haze");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "writhing shadow");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "briefly");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "intensely");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "oppressively");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "ravenous");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "exhausted");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", "dizzy");
            }
            else if (firstOrganTouched == "") {
                first_sacrifice.SetStringVariable("organString", "cold");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "You wonder where it is going.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "A " + first_sacrifice.GetStringVariable("nonAnswerString") + " streaks across the sky. You feel " + first_sacrifice.GetStringVariable("commitmentString") + " " + first_sacrifice.GetStringVariable("organString");
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
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "a grinning");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "a sneering");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "a despondent");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "placed on a rock");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "dug into the earth");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", "broken on the ground");
            }
            else if (firstOrganTouched =="") {
                first_sacrifice.SetStringVariable("organString", "nailed to a tree");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It looks as if it is judging you.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "Walking " + first_sacrifice.GetStringVariable("nonAnswerString") + " you find a " + first_sacrifice.GetStringVariable("commitmentString") + " mask " + first_sacrifice.GetStringVariable("organString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");

        }

        else if (firstDivination == "Nothing" && firstAnswer == "dread") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "a brilliant white");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "an infernal red");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "black as oil");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "a sickly green");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "The moonlight");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "The starlight");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "The fiery glow of a comet overhead");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "every leaf on");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "all the naked branches of");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", "the bark on");
            }
            else if (firstOrganTouched =="") {
                first_sacrifice.SetStringVariable("organString", "the tips of");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "They tower over you, motionless.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = first_sacrifice.GetStringVariable("commitmentVariable") + " touches " + first_sacrifice.GetStringVariable("organString") + " every tree and you see that they are all " + first_sacrifice.GetStringVariable("nonAnswerString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");


        }

        else if (firstDivination == "Nothing" && firstAnswer == "death") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "blood");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "water");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "tar");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "sap");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "to where you sleep");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "to where you prepare");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "away from that place");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "dripping from your wrists");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "behind your teeth");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", "between your fingers");
            }
            else if (firstOrganTouched =="") {
                first_sacrifice.SetStringVariable("organString", "beneath your feet");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It will not wash off");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "That night, walking " + first_sacrifice.GetStringVariable("commitmentString") + ", you notice " + first_sacrifice.GetStringVariable("nonAnswerString") + " " + first_sacrifice.GetStringVariable("organString") + ".";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Nothing" && firstAnswer == "silence") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "somber");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "capricious");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "stern");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "muted");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "round");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "narrow");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "distant");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "beyond the trees");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "over a river");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", "at the bottom of a lake");
            }
            else if (firstOrganTouched =="") {
                first_sacrifice.SetStringVariable("organString", "inside a deep knothole");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It looks lost.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You thought you saw a " + first_sacrifice.GetStringVariable("commitmentString") + " face in the dark " + first_sacrifice.GetStringVariable("organString") + "; it looked " + first_sacrifice.GetStringVariable("nonAnswerString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Nothing" && firstAnswer == "vision") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "an eye");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "an egg");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "a wing");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "a lamb");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "a mouth");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "a perfect circle");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "a star");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "drawn in charcoal on");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "carved into");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", "burnt into");
            }
            else if (firstOrganTouched == "") {
                first_sacrifice.SetStringVariable("organString", "painted on");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "Its meaning escapes you.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "There was " + first_sacrifice.GetStringVariable("nonAnswerString") + " " + first_sacrifice.GetStringVariable("organString") + " one of the old oaks; " + first_sacrifice.GetStringVariable("commitmentString") + " on another.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Tree" && firstAnswer == "prosperity") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "acorns");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "walnut husks");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "seashells");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "bones");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "Every one looks decayed from the inside");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "Each one is stained dark");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "They are all being devoured by insects");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "a clearing strewn with");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "a pit filled with");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", "a beach littered with");
            }
            else if (firstOrganTouched == "") {
                first_sacrifice.SetStringVariable("organString", "a gravesite, cluttered with");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "They came from elsewhere.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You come across a " + first_sacrifice.GetStringVariable("organString") + " " + first_sacrifice.GetStringVariable("nonAnswerString") + " . " + first_sacrifice.GetStringVariable("commitmentString"); 
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Tree" && firstAnswer == "dread") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "tall");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "stout");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "eldritch");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "sinister");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "in the moonlight");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "through the ambient glow of the forest");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "under the vast expanse of sky");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "serpentine");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "cyclopean");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", "feline");
            }
            else if (firstOrganTouched == "") {
                first_sacrifice.SetStringVariable("organString", "ghastly");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It does not follow you home.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "Your shadow appears " + first_sacrifice.GetStringVariable("nonAnswerString") + " and " + first_sacrifice.GetStringVariable("organString") + " " + first_sacrifice.GetStringVariable("commitmentString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");

        }

        else if (firstDivination == "Tree" && firstAnswer == "death") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "in the shape of a star");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "in the shape of a lotus");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "in the shape of a cross");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "in the shape of a finger");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "pendant");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "ring");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "brooch");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", ", intricately woven from twigs");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", ", built from shiny refuse");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", ", long since abandoned");
            }
            else if (firstOrganTouched == "") {
                first_sacrifice.SetStringVariable("organString", "made of sticks and mud");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "You wonder how long it has been there.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "There is a nest in a nearby tree " + first_sacrifice.GetStringVariable("organString") + ". It has a " + first_sacrifice.GetStringVariable("commitmentString") + " hanging from it " + first_sacrifice.GetStringVariable("nonAnswerString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");

        }

        else if (firstDivination == "Tree" && firstAnswer == "silence") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "It twitches, and convulses and is still");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "It appears to be in pain");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "It did not suffer too long");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "It looks at you as its eyes go dark");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "on the forest floor");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "on its back");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "half-burried in the soil");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "cicada");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "squirrel");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", "trout");
            }
            else if (firstOrganTouched == "") {
                first_sacrifice.SetStringVariable("organString", "crow");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "You push a mound of dirt on top of it.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "A dying " + first_sacrifice.GetStringVariable("organString") + " lies  " + first_sacrifice.GetStringVariable("commitmentString") + ". " + first_sacrifice.GetStringVariable("nonAnswerString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");

        }

        else if (firstDivination == "Tree" && firstAnswer == "vision") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "Ashen");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "Ghoulish");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "Emaciated");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "Cephalopodean");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "and collapse into dust");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "and extend their tendrils out for you");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "and blur into nothing");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "flail");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "seethe");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", "flicker");
            }
            else if (firstOrganTouched == "") {
                first_sacrifice.SetStringVariable("organString", "dance");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "You taste the sea deep inside your lungs");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = first_sacrifice.GetStringVariable("nonAnswerString") + " figures " + first_sacrifice.GetStringVariable("organString") + " in front of you; they drip ink " + first_sacrifice.GetStringVariable("commitmentString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");

        }



        else if (firstDivination == "Released" && firstAnswer == "prosperity") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "as you walked");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "as you contemplated the evening");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "as you slept on the forest floor");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "as clouds drowned out the light");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "An owl");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "A hawk");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "A raven");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "distracted the shadows");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "whispered charms to you");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", "guarded your passage");
            }
            else if (firstOrganTouched =="") {
                first_sacrifice.SetStringVariable("organString", "called your name");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "You feel somehow safer");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = first_sacrifice.GetStringVariable("commitmentString") + " " + first_sacrifice.GetStringVariable("organString") + " " + first_sacrifice.GetStringVariable("nonAnswerString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Released" && firstAnswer == "dread") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "close enough to embrace you");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "lurking within the gloom");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "staying distant and hidden");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "creeping like a toxic fog");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "behind you");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "beside you");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "all around you");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "They stuttered and were gone.");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "They cautiously pattered underneath your footfall.");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", "They leave no trail.");
            }
            else if (firstOrganTouched == "") {
                first_sacrifice.SetStringVariable("organString", "They stop when you do.");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "You hope you are not alone in these woods.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You thought you heard footsteps " + first_sacrifice.GetStringVariable("commitmentString") + ", " + first_sacrifice.GetStringVariable("nonAnswerString") + ". " + first_sacrifice.GetStringVariable("organString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Released" && firstAnswer == "death") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "leaving a trail of smoke and dust");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "cutting the oppressive shades of desolation");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "cutting the night with the edge of its wings");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "undulating as if through space");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "behind you");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "beside you");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "all around you");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", "It sucks the color from the night");
            }
            else if (firstOrganTouched == "") {
                first_sacrifice.SetStringVariable("organString", "You see a flower wilt");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "You hope you are not alone in these woods.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You thought you heard footsteps " + first_sacrifice.GetStringVariable("commitmentString") + ", " + first_sacrifice.GetStringVariable("nonAnswerString") + ". " + first_sacrifice.GetStringVariable("organString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Released" && firstAnswer == "silence") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "smelled of citrus and iron");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "tasted like molases");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "felt acrid against your skin");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "hurt your eyes like needles");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "before becoming ash");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "and moaned, anxiously");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "and wrapped around you like a chrysalis");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "The woods");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "The azure clounds");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", "The moon's reflection");
            }
            else if (firstOrganTouched == "") {
                first_sacrifice.SetStringVariable("organString", "The murmuring shadows");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "You are not so far away.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = first_sacrifice.GetStringVariable("organString") + " " + first_sacrifice.GetStringVariable("nonAnswerString") + ", " + first_sacrifice.GetStringVariable("commitmentString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Released" && firstAnswer == "vision") {
            if (howManyNullAnswers <= 2) {
                first_sacrifice.SetStringVariable("nonAnswerString", "into the woods");
            }
            else if (howManyNullAnswers <= 4) {
                first_sacrifice.SetStringVariable("nonAnswerString", "into the turbulent night");

            }
            else if (howManyNullAnswers <= 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "into the denser pockets of fog");
            }
            else if (howManyNullAnswers > 6) {
                first_sacrifice.SetStringVariable("nonAnswerString", "out beyond the trees");
            }
            ////////
            if (commitment == "committed") {
                first_sacrifice.SetStringVariable("commitmentString", "everything seems so far away");
            }
            else if (commitment == "uncommitted") {
                first_sacrifice.SetStringVariable("commitmentString", "it all stretches out forever");

            }
            else if (commitment == "timeRanOut") {
                first_sacrifice.SetStringVariable("commitmentString", "things spiral infinitely downward");
            }
            ///////
            if (firstOrganTouched == "intestines") {
                first_sacrifice.SetStringVariable("organString", "and it never gets any further away");
            }
            else if (firstOrganTouched == "liver") {
                first_sacrifice.SetStringVariable("organString", "and time seems to stand still");
            }
            else if (firstOrganTouched == "pancreas") {
                first_sacrifice.SetStringVariable("organString", "and everything seems perfect and still");
            }
            else if (firstOrganTouched == "") {
                first_sacrifice.SetStringVariable("organString", "and everything oscillates with every step");
            }
            ///////
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "You feel anger and sadness in those trees.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "When you look out " + first_sacrifice.GetStringVariable("nonAnswerString") + ", " + first_sacrifice.GetStringVariable("commitmentString") + ". You walk " + first_sacrifice.GetStringVariable("organString");
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Stone" && firstAnswer == "anguish") {
            
            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It obscures the way in front of you.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You find a white rope strung between the trees";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Stone" && firstAnswer == "remorse") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "You wished you could turn around.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You are painfully and violently hungry";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Stone" && firstAnswer == "desperation") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "Your breath crystallizes as it leaves you.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You see a rock covered in ice along the shore.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Stone" && firstAnswer == "arrogance") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It burns your eyes.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "There is smoke, but no heat or fire";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Stone" && firstAnswer == "woe") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "The smell is sickening and passes over you.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "Fetid earth clings to your boot.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Stone" && firstAnswer == "delight") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "They hover like ghosts on the horizon");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You see the sun beginning to rise, shining purple through the clouds";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Castle" && firstAnswer == "anguish") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It slips down your throat, as you swallow.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "A beetle flies into your open mouth.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Castle" && firstAnswer == "remorse") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "The shapes they make look like forgotten words.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "The shadows from branches flicker in spirals.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Castle" && firstAnswer == "desperation") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "There is no wind.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "One bright white birch sits and sways next to the lake.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Castle" && firstAnswer == "arrogance") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "The cool blue washes over you and warms you.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "A kitten crosses your path with eyes like the sea.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Castle" && firstAnswer == "delight") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "There is a star above you that was not there before.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "The sky turns red for only a moment.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Castle" && firstAnswer == "woe") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "As if a great beast was returning to slumber.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You feel a rumbling beneath you that swells and subsides.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Shadow" && firstAnswer == "anguish") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It disperses as a cloud of flies.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You thought you saw a body hanging from the trees";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Shadow" && firstAnswer == "remorse") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "Like a halo, their wings filtering the moonlight");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "A circle of locusts buzzes overhead";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Shadow" && firstAnswer == "desperation") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "Leaves rain down around you.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "The wind whips around in a vortex.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Shadow" && firstAnswer == "arrogance") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "Their feathers look like glass.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "Bloody wings are arranged in a circle.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Shadow" && firstAnswer == "desperation") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "The blades writhe and wiggle in concert.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "One patch of red grass pokes up through the underbrush.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Shadow" && firstAnswer == "woe") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It almost looks like a face, contorted in agony.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You pick up an oak leaf with burnt markings on it.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Tree" && firstAnswer == "anguish") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "Sap drips from above onto your face.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You smell something pungent.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Tree" && firstAnswer == "remorse") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It is viscous, like cold tar.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You feel something beneath the shadows slither around your leg";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Tree" && firstAnswer == "desperation") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "Glowing eyes watch you from the deep.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You hear music resounding from beneath the lake's surface.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }

        else if (firstDivination == "Tree" && firstAnswer == "arrogance") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "They stop abruptly with a flicker of green.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "Tiny voices laugh at you as you pass";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Tree" && firstAnswer == "delight") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "Then the galloping of hooves and silence.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You hear a heavy breathing behind your ear.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Tree" && firstAnswer == "woe") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "Endlessly and eternally looking out across the waves.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You come across a giant stone head buried by the shore.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Nothing" && firstAnswer == "anguish") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "His flesh dries up, leaving only a husk and is gone.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "The shadow of a man stands tall in front of you.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Nothing" && firstAnswer == "remorse") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "As the ripples pass over your face, a monster stares back.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You glance at your reflection in the lake";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Nothing" && firstAnswer == "desperation") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "A pile of ash and a tiny skeleton lie beneath it.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "A burning doll hangs from a nearby branch";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Nothing" && firstAnswer == "arrogance") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "You slept, and dreamt of hunting.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "For a moment, you thought you were watching you with another's eyes";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Nothing" && firstAnswer == "delight") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "The night is always in front of you.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "You saw daybreak, and gasped for air.";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        else if (firstDivination == "Nothing" && firstAnswer == "woe") {

            if (talkedToOffering == true) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "It called, and cursed, and spit out your name.");
            }
            if (talkedToOffering == false) {
                first_sacrifice.SetStringVariable("talkedToOfferingString", "");
            }

            theFirstSentence = "That one lake looked to burn";
            theSecondSentence = first_sacrifice.GetStringVariable("talkedToOfferingString");
        }
        first_sacrifice.SetStringVariable("endingKey", theFirstSentence + " " + theSecondSentence + "~");
    }
}
