# Ease

An implementation of Easing Functions for C#.

This library target .NET 8

If you're looking for a simpler helper class, I recommend using [Kryzarel's gist](https://gist.github.com/Kryzarel/bba64622057f21a1d6d44879f9cd7bd4)

## Usage

### Easings

`Easings` is a static helper class, which provides a shorter way of calling the `EasingFunction`equivalent.

```cs
double interpolated = Easings.InOutQuad(0.5);
```

Easings class also provides casting to `float`, given the parameter is also a `float`.

```cs
float interpolated = Easings.InOutQuad(0.5f);
```

Internally, all functions from `Easings` calls the exposed functions from corresponding implemented `EasingFunction`.

### Implemented EasingFunction

Each implemented `EasingFunction` provides an exposed static `In`, `Out`, and `InOut` to simplify calling.

```cs
double interpolated1 = QuadEasingFunction.In(0.5);

double interpolated2 = QuadEasingFunction.Out(0.5);

double interpolated3 = QuadEasingFunction.InOut(0.5);
```

If you want to hold on to the reference, you can create the class instead.

```cs
QuadEasingFunction easingFunction = new QuadEasingFunction(EasingMode.In);
double first = easingFunction.Interpolate(0.5);

// to use different EasingMode, simply change the property.
easingFunction.Mode = EasingMode.InOut;
double second = easingFunction.Interpolate(0.5);
```

### Easing and EasingMode

```cs
Easing easing = Easing.Quad;

double first = easing.Interpolate(EasingMode.InOut, 0.5);

// This is equvalent to calling easing.Interpolate(EasingMode.InOut, 0.5)
double second = easing.Interpolate(0.5);
```

or

```cs
Easing easing = Easing.Quad;

IEasingFunction easingFunction = easings.ToFunction(EasingMode.InOut);

double value = easingFunction.Interpolate(0.5);
```

## Custom Easing Function

You can implement your own function by implementing `IEasingFunction` interface.

It is intentionally not given additional parameter of `EasingMode` on `Interpolate` to give you the freedom on what it should do.

## Related Links

- [easing.net](https://easings.net/)

- [Kryzarel's gist](https://gist.github.com/Kryzarel/bba64622057f21a1d6d44879f9cd7bd4)
