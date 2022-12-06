using System;

  namespace Final4360
  {
    //this is a model of the Packages
      public class package
      {
        public int PackageID {get; set;}// This is the "primary key"
        public int ResidentID {get; set;}
        public int PostingID {get; set;}
        public DateTime DeliveryDate {get; set;}
        public DateTime? PickupDate {get; set;}
      }
  }