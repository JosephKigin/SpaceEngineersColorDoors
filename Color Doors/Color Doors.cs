using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.Common;
using Sandbox.Common.Components;
using Sandbox.Common.ObjectBuilders;
using Sandbox.Definitions;
using Sandbox.Engine;
using Sandbox.Game;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;


namespace SpaceEngineersTemplate
{
    public class Class1
    {
        IMyGridTerminalSystem GridTerminalSystem;

        void Main()
        {
           /****************
            * DOOR VARIABLES
            * **************/
            IMyDoor door1 = (IMyDoor)GridTerminalSystem.GetBlockWithName("Door1");
            IMyDoor door2 = (IMyDoor)GridTerminalSystem.GetBlockWithName("Door2");
            IMyDoor door3 = (IMyDoor)GridTerminalSystem.GetBlockWithName("Door3");
            IMyDoor door4 = (IMyDoor)GridTerminalSystem.GetBlockWithName("Door4");
            IMyDoor door5 = (IMyDoor)GridTerminalSystem.GetBlockWithName("Door5");
            IMyDoor door6 = (IMyDoor)GridTerminalSystem.GetBlockWithName("Door6");
            IMyDoor door7 = (IMyDoor)GridTerminalSystem.GetBlockWithName("Door7");
            IMyDoor door8 = (IMyDoor)GridTerminalSystem.GetBlockWithName("Door8");
            IMyDoor door9 = (IMyDoor)GridTerminalSystem.GetBlockWithName("Door9");

            /****************
            * SENSOR VARIABLES
            * **************/

            IMySensorBlock sensor1 = (IMySensorBlock)GridTerminalSystem.GetBlockWithName("SensorBlack");
            IMySensorBlock sensor2 = (IMySensorBlock)GridTerminalSystem.GetBlockWithName("SensorBlue");
            IMySensorBlock sensor3 = (IMySensorBlock)GridTerminalSystem.GetBlockWithName("SensorCyan");
            IMySensorBlock sensor4 = (IMySensorBlock)GridTerminalSystem.GetBlockWithName("SensorGreen");
            IMySensorBlock sensor5 = (IMySensorBlock)GridTerminalSystem.GetBlockWithName("SensorLBlue");
            IMySensorBlock sensor6 = (IMySensorBlock)GridTerminalSystem.GetBlockWithName("SensorOrange");
            IMySensorBlock sensor7 = (IMySensorBlock)GridTerminalSystem.GetBlockWithName("SensorPink");
            IMySensorBlock sensor8 = (IMySensorBlock)GridTerminalSystem.GetBlockWithName("SensorWhite");
            IMySensorBlock sensor9 = (IMySensorBlock)GridTerminalSystem.GetBlockWithName("SensorYellow");
            IMySensorBlock resetSensor = (IMySensorBlock)GridTerminalSystem.GetBlockWithName("SensorReset");

            /****************
            * ROTOR VARIABLES
            * **************/
           
            IMyMotorStator blackRotor = (IMyMotorStator)GridTerminalSystem.GetBlockWithName("BlackRotor");
            IMyMotorStator blueRotor = (IMyMotorStator)GridTerminalSystem.GetBlockWithName("BlueRotor");
            IMyMotorStator cyanRotor = (IMyMotorStator)GridTerminalSystem.GetBlockWithName("CyanRotor");
            IMyMotorStator greenRotor = (IMyMotorStator)GridTerminalSystem.GetBlockWithName("GreenRotor");
            IMyMotorStator lightBlueRotor = (IMyMotorStator)GridTerminalSystem.GetBlockWithName("LightBlueRotor");
            IMyMotorStator orangeRotor = (IMyMotorStator)GridTerminalSystem.GetBlockWithName("OrangeRotor");
            IMyMotorStator pinkRotor = (IMyMotorStator)GridTerminalSystem.GetBlockWithName("PinkRotor");
            IMyMotorStator whiteRotor = (IMyMotorStator)GridTerminalSystem.GetBlockWithName("WhiteRotor");
            IMyMotorStator yellowRotor = (IMyMotorStator)GridTerminalSystem.GetBlockWithName("YellowRotor");

            /****************
            * SPOTLIGHT VARIABLES
            * **************/

            IMyReflectorLight spotlightBlack = (IMyReflectorLight)GridTerminalSystem.GetBlockWithName("SpotlightBlack");
            IMyReflectorLight spotlightBlue = (IMyReflectorLight)GridTerminalSystem.GetBlockWithName("SpotlightBlue");
            IMyReflectorLight spotlightCyan = (IMyReflectorLight)GridTerminalSystem.GetBlockWithName("SpotlightCyan");
            IMyReflectorLight spotlightGreen = (IMyReflectorLight)GridTerminalSystem.GetBlockWithName("SpotlightGreen");
            IMyReflectorLight spotlightLightBlue = (IMyReflectorLight)GridTerminalSystem.GetBlockWithName("SpotlightLightBlue");
            IMyReflectorLight spotlightOrange = (IMyReflectorLight)GridTerminalSystem.GetBlockWithName("SpotlightOrange");
            IMyReflectorLight spotlightPink = (IMyReflectorLight)GridTerminalSystem.GetBlockWithName("SpotlightPink");
            IMyReflectorLight spotlightWhite = (IMyReflectorLight)GridTerminalSystem.GetBlockWithName("SpotlightWhite");
            IMyReflectorLight spotlightYellow = (IMyReflectorLight)GridTerminalSystem.GetBlockWithName("SpotlightYellow");


            //SUCCESS
            //Black door        
            if(sensor1.IsActive == true &&
                door1.Open == false &&
                door2.Open == false &&
                door3.Open == false &&
                door4.Open == false &&
                door5.Open == false &&
                door6.Open == false &&
                door7.Open == false &&
                door8.Open == false &&
                door9.Open == false)
            {
                door1.GetActionWithName("Open_On").Apply(door1);
                sensor1.GetActionWithName("OnOff_Off").Apply(sensor1);
                blueRotor.GetActionWithName("ResetVelocity").Apply(blueRotor);
                spotlightBlue.GetActionWithName("IncreaseBlink Interval").Apply(spotlightBlue);
                resetSensor.GetActionWithName("OnOff_On").Apply(resetSensor);

                
                for (int i = 0; i < 6; i += 3)
                {
                    blackRotor.GetActionWithName("IncreaseVelocity").Apply(blackRotor);
                }
                spotlightBlack.GetActionWithName("DecreaseBlink Interval").Apply(spotlightBlack);
            }
           
            //Blue door
            else if (sensor2.IsActive == true &&
                    door1.Open == true &&
                    door2.Open == false &&
                    door3.Open == false &&
                    door4.Open == false &&
                    door5.Open == false &&
                    door6.Open == false &&
                    door7.Open == false &&
                    door8.Open == false &&
                    door9.Open == false)
            {
                door2.GetActionWithName("Open_On").Apply(door2);
                sensor2.GetActionWithName("OnOff_Off").Apply(sensor2);
                cyanRotor.GetActionWithName("ResetVelocity").Apply(cyanRotor);
                spotlightCyan.GetActionWithName("IncreaseBlink Interval").Apply(spotlightCyan);

                for (int i = 0; i < 6; i += 3)
                {
                    blueRotor.GetActionWithName("IncreaseVelocity").Apply(blueRotor);
                }
                spotlightBlue.GetActionWithName("DecreaseBlink Interval").Apply(spotlightBlue);
            }
            
            //Cyan door
            else if (sensor3.IsActive == true &&
                    door1.Open == true &&
                    door2.Open == true &&
                    door3.Open == false &&
                    door4.Open == false &&
                    door5.Open == false &&
                    door6.Open == false &&
                    door7.Open == false &&
                    door8.Open == false &&
                    door9.Open == false)
            {
                door3.GetActionWithName("Open_On").Apply(door3);
                sensor3.GetActionWithName("OnOff_Off").Apply(sensor3);
                greenRotor.GetActionWithName("ResetVelocity").Apply(greenRotor);
                spotlightGreen.GetActionWithName("IncreaseBlink Interval").Apply(spotlightGreen);

                for (int i = 0; i < 6; i += 3)
                {
                    cyanRotor.GetActionWithName("IncreaseVelocity").Apply(cyanRotor);
                }
                spotlightCyan.GetActionWithName("DecreaseBlink Interval").Apply(spotlightCyan);
            }
           
            //Green door
            else if (sensor4.IsActive == true &&
                    door1.Open == true &&
                    door2.Open == true &&
                    door3.Open == true &&
                    door4.Open == false &&
                    door5.Open == false &&
                    door6.Open == false &&
                    door7.Open == false &&
                    door8.Open == false &&
                    door9.Open == false)
            {
                door4.GetActionWithName("Open_On").Apply(door4);
                sensor4.GetActionWithName("OnOff_Off").Apply(sensor4);
                lightBlueRotor.GetActionWithName("ResetVelocity").Apply(lightBlueRotor);
                spotlightLightBlue.GetActionWithName("IncreaseBlink Interval").Apply(spotlightLightBlue);

                for (int i = 0; i < 6; i += 3)
                {
                    greenRotor.GetActionWithName("IncreaseVelocity").Apply(greenRotor);
                }
                spotlightGreen.GetActionWithName("DecreaseBlink Interval").Apply(spotlightGreen);
            }
          
            //Light blue door
            else if (sensor5.IsActive == true &&
                    door1.Open == true &&
                    door2.Open == true &&
                    door3.Open == true &&
                    door4.Open == true &&
                    door5.Open == false &&
                    door6.Open == false &&
                    door7.Open == false &&
                    door8.Open == false &&
                    door9.Open == false)
            {
                door5.GetActionWithName("Open_On").Apply(door5);
                sensor5.GetActionWithName("OnOff_Off").Apply(sensor5);
                orangeRotor.GetActionWithName("ResetVelocity").Apply(orangeRotor);
                spotlightOrange.GetActionWithName("IncreaseBlink Interval").Apply(spotlightOrange);

                for (int i = 0; i < 6; i += 3)
                {
                    lightBlueRotor.GetActionWithName("IncreaseVelocity").Apply(lightBlueRotor);
                }
                spotlightLightBlue.GetActionWithName("DecreaseBlink Interval").Apply(spotlightLightBlue);
            }
            
            //Orange door
            else if (sensor6.IsActive == true &&
                    door1.Open == true &&
                    door2.Open == true &&
                    door3.Open == true &&
                    door4.Open == true &&
                    door5.Open == true &&
                    door6.Open == false &&
                    door7.Open == false &&
                    door8.Open == false &&
                    door9.Open == false)
            {
                door6.GetActionWithName("Open_On").Apply(door6);
                sensor6.GetActionWithName("OnOff_Off").Apply(sensor6);
                pinkRotor.GetActionWithName("ResetVelocity").Apply(pinkRotor);
                spotlightPink.GetActionWithName("IncreaseBlink Interval").Apply(spotlightPink);

                for (int i = 0; i < 6; i += 3)
                {
                    orangeRotor.GetActionWithName("IncreaseVelocity").Apply(orangeRotor);
                }
                spotlightOrange.GetActionWithName("DecreaseBlink Interval").Apply(spotlightOrange);
            }
    
            //Pink rotor
            else if (sensor7.IsActive == true &&
                    door1.Open == true &&
                    door2.Open == true &&
                    door3.Open == true &&
                    door4.Open == true &&
                    door5.Open == true &&
                    door6.Open == true &&
                    door7.Open == false &&
                    door8.Open == false &&
                    door9.Open == false)
            {
                door7.GetActionWithName("Open_On").Apply(door7);
                sensor7.GetActionWithName("OnOff_Off").Apply(sensor7);
                whiteRotor.GetActionWithName("ResetVelocity").Apply(whiteRotor);
                spotlightWhite.GetActionWithName("IncreaseBlink Interval").Apply(spotlightWhite);

                for (int i = 0; i < 6; i += 3)
                {
                    pinkRotor.GetActionWithName("IncreaseVelocity").Apply(pinkRotor);
                }
                spotlightPink.GetActionWithName("DecreaseBlink Interval").Apply(spotlightPink);
            }
       
            //White rotor
            else if (sensor8.IsActive == true &&
                    door1.Open == true &&
                    door2.Open == true &&
                    door3.Open == true &&
                    door4.Open == true &&
                    door5.Open == true &&
                    door6.Open == true &&
                    door7.Open == true &&
                    door8.Open == false &&
                    door9.Open == false)
            {
                door8.GetActionWithName("Open_On").Apply(door8);
                sensor8.GetActionWithName("OnOff_Off").Apply(sensor8);
                yellowRotor.GetActionWithName("ResetVelocity").Apply(yellowRotor);
                spotlightYellow.GetActionWithName("IncreaseBlink Interval").Apply(spotlightYellow);

                for (int i = 0; i < 6; i += 3)
                {
                    whiteRotor.GetActionWithName("IncreaseVelocity").Apply(whiteRotor);
                }
                spotlightWhite.GetActionWithName("DecreaseBlink Interval").Apply(spotlightWhite);
            }
            
            //Yellow door
            else if (sensor9.IsActive == true &&
                    door1.Open == true &&
                    door2.Open == true &&
                    door3.Open == true &&
                    door4.Open == true &&
                    door5.Open == true &&
                    door6.Open == true &&
                    door7.Open == true &&
                    door8.Open == true &&
                    door9.Open == false)
            {
                door9.GetActionWithName("Open_On").Apply(door9);
                sensor9.GetActionWithName("OnOff_Off").Apply(sensor9);

                for (int i = 0; i < 6; i += 3)
                {
                    yellowRotor.GetActionWithName("IncreaseVelocity").Apply(yellowRotor);
                }
                spotlightYellow.GetActionWithName("DecreaseBlink Interval").Apply(spotlightYellow);
            }
            
            //FAILURE
            else
            {
                //Reset doors
                door1.GetActionWithName("Open_Off").Apply(door1);
                door2.GetActionWithName("Open_Off").Apply(door2);
                door3.GetActionWithName("Open_Off").Apply(door3);
                door4.GetActionWithName("Open_Off").Apply(door4);
                door5.GetActionWithName("Open_Off").Apply(door5);
                door6.GetActionWithName("Open_Off").Apply(door6);
                door7.GetActionWithName("Open_Off").Apply(door7);
                door8.GetActionWithName("Open_Off").Apply(door8);
                door9.GetActionWithName("Open_Off").Apply(door9);
                
                //Reset sensors
                sensor1.GetActionWithName("OnOff_On").Apply(sensor1);
                sensor2.GetActionWithName("OnOff_On").Apply(sensor2);
                sensor3.GetActionWithName("OnOff_On").Apply(sensor3);
                sensor4.GetActionWithName("OnOff_On").Apply(sensor4);
                sensor5.GetActionWithName("OnOff_On").Apply(sensor5);
                sensor6.GetActionWithName("OnOff_On").Apply(sensor6);
                sensor7.GetActionWithName("OnOff_On").Apply(sensor7);
                sensor8.GetActionWithName("OnOff_On").Apply(sensor8);
                sensor9.GetActionWithName("OnOff_On").Apply(sensor9);

                //Reset rotors
                blackRotor.GetActionWithName("ResetVelocity").Apply(blackRotor);
                blueRotor.GetActionWithName("ResetVelocity").Apply(blueRotor);
                cyanRotor.GetActionWithName("ResetVelocity").Apply(cyanRotor);
                greenRotor.GetActionWithName("ResetVelocity").Apply(greenRotor);
                lightBlueRotor.GetActionWithName("ResetVelocity").Apply(lightBlueRotor);
                orangeRotor.GetActionWithName("ResetVelocity").Apply(orangeRotor);
                pinkRotor.GetActionWithName("ResetVelocity").Apply(pinkRotor);
                whiteRotor.GetActionWithName("ResetVelocity").Apply(whiteRotor);
                yellowRotor.GetActionWithName("ResetVelocity").Apply(yellowRotor);

                for(int i = 0; i < 6; i +=3)
                {
                    blueRotor.GetActionWithName("IncreaseVelocity").Apply(blueRotor);
                    cyanRotor.GetActionWithName("IncreaseVelocity").Apply(cyanRotor);
                    greenRotor.GetActionWithName("IncreaseVelocity").Apply(greenRotor);
                    lightBlueRotor.GetActionWithName("IncreaseVelocity").Apply(lightBlueRotor);
                    orangeRotor.GetActionWithName("IncreaseVelocity").Apply(orangeRotor);
                    pinkRotor.GetActionWithName("IncreaseVelocity").Apply(pinkRotor);
                    whiteRotor.GetActionWithName("IncreaseVelocity").Apply(whiteRotor);
                    yellowRotor.GetActionWithName("IncreaseVelocity").Apply(yellowRotor);
                }

                    //Reset spotlights                   
                    spotlightBlue.GetActionWithName("DecreaseBlink Interval").Apply(spotlightBlue);
                    spotlightCyan.GetActionWithName("DecreaseBlink Interval").Apply(spotlightCyan);
                    spotlightGreen.GetActionWithName("DecreaseBlink Interval").Apply(spotlightGreen);
                    spotlightLightBlue.GetActionWithName("DecreaseBlink Interval").Apply(spotlightLightBlue);
                    spotlightOrange.GetActionWithName("DecreaseBlink Interval").Apply(spotlightOrange);
                    spotlightPink.GetActionWithName("DecreaseBlink Interval").Apply(spotlightPink);
                    spotlightWhite.GetActionWithName("DecreaseBlink Interval").Apply(spotlightWhite);
                    spotlightYellow.GetActionWithName("DecreaseBlink Interval").Apply(spotlightYellow);

                    if (spotlightBlack.BlinkIntervalSeconds < 1.5) { spotlightBlack.GetActionWithName("IncreaseBlink Interval").Apply(spotlightBlack); }
                
            }
        }

    }
}