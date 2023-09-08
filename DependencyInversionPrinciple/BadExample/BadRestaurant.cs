using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.BadExample
{
    public class BadRestaurant
    {
        BadFish badFish = new BadFish();
        BadPoultry badPoultry = new BadPoultry();
        public string GetCookingInstructor() => $"{badFish.GetFishInstruction()} - {badPoultry.GetPoultryInstruction()}";
    }
}
