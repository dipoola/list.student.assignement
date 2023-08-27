namespace list.student.assignement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>
                {
                   new Student
                   {
                       Name = "Alice",
                       Age = 18,
                       Grade = 85.5,

                   },


                    new Student
                   {
                       Name = "bob",
                       Age = 20,
                       Grade =70.0,

                   },


                     new Student
                   {
                       Name = "charlie",
                       Age = 19,
                       Grade = 25.5,

                   },


                         new Student
                   {
                       Name = "Dave",
                       Age = 21,
                       Grade = 81.2,

                   },



                         new Student
                   {
                       Name = "Eve",
                       Age = 19,
                       Grade = 87.8,

                   },

               };

            gradesHigherthan();
                  //Descending();



            void Descending()
            {
                var orderDecs = from holdsDesc in student
                                orderby holdsDesc.Age descending
                                select holdsDesc;
                foreach (var item in orderDecs)
                {
                    Console.WriteLine($"These are the student sortd out based on their age  {item.Age}");
                }

            }



            void Ascending()
            {
                var bolaji = student
                        .OrderBy(x => x.Grade);


             Console.WriteLine($"These are the students sorted out ascendingly base on their grades {bolaji}");

            }



            void gradesHigherthan()
            {
                var higher = from hub in student
                             where hub.Grade >= 80
                             select hub;
                foreach (var now in higher)
                {
                    Console.WriteLine($"These are the students whose grades are higher than 80 {now.Grade}" 
                        + $" and these are the names{now.Name} ");
                }

            }

              
        }






    }

}