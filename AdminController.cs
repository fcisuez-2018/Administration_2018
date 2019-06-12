using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using MySql.Data.MySqlClient;
using Admin.Models;
using AdminstratorModule.Models;


namespace AdminstratorModule.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        //Action To get The Contents of GPA Grade Table in Adminstrator DB
        public ActionResult GBA_Grade()
        {

            return View(GPA_GradeBL.GetAll());

        }

        //-----------------------------------------------------------------

        //Action To Redirect To Home Page --------------

        public ActionResult Home()
        {

            return View();
        }



        public ActionResult EditActivation_Student(int id, int StatusID)
        {
            StudentBL.EditActive(id, StatusID);
            return RedirectToAction("students");
        }



        //EDIT
        //Edit in Gpa Grade Table

        public ActionResult course_Grade()
        {

            return View(CourseGradeBL.GetAll());

        }
        public ActionResult level()
        {

            return View(LevelBL.GetAll());

        }


        //------------------------------------------------------------------------
        //students table 
        #region Display All Data
        [HttpGet]
        public ActionResult students(string search)
        {

            if (search != null)          
                return View(StudentBL.GetByStudentEductionalNumber(search));

            else
                return View(StudentBL.GetAll());
        }
        #endregion

        //---------------------------------------------------------------
        //Department Table

        public ActionResult Department()
        {

            return View(DepartmentBL.GetAll());

        }
        //----------------------------------------------------------------------
        // view of course Table
        [HttpGet]
        public ActionResult Course(string search)
        {
            ModelState.Remove("ID");
            if (search != null)
                return View(CourseBL.GetByCode(search));

            else
                return View(CourseBL.GetAll());
        }



        //---------------------------------------------------------------
        // edit level table
        [HttpGet]
        public ViewResult Edit(int id)
        {
            var ob = LevelBL.GetById(id);
            return View(ob);
        }


        [HttpPost]
        public ActionResult Edit(level ob)
        {
            if (ModelState.IsValid)
            {
                LevelBL.Update(ob);
                return RedirectToAction("level");
            }
            else
            {
                return View();
            }
        }

        //-------------------------------------
        //EDit In Department Table


        [HttpGet]
        public ViewResult Edit_Dep(int id)
        {
            var ob = DepartmentBL.GetById(id);
            return View(ob);
        }


        [HttpPost]
        public ActionResult Edit_Dep(Department ob)
        {
            ModelState.Remove("FacultyName_English");
            if (ModelState.IsValid)
            {
                DepartmentBL.Update(ob);
                return RedirectToAction("Department");
            }
            else
            {
                return View();
            }
        }
        ////---------------------------------------------
        //EDIT in Course Grade
        [HttpGet]
        public ViewResult Edit_CourseGrade(int id)
        {
            var ob = CourseGradeBL.GetById(id);
            return View(ob);
        }


        [HttpPost]
        public ActionResult Edit_CourseGrade(CourseGrade ob)
        {
            if (ModelState.IsValid)
            {
               
                CourseGradeBL.Update(ob);
             
                return RedirectToAction("course_Grade");
            }
            else
            {
                return View();
            }
        }

        //////////////////////////////////////////////
        //edit In Gpa Grade
        [HttpGet]
        public ViewResult Edit_GPA_Grade(int id)
        {
            var ob = GPA_GradeBL.GetById(id);
            ViewBag.Locations = GPA_GradeBL.GetSemesterID();
            return View(ob);
        }


        [HttpPost]
        public ActionResult Edit_GPA_Grade(GPA_Grade ob)
        {
            if (ModelState.IsValid)
            {
                GPA_GradeBL.Update(ob);
             
                return RedirectToAction("GBA_Grade");
            }
            else
            {
                return View();
            }
        }

        public ActionResult students_General()
        {

            return View(StudentBL.GetAll_General());

        }
        public ActionResult students_IT()
        {

            return View(StudentBL.GetAll_IT());

        }
        public ActionResult students_CS()
        {

            return View(StudentBL.GetAll_Cs());

        }

        public ActionResult EditActivation(int id, int StatusID)
        {
            StudentBL.EditActive(id, StatusID);
            return RedirectToAction("students_IT");
        }

        public ActionResult students_IS()
        {

            return View(StudentBL.GetAll_IS());

        }

        public ActionResult students_Software()
        {

            return View(StudentBL.GetAll_Software());

        }

        [HttpGet]
        public ViewResult Edit_Student(int id)
        {
            var ob = StudentBL.GetById(id);
            return View(ob);
        }


        [HttpPost]
        public ActionResult Edit_Student(Student ob)
        {



            if (ModelState.IsValid)
            {
                StudentBL.Update(ob);
                return RedirectToAction("students");
            }
            else
            {
                return View();
            }
        }


        //EDIT ACTIVATION IN STUDENT CS
        public ActionResult EditActivation_CS(int id, int StatusID)
        {
            StudentBL.EditActive(id, StatusID);
            return RedirectToAction("students_CS");
        }
        //general
        public ActionResult EditActivation_General(int id, int StatusID)
        {
            StudentBL.EditActive(id, StatusID);
            return RedirectToAction("students_General");
        }


        public ActionResult Semester()
        {
            ViewBag.Locations =semesterBL.GetSemesterFullNames();
            return View(semesterBL.GetAll());
      

        }

        public ActionResult EditStatus(int id, int StatusID)
        {
            semesterBL.EditActive(id, StatusID);
            return RedirectToAction("Semester");
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Create(semester sem)
        {
            ModelState.Remove("ID");
            if (ModelState.IsValid)
            {
                semesterBL.Add_Semester(sem);
                return RedirectToAction("Semester");
            }
            else
            {
                return View();
            }


        }
        public ActionResult Course_Semester()
        {

            ViewBag.Locations = CourseSemesterBL.GetSemesterFullNames();
            return View(CourseSemesterBL.GetAll());

        }


      public ActionResult dropDownList_Semesters()
        {
            List<SelectListItem> list = new List<SelectListItem>()
            {
            new SelectListItem {Text="Fall2016" , Value= "1" },
            new SelectListItem {Text="Spring2017" , Value= "2" },
            new SelectListItem {Text="Summer2017" , Value= "3" },
            new SelectListItem { Text="Fall2017" , Value= "4"},
             new SelectListItem { Text="Spring2018" , Value= "5"},
              new SelectListItem { Text="summer2018" , Value= "6"},
               new SelectListItem { Text="Fall2018" , Value= "7"},
                new SelectListItem { Text="Spring2019" , Value= "7"},


        };
            ViewBag.Locations = list;
               
            return View();
        }


        //edit in course semester

        [HttpGet]
        public ViewResult Edit_CourseSemester(int id)
        {
            var ob = CourseSemesterBL.GetById(id);
            return View(ob);
        }


        [HttpPost]
        public ActionResult Edit_CourseSemester(CourseSemester ob)
        {
            if (ModelState.IsValid)
            {
                CourseSemesterBL.Update(ob);
                return RedirectToAction("Course_Semester");
            }
            else
            {
                return View();
            }
        }


        [HttpGet]
        public ViewResult Edit_Course(int id)
        {
            var ob = CourseBL.GetByID(id);
            return View(ob);
        }


        [HttpPost]
        public ActionResult Edit_Course(Course ob)
        {
            //ModelState.Remove("CourseTypeID");
            //ModelState.Remove("Teaching_Hours_Lecture");
            //ModelState.Remove("Teching_Hours_Tutorial");
            //ModelState.Remove("TeachingHours_Practical");
            //ModelState.Remove("Midterm");
            //ModelState.Remove("Year_Work_Grades_O");
            //ModelState.Remove("Year_Work_Grades_PE");
            //ModelState.Remove("Year_Work_Grades_G");
            //ModelState.Remove("CurriculumID");

            if (ModelState.IsValid)
            {
                CourseBL.Update(ob);
                return RedirectToAction("Course");
            }
            else
            {
                return View();
            }
        }


        public ActionResult Doctors()
        {

            return View(DoctorsBL.GetAll());

        }


        public ActionResult EditActivation_doctor(int id, int StatusID)
        {
            DoctorsBL.EditActive(id, StatusID);
            return RedirectToAction("Doctors");
        }



        [HttpGet]
        public ViewResult Edit_Doctor(int id)
        {
            var ob = DoctorsBL.GetById(id);
            return View(ob);
        }


        [HttpPost]
        public ActionResult Edit_Doctor(Doctors ob)
        {
            if (ModelState.IsValid)
            {
                DoctorsBL.Update(ob);
                return RedirectToAction("Doctors");
            }
            else
            {
                return View();
            }
        }



        [HttpGet]
        public ViewResult AddNewConfig()
        { 
            return View();
        }



        [HttpPost]
        public ActionResult AddNewConfig(AdminConfig ob)
        {
            ModelState.Remove("ID");
            if (ModelState.IsValid)
            {
                AdminConfigBL.AddNewConfig(ob);
                return RedirectToAction("Configrations");
            }
            else
            {
                return View();
            }


        }


        public ActionResult Configrations()
        {

            return View(AdminConfigBL.GetAll());

        }

        // filtered Courses
        public ActionResult Cr_general()
        {

            return View(CourseBL.GetAll_General());

        }
        public ActionResult Cr_IT()
        {

            return View(CourseBL.GetAll_IT());

        }
        public ActionResult Cr_CS()
        {

            return View(CourseBL.GetAll_CS());

        }
        public ActionResult Cr_SE()
        {

            return View(CourseBL.GetAll_SE());

        }
        public ActionResult Cr_IS()
        {

            return View(CourseBL.GetAll_IS());

        }
        public ActionResult EditActivation_ALLCourses(int id, int StatusID)
        {
            CourseBL.EditActive(id, StatusID);
            return RedirectToAction("Course");
        }
        public ActionResult EditActivation_Cr_CS(int id, int StatusID)
        {
            CourseBL.EditActive(id, StatusID);
            return RedirectToAction("Cr_CS");
        }

        public ActionResult EditActivation_Cr_IS(int id, int StatusID)
        {
            CourseBL.EditActive(id, StatusID);
            return RedirectToAction("Cr_IS");
        }
        public ActionResult EditActivation_Cr_IT(int id, int StatusID)
        {
            CourseBL.EditActive(id, StatusID);
            return RedirectToAction("Cr_IT");
        }
        public ActionResult EditActivation_Cr_SE(int id, int StatusID)
        {
            CourseBL.EditActive(id, StatusID);
            return RedirectToAction("Cr_SE");
        }
        public ActionResult EditActivation_Cr_general(int id, int StatusID)
        {
            CourseBL.EditActive(id, StatusID);
            return RedirectToAction("Cr_general");
        }

        /////MIS WORK
        public ActionResult students_MIS_TEST()
        {

            return View(Students_MIS_BL.GetAll());

        }




        [HttpGet]
        public ViewResult Edit_Config(int id)
        {
            var ob = AdminConfigBL.GetById(id);
            return View(ob);
        }


        [HttpPost]
        public ActionResult Edit_Config(AdminConfig ob)
        {
                  ModelState.Remove("ID");
            if (ModelState.IsValid)
            {
                AdminConfigBL.Update(ob);
                return RedirectToAction("Configrations");
            }
            else
            {
                return View();
            }
        }
      
        [HttpGet]
        public ActionResult Admin()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Admin(Users user)
        {
            if (ModelState.IsValid)
            {
                int ID = UsersBL.CheckExistentUser(user);
                if (ID == 0)
                {
                    ModelState.AddModelError("UserID", "UserName or Password is Error");
                    return RedirectToAction("Admin_Login");
                }
                else if (ID == 1)
                {
                    return RedirectToAction("Doctors");
                }
                else if (ID == 2)
                {
                    return RedirectToAction("students");
                }


            }

            return View(user);
        }


        [HttpGet]
        public ActionResult Admin_Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Admin_Login(Users user)
        {
            if (ModelState.IsValid)
            {
                int ID = UsersBL.CheckExistentUser(user);
                if (ID == 0)
                {
                    ModelState.AddModelError("UserID", "UserName or Password is Error");
                    return RedirectToAction("Admin");
                }
                else if (ID == 1)
                {
                    return RedirectToAction("Doctors");
                }
                else if (ID == 2)
                {
                    return RedirectToAction("students");
                }


            }

            return View(user);
        }


        [HttpGet]
        public ViewResult Add_student()
        {
          //  var ob = StudentBL.GetById(id);
            return View();
        }


        [HttpPost]
        public ActionResult Add_student(Student ob)
        {
            ModelState.Remove("ID"); 
            if (ModelState.IsValid)
            {
                StudentBL.Add(ob);
                return RedirectToAction("students");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Semesters()
        {
            return View(semesterBL.GetAll());


        }

        public ActionResult allstudents()
        {
            return View(StudentBL.GetAll());
        }

        public ActionResult allstudents_CS()
        {
            return View(StudentBL.GetAll_Cs());
        }
        public ActionResult allstudents_IS()
        {
            return View(StudentBL.GetAll_IS());
        }
        public ActionResult allstudentsgeneral()
        {
            return View(StudentBL.GetAll_General());
        }
        public ActionResult allstudentsSoftware()
        {
            return View(StudentBL.GetAll_Software());
        }
        public ActionResult IT()
        {
            return View(StudentBL.GetAll_IT());
        }


        [HttpGet]
        public ViewResult Add_course()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Add_course(Course ob)
        {
            ModelState.Remove("ID");
            if (ModelState.IsValid)
            {
                CourseBL.Add(ob);
                return RedirectToAction("Course");
            }
            else
            {
                return View();
            }
        }

        #region Display All Data
        [HttpGet]
        public ActionResult courses(string search)
        {

            if (search != null)
                return View(CourseBL.GetByCode(search));

            else
                return View(CourseBL.GetAll());
        }
        #endregion



        [HttpGet]
        public ViewResult Create_Dep()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Create_Dep(Department sem)
        {
            ModelState.Remove("DepartmentID");
            if (ModelState.IsValid)
            {
                DepartmentBL.Add_Department(sem);
                return RedirectToAction("Department");
            }
            else
            {
                return View();
            }


        }
    }
}



