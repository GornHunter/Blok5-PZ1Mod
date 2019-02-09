using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    public class ImageModel { }

    public class Image : ValidationBase
    {
        private string uri;
        private string title;
        private string description;
        private DateTime time;

        public string Uri
        {
            get { return uri; }
            set
            {
                if (uri != value)
                {
                    uri = value;
                    OnPropertyChanged("Uri");
                }
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged("Description");
                }
            }
        }

        public DateTime Time
        {
            get { return time; }
            set
            {
                if (time != value)
                {
                    time = value;
                    OnPropertyChanged("Time");
                }
            }
        }

        protected override void ValidateSelf()
        {
            if (string.IsNullOrWhiteSpace(this.title))
            {
                this.ValidationErrors["Title"] = "Title is required.";
            }
            if (string.IsNullOrWhiteSpace(this.uri))
            {
                this.ValidationErrors["Uri"] = "Image URI is required.";
            }
        }
    }
}
