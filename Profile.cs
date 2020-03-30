namespace Flinter
{
    /// <summary>
    /// This class represents a person profile,
    /// for instance for a dating website
    /// </summary>
    public class Profile
    {
        #region Instance fields
        private Gender _gender;
        private EyeColor _eyeColor;
        private HairColor _hairColor;
        private HeightCategory _heightCategory;
        #endregion

        #region Constructor
        public Profile(Gender gender, EyeColor eyeColor, HairColor hairColor, HeightCategory heightCategory)
        {
            _gender = gender;
            _eyeColor = eyeColor;
            _hairColor = hairColor;
            _heightCategory = heightCategory;
        }
        #endregion

        #region Properties
        public string Description
        {
            get
            {
                return $"You got a {GenderDescription} with {_eyeColor} eyes and {_hairColor} hair, who is {HeightDescription}";
            }
        }

        public string GenderDescription
        {
             get
             { 
                 switch(_gender){
                    case Gender.Female:
                        return "Woman";
                    case Gender.Male:
                        return "Man";
                    case Gender.Intersex:
                        return "Hermaphrodite";
                    default:
                        return "Unknown gender";
                 }
             }
        }

        public string HeightDescription
        {
            get
            {
                switch (_heightCategory)
                {
                    case HeightCategory.Midget:
                        return "Very short";
                    case HeightCategory.Short:
                        return "Short";
                    case HeightCategory.Average:
                        return "Medium height";
                    case HeightCategory.Tall:
                        return "Tall";
                    case HeightCategory.Giant:
                        return "Very tall";
                    default:
                        return "Unknown height";
                }
            }
        } 
        #endregion
        public enum Gender{
            Female,
            Male,
            Intersex
        }
        public enum EyeColor{
            Blue,
            Brown,
            Green,
            Black,
            Hazel
        }
        public enum HairColor{
            White,
            Black,
            Red,
            Brown,
            Blonde
        }
        public enum HeightCategory{
            Short,
            Tall,
            Average,
            Midget,
            Giant
        }
    }
}