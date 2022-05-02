# RoomDesignVR

RoomDesign VR is an interactive Virtual Reality Game for Google Cardboard where you can design your own house.

# Table of contents

* [Introduction](#Introduction)
* [Space](#Space)
* [Details](#Details)
* [Conclusions](#Conclusions)
* [Contact](#Contact)
* [License](#License)

# Introduction
>[Table of contents](#table-of-contents)

This work consists of the application of the concepts acquired in the subject (23.15) Virtual Reality taught by the engineer Marc S. Ressl. The project consists of a kind of interior design game where the user is inserted into a room predefined by the group, and is given the possibility of modifying it to their liking to be able to generate different types of design on the same distribution of basic components in the room. This includes being able to change objects, materials, lights, sounds, being able to move around in the assigned space and letting the user's imagination run wild as they try to fit in the best possible way the large number of combinations available for the different types of designs.
To go a little deeper, the following sections will mention in a little more detail what can be done and how it was implemented in the work.

# Space
>[Table of contents](#table-of-contents)

In order to understand where the user will be inserted, we detail in this small section the space where the user will work to improve. More specifically it will be 2 portions of a house, the kitchen and the living/dining room. In the following Figure you can see the model from which we started to change and add new components to make the user feel comfortable.

<img src="https://github.com/MT2321/RoomDesignVR/blob/main/docs/lowpoly_house_interior.png?raw=true" width=800 align=center>

However, due to the aforementioned issues, only the first floor was used, and the second floor was discarded.

In the following figure we can see what was later the distribution of objects on the first floor between which the user has the possibility to change, this is to give us a better idea of how is the space where we are going to find ourselves as soon as we enter the world.

<img src="https://github.com/MT2321/RoomDesignVR/blob/main/docs/distribucion.png?raw=true" width=800 align=center>


As you can see in the image there are different types of things that can be changed, some of them are listed below:

* Red: Armchairs
* Red: Mouse Table
* Red: Television
* Yellow: Television set
* Green: Furniture decorations
* Yellow: Wall painting
* Violet: Dining table
* Violet: Dining chairs
* Light Blue: Microwave


However, there are things that cannot be seen in the house distribution plan because they are not visible from that view, those things are for example the ceiling lamps and the decorations on the furniture. On the other hand, another important leg on the design is to have the possibility to change the materials, and that is why we also have the possibility to change the materials to:


* All walls independent of each other
* Both ceilings (living room and kitchen)
* Both floors (living room and kitchen)
* Marble of the kitchen
* Kitchen furniture material


In the following figures we will show some examples of possible designs with different combinations of objects and materials.

<img src="https://github.com/MT2321/RoomDesignVR/blob/main/docs/1_1.png?raw=true" width=800 align=center>

<img src="https://github.com/MT2321/RoomDesignVR/blob/main/docs/1_2.png?raw=true" width=800 align=center>

<img src="https://github.com/MT2321/RoomDesignVR/blob/main/docs/2_1.png?raw=true" width=800 align=center>

<img src="https://github.com/MT2321/RoomDesignVR/blob/main/docs/2_2.png?raw=true" width=800 align=center>

<img src="https://github.com/MT2321/RoomDesignVR/blob/main/docs/3_1.png?raw=true" width=800 align=center>

<img src="https://github.com/MT2321/RoomDesignVR/blob/main/docs/3_2.png?raw=true" width=800 align=center>


# Details
>[Table of contents](#table-of-contents)

Although this report will not go into detail about the entire contents of the project, there are some details that we would like to mention so that they are not overlooked by the reader.

## Materials

As mentioned above, the user is able to change the materials to a wide variety of components, however the selection made by the members of the group for these materials was not random, but rather a search for those that met a previously defined standard so that the objects look sufficiently defined on screen. Although there are exceptions, we tried to ensure that all the materials used had a definition of at least 4096x4096 pixels. And if not necessary, we downsampled the images of the materials as appropriate using unity. This provided us with materials for the walls and objects that we were impressed with ourselves and gave the project an incredible level of realism. In general, we sourced most of the textures from [Ambientcg](https://ambientcg.com/categories).

## Objects

While the number of objects available for selection remains adequate, selecting them proved to be an arduous task due to the fact that many more component options were discarded due to different problems. Although the option to add more options for each particular object was available, it was decided not to do so for the moment in order to maintain a certain level of quality of the scene we were providing to the user. In general, the majority of the prefabs were obtained from [SketchFab](https://sketchfab.com/feed)


## Ray Tracing

To give a realistic effect to the scene, we chose to apply Ray Tracing Baked on some pre-selected objects, and in this way generate static lightmaps that will not be modified throughout the game. This provided the realistic generation of shadows, without the loss of processing power of the phone where this game is run.

## Post-Processing

Finally another thing to highlight are the post-processing effects added to the scene, they are:


* Bloom, to give a more realistic effect to the emissive objects such as lamps.
* Color Grading: To change the color curve seen by the user and give a more pleasant tone to the scene.
* Motion Blur: To give a more realistic effect to the camera when it moves at high speeds.

## Motion

To be able to move around the space it was decided to go for an option without external controls, so that any user with a Google CardBoard can participate and play with their own phone. This is achieved by simply looking at the ground, once a certain threshold is exceeded, the subject will start to move to wherever it is looking without changing the height of the camera.


# Conclusions
>[Table of contents](#table-of-contents)

To finish this report, first of all the reader is invited to try this game, it is available as a [release](https://github.com/MT2321/RoomDesignVR/releases/tag/v1.0.0) and you can compile it directly from there. As last leg of the project we have to mention what we think we want to improve or expand for future versions of the project, they are detailed here below:


* Add room modification: Currently we are focusing only on the living room and kitchen, but to make it appear to be a real environment, we would need to add the design of the bedrooms and bathrooms.
* Add more options for each object: Increase the ability to change by adding much more options for each object you want to change.
* Ability to change materials to interchangeable objects: Add the ability to change the material to an interchangeable object, such as individual armchairs.
\Add more objects with animations. Although we could add more objects with animations such as fans, we struggled to find a sufficient reason to add objects that move in the design of a room, that is why for the moment it was decided not to do so.
* Add more furniture and decorations.
* Add messages to the user indicating information about what he/she is doing.
* Adding value to the objects in order to make it more dynamic and challenging for the user to make a design with a given budget.

# Contact
>[Table of contents](#table-of-contents)

Please do not hesitate to reach out to us if you find any issue with the code or if you have any questions.

* Personal emails:
    * [idiaz@itba.edu.ar](mailto:idiaz@itba.edu.ar)
    * [mrodriguez@itba.edu.ar](mailto:mrodriguez@itba.edu.ar)
    * [matiasrodriguez@itba.edu.ar](mailto:matiasrodriguez@itba.edu.ar)
    * [csena@itba.edu.ar](mailto:csena@itba.edu.ar)

* LinkedIn Profiles:
    * [Ian C. Diaz](https://www.linkedin.com/in/iancraz/)
    * [Martin S. Rodriguez Turco](https://www.linkedin.com/in/mrturco/)
    * [Conrado Sena](https://www.linkedin.com/in/conrado-sena-giere-4b8331205/)

# License
>[Table of contents](#table-of-contents)

```
MIT License

Copyright (c) 2022 Ian Cruz Diaz, Martin Sebastian Rodriguez Turco, Matías Rodriguez Turco, Conrado Sena

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```