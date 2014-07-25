﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangmanLib
{
	public abstract class Renderer
	{
		private IMessageProvider messageRenderer;

		public Renderer(IMessageProvider messageProvider)
		{
			this.messageRenderer = messageProvider;
		}

        public virtual void RenderMessage(MessageTypes messageType, params object[] parameters);

        // TODO: add additional functionality
	}
}
