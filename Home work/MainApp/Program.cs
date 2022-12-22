using Domain.Models;
using Infrastructure.Services;
using Microsoft.VisualBasic.FileIO;



var sdt=new Student();
Console.WriteLine("Add student details ");
Console.Write("Enter Id : " );
int id=Convert.ToInt32(Console.ReadLine());
sdt.Id = id;
Console.Write("Enter FirstName : ");
string firstName=Convert.ToString(Console.ReadLine());
sdt.FirstName = firstName;
Console.Write("Enter LastName : ");
string lastName = Convert.ToString(Console.ReadLine());
sdt.LastName = lastName;
sdt.BirthDate = DateTime.Now;
Console.Write("Enter Address : ");
string address = Convert.ToString(Console.ReadLine());
sdt.Address = address;

Console.WriteLine("All data added successfully .");
Console.WriteLine();

var sdtService=new StudentService();
sdtService.AddStudent(sdt);


/*foreach (var studentData in sdtService.GetStudents())
{
    Console.WriteLine("Id : "+studentData.Id+"\n "+"Name : " +studentData.FirstName + " " + studentData.LastName + "\n" + "BirthDate : " + studentData.BirthDate + "\n "+"Address : " + studentData.Address);
}
Console.WriteLine();*/

// One






int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter FirstName : ");
sdt.FirstName = Convert.ToString(Console.ReadLine());
Console.Write("Enter LastName : ");
sdt.LastName = Convert.ToString(Console.ReadLine());
sdt.BirthDate = DateTime.Now;
Console.Write("Enter Address : ");
sdt.Address = Convert.ToString(Console.ReadLine());

Console.WriteLine("All data added successfully .");
Console.WriteLine();
var studenService = new StudentService();

studenService.UpdateStudent(sdt, n);

foreach (var studentData2 in studenService.GetStudents())
{
    Console.WriteLine("Id : " + studentData2.Id + "\n " + "Name : " + studentData2.FirstName + " " + studentData2.LastName + "\n" + "BirthDate : " + studentData2.BirthDate + "\n " + "Address : " + studentData2.Address);

}



/*
// Two
Console.Write("Want to update student data ? ");
string n = Convert.ToString(Console.ReadLine());
if (n == "Yes")
{
    Console.Write("What do you want to change ? ");
    string a = Convert.ToString(Console.ReadLine());

    // change Id

    if (a == "Id")
    {

        Console.Write("Enter new Id : ");
        sdt.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Id changed successfully .");

        var iddService = new StudentService();
        iddService.UpdateStudent(sdt);

        foreach (var studentnIdd in iddService.GetStudents())
        {
            Console.WriteLine("Id : " + studentnIdd.Id + "\n" + "Name : " + studentnIdd.FirstName + " " + studentnIdd.LastName + "\n" + "BirthDate : " + studentnIdd.BirthDate + "\n" + "Address : " + studentnIdd.Address);
        }
    }
    // change FirstName
    if (a == "Firstname")
    {

        Console.Write("Enter new FirstName : ");
        sdt.FirstName = Convert.ToString(Console.ReadLine());
        Console.WriteLine("FirstName changed successfully .");

        var iddService = new StudentService();
        iddService.UpdateStudent(sdt);

        foreach (var studentnIdd in iddService.GetStudents())
        {
            Console.WriteLine("Id : " + studentnIdd.Id + "\n" + "Name : " + studentnIdd.FirstName + " " + studentnIdd.LastName + "\n" + "BirthDate : " + studentnIdd.BirthDate + "\n" + "Address : " + studentnIdd.Address);
        }
    }

    // change LastName
    if (a == "Lastname")
    {

        Console.Write("Enter new LastName : ");
        sdt.LastName = Convert.ToString(Console.ReadLine());
        Console.WriteLine("LastName changed successfully .");

        var iddService = new StudentService();
        iddService.UpdateStudent(sdt);

        foreach (var studentnIdd in iddService.GetStudents())
        {
            Console.WriteLine("Id : " + studentnIdd.Id + "\n" + "Name : " + studentnIdd.FirstName + " " + studentnIdd.LastName + "\n" + "BirthDate : " + studentnIdd.BirthDate + "\n" + "Address : " + studentnIdd.Address);
        }
    }


    // change Address
    if (a == "Address")
    {

        Console.Write("Enter new LastName : ");
        sdt.Address = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Address changed successfully .");

        var iddService = new StudentService();
        iddService.UpdateStudent(sdt);

        foreach (var studentnIdd in iddService.GetStudents())
        {
            Console.WriteLine("Id : " + studentnIdd.Id + "\n" + "Name : " + studentnIdd.FirstName + " " + studentnIdd.LastName + "\n" + "BirthDate : " + studentnIdd.BirthDate + "\n" + "Address : " + studentnIdd.Address);
        }
    }

    // change all
    if (a == "Change all")
    {
        Console.Write("Enter new Id : ");
        sdt.Id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter new FirstName : ");
        sdt.FirstName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter new LastName : ");
        sdt.LastName = Convert.ToString(Console.ReadLine());
        sdt.BirthDate = DateTime.Now;
        Console.Write("Enter new Address : ");
        sdt.Address = Convert.ToString(Console.ReadLine());


        var iddService = new StudentService();
        iddService.UpdateStudent(sdt);

        foreach (var studentnIdd in iddService.GetStudents())
        {
            Console.WriteLine("Id : " + studentnIdd.Id + "\n" + "Name : " + studentnIdd.FirstName + " " + studentnIdd.LastName + "\n" + "BirthDate : " + studentnIdd.BirthDate + "\n" + "Address : " + studentnIdd.Address);
        }

        Console.WriteLine("Data changed sucessfully .");
    }
}
*/




