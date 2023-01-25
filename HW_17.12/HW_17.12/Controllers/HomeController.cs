using HW_17._12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HW_17._12.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISupportService _supportService;
        public HomeController(ISupportService supportService)
        {
            _supportService = supportService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var department1 = new Department()
            {
                DepartmentId = Guid.NewGuid(),
                Name = "Department of client",
                SupportSpecialists = new List<SupportSpecialist>
                {
                    new SupportSpecialist
                    {
                        SupportSpecialistId = Guid.NewGuid(),
                        Name = "Ilya",
                        SupportRequests = new List<SupportRequest>
                        {
                            new SupportRequest
                            {
                                SupportRequestId = Guid.NewGuid(),
                                Topic ="Permission",
                                Description ="What permission do i have?",
                                Status ="Wait"
                            }
                        }
                    },
                    new SupportSpecialist
                    {
                        SupportSpecialistId = Guid.NewGuid(),
                        Name = "Dima",
                        SupportRequests = new List<SupportRequest>
                        {
                            new SupportRequest
                            {
                                SupportRequestId = Guid.NewGuid(),
                                Topic ="Responsibilities",
                                Description ="What responsibilities do i have?",
                                Status ="Wait"
                            }
                        }
                    },
                    new SupportSpecialist
                    {
                        SupportSpecialistId = Guid.NewGuid(),
                        Name = "Dasha",
                        SupportRequests = new List<SupportRequest>
                        {
                            new SupportRequest
                            {
                                SupportRequestId = Guid.NewGuid(),
                                Topic ="Error",
                                Description ="An error occurred on the server",
                                Status ="Wait"
                            }
                        }
                    }
                }
            };
            var department2 = new Department()
            {
                DepartmentId = Guid.NewGuid(),
                Name = "Department of sales",
                SupportSpecialists = new List<SupportSpecialist>
                {
                    new SupportSpecialist
                    {
                        SupportSpecialistId = Guid.NewGuid(),
                        Name = "Nikita",
                        SupportRequests = new List<SupportRequest>
                        {
                            new SupportRequest
                            {
                                SupportRequestId = Guid.NewGuid(),
                                Topic ="Price",
                                Description ="Why is it so expensive?",
                                Status ="Wait"
                            }
                        }
                    },
                    new SupportSpecialist
                    {
                        SupportSpecialistId = Guid.NewGuid(),
                        Name = "Misha",
                        SupportRequests = new List<SupportRequest>
                        {
                            new SupportRequest
                            {
                                SupportRequestId = Guid.NewGuid(),
                                Topic ="sale",
                                Description ="Where are my sales?",
                                Status ="Wait"
                            }
                        }
                    },
                    new SupportSpecialist
                    {
                        SupportSpecialistId = Guid.NewGuid(),
                        Name = "Ksusha",
                        SupportRequests = new List<SupportRequest>
                        {
                            new SupportRequest
                            {
                                SupportRequestId = Guid.NewGuid(),
                                Topic ="Website",
                                Description ="Your website is broken",
                                Status ="Done"
                            }
                        }
                    }
                }
            };
            var department3 = new Department()
            {
                DepartmentId = Guid.NewGuid(),
                Name = "Department of social",
                SupportSpecialists = new List<SupportSpecialist>
                {
                    new SupportSpecialist
                    {
                        SupportSpecialistId = Guid.NewGuid(),
                        Name = "Andrey",
                        SupportRequests = new List<SupportRequest>
                        {
                            new SupportRequest
                            {
                                SupportRequestId = Guid.NewGuid(),
                                Topic ="Money",
                                Description ="I need financial help",
                                Status ="Done"
                            }
                        }
                    },
                    new SupportSpecialist
                    {
                        SupportSpecialistId = Guid.NewGuid(),
                        Name = "Nastya",
                        SupportRequests = new List<SupportRequest>
                        {
                            new SupportRequest
                            {
                                SupportRequestId = Guid.NewGuid(),
                                Topic ="Events",
                                Description ="We want more events",
                                Status ="Done"
                            }
                        }
                    },
                    new SupportSpecialist
                    {
                        SupportSpecialistId = Guid.NewGuid(),
                        Name = "Sasha",
                        SupportRequests = new List<SupportRequest>
                        {
                            new SupportRequest
                            {
                                SupportRequestId = Guid.NewGuid(),
                                Topic ="Work",
                                Description ="How to find a job",
                                Status ="Wait"
                            }
                        }
                    }
                }
            };

            await _supportService.Add(department1);
            await _supportService.Add(department2);
            await _supportService.Add(department3);

            return View();
        }
    }
}
