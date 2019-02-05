using System;

namespace RentVsOwn
{
    [AttributeUsage(AttributeTargets.Property)]

    public class ReportAttribute : Attribute

    {
        public ReportAlignment Alignment { get; set; }
        private string text;

        public ReportAttribute(string text)

        {

            this.Text = text;

        }

        public string Text

        {

            get

            {

                return this.text;

            }

            set

            {

                this.text = value;

            }

        }

    }
}
