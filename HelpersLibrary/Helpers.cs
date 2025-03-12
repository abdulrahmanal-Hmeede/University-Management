
using CoreLibrary;
using System.Drawing;

namespace HelpersLibrary
{
    public delegate bool CheckCol(College college);
    public delegate bool CheckUniv(University university);
    public static class Helpers
    {
        public static int getCountStudentOfCollegs(this List<College> colls, CheckCol c)
        {
            int count = 0; 
            foreach (var item in colls)
            {
                if (c(item))
                {
                    count += item.NumberOfStudent;
                }
                
            }
            return count;
        }

        //public static int getCountStudentOfUniversities(this List<University> universities , CheckUniv c) {
            
        //}
    }
}
