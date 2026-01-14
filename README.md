# Ease

An implementation of Easing Functions for C#.

## Examples

```cs
double d = Easings.InQuad(0.5);
double d = Easing.Quad.Interpolate(EasingMode.In, 0.5);
double d = QuadEasingFunction.In(0.5);
```

The first two methods above uses `QuadEasingFunction.In`. they also provides casting to float by using the following methods:

```cs
float f = Easings.InQuadF(0.5f);
float f = Easing.Quad.InterpolateF(EasingMode.In, 0.5f);
```

Using `Easing`'s extension to create EasingFunction instance.

```cs
IEasingFunction function = Easing.Quad.ToFunction(EasingMode.In);
double d = function.Interpolate(0.5);
```

Directly create the EasingFunction, which allows you to change `EasingMode`.

```cs
QuadEasingFunction function = new QuadEasingFunction(EasingMode.In);
double d = function.Interpolate(0.5);

function.Mode = EasingMode.Out;
double d = function.Interpolate(0.5); // returning value using EasingMode.Out calculation.
```

## Related Links

- [Robert Penner's Easing Function](https://robertpenner.com/easing/)

- [easing.net](https://easings.net/)

- [Kryzarel's gist](https://gist.github.com/Kryzarel/bba64622057f21a1d6d44879f9cd7bd4)
