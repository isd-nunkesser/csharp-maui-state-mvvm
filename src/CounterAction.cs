namespace CounterDemo;

public abstract record CounterAction;

public sealed record Increment : CounterAction;
public sealed record Decrement : CounterAction;
public sealed record Reset : CounterAction;
