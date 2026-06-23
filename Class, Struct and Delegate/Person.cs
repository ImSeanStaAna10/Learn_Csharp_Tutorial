using System;
using System.Collections.Generic;
using System.Text;

namespace Class__Struct_and_Delegate
{
    internal class Person
    {
        #region -- FIELDS --
        // fields lagayan ng variables na naghohold ng data
        // Private field na nagho-hold ng value ng first name.
        // Hindi siya directly accessible sa labas ng class (encapsulation).
        private string _firstName;
        private string _nickname;
        #endregion

        #region -- PROPERTIES--

        /*
         * NAGBIBIGAY NG CONTROLLED ACCESS SA FIELDS
         Property (FistName) na nagbibigay ng controlled access sa private field na _firstName.

         get  -> kinukuha ang current value ng _firstName
         set  -> binibigyan / siniset ang new value ng _firstName gamit ang implicit na 'value'

         Ginagamit ito para sa encapsulation (pag-hihide ng internal data at controlled access).
        */
        public string FistName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }
        /*
         Auto-implemented property para sa LastName.

         Ang compiler na ang bahalang gumawa ng hidden private field behind the scenes.
         Shortcut version ito ng property kapag walang extra logic sa get/set.
        */
        public string LastName { get; set; } //Auto-implemented property para sa LastName /  Ang compiler na ang bahalang gumawa ng hidden private field behind the scenes.   Shortcut version ito ng property kapag walang extra logic sa get/set.
        public string FullName
        {
            get
            {
                return $"{_firstName} {LastName}";
            }
        }
        public int Sample { get;  private set; }
        public string NickName
        {
            get
            {
                if (string.IsNullOrEmpty(_nickname))
                {
                    return "N/A";
                }
                return _nickname;
            }

            set
            {
                if (value == null)
                {
                    _nickname = string.Empty;
                }
                else
                {
                    _nickname = value;
                }

            }
        }
        public DateTime? BirthDate { get; set; } // for delegate example
        
        public List<Fruit> FavoritesFruits { get; set; } = new List<Fruit>(); // initial value empty list 
        #endregion

        #region-- CONSTRUCTOR --
        // eto yung tinatawag pag nag iinstantiate tayo
        // overloading - same identifuer but different parameters
        public Person()
        {

        }

        public Person(string first)
        {
            _firstName = first;
        }

        public Person(string first , string second): this(first) // constructor chaining
        {
            LastName = second;
        }


        #endregion

        #region -- METHODS -- 
        // overloading Update Method
        public void Update(int sample)
        {
            Sample = sample;
        }
        public void Update(int sample, string nickName)
        {
            Update(sample);
            NickName = nickName;
            NickNameHand1er?.Invoke(this, new NickNameArgs {NickName =  nickName }); // 3. invoke para I run lahat ng method na naka subscribe sa event ito yung actual announcemnt ?. means member access operator
        }
        public int? GetAge()
        {
            if (BirthDate.HasValue)
            {
                return (int?) ((DateTime.Now - BirthDate.Value).TotalDays / 365);
            }
            return default;
        }

        #region -- DELEGATE METHODS --
        // DELEGATE METHODS for delagate example
        public void AddFavoriteFruit(Fruit fruit, ProcessFruitDelegate successCallback)
        {
            FavoritesFruits.Add(fruit);
            successCallback(fruit);
        }

        public void DeleteFavoriteFruit(Fruit fruit, ProcessFruitDelegate successCallback)
        {
            FavoritesFruits.Remove(fruit);
            successCallback(fruit);
        }

        #endregion
        #endregion

        #region -- EVENT --
        public event EventHandler<NickNameArgs> NickNameHand1er; // 1 . gumawa ako event -  eto yung event (NickNameHandler is variable name);
    }
        public class NickNameArgs : EventArgs // 2. event data -  lalagyan ng data parang envelope 
    {
        public string NickName { get; set; } // property
    } 
    #endregion
}
