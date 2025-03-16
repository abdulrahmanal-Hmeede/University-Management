
using CoreLibrary;
using System.Drawing;

namespace HelpersLibrary
{
    public delegate bool CheckCol(College college);
    public static class Helpers
    {

        public static int getCountStudentOfUniversities(this List<University> universities, CheckCol c)
        {
            int count = 0;
            List<College> collegs = new List<College>();
            foreach (var univ in universities)
            {
                foreach (var col in univ.colleges)
                {
                    collegs.Add(col);
                }
            }

            foreach (var item in collegs)
            {
                if (c(item))
                {
                    count += item.NumberOfStudent;
                }
                else
                {
                    throw new Exception("Invalid Check Col");
                }
            }
            return count;
        }

        public static int getCountStudentOfCollegs(this University university, CheckCol c)
        {
            int count = 0;
            foreach (var item in university.colleges)
            {
                if (c(item))
                {
                    count += item.NumberOfStudent;
                }
                else
                {
                    throw new Exception("Invalid Check Col");
                }
            }
            return count;

        }
    }
}