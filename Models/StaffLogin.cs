using System;

namespace Final4360
{
  //this is a model of the Staff logins
  public class staff
  {
    public int StaffID {get; set;}// This is the "primary key"
    public string StaffUsername {get; set;} = string.Empty;
    public string StaffPassword {get; set;} = string.Empty;
  }
}