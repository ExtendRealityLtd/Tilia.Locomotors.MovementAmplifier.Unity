namespace Tilia.Locomotors.MovementAmplifier
{
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Operation.Mutation;
    using Zinnia.Data.Type.Transformation.Aggregation;
    using Zinnia.Extension;
    using Zinnia.Tracking.Follow;

    /// <summary>
    /// Sets up the MovementAmplifier prefab based on the provided user settings.
    /// </summary>
    public class MovementAmplifierConfigurator : MonoBehaviour
    {
        #region Facade Settings
        [Header("Facade Settings")]
        [Tooltip("The public interface facade.")]
        [SerializeField]
        [Restricted]
        private MovementAmplifierFacade facade;
        /// <summary>
        /// The public interface facade.
        /// </summary>
        public MovementAmplifierFacade Facade
        {
            get
            {
                return facade;
            }
            protected set
            {
                facade = value;
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The public interface facade.")]
        [SerializeField]
        [Restricted]
        private ObjectDistanceComparator radiusOriginMover;
        /// <summary>
        /// Moves the radius origin.
        /// </summary>
        public ObjectDistanceComparator RadiusOriginMover
        {
            get
            {
                return radiusOriginMover;
            }
            protected set
            {
                radiusOriginMover = value;
            }
        }
        [Tooltip("Determines whether MovementAmplifierFacade.Source is inside the radius.")]
        [SerializeField]
        [Restricted]
        private ObjectDistanceComparator distanceChecker;
        /// <summary>
        /// Determines whether <see cref="MovementAmplifierFacade.Source"/> is inside the radius.
        /// </summary>
        public ObjectDistanceComparator DistanceChecker
        {
            get
            {
                return distanceChecker;
            }
            protected set
            {
                distanceChecker = value;
            }
        }
        [Tooltip("Moves the objects.")]
        [SerializeField]
        [Restricted]
        private ObjectDistanceComparator objectMover;
        /// <summary>
        /// Moves the objects.
        /// </summary>
        public ObjectDistanceComparator ObjectMover
        {
            get
            {
                return objectMover;
            }
            protected set
            {
                objectMover = value;
            }
        }
        [Tooltip("Subtracts the radius.")]
        [SerializeField]
        [Restricted]
        private FloatAdder radiusSubtractor;
        /// <summary>
        /// Subtracts the radius.
        /// </summary>
        public FloatAdder RadiusSubtractor
        {
            get
            {
                return radiusSubtractor;
            }
            protected set
            {
                radiusSubtractor = value;
            }
        }
        [Tooltip("Stabilizes the radius by ensuring MovementAmplifierFacade.Target moves back into the radius.")]
        [SerializeField]
        [Restricted]
        private float radiusStabilizer = 0.001f;
        /// <summary>
        /// Stabilizes the radius by ensuring <see cref="MovementAmplifierFacade.Target"/> moves back into the radius.
        /// </summary>
        public float RadiusStabilizer
        {
            get
            {
                return radiusStabilizer;
            }
            protected set
            {
                radiusStabilizer = value;
            }
        }
        [Tooltip("Amplifies the movement.")]
        [SerializeField]
        [Restricted]
        private Vector3Multiplier movementMultiplier;
        /// <summary>
        /// Amplifies the movement.
        /// </summary>
        public Vector3Multiplier MovementMultiplier
        {
            get
            {
                return movementMultiplier;
            }
            protected set
            {
                movementMultiplier = value;
            }
        }
        [Tooltip("Moves the target.")]
        [SerializeField]
        [Restricted]
        private TransformPositionMutator targetPositionMutator;
        /// <summary>
        /// Moves the target.
        /// </summary>
        public TransformPositionMutator TargetPositionMutator
        {
            get
            {
                return targetPositionMutator;
            }
            protected set
            {
                targetPositionMutator = value;
            }
        }
        #endregion

        /// <summary>
        /// Configures the <see cref="RadiusOriginMover"/> with the facade settings.
        /// </summary>
        public virtual void ConfigureRadiusOriginMover()
        {
            RadiusOriginMover.transform.parent.position = Facade.Source.transform.position;
            RadiusOriginMover.RunWhenActiveAndEnabled(() => RadiusOriginMover.Target = Facade.Source);
        }

        /// <summary>
        /// Configures the <see cref="DistanceChecker"/> with the facade settings.
        /// </summary>
        public virtual void ConfigureDistanceChecker()
        {
            DistanceChecker.RunWhenActiveAndEnabled(() => DistanceChecker.Source = Facade.Source);
            DistanceChecker.DistanceThreshold = Facade.IgnoredRadius;
        }

        /// <summary>
        /// Configures the <see cref="ObjectMover"/> with the facade settings.
        /// </summary>
        public virtual void ConfigureObjectMover()
        {
            ObjectMover.RunWhenActiveAndEnabled(() => ObjectMover.Source = Facade.Source);
        }

        /// <summary>
        /// Configures the <see cref="RadiusSubtractor"/> with the facade settings.
        /// </summary>
        public virtual void ConfigureRadiusSubtractor()
        {
            RadiusSubtractor.RunWhenActiveAndEnabled(() => RadiusSubtractor.Collection.SetAt(-Facade.IgnoredRadius + RadiusStabilizer, 1));
        }

        /// <summary>
        /// Configures the <see cref="MovementMultiplier"/> with the facade settings.
        /// </summary>
        public virtual void ConfigureMovementMultiplier()
        {
            MovementMultiplier.RunWhenActiveAndEnabled(() => MovementMultiplier.Collection.SetAt(Vector3.one * (Facade.Multiplier - 1f), 1));
        }

        /// <summary>
        /// Configures the <see cref="TargetPositionMutator"/> with the facade settings.
        /// </summary>
        public virtual void ConfigureTargetPositionMutator()
        {
            TargetPositionMutator.Target = Facade.Target;
        }

        protected virtual void OnEnable()
        {
            ConfigureRadiusOriginMover();
            ConfigureDistanceChecker();
            ConfigureObjectMover();
            ConfigureRadiusSubtractor();
            ConfigureMovementMultiplier();
            ConfigureTargetPositionMutator();
        }

        protected virtual void OnDisable()
        {
            ObjectMover.enabled = false;
        }
    }
}