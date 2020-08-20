using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading;

namespace Portofolio.Pages
{
    public class ProjectsModel : PageModel
    {
        public string[,] projects = new string[10, 4];
        private readonly ILogger<ProjectsModel> _logger;

        public ProjectsModel(ILogger<ProjectsModel> logger)
        {
            _logger = logger;
            projects[0, 0] = "MngLeasers";
            projects[0, 1] = "https://github.com/netarazvan/MngLeasers";
            projects[0, 2] = "/res/mngLeasers.JPG";
            projects[0, 3] = "This is a Windows Forms application that helps my dad to keep records of leasers and their share. For the database i used MS SQL";

            projects[1, 0] = "StudentSaver";
            projects[1, 1] = "https://github.com/netarazvan/StudentSaver";
            projects[1, 2] = "/res/studentSaver.JPG";
            projects[1, 3] = "A lot of teachers have the the courses posted on their own blogs and password protected. I created this app to help the students from faculty to get their courses more easly";

            projects[2, 0] = "MusicCrono";
            projects[2, 1] = "https://github.com/netarazvan/Music_Crono";
            projects[2, 2] = "/res/MusicCrono.JPG";
            projects[2, 3] = "Me and my roommates were always fighting over music. So I created this little app that allows us to listen for a limited time. So we had to pay for music.";

            projects[3, 0] = "ShutdownER";
            projects[3, 1] = "https://github.com/netarazvan/ShutdownER";
            projects[3, 2] = "/res/ShutdownER.JPG";
            projects[3, 3] = "A friend wanted to end his shift earlyer so he asked me if I can build a app that will shut down his pc at certain time. Enjoy :) ";

        }
      

        public void OnGet()
        {
        }
    }
}
