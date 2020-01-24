﻿using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
	public class Booking
	{

		private string name;
		private string code;
		private string room;
		private TimeSpan startTime;

		public Booking(string name, string code, string room, TimeSpan startTime)
		{

			this.name = name;
			this.code = code;
			this.room = room;
			this.startTime = startTime;

		}

		public string Name
		{

			get
			{
				return name;
			}

			set
			{
				name = value;
			}
		}

		public string Code
		{

			get
			{
				return code;
			}

			set
			{
				code = value;
			}
		}

		public string Room
		{

			get
			{
				return room;
			}

			set
			{
				room = value;
			}
		}

		public TimeSpan StartTime
		{

			get
			{
				return startTime;
			}

			set
			{
				startTime = value;
			}
		}

	}
}
