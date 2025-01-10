namespace OOPsReview
{
    /// <summary>
    /// This is a class that manages the employment
    /// of our companies employees.
    /// </summary>
    public class Employment
    {
        #region Attributes

        //Employment job title.
        private String _Title;

        //Years in this Employment role.
        private double _Years;

        #endregion

        #region Properties

        public String Title
        {
            //Simple get
            get { return _Title; }
            
            //
            set {
                //This will cover cases of strings with whitespace ex."   "
                //Better than .IsNullorEmpty()
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Title is Required.");
                }

                _Title = value; }
        }

        public double Years
        {
            get { return _Years; }
            set 
            { if (value < 0)
                {
                    throw new ArgumentException($"Year value {value} is invalid. Must be non-negative.");
                }

                _Years = value;
            }
        }
        #endregion

        #region Constructors
        #endregion

        #region Methods
        #endregion
    }
}
