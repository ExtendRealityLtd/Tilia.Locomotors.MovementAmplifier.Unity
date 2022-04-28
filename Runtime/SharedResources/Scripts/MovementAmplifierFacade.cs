namespace Tilia.Locomotors.MovementAmplifier
{
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;

    /// <summary>
    /// The public interface for the MovementAmplifier prefab.
    /// </summary>
    public class MovementAmplifierFacade : MonoBehaviour
    {
        #region Tracking Settings
        [Header("Tracking Settings")]
        [Tooltip("The source to observe movement of.")]
        [SerializeField]
        private GameObject source;
        /// <summary>
        /// The source to observe movement of.
        /// </summary>
        public GameObject Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterSourceChange();
                }
            }
        }
        [Tooltip("The target to apply amplified movement to.")]
        [SerializeField]
        private GameObject target;
        /// <summary>
        /// The target to apply amplified movement to.
        /// </summary>
        public GameObject Target
        {
            get
            {
                return target;
            }
            set
            {
                target = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterTargetChange();
                }
            }
        }
        #endregion

        #region Movement Settings
        [Header("Movement Settings")]
        [Tooltip("The radius in which Source movement is ignored. Too small values can result in movement amplification happening during crouching which is often unexpected.")]
        [SerializeField]
        private float ignoredRadius = 0.25f;
        /// <summary>
        /// The radius in which <see cref="Source"/> movement is ignored. Too small values can result in movement amplification happening during crouching which is often unexpected.
        /// </summary>
        public float IgnoredRadius
        {
            get
            {
                return ignoredRadius;
            }
            set
            {
                ignoredRadius = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterIgnoredRadiusChange();
                }
            }
        }
        [Tooltip("How much to amplify movement of Source to apply to Target.")]
        [SerializeField]
        private float multiplier = 2f;
        /// <summary>
        /// How much to amplify movement of <see cref="Source"/> to apply to <see cref="Target"/>.
        /// </summary>
        public float Multiplier
        {
            get
            {
                return multiplier;
            }
            set
            {
                multiplier = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterMultiplierChange();
                }
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The linked Internal Setup.")]
        [SerializeField]
        [Restricted]
        private MovementAmplifierConfigurator configuration;
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        public MovementAmplifierConfigurator Configuration
        {
            get
            {
                return configuration;
            }
            protected set
            {
                configuration = value;
            }
        }
        #endregion

        /// <summary>
        /// Clears <see cref="Source"/>.
        /// </summary>
        public virtual void ClearSource()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Source = default;
        }

        /// <summary>
        /// Clears <see cref="Target"/>.
        /// </summary>
        public virtual void ClearTarget()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Target = default;
        }

        /// <summary>
        /// Called after <see cref="Source"/> has been changed.
        /// </summary>
        protected virtual void OnAfterSourceChange()
        {
            Configuration.ConfigureRadiusOriginMover();
            Configuration.ConfigureDistanceChecker();
            Configuration.ConfigureObjectMover();
        }

        /// <summary>
        /// Called after <see cref="Target"/> has been changed.
        /// </summary>
        protected virtual void OnAfterTargetChange()
        {
            Configuration.ConfigureTargetPositionMutator();
        }

        /// <summary>
        /// Called after <see cref="IgnoredRadius"/> has been changed.
        /// </summary>
        protected virtual void OnAfterIgnoredRadiusChange()
        {
            Configuration.ConfigureDistanceChecker();
            Configuration.ConfigureRadiusSubtractor();
        }

        /// <summary>
        /// Called after <see cref="Multiplier"/> has been changed.
        /// </summary>
        protected virtual void OnAfterMultiplierChange()
        {
            Configuration.ConfigureMovementMultiplier();
        }
    }
}