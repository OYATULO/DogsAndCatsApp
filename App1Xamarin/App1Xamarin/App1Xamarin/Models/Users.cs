using System;
using System.Collections.Generic;
using System.Text;

namespace App1Xamarin.Models
{
	public class Users
	{
		public string Id { get; set; } = "1";
		public string Username { get; set; } = "admin";
		public string Email { get; set; } = "amdin@gmail.com";
		public string Password { get; set; } = "admin";

	}

	
	public class FromjsonTokey
	{
		public string StringKey { get; set; }
	    public NewUsers StrinValue { get; set; }
	}
	
	public class NewUsers
	{
		//public string Id { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }

	}
}
