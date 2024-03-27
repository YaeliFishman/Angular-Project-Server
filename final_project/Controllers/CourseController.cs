using final_project;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace final_project.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CourseController : ControllerBase
  {



    public static List<Course> courses = new List<Course>
        {
            new Course{Id= 1, Name="שחייה", Img="http//fhg",Count=3,StartDate=new DateTime(2024,4,5),Syllabus=new List<string>{"gdhgshfiudgh","yj"},LearningWay=ELearningWay.zoom,categoryId=2,SpeecherId=123  },
            new Course{Id= 2, Name="אנגלית בחויה", Img="http//fhg",Count=3,StartDate=new DateTime(2024,4,5),Syllabus=new List<string>{"yk","yj"},LearningWay=ELearningWay.frontal,categoryId=1,SpeecherId=123  },
            new Course{Id= 3, Name="ציור", Img="https://encrypted-tbn0.gstatic.com/licensed-image?q=tbn:ANd9GcQ3xPSN3giNY8WUvy9UY-u3_9JX_yrQFA82Mo0MsUp9L1jqbIECKARz98G9jMtMPtGBMpiQ2u816sUxcXAuKg&s=19",Count=1,StartDate=new DateTime(2024,4,5),Syllabus=new List<string>{"yk","yj"},LearningWay=ELearningWay.zoom,categoryId=2,SpeecherId=123  },
            new Course{Id= 4, Name="דרמה", Img="http//fhg",Count=3,StartDate=new DateTime(2024,4,5),Syllabus=new List<string>{"yk","tehjuwyrir"},LearningWay=ELearningWay.zoom,categoryId=2,SpeecherId=123  },
            new Course{Id= 5, Name="אקריליק", Img="https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSywIAey61lqHo_HmhLiU59GdOEonqj4Vl8gF15z-OYmEgJFqDHQmT4So8hSzK1d6vqJ-JyJGRmmEAd0PU7SBi_mTb86AWj2x-8GjPrZgr-g2QeItSP7orVO0XyBx2ZJhwcuGv0xA4dtw&usqp=CAc",Count=3,StartDate=new DateTime(2024,4,5),Syllabus=new List<string>{"yk","yj"},LearningWay=ELearningWay.frontal,categoryId=1,SpeecherId=123  },
        };
//Img=https://www.pinterest.com/pin/672303050622495414/ - ציור
    
   


    // GET: api/<CourseController>
    [HttpGet]
    public IEnumerable<Course> Get()
    {
      return courses;
    }

    // GET api/<CourseController>/5
    [HttpGet("{id}")]
    public Course Get(int id)
    {
      var c= courses.Find(x=>id==x.Id);
      return c;
    }

    // POST api/<CourseController>
    [HttpPost]
    public void Post([FromBody] Course course)
    {
      courses.Add(course);
    }

    // PUT api/<CourseController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Course course)
    {
      var c=courses.Find(x=>id==x.Id);

      c.StartDate=course.StartDate;
      c.SpeecherId=course.SpeecherId;
      c.categoryId = course.categoryId;
      c.Name = course.Name;
      c.Count=course.Count;
      c.Img = course.Img;
      c.Syllabus = course.Syllabus;
      c.LearningWay = course.LearningWay;
    }

    // DELETE api/<CourseController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var f=courses.Find(x=>id==x.Id);
      courses.Remove(f);
    }
  }
}
