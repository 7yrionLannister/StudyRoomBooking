using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
	public class Booking
	{

		private string name;
		private string code;
		private string room;
		private string startTime;
		private string endTime;

		public Booking(string name, string code, string room, string startTime, string endTime)
		{
			this.name = name;
			this.code = code;
			this.room = room;
			this.startTime = startTime;
			this.endTime = endTime;
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

		public string StartTime
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

		public string EndTime
		{

			get
			{
				return endTime;
			}

			set
			{
				endTime = value;
			}
		}
	}
}
