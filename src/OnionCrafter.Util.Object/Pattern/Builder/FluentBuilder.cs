using OnionCrafter.Util.BinarySerialization;
using OnionCrafter.Util.Object.Pattern.Prototype;
using OnionCrafter.Utils.Exception;

namespace OnionCrafter.Util.Object.Pattern.Builder
{
    /// <summary>
    /// A generic fluent builder for constructing objects of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of object to build.</typeparam>

    public class FluentBuilder<T> :
        IFluentBuilder<T>,
        IClonable<IFluentBuilder<T>>
        where T : class, new()
    {
        /// <summary>
        /// The object in construction
        /// </summary>
        protected T _objectInConstruction;

        /// <summary>
        /// The set object default values
        /// </summary>
        protected Action<T>? _setObjectDefaultValues;

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentBuilder{T}"/> class.
        /// </summary>
        public FluentBuilder()
        {
            _objectInConstruction = new();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentBuilder{T}"/> class with specified default values.
        /// </summary>
        /// <param name="defaultValues">An action to set default values for the object.</param>
        public FluentBuilder(Action<T>? defaultValues) : this()
        {
            _setObjectDefaultValues = defaultValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentBuilder{T}"/> class with an existing object.
        /// </summary>
        /// <param name="myObject">The existing object to build upon.</param>
        public FluentBuilder(T myObject)
        {
            _objectInConstruction = myObject;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluentBuilder{T}"/> class with an existing object and specified default values.
        /// </summary>
        /// <param name="myObject">The existing object to build upon.</param>
        /// <param name="defaultValues">An action to set default values for the object.</param>
        public FluentBuilder(T myObject, Action<T>? defaultValues) : this(myObject)
        {
            _setObjectDefaultValues = defaultValues;
        }

        /// <inheritdoc/>

        public virtual T Build()
        {
            return _objectInConstruction;
        }

        /// <inheritdoc/>

        public virtual IFluentBuilder<T> SetProperty(Action<T> action)
        {
            action(_objectInConstruction);
            return this;
        }

        /// <inheritdoc/>

        public virtual IFluentBuilder<T> SetDefaultValues()
        {
            _setObjectDefaultValues.ThrowIfNull<Action<T>, NullReferenceException>()
                .Invoke(_objectInConstruction);
            return this;
        }

        /// <inheritdoc/>

        public virtual TReturn Clone<TReturn>() where TReturn : IFluentBuilder<T>
        {
            var newObject = _objectInConstruction.SerializeToBinary().DeserializeToObject<T>();
            FluentBuilder<T> newbuilder = new FluentBuilder<T>(newObject);
            return (TReturn)(IFluentBuilder<T>)newbuilder;
        }

        /// <inheritdoc/>

        public IFluentBuilder<T> CombineWith(IFluentBuilder<T> otherBuilder, Func<T, T, T> combineFunc)
        {
            var otherObject = otherBuilder.Build();

            _objectInConstruction = combineFunc(_objectInConstruction, otherObject);
            return this;
        }
    }
}