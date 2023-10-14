#region Includes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Numerics;

#endregion

namespace DoD_23_24
{
	public class World
	{
		Shahd shahd; 

        public World()
		{
			 shahd = new Shahd("goofy", new Vector2(50,50) new Vector2(50,50), true);
        }

		public virtual void Update(GameTime gameTime)
		{
			shahd.Update(gameTime);
		}

		public virtual void Draw()
		{
			shahd.Draw();
		}


	}
}

