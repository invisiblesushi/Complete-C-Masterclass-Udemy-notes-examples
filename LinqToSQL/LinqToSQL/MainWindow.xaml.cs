using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace LinqToSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSQL.Properties.Settings.DBConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            InsertUniversities();
            InsertStudents();
            InsertLectures();
            InsertStudentLectureAssociations();
            GetUniversityOfTonie();
            GetLecturesFromTonie();
            GetAllStudentsFromYale();
            GetAllUniversitiesWithTransgenders();
            GetAllLecturesFromBeijingTech();
            UpdateTonie();
            DeleteJames();
        }

        // Create objects of db table from *DataClasses.dbml
        // Drag table into *DataClasses.dbml to create classes for table
        public void InsertUniversities()
        {
            //Delete all entries
            dataContext.ExecuteCommand("Delete from University");

            //Add entries
            //Id does not get reset
            University yale = new University();
            yale.Name = "Yale";
            dataContext.Universities.InsertOnSubmit(yale);

            University beijingTech = new University();
            beijingTech.Name = "BeijingTech";
            dataContext.Universities.InsertOnSubmit(beijingTech);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudents()
        {
            // Lambda expression
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));
            University beijingTech = dataContext.Universities.First(un => un.Name.Equals("BeijingTech"));


            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "Carla", Gender = "female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Tonie", Gender = "male", University = beijingTech });
            students.Add(new Student { Name = "Leyle", Gender = "female", University = beijingTech });
            students.Add(new Student { Name = "James", Gender = "trans-gender", University = beijingTech });

            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;

        }

        public void InsertLectures()
        {

            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });

            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Lectures;
        }

        public void InsertStudentLectureAssociations()
        {
            Student Carla = dataContext.Students.First(st => st.Name.Equals("Carla"));
            Student Tonie = dataContext.Students.First(st => st.Name.Equals("Tonie"));
            Student Leyle = dataContext.Students.First(st => st.Name.Equals("Leyle"));
            Student James = dataContext.Students.First(st => st.Name.Equals("James"));

            Lecture Math = dataContext.Lectures.First(lc => lc.Name.Equals("Math"));
            Lecture History = dataContext.Lectures.First(lc => lc.Name.Equals("History"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Tonie, Lecture = Math });

            //Different way to do the same
            StudentLecture slToni = new StudentLecture();
            slToni.Student = Tonie;
            slToni.LectureId = History.Id;
            dataContext.StudentLectures.InsertOnSubmit(slToni);

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Leyle, Lecture = History });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;

        }

        public void GetUniversityOfTonie()
        {
            Student Toni = dataContext.Students.First(st => st.Name.Equals("Tonie"));

            University TonisUniversity = Toni.University;

            //Create a List with TonisUniversity
            List<University> universities = new List<University>();
            universities.Add(TonisUniversity);

            //ItemSource only accepts IEnumerable
            MainDataGrid.ItemsSource = universities;
        }

        public void GetLecturesFromTonie()
        {
            Student Toni = dataContext.Students.First(st => st.Name.Equals("Tonie"));

            var tonisLectures = from sl in Toni.StudentLectures select sl.Lecture;

            MainDataGrid.ItemsSource = tonisLectures;
        }

        public void GetAllStudentsFromYale()
        {
            var studentsFromYale = from student in dataContext.Students
                                   where student.University.Name == "Yale"
                                   select student;

            MainDataGrid.ItemsSource = studentsFromYale;
        }

        public void GetAllUniversitiesWithTransgenders()
        {
            var transgenderUniversites = from student in dataContext.Students
                                         join university in dataContext.Universities
                                         on student.University equals university
                                         where student.Gender == "trans-gender"
                                         select university;

            MainDataGrid.ItemsSource = transgenderUniversites;
        }

        public void GetAllLecturesFromBeijingTech()
        {
            var lecturesFromBeijingTech = from sl in dataContext.StudentLectures
                                          join student in dataContext.Students on sl.StudentId equals student.Id
                                          where student.University.Name == "BeijingTech"
                                          select sl.Lecture;

            MainDataGrid.ItemsSource = lecturesFromBeijingTech;
        }

        public void UpdateTonie()
        {
            Student Tonie = dataContext.Students.FirstOrDefault(st => st.Name == "Tonie");
            Tonie.Name = "Antonio";
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void DeleteJames()
        {
            Student James = dataContext.Students.FirstOrDefault(st => st.Name == "James");
            dataContext.Students.DeleteOnSubmit(James);
            dataContext.SubmitChanges();

            //Workaround for deleting not working
            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSQL.Properties.Settings.DBConnectionString"].ConnectionString;
            LinqToSqlDataClassesDataContext db = new LinqToSqlDataClassesDataContext(connectionString);

            MainDataGrid.ItemsSource = db.Students;
        }
    }
}
