using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StardewValley;

namespace NermNermNerm.Junimatic
{
    internal class JunimoPortalQuest
        : BaseQuest
    {
        public JunimoPortalQuest(JunimoPortalQuestController controller) : base(controller) { }

        public override void CheckIfComplete(NPC n, Item? item)
        {
            // Maybe have somebody in town recognize it?  Seems improbable.
        }

        public override bool IsItemForThisQuest(Item item) => false; // item.ItemId == ObjectIds.OldJunimoPortal;    is not appropriate since you can't talk to anyone about it

        protected override void SetObjective()
        {
            this.currentObjective = "Bring the remnants of the strange little structure to the wizard";
        }
    }
}
