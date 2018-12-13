# Game_controller_arduino
The device consists of a simple controller that is made up of an embedded sensor, the accelerometer. The game we will make will be a car racing game made using the Unity web engine. The player would control the movement of the car in the game by simply turning the hand wrist, which would turn the car, accordingly. If the player wants to turn the car to the right side of the lane, the player will simply    turn their wrist and the car will turn; likewise, to turn to the right side of the lane, the player will turn the wrist to the left. Furthermore, the gears can be manually changed by entering the gear number in a keypad. The default gear will begear1, which can be changed gradually to gear 5 as the car accelerates, just like gears change in a manual gear car. The game data will be shared through either the ethernet module or the bluetooth module.The speed of the car will be displayed on a LCD and the camera view can be changed from 4x4 keyboard. 

Following sources will be helpful to interface sensors and to build the game.
To build game scene: https://www.youtube.com/watch?v=61YVdB66jMg
Controlling different camera mode: https://www.youtube.com/watch?v=NO3-76WUZiY&index=8&list=PLZ1b66Z1KFKgkE9ji0tF2iDO0LGxmlwIm
Interfacing MPU6050 with Arduino: https://github.com/Hstellar/Game_controller_arduino/blob/master/game_arduino.ino
Interfacing Keypad with Arduino: https://circuitdigest.com/microcontroller-projects/keypad-interfacing-with-arduino-uno
To obtain offsets, download MPU6050_calbration.ino: https://forum.arduino.cc/index.php?action=dlattach;topic=446713.0;attach=193816
MPU6050 Library: https://github.com/jrowberg/i2cdevlib/blob/master/Arduino/MPU6050/MPU6050.h
I2cdev.h Library: https://www.i2cdevlib.com/docs/html/_i2_cdev_8h_source.html
 
