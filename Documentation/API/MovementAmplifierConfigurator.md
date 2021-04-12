# Class MovementAmplifierConfigurator

Sets up the MovementAmplifier prefab based on the provided user settings.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [DistanceChecker]
  * [Facade]
  * [MovementMultiplier]
  * [ObjectMover]
  * [RadiusOriginMover]
  * [RadiusStabilizer]
  * [RadiusSubtractor]
  * [TargetPositionMutator]
* [Methods]
  * [ConfigureDistanceChecker()]
  * [ConfigureMovementMultiplier()]
  * [ConfigureObjectMover()]
  * [ConfigureRadiusOriginMover()]
  * [ConfigureRadiusSubtractor()]
  * [ConfigureTargetPositionMutator()]
  * [OnDisable()]
  * [OnEnable()]

## Details

##### Inheritance

* System.Object
* MovementAmplifierConfigurator

##### Namespace

* [Tilia.Locomotors.MovementAmplifier]

##### Syntax

```
public class MovementAmplifierConfigurator : MonoBehaviour
```

### Properties

#### DistanceChecker

Determines whether [Source] is inside the radius.

##### Declaration

```
public ObjectDistanceComparator DistanceChecker { get; protected set; }
```

#### Facade

The public interface facade.

##### Declaration

```
public MovementAmplifierFacade Facade { get; protected set; }
```

#### MovementMultiplier

Amplifies the movement.

##### Declaration

```
public Vector3Multiplier MovementMultiplier { get; protected set; }
```

#### ObjectMover

Moves the objects.

##### Declaration

```
public ObjectDistanceComparator ObjectMover { get; protected set; }
```

#### RadiusOriginMover

Moves the radius origin.

##### Declaration

```
public ObjectDistanceComparator RadiusOriginMover { get; protected set; }
```

#### RadiusStabilizer

Stabilizes the radius by ensuring [Target] moves back into the radius.

##### Declaration

```
public float RadiusStabilizer { get; protected set; }
```

#### RadiusSubtractor

Subtracts the radius.

##### Declaration

```
public FloatAdder RadiusSubtractor { get; protected set; }
```

#### TargetPositionMutator

Moves the target.

##### Declaration

```
public TransformPositionMutator TargetPositionMutator { get; protected set; }
```

### Methods

#### ConfigureDistanceChecker()

Configures the [DistanceChecker] with the facade settings.

##### Declaration

```
public virtual void ConfigureDistanceChecker()
```

#### ConfigureMovementMultiplier()

Configures the [MovementMultiplier] with the facade settings.

##### Declaration

```
public virtual void ConfigureMovementMultiplier()
```

#### ConfigureObjectMover()

Configures the [ObjectMover] with the facade settings.

##### Declaration

```
public virtual void ConfigureObjectMover()
```

#### ConfigureRadiusOriginMover()

Configures the [RadiusOriginMover] with the facade settings.

##### Declaration

```
public virtual void ConfigureRadiusOriginMover()
```

#### ConfigureRadiusSubtractor()

Configures the [RadiusSubtractor] with the facade settings.

##### Declaration

```
public virtual void ConfigureRadiusSubtractor()
```

#### ConfigureTargetPositionMutator()

Configures the [TargetPositionMutator] with the facade settings.

##### Declaration

```
public virtual void ConfigureTargetPositionMutator()
```

#### OnDisable()

##### Declaration

```
protected virtual void OnDisable()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

[Tilia.Locomotors.MovementAmplifier]: README.md
[Source]: MovementAmplifierFacade.md#Tilia_Locomotors_MovementAmplifier_MovementAmplifierFacade_Source
[MovementAmplifierFacade]: MovementAmplifierFacade.md
[Target]: MovementAmplifierFacade.md#Tilia_Locomotors_MovementAmplifier_MovementAmplifierFacade_Target
[DistanceChecker]: MovementAmplifierConfigurator.md#DistanceChecker
[MovementMultiplier]: MovementAmplifierConfigurator.md#MovementMultiplier
[ObjectMover]: MovementAmplifierConfigurator.md#ObjectMover
[RadiusOriginMover]: MovementAmplifierConfigurator.md#RadiusOriginMover
[RadiusSubtractor]: MovementAmplifierConfigurator.md#RadiusSubtractor
[TargetPositionMutator]: MovementAmplifierConfigurator.md#TargetPositionMutator
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[DistanceChecker]: #DistanceChecker
[Facade]: #Facade
[MovementMultiplier]: #MovementMultiplier
[ObjectMover]: #ObjectMover
[RadiusOriginMover]: #RadiusOriginMover
[RadiusStabilizer]: #RadiusStabilizer
[RadiusSubtractor]: #RadiusSubtractor
[TargetPositionMutator]: #TargetPositionMutator
[Methods]: #Methods
[ConfigureDistanceChecker()]: #ConfigureDistanceChecker
[ConfigureMovementMultiplier()]: #ConfigureMovementMultiplier
[ConfigureObjectMover()]: #ConfigureObjectMover
[ConfigureRadiusOriginMover()]: #ConfigureRadiusOriginMover
[ConfigureRadiusSubtractor()]: #ConfigureRadiusSubtractor
[ConfigureTargetPositionMutator()]: #ConfigureTargetPositionMutator
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
