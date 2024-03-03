using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht9_FileManager
{
    internal class Event
    {
        // Field
        private string startDate;
        private string endDate;
        private string title;
        private string location;
        private string description;

        // Properties
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
        public string Title { get => title; set => title = value; }
        public string Location { get => location; set => location = value; }
        public string Description { get => description; set => description = value; }

        // Constructor
        public Event()
        {
            StartDate = string.Empty;
            EndDate = string.Empty;
            Title = string.Empty;
            Location = string.Empty;
            Description = string.Empty;
        }

        // Overrides
        public override string? ToString()
        {
            return  "StartDate:\t" + this.StartDate +
                    "\nEndDate:\t" + this.EndDate +
                    "\nTitle:\t\t" + this.Title +
                    "\nLocation:\t" + this.Location +
                    "\nDescription:\t" + this.Description + "\n";
        }
    }
}
