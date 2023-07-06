using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class ArrayDeletion
    {
        public static List<int> DeleteAtIndex(List<int> list, int index)
        {
            List<int> copyList = new List<int>(list);
            for (int i = (index+1); i<copyList.Count; i++)
            {
                // shift the elements one position to the lift and overwriting the element we wanted to delete
                copyList[i - 1] = copyList[i];
            }
            return copyList;
        }
    }
}
