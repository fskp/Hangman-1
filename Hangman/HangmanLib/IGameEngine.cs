﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangmanLib
{
	public interface IGameEngine : IWordsContainer
	{
		void Run();
	}
}
