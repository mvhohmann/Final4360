using System;

  namespace Final4360
  {
    //this is a model of the Residents
      public class resident
      {
        public int ResidentID {get; set;}// This is the "primary key"
        public string FullName {get; set;} = string.Empty;
        public string Email {get; set;} = string.Empty;
        public int UnitNumber {get; set;}
      }
  }