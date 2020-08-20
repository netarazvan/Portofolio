using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net.Mail;

namespace Portofolio.Pages
{
    public class IndexModel : PageModel
    {
        public string name;
        public string mail;
        public string message;
        private readonly ILogger<IndexModel> _logger;
        protected void SendMail()
        {
            
           // MailMessage mail = new MailMessage();
           // mail.To.Add()
        }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

        }
        
        public void OnGet()
        {
            
        }
    }
}
