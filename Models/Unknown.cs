using System;

  namespace Final4360
  {
    //this is a model of the Unknown packages
      public class unknown
      {
        public int UnknownID {get; set;}// This is the "primary key"
        public string FullName {get; set;} = string.Empty;
        public int PostingID {get; set;}
        public DateTime DeliveryDate {get; set;}
      }
  }