using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospRec.Pages
{
    public class editPatientModel : PageModel
    {
        public int _id;
        public void OnGet(int patientID)
        {
            _id = patientID;
        }
    }
}
