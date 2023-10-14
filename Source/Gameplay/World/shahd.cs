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
#endregion
namespace DoD_23_24
{
    public class Shahd : Basic2D
    {

       


        public Shahd(string PATH, Vector2 POS, Vector2 DIMS, bool shouldScale) : base(PATH, POS, DIMS, shouldScale)
        {
        }

        public override void Update(GameTime gameTime)
        {

            var kstate = keboard.GetState();

            if (kstate.IsKeyDown(Keys.W){

                pos.Y -= 1;
            }
            else if (kstate.IsKeyDown(Keys.Down))
            {
                pos.Y += 1;
            }
            if (kstate.IsKeyDown(Keys.Right))
            {
                pos.X += 1;
            }
            else if (kstate.IsKeyDown(Keys.Left))
            {
                pos.X -= 1;
            }

            base.Update(gameTime);
        }

        public override void Draw()
        {
            base.Draw();
        }
    }
}