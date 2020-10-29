/*
* Author: Samuel McGowan
* Class name: PrivacyModel.cs
* Purpose: The model for the Privacy.cshtml website page
* Last Modified: 10/29/20
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
	/// <summary>
	/// The model for the Privacy.cshtml website page
	/// </summary>
	public class PrivacyModel : PageModel
	{
		private readonly ILogger<PrivacyModel> _logger;

		public PrivacyModel(ILogger<PrivacyModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
		}
	}
}
