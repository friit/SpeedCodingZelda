﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace LetsCreateZelda.Components
{
    class GUI : Component
    {
        private Texture2D _tempTexture; 
        private Texture2D _rupeeTexture;
        private Texture2D _heartTexture;
        private Texture2D _containerTexture;
        private Texture2D _backgroundTexture; 
        private SpriteFont _font; 

        public override ComponentType ComponentType
        {
            get { return ComponentType.GUI;  }
        }

        public void LoadContent(ContentManager content)
        {
            _rupeeTexture = content.Load<Texture2D>("rupee_gui");
            _heartTexture = content.Load<Texture2D>("heart_gui");
            _containerTexture = content.Load<Texture2D>("container_gui");
            _font = content.Load<SpriteFont>("Font_GUI");
            _tempTexture = content.Load<Texture2D>("boomerang_gui");
            _backgroundTexture = content.Load<Texture2D>("white_background");
        }

        public override void Update(double gameTime)
        {
           
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            var stats = GetComponent<Stats>(ComponentType.Stats);

            spritebatch.Draw(_backgroundTexture,new Rectangle(0,128,160,16),new Color(245,245,135));

            spritebatch.Draw(_containerTexture, new Rectangle(9, 130, 30, 12), Color.Black);
            spritebatch.DrawString(_font, "B", new Vector2(1, 129), Color.Black);
            spritebatch.Draw(_tempTexture, new Rectangle(12, 131, 10, 10), Color.White);

            spritebatch.Draw(_containerTexture, new Rectangle(47, 130, 30, 12), Color.Black);
            spritebatch.DrawString(_font, "A", new Vector2(40, 129), Color.Black);

            spritebatch.Draw(_rupeeTexture,new Rectangle(80,130,9,9),Color.White);
            spritebatch.DrawString(_font,"999",new Vector2(80,135),Color.Black);

            if (stats == null)
                return; 

            for(int n = 0; n < stats.CurrentHealth; n++)
            {
                spritebatch.Draw(_heartTexture,new Rectangle(100+n*10,130,9,9),Color.White);
            }

        }
    }
}
