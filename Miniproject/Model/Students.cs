
// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using miniproject.Model;
//
//    var students = Students.FromJson(jsonString);

namespace Miniproject.Model
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Students
    {
        [JsonProperty("student_id")]
        public string StudentId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("img_url")]
        public string ImgUrl { get; set; }

        [JsonProperty("faculty")]
        public string Faculty { get; set; }

        [JsonProperty("major")]
        public string Major { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("gpa")]
        public double Gpa { get; set; }

        [JsonProperty("courses_enrolled")]
        public List<CoursesEnrolled> CoursesEnrolled { get; set; }

        public static implicit operator Students(ObservableCollection<Students> v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator ObservableCollection<object>(Students v)
        {
            throw new NotImplementedException();
        }
    }

    public partial class CoursesEnrolled
    {
        [JsonProperty("course_id")]
        public string CourseId { get; set; }

        [JsonProperty("course_name")]
        public string CourseName { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("term")]
        public long Term { get; set; }

        [JsonProperty("credits")]
        public long Credits { get; set; }

        [JsonProperty("grade")]
        public string Grade { get; set; }

        [JsonProperty("instructor")]
        public string Instructor { get; set; }
    }

    public partial class Students
    {
        public static List<Students> FromJson(string json) => JsonConvert.DeserializeObject<List<Students>>(json, Miniproject.Model.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<Students> self) => JsonConvert.SerializeObject(self, Miniproject.Model.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
