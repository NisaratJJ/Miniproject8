namespace Miniproject.Pages
{
    public partial class SearchPage : ContentPage
    {
        private List<CourseDetails> allCourses;

        public SearchPage()
        {
            InitializeComponent();
            LoadAllCourses();
        }

        private void LoadAllCourses()
        {
            allCourses = new List<CourseDetails>
            {
                new CourseDetails { CourseCode = "CS101", CourseName = "Introduction to Programming", Description = "Basic programming concepts using Python" },
                new CourseDetails { CourseCode = "CS102", CourseName = "Data Structures", Description = "Fundamental data structures and algorithms" },
                new CourseDetails { CourseCode = "CS201", CourseName = "Web Development", Description = "Basic web development with HTML, CSS, and JavaScript" },
                new CourseDetails { CourseCode = "CS202", CourseName = "Database Management", Description = "Introduction to SQL and database design" },
                new CourseDetails { CourseCode = "CS203", CourseName = "Operating Systems", Description = "Fundamentals of operating system design" },
                new CourseDetails { CourseCode = "CS301", CourseName = "Software Engineering", Description = "Software development life cycle and methodologies" },
                new CourseDetails { CourseCode = "CS302", CourseName = "Computer Networks", Description = "Network protocols and architecture" },
                new CourseDetails { CourseCode = "CS303", CourseName = "Artificial Intelligence", Description = "Basic AI concepts and algorithms" },
                new CourseDetails { CourseCode = "CS304", CourseName = "Mobile Development", Description = "Mobile app development for iOS and Android" },
                new CourseDetails { CourseCode = "CS305", CourseName = "Cloud Computing", Description = "Cloud services and deployment" },
                new CourseDetails { CourseCode = "CS401", CourseName = "Cybersecurity", Description = "Security principles and practices" },
                new CourseDetails { CourseCode = "CS402", CourseName = "Machine Learning", Description = "ML algorithms and applications" },
                new CourseDetails { CourseCode = "CS403", CourseName = "Big Data Analytics", Description = "Data processing and analysis" },
                new CourseDetails { CourseCode = "CS404", CourseName = "Computer Graphics", Description = "2D and 3D graphics programming" },
                new CourseDetails { CourseCode = "CS405", CourseName = "Game Development", Description = "Game design and implementation" },
                new CourseDetails { CourseCode = "CS406", CourseName = "IoT Systems", Description = "Internet of Things fundamentals" },
                new CourseDetails { CourseCode = "CS407", CourseName = "Blockchain Technology", Description = "Cryptocurrency and smart contracts" },
                new CourseDetails { CourseCode = "CS408", CourseName = "System Architecture", Description = "Computer system design principles" },
                new CourseDetails { CourseCode = "CS409", CourseName = "DevOps Practices", Description = "Continuous integration and deployment" },
                new CourseDetails { CourseCode = "CS410", CourseName = "Natural Language Processing", Description = "Text processing and analysis" },
                new CourseDetails { CourseCode = "CS411", CourseName = "Quantum Computing", Description = "Introduction to quantum algorithms" },
                new CourseDetails { CourseCode = "CS412", CourseName = "Computer Vision", Description = "Image processing and recognition" }
            };
            SearchResults.ItemsSource = allCourses;
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            var searchText = e.NewTextValue?.ToLower() ?? "";
            var filteredCourses = allCourses.Where(c => 
                c.CourseCode.ToLower().Contains(searchText) || 
                c.CourseName.ToLower().Contains(searchText)
            ).ToList();
            SearchResults.ItemsSource = filteredCourses;
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Success", "ลงทะเบียนสำเร็จ", "ตกลง");
        }
    }

    public class CourseDetails
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
    }
}
