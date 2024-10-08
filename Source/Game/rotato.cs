using System;
using System.Collections.Generic;
using FlaxEngine;

namespace Game;

/// <summary>
/// rotato Script.
/// </summary>
public class rotato : Script
{

    public Actor playerhead;

    /// <inheritdoc/>
    public override void OnStart()
    {
        // Here you can add code that needs to be called when script is created, just before the first game update
    }
    
    /// <inheritdoc/>
    public override void OnEnable()
    {
        // Here you can add code that needs to be called when script is enabled (eg. register for events)
    }

    /// <inheritdoc/>
    public override void OnDisable()
    {
        // Here you can add code that needs to be called when script is disabled (eg. unregister from events)
    }

    /// <inheritdoc/>
    public override void OnUpdate()
    {
        Actor.LookAt(new Vector3(playerhead.Position.X, Actor.Position.Y, playerhead.Position.Z));
        // Here you can add code that needs to be called every frame
    }
}
