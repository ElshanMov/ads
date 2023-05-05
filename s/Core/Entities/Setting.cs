﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
	public class Setting
	{
		public int Id { get; set; }
		public string Key { get; set; }
		public string Value { get; set; }

		[NotMapped]
		public IFormFile ImageFile { get; set; }
	}
}
