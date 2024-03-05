using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal interface ITank
    {
        interface ITank
        {
            // lisää säiliöön parametrin ilmoittaman määrän nestettä
            string AddToTank(int amount);

            // ilmoittaa nesteen määrän säiliössä
            int GetAmount();

            // poistaa säiliöstä parametrin ilmoittaman määrän nestettä
            string RemoveFromTank(int amount);

            // tyhjentää säiliön
            void ClearTank();
        }
    }
}
