/* * (Jerod Lockhart) 
 * * (RuneNature) 
 * * (Assignment4) 
 * * (This is the nature rune that ads to the sword) 
 */
namespace DecoratorPattern
{
    internal class RuneNature : RuneDecorator
    {
        private Sword sword;

        public RuneNature(Sword sword)
        {
            this.sword = sword;
        }

        public override string GetDescription()
        {
            return sword.GetDescription() + ", now imbued with the power of nature";
        }

        public override int GetDamage()
        {
            return sword.GetDamage() + 9;
        }
    }
}