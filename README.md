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

## Run locally

1. Change into the app folder.
2. Restore dependencies.
3. Build and run for your target platform.

```bash
cd app
dotnet restore
dotnet build
dotnet run -f net10.0-maccatalyst
```

## Shared counter state example

This repository uses the same teaching example as the sibling stacks:

- `src/CounterState.cs`
- `src/CounterAction.cs`
- `src/CounterReducer.cs`

The goal is a side-by-side comparison of identical state and reducer logic across MAUI MVVM, MAUI Reactor-style MVU, and Uno MVUX-oriented demos.
