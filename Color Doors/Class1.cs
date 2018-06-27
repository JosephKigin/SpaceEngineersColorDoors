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
            IMyDoor door1 = (IMyDoor)GridTerminalSystem.GetBlockWithName("Door1");
            IMyDoor door2 = (IMyDoor)GridTerminalSystem.GetBlockWithName("Door2");
            IMyDoor door3 = (IMyDoor)GridTerminalSystem.GetBlockWithName("Door3");
            IMyDoor door4 = (IMyDoor)GridTerminalSystem.GetBlockWithName("Door4");
            IMyDoor door5 = (IMyDoor)GridTerminalSystem.GetBlockWithName("Door5");
            IMySensorBlock sensor1 = (IMySensorBlock)GridTerminalSystem.GetBlockWithName("Sensor1");
            IMySensorBlock sensor2 = (IMySensorBlock)GridTerminalSystem.GetBlockWithName("Sensor1");
            IMySensorBlock sensor3 = (IMySensorBlock)GridTerminalSystem.GetBlockWithName("Sensor1");
            IMySensorBlock sensor4 = (IMySensorBlock)GridTerminalSystem.GetBlockWithName("Sensor1");
            IMySensorBlock sensor5= (IMySensorBlock)GridTerminalSystem.GetBlockWithName("Sensor1");

            if(sensor1.DetectPlayers == true &&
                door1.Open == false &&
                door2.Open == false &&
                door3.Open == false &&
                door4.Open == false &&
                door5.Open == false)
            {
                door1.GetActionWithName("Open_On").Apply(door1);
            }
            else if (sensor2.DetectPlayers == true &&
                    door1.Open == true &&
                    door2.Open == false &&
                    door3.Open == false &&
                    door4.Open == false &&
                    door5.Open == false)
            {
                door2.GetActionWithName("Open_On").Apply(door2);
            }
            else if (sensor3.DetectPlayers == true &&
                    door1.Open == true &&
                    door2.Open == true &&
                    door3.Open == false &&
                    door4.Open == false &&
                    door5.Open == false)
            {
                door3.GetActionWithName("Open_On").Apply(door3);
            }
            else if (sensor4.DetectPlayers == true &&
                    door1.Open == true &&
                    door2.Open == true &&
                    door3.Open == true &&
                    door4.Open == false &&
                    door5.Open == false )
            {
                door4.GetActionWithName("Open_On").Apply(door4);
            }
            else if (sensor5.DetectPlayers == true &&
                    door1.Open == true &&
                    door2.Open == true &&
                    door3.Open == true &&
                    door4.Open == true &&
                    door5.Open == false)
            {
                door5.GetActionWithName("Open_On").Apply(door5);
            }
            else
            {
                door1.GetActionWithName("Open_Off").Apply(door1);
                door2.GetActionWithName("Open_Off").Apply(door2);
                door3.GetActionWithName("Open_Off").Apply(door3);
                door4.GetActionWithName("Open_Off").Apply(door4);
                door5.GetActionWithName("Open_Off").Apply(door5);
            }
        }

    }
}


/********
*     GridTerminalSystem.SearchBlocksOfName("[Door1]", blocks);
            door1 = blocks[0] as IMyDoor;
            blocks.Clear();
            GridTerminalSystem.SearchBlocksOfName("[Door2]", blocks);
            door2 = blocks[0] as IMyDoor;
            blocks.Clear();
            GridTerminalSystem.SearchBlocksOfName("[Door3]", blocks);
            door3 = blocks[0] as IMyDoor;
            blocks.Clear();
            GridTerminalSystem.SearchBlocksOfName("[Door4]", blocks);
            door4 = blocks[0] as IMyDoor;
            blocks.Clear();
            GridTerminalSystem.SearchBlocksOfName("[Door5]", blocks);
            door5 = blocks[0] as IMyDoor;
            blocks.Clear();
            GridTerminalSystem.SearchBlocksOfName("[Sensor1]", blocks);
            sensor1 = blocks[0] as IMySensorBlock;
            blocks.Clear();
            GridTerminalSystem.SearchBlocksOfName("[Sensor2]", blocks);
            sensor2 = blocks[0] as IMySensorBlock;
            blocks.Clear();
            GridTerminalSystem.SearchBlocksOfName("[Sensor3]", blocks);
            sensor3 = blocks[0] as IMySensorBlock;
            blocks.Clear();
            GridTerminalSystem.SearchBlocksOfName("[Sensor4]", blocks);
            sensor4 = blocks[0] as IMySensorBlock;
            blocks.Clear();
            GridTerminalSystem.SearchBlocksOfName("[Sensor5]", blocks);
            sensor5 = blocks[0] as IMySensorBlock;
            blocks.Clear();      
*********/