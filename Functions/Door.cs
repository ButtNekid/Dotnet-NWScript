using NWN.Enums;

namespace NWN
{
    public partial class NWScript
    {
        /// <summary>
        ///  * Returns TRUE if oObject (which is a placeable or a door) is currently open.
        /// </summary>
        public static bool GetIsOpen(uint oObject)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oObject);
            NWN.Internal.NativeFunctions.CallBuiltIn(443);
            return NWN.Internal.NativeFunctions.StackPopInteger() != 0;
        }

        /// <summary>
        ///  The action subject will unlock oTarget, which can be a door or a placeable
        ///  object.
        /// </summary>
        public static void ActionUnlockObject(uint oTarget)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oTarget);
            NWN.Internal.NativeFunctions.CallBuiltIn(483);
        }

        /// <summary>
        ///  The action subject will lock oTarget, which can be a door or a placeable
        ///  object.
        /// </summary>
        public static void ActionLockObject(uint oTarget)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oTarget);
            NWN.Internal.NativeFunctions.CallBuiltIn(484);
        }


        /// <summary>
        ///  Cause the action subject to open oDoor
        /// </summary>
        public static void ActionOpenDoor(uint oDoor)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oDoor);
            NWN.Internal.NativeFunctions.CallBuiltIn(43);
        }

        /// <summary>
        ///  Cause the action subject to close oDoor
        /// </summary>
        public static void ActionCloseDoor(uint oDoor)
        {
            NWN.Internal.NativeFunctions.StackPushObject(oDoor);
            NWN.Internal.NativeFunctions.CallBuiltIn(44);
        }

        /// <summary>
        ///  Get the last blocking door encountered by the caller of this function.
        ///  * Returns OBJECT_INVALID if the caller is not a valid creature.
        /// </summary>
        public static uint GetBlockingDoor()
        {
            NWN.Internal.NativeFunctions.CallBuiltIn(336);
            return NWN.Internal.NativeFunctions.StackPopObject();
        }

        /// <summary>
        ///  - oTargetDoor
        ///  - nDoorAction: DOOR_ACTION_*
        ///  * Returns TRUE if nDoorAction can be performed on oTargetDoor.
        /// </summary>
        public static int GetIsDoorActionPossible(uint oTargetDoor, DoorAction nDoorAction)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDoorAction);
            NWN.Internal.NativeFunctions.StackPushObject(oTargetDoor);
            NWN.Internal.NativeFunctions.CallBuiltIn(337);
            return NWN.Internal.NativeFunctions.StackPopInteger();
        }

        /// <summary>
        ///  Perform nDoorAction on oTargetDoor.
        /// </summary>
        public static void DoDoorAction(uint oTargetDoor, DoorAction nDoorAction)
        {
            NWN.Internal.NativeFunctions.StackPushInteger((int)nDoorAction);
            NWN.Internal.NativeFunctions.StackPushObject(oTargetDoor);
            NWN.Internal.NativeFunctions.CallBuiltIn(338);
        }
    }
}