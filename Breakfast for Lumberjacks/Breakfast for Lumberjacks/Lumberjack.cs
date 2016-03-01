using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakfast_for_Lumberjacks
{
    class Lumberjack                                  // Лесоруб
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;

        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }

        public int FlapjackCount { get { return meal.Count; } }

        public void TakeFlapjack(Flapjack Food, int HowMany)
        {
            for (int i = 0; i < HowMany; i++)
                meal.Push(Food);
        }

        public void EatFlapjack()
        {

        }
    }
}
