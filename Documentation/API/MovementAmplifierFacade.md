# Class MovementAmplifierFacade

The public interface for the MovementAmplifier prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Configuration]
  * [IgnoredRadius]
  * [Multiplier]
  * [Source]
  * [Target]
* [Methods]
  * [ClearSource()]
  * [ClearTarget()]
  * [OnAfterIgnoredRadiusChange()]
  * [OnAfterMultiplierChange()]
  * [OnAfterSourceChange()]
  * [OnAfterTargetChange()]

## Details

##### Inheritance

* System.Object
* MovementAmplifierFacade

##### Namespace

* [Tilia.Locomotors.MovementAmplifier]

##### Syntax

```
public class MovementAmplifierFacade : MonoBehaviour
```

### Properties

#### Configuration

The linked Internal Setup.

##### Declaration

```
public MovementAmplifierConfigurator Configuration { get; protected set; }
```

#### IgnoredRadius

The radius in which [Source] movement is ignored. Too small values can result in movement amplification happening during crouching which is often unexpected.

##### Declaration

```
public float IgnoredRadius { get; set; }
```

#### Multiplier

How much to amplify movement of [Source] to apply to [Target].

##### Declaration

```
public float Multiplier { get; set; }
```

#### Source

The source to observe movement of.

##### Declaration

```
public GameObject Source { get; set; }
```

#### Target

The target to apply amplified movement to.

##### Declaration

```
public GameObject Target { get; set; }
```

### Methods

#### ClearSource()

Clears [Source].

##### Declaration

```
public virtual void ClearSource()
```

#### ClearTarget()

Clears [Target].

##### Declaration

```
public virtual void ClearTarget()
```

#### OnAfterIgnoredRadiusChange()

Called after [IgnoredRadius] has been changed.

##### Declaration

```
protected virtual void OnAfterIgnoredRadiusChange()
```

#### OnAfterMultiplierChange()

Called after [Multiplier] has been changed.

##### Declaration

```
protected virtual void OnAfterMultiplierChange()
```

#### OnAfterSourceChange()

Called after [Source] has been changed.

##### Declaration

```
protected virtual void OnAfterSourceChange()
```

#### OnAfterTargetChange()

Called after [Target] has been changed.

##### Declaration

```
protected virtual void OnAfterTargetChange()
```

[Tilia.Locomotors.MovementAmplifier]: README.md
[MovementAmplifierConfigurator]: MovementAmplifierConfigurator.md
[Source]: MovementAmplifierFacade.md#Source
[Source]: MovementAmplifierFacade.md#Source
[Target]: MovementAmplifierFacade.md#Target
[Source]: MovementAmplifierFacade.md#Source
[Target]: MovementAmplifierFacade.md#Target
[IgnoredRadius]: MovementAmplifierFacade.md#IgnoredRadius
[Multiplier]: MovementAmplifierFacade.md#Multiplier
[Source]: MovementAmplifierFacade.md#Source
[Target]: MovementAmplifierFacade.md#Target
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Configuration]: #Configuration
[IgnoredRadius]: #IgnoredRadius
[Multiplier]: #Multiplier
[Source]: #Source
[Target]: #Target
[Methods]: #Methods
[ClearSource()]: #ClearSource
[ClearTarget()]: #ClearTarget
[OnAfterIgnoredRadiusChange()]: #OnAfterIgnoredRadiusChange
[OnAfterMultiplierChange()]: #OnAfterMultiplierChange
[OnAfterSourceChange()]: #OnAfterSourceChange
[OnAfterTargetChange()]: #OnAfterTargetChange
