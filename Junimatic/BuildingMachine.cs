using Microsoft.Xna.Framework;
using StardewValley.Buildings;
using static NermNermNerm.Stardew.LocalizeFromSource.SdvLocalizeMethods;

namespace NermNermNerm.Junimatic
{
    public abstract class BuildingMachine
        : GameMachine
    {
        protected BuildingMachine(Building building, Point accessPoint)
            : base(building, accessPoint)
        {
        }

        public static BuildingMachine? TryCreate(Building building, Point accessPoint)
        {
            if (building is FishPond fishPond)
            {
                return new FishPondMachine(fishPond, accessPoint);
            }
            else
            {
                return null;
            }
        }

        protected Building Building => (Building)base.GameObject;

        public override string ToString()
        {
            return IF($"{this.Building.buildingType} at {this.Building.tileX.Value},{this.Building.tileY.Value}");
        }
    }
}
