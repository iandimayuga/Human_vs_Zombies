﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human_vs_Zombies.HvZClasses;
using Human_vs_Zombies.HvZClasses.Mobs;
using Microsoft.Xna.Framework;

namespace Human_vs_Zombies.Controls
{
    /// <summary>
    /// The interface for controlling a player.
    /// </summary>
    public interface Brains
    {
        /// <summary>
        /// Updates this instance.
        /// </summary>
        void Update();

        Vector2 GetShoot();

        Vector2 GetWalk();
        
        public Vector2 shoot;

        public Vector2 walk;

        /// <summary>
        /// Gets or sets the player.
        /// </summary>
        /// <value>The player.</value>
        Player player { get; set; }

        /// <summary>
        /// Gets or sets the pong world.
        /// </summary>
        /// <value>The pong world.</value>
        HvZWorld hvzWorld { get; set; }
    }
}
