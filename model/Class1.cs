using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
	public class DataManager{

		private string name;
		private string code;
		private string room;
		private TimeSpan startTime;
		private TimeSpan endTime;

		public string Name {

			get {
				return name;
			}

			set {
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

		public TimeSpan EndTime
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
