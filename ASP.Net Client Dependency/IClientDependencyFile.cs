﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClientDependency.Core
{
	public interface IClientDependencyFile
	{
		string FilePath { get; set; }
		ClientDependencyType DependencyType { get; }
		int Priority { get; set; }
        string PathNameAlias { get; set; }
		string ForceProvider { get; set; }
	}
}
