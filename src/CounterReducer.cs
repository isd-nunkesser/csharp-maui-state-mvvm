namespace CounterDemo;

public static class CounterReducer
{
    public static CounterState Reduce(CounterState state, CounterAction action) => action switch
    {
        Increment => state with { Count = state.Count + 1 },
        Decrement => state with { Count = state.Count - 1 },
        Reset => state with { Count = 0 },
        _ => state,
    };
}
