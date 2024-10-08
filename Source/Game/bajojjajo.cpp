#include "bajojjajo.h"

bajojjajo::bajojjajo(const SpawnParams& params)
    : Script(params)
{
    // Enable ticking OnUpdate function
    _tickUpdate = true;
}

void bajojjajo::OnEnable()
{
    // Here you can add code that needs to be called when script is enabled (eg. register for events)
}

void bajojjajo::OnDisable()
{
    // Here you can add code that needs to be called when script is disabled (eg. unregister from events)
}

void bajojjajo::OnUpdate()
{
    // Here you can add code that needs to be called every frame
}
