using System;
using TrueCraft.API.Logic;

namespace TrueCraft.Core.Logic.Items
{
    public class FishingRodItem : ItemProvider
    {
        public static readonly short ItemID = 0x15A;

        public override short ID { get { return 0x15A; } }

        public override sbyte MaximumStack { get { return 1; } }

        public override string DisplayName { get { return "Fishing Rod"; } }
    }
}