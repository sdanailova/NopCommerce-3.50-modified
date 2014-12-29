using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nop.Web.Framework.Mvc;

namespace Nop.Web.Models.Common
{
	public partial class HeaderModel : BaseNopModel
	{
		public string FacebookLink { get; set; }
		public string TwitterLink { get; set; }
		public string YoutubeLink { get; set; }
		public string GooglePlusLink { get; set; }
	}
}