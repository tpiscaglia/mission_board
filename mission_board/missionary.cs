using System.Collections.Generic;
using System.IO;

namespace mission_board
{
    public class Missionary
    {
        public Missionary()
        {
            DisplayName = MissionField = FirstName = LastName = LetterAlias = ProfilePicture = Email = string.Empty;
            Latitude = Longitude = 0d;
            Letters = new List<FileInfo>();
        }

        public List<FileInfo> Letters { get; set; }

        public string DisplayName { get; set; }

        public string MissionField { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string LetterAlias { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string ProfilePicture { get; set; }

        public string Email { get; set; }
    }
}
