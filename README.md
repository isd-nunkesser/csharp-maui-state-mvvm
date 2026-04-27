# csharp-maui-state-mvvm

Education consumer for showing a modern .NET MAUI state-based architecture comparable to Flutter, SwiftUI, and Jetpack Compose.

## Main concept

- Immutable app state
- Explicit actions
- Reducer-style state transition
- `CommunityToolkit.Mvvm` for binding and commands

## Learning goal

Students should understand how unidirectional state flow can be implemented in a production-relevant MAUI stack without Comet.

## Minimal flow

1. User triggers command.
2. Command dispatches action.
3. Reducer produces next immutable state.
4. ViewModel publishes state to UI bindings.

## Suggested next step

Integrate this into an existing MAUI solution with a `Core` project for state/actions/reducer and a MAUI project for views and viewmodels.
