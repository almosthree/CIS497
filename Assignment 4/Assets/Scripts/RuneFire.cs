/* * (Jerod Lockhart) 
 * * (RuneFire) 
 * * (Assignment4) 
 * * (This builds the fire rune) 
 */
namespace DecoratorPattern
{
    internal class RuneFire : RuneDecorator
    {
        private Sword sword;

        public RuneFire(Sword sword)
        {
            this.sword = sword;
        }

        public override string GetDescription()
        {
            return sword.GetDescription() +  ", now imbued with the power of fire";
        }

        public override int GetDamage()
        {
            return sword.GetDamage() + 6;
        }
    }
}