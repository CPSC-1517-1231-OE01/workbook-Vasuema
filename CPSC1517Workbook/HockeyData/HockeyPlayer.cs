using Utils;

namespace Hockey.Data
{
    public class HockeyPlayer
    {
        //data fields
        private string _firstName;  //using "string?" allows nulls
        private string _lastName;
        private string _birthPlace;
        private DateOnly _dateOfBirth;
        private int _heightInInches;
        private int _weightInPounds;

        //we don't need the following
        //private Position _positions;
        //private Shot _shot;

        //properties

        /// <summary>
        /// Gets/Sets the Birthplace of a hockey player
        /// </summary>
        public string BirthPlace
        {
            get
            {
                return _birthPlace;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) //checks for null/empty/whitespace
                {
                    throw new ArgumentException("Birthplace cannot be null or empty.");
                }
                //if we get here, then no exception happened
                _birthPlace = value;
            }
        }

        /// <summary>
        /// gets/sets the first name of a hockey player
        /// </summary>
        public string FirstName
        {
            get 
            { 
                return _firstName; 
            } 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name cannot be empty");
                }
                _firstName = value;
            }
        }

        /// <summary>
        /// gets/sets the last name of a hockey player
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be empty or null");
                }
                _lastName = value;
            }
        }

        /// <summary>
        /// gets/sets the height of a hockey player in inches
        /// </summary>
        public int HeightInInches
        {
            get
            {
                return _heightInInches;
            }
            set
            {
                if (Utilities.IsZeroOrNegative(value))
                {
                    throw new ArgumentException("Weight must be more than 0");
                }
                _heightInInches = value;
            }
        }

        /// <summary>
        /// gets/ sets the weight of a hockey player in pounds
        /// </summary>
        public int WeightInPounds
        {
            get
            {
                return _weightInPounds;
            }
            set
            {
                if(Utilities.IsZeroOrNegative(value))
                {
                    throw new ArgumentException("weight must be more than 0");
                }
                _weightInPounds = value;
            }
        }

        /// <summary>
        /// gets/sets the date of birth of a hockey player
        /// </summary>
        public DateOnly DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (Utilities.IsInFuture(value))
                {
                    throw new ArgumentException("Date cannot be a future date.");
                }
                _dateOfBirth = value;
            }
        }

        //Auto-implemented property

        /// <summary>
        /// Represents the position of the hockey player
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        /// Represents the shot hand of the hockey player
        /// </summary>
        public Shot Shot { get; set; }

        //constructors

        /// <summary>
        /// creates the default instance of a hockey player
        /// </summary>
        public HockeyPlayer() //default constructor
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            _birthPlace = string.Empty;
            _dateOfBirth = new DateOnly();
            _weightInPounds = 0;
            _heightInInches = 0;
            Shot = Shot.Left;
            Position = Position.Center;
        }

        //greedy constructor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastname"></param>
        /// <param name="birthPlace"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="weightInPounds"></param>
        /// <param name="heightInInches"></param>
        /// <param name="position"></param>
        /// <param name="shot"></param>
        public HockeyPlayer(string firstName, string lastname, string birthPlace, DateOnly dateOfBirth, int weightInPounds, int heightInInches, Position position = Position.Center, Shot shot = Shot.Left)  
            //ORDER MATTERS, defaults have to be at the end e.g.(Position position = Position.center, Shot shot = Shot.left)
            //you can default parameters with a greedy constructor where you pass in the parameters
        {
            FirstName = firstName;
            LastName = lastname;
            BirthPlace = birthPlace;
            DateOfBirth = dateOfBirth;
            WeightInPounds = weightInPounds;
            HeightInInches = heightInInches;
            Position = position;
            Shot = shot;
        }

    }
}