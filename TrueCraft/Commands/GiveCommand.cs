﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrueCraft.Core.Windows;
using TrueCraft.API;
using TrueCraft.API.Networking;

namespace TrueCraft.Commands
{
    public class GiveCommand : Command
    {
        public override string Name
        {
            get { return "give"; }
        }

        public override string Description
        {
            get { return "Give the specified player an amount of items."; }
        }

        public override string[] Aliases
        {
            get { return new string[1]{ "i" }; }
        }

        public override void Handle(IRemoteClient Client, string Alias, string[] Arguments)
        {
            if (Arguments.Length != 4)
            {
                Help(Client, Alias, Arguments);
                return;
            }
            // TODO: Send items to the client mentioned in the command, not the client issuing the command
            // TODO: Check to make sure an item with that ID actually exists
            short id;
            sbyte count;
            if (short.TryParse(Arguments[2], out id) && sbyte.TryParse(Arguments[3], out count))
            {
                var inventory = Client.Inventory as InventoryWindow;
                inventory.PickUpStack(new ItemStack(id, count));
            }
        }

        public override void Help(IRemoteClient Client, string Alias, string[] Arguments)
        {
            Client.SendMessage("Correct usage is /" + Alias + " <User> <Item ID> <Amount>");
        }
    }
}
