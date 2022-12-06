using System;

  namespace Final4360
  {
    //this is a model of the Posting services
      public class posting
      {
        public int PostingID {get; set;}// This is the "primary key"
        public string Service {get; set;} = string.Empty;
      }
  }