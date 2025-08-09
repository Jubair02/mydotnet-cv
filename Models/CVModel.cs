using System.Collections.Generic;

namespace CVApp.Models
{
    public class CVModel
    {
        public PersonalInfo PersonalInfo { get; set; }
        public Education Education { get; set; }
        public List<Project> Projects { get; set; }
        public TechnicalSkills TechnicalSkills { get; set; }
        public SoftSkills SoftSkills { get; set; }
        public Languages Languages { get; set; }
        public AreasOfInterest AreasOfInterest { get; set; }
        public ExtraCurricularActivities ExtraCurricularActivities { get; set; }

        public CVModel()
        {
            PersonalInfo = new PersonalInfo
            {
                Name = "Jubair Hossain",
                Description = "Motivated Computer Science student with a strong foundation in programming, algorithms, and software development. Passionate about building efficient solutions, exploring emerging technologies, and contributing to impactful projects. Quick learner with hands-on experience in coding, problem-solving, and collaborative teamwork",
                Phone = "01754995743",
                Email = "jubu01754@gmail.com",
                LinkedIn = "Jubair",
                LinkedIn_Url = "#",
                Github = "Jubair",
                Github_Url = "#",
                Address = "6/7, Road-3, Block-G, Bashundhara R/A, Dhaka"
            };

            Education = new Education
            {
                Degrees = new List<Degree>
                {
                    new Degree
                    {
                        Title = "BSc in Computer Science and Engineering",
                        Institution = "North South University",
                        GPA = "CGPA 2.56",
                        Year = "Passing Year: 2025"
                    },
                    new Degree
                    {
                        Title = "Higher Secondary Certificate (HSC)",
                        Institution = "Bhola Govt. college",
                        GPA = "GPA: 4.83",
                        Year = "Passing Year: 2019"
                    },
                    new Degree
                    {
                        Title = "Secondary School Certificate (SSC)",
                        Institution = "Daulatkhan Govt. High School",
                        GPA = "GPA: 4.64",
                        Year = "Passing Year: 2017"
                    }
                }
            };

            Projects = new List<Project>
            {
                new Project
                {
                    Title = "Weather App",
                    Description = "Created a real-time weather forecasting app using JavaScript and external APIs, focusing on API integration, asynchronous data fetching, and user-friendly interface design."
                },
                new Project
                {
                    Title = "Quote Generator",
                    Description = "JavaScript application that fetches and displays random inspirational quotes, demonstrating API usage and asynchronous programming skills."
                },
                new Project
                {
                    Title = "Tic-Tac-Toe Game",
                    Description = "Classic two-player game built with HTML, CSS, and JavaScript, showcasing front-end development and user interaction design."
                },
                new Project
                {
                    Title = "Pong Game",
                    Description = "Recreation of the classic Pong game using JavaScript, focusing on game logic and real-time event handling."
                },
                new Project
                {
                    Title = "School Management System",
                    Description = "A web-based system developed to manage school operations, including student records and attendance, illustrating backend development and database integration."
                }
            };

            TechnicalSkills = new TechnicalSkills
            {
                ProgrammingLanguages = "Python, Java, C, C++, C#",
                WebTechnologies = "HTML, CSS, JavaScript, Bootstrap",
                Databases = "MySQL, SQLite",
                Frameworks = "Dot Net, React"
            };

            SoftSkills = new SoftSkills
            {
                Skills = new List<string>
                {
                    "Strong Problem-Solving Ability",
                    "Effective Communication Time",
                    "Management Team",
                    "Collaboration Adaptability",
                    "Critical Thinking Attention to Detail"
                }
            };

            Languages = new Languages
            {
                LanguageList = new List<string>
                {
                    "Bengali (Native)",
                    "English"
                }
            };

            AreasOfInterest = new AreasOfInterest
            {
                Interests = new List<string>
                {
                    "Web Development",
                    "Machine Learning",
                    "Data Analysis",
                    "Software Engineering"
                }
            };

            ExtraCurricularActivities = new ExtraCurricularActivities
            {
                Organizations = new List<Organization>
                {
                    new Organization
                    {
                        Name = "NSUSS",
                        Roles = new List<Role>
                        {
                            new Role
                            {
                                Title = "Senior Workforce",
                                Description = "Logistics And Operations NSUSS (North South University Shangskritik Shangathan | 2022-2023) Coordinated With Different Teams To Facilitate Event Setups, Material Distribution, And Other Operational Tasks."
                            }
                        }
                    },
                    new Organization
                    {
                        Name = "NSU ACM",
                        Roles = new List<Role>
                        {
                            new Role
                            {
                                Title = "Member, NSU Computer & Engineering Club (CEC)",
                                Description = "Participated in tech workshops, coding competitions, and project showcases."
                            },
                            new Role
                            {
                                Title = "Organizer",
                                Description = "Organized and assisted in university tech events and hackathons, fostering collaboration and innovation."
                            },
                            new Role
                            {
                                Title = "Volunteer",
                                Description = "Volunteered in STEM outreach programs to encourage technology learning among students."
                            },
                            new Role
                            {
                                Title = "Participant",
                                Description = "Participated in inter-university programming contests to enhance problem-solving skills."
                            }
                        }
                    }
                }
            };
        }
    }

    public class PersonalInfo
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string LinkedIn { get; set; } = string.Empty;
        public string LinkedIn_Url { get; set; } = string.Empty;
        public string Github { get; set; } = string.Empty;
        public string Github_Url { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }

    public class Education
    {
        public List<Degree> Degrees { get; set; } = new List<Degree>();
    }

    public class Degree
    {
        public string Title { get; set; } = string.Empty;
        public string Institution { get; set; } = string.Empty;
        public string GPA { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
    }

    public class Project
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class TechnicalSkills
    {
        public string ProgrammingLanguages { get; set; } = string.Empty;
        public string WebTechnologies { get; set; } = string.Empty;
        public string Databases { get; set; } = string.Empty;
        public string Frameworks { get; set; } = string.Empty;
    }

    public class SoftSkills
    {
        public List<string> Skills { get; set; } = new List<string>();
    }

    public class Languages
    {
        public List<string> LanguageList { get; set; } = new List<string>();
    }

    public class AreasOfInterest
    {
        public List<string> Interests { get; set; } = new List<string>();
    }

    public class ExtraCurricularActivities
    {
        public List<Organization> Organizations { get; set; } = new List<Organization>();
    }

    public class Organization
    {
        public string Name { get; set; } = string.Empty;
        public List<Role> Roles { get; set; } = new List<Role>();
    }

    public class Role
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}