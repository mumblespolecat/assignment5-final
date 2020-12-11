<strong>EG-M126 – Development of Virtual Reality Environments: Assignment 5</strong>
<strong>Name:</strong>  Matthew Allen
<strong>Date:</strong>  11th December 2020
<hr>
<strong>Submitted for Assignment 5: AI of the VR MSc for Swansea University</strong>
<hr>
<strong>Unity Version:</strong>  2019.4.12f1
<strong>Tested on:</strong>  Windows Mixed Reality HMD (as provided) and ASUS ROG laptop (as provided)
<strong>GitHub link:</strong>  Git hub wasn’t always entirely cooperative for this assignment !  I started of with one for the initial project where I was experimenting with the crowd movement and with getting Yarn Spinner to work.  This was all with the simple camera script.  That is GitHub link 1 below.  I’ve then had some issues in the past with things breaking when XR is enabled in the project, so as recommended by Ted in week 1, I duplicated the project before doing so.  I decided to have a separate GitHub for it, so I forked off rathe than branching.  Not long after that, I got myself in a mess and ended up with 2 stuck outgoings.  I could only manage to clear one of them.  This is GitHub link 2 below.  Lastly, I put up a third GitHub today with the final project on it.  That is link 3.  I’ve included all of them to show I have been using it, even though badly ...

<ul>
  <li>GitHub 1:  https://github.com/mumblespolecat/Assignment5AI-2.git</li>
  <li>GitHub 2:  https://github.com/mumblespolecat/assignment5-AIXR.git</li>
  <li>GitHub 3:  https://github.com/mumblespolecat/assignment5-final.git   (this is the final working one, with properly commented code)</li>
</ul>

<strong>The Dialogue:</strong>
I wanted dialogue that fitted the characters.  I also wanted it to have very light humour (which was also due to the cartoon feel of the characters), and also have a few cultural references.  I hope I achieved at least some of that.  There is an order to the dialogue, with responses / options allowing the player to go forward through the story only becoming available as things are done in the right order.  There are consequences in so far as you have to talk to them all to work out what to do and subsequently, if you don’t do things in the right order, you don’t progress (very fancy sounding language for such a simple story …).
I have tried to ensure repetition is only encountered when the same character is repeatedly approached with nothing having happened in between.  They have that in the Zelda games on the switch, so if it is good enough for them …  I’ve tried to ensure that not only does the story drive the dialogue, but also that the dialogue drives the story in return.  The dialogue also sets the appropriate variables to see who has talked to who and been asked what, and as a final act enables the present (a dog) to appear by making he object active.  I tried to use the available functionality appropriately.
(225 words)
<strong>The Crowd:</strong>
The ideas and mechanics of my humanoid crowd was demonstrated on the Learn Unity website (1), as signposted by Ted, and creditied below.  It doesn’t really fit in with the story, as such, but it doesn’t interfere with or detract from it either.  It is made up of very simple models from Mixamo (deliberately, so that it was easy to spot the three interactable characters) who roam around with one of two walking animations, also from Mixamo.  They move around the space, between randomly selected goals, dotted here and there.  When they got close to their goal, they pick another one at random and move off towards that instead.  
They all have a random offset in their animation so that they aren’t walking in step, as that would have looked odd.  They also have a random speed multiplier for both the magnitude of their movement vector and also for the rate at which their animation runs, so they look like they are moving at different speeds.  They can be a little swervy and at times manage to walk sideways, but it isn’t too obvious, I hope.  They all avoid the player, each other and the three NPCs.  They stick fairly close to the blocks as the goals are fairly close to the blocks and it looked weird if they were further out.
(221 words)
<strong>The Story:</strong>
I initially had two strands of story (the one that remains, and another one about the male character becoming jealous).  I dropped the idea of the second (completrely undeveloped, so I wasted no time on it at all) one as I started to think about how the dialogue was going to work – it would have been too confusing to have both and they would have distracted from each other to the point of being obstructive.
So the story is essentially about a sighly aimless, mostly harmless male character with a granny (not backwards about going forwards) who wants to give him something for his birthday to occupy himself with, but doesn’t really know what to give.  His girlfriend is the one who actually talks to him and has that understanding of what he wants (and is slightly scathing about his granny’s probable choice, i.e. she knows what he doesn’t want too) and the player acts as the messenger between the three to get the right present for the right person.  So it’s a tale of the disconnect sometimes present in families between the generations.  It is a very simple story, but one that I felt drove the dialogue quite nicely and gave opportunities for using the functionality available.
(208 words)

<strong>Reflection:</strong>
This has been my favourite assignment to work on by far !  It has also been the most challenging.
As soon as I saw the dialogue, lightbulbs turned on in my mind, probably more than through any other single element we’ve looked at in these last few weeks.  The ability to create stories is central to our role of the story telling ape (2) and adds greatly to the immersion of the experience.  It enables me to envisage even more application of VR to my own particular interest of education.  I really enjoyed putting the dialogue together, although it was much more challenging than I had (naievely) expected it to be.  I had a bit of a lost weekend to that.  Having to work out not only what to say but the structure and the mechanics behind the saying of it.  Then you’ve got to work it out in Yarn Spinner, with it’s little peculiarities !  However, I was pleased with the result.
The crowd was such a big thing in itself.  The more I read and watched the more it became apparent how detailed you could make it.  I considered trying to implement wandering (as considered on the Learn Unity website (3)). I even toyed with having Robot Kyle from  my cell scene for assignment 4 following the player and hiding if spotted.  However, I ultimately decided to put those ideas on the list of things to try in the future and focus on the dialogue.  The more I use Unity, the more I am amazed by how powerful it is though.
I was very pleased to get better movement working in the XR build for this assignment – not continuous motion, but using the controllers functionality much more, both teleporting and rotating.  This assignment has given me the opportunity to gain a much better understanding of the workings of the XR rig and of the input system.
I look at what I can now do with Unity (and I obviously realise I can only do about 10% of the 20% that Steve uses) and see that I am now doing fairly easily things that I struggled with a few weeks ago and I am glad to see obvious progress.  Ted has again helped me a couple of times, but I also managed to work several things out which would have floored me before.

<strong>Asset Credits:</strong>
•	Three NPCs (Kaya, Michelle and Sporty Granny - From: Mixamo)
•	Two repeated crowd members (xbot and ybot | From: Mixamo)
•	NPC and crowd animations (From: Mixamo)
•	Crowd mechanics scripting and inspiration (Creating a City Crowd | From: Learn Unity)
•	Grass and stone materials (World Materials Free | From: Unity Asset Store | By: Avionx)
•	The dog (5 Animated Voxel Animals | From: Unity Asset Store | By: VoxelGuy)

<strong>References:</strong>
1.	Learn Unity. Creating a City Crowd [Internet]. 2020 [cited 2020 Dec 11]. Available from: https://learn.unity.com/tutorial/creating-a-city-crowd
2.	Wikipedia. Homo narrans [Internet]. 2020 [cited 2020 Dec 11]. Available from: https://en.wikipedia.org/wiki/Homo_narrans  
3.	Learn Unity. Autonomously Moving Agents [Internet]. 2020 [cited 2020 Dec 11]. Available from: https://learn.unity.com/project/autonomously-moving-agents  

