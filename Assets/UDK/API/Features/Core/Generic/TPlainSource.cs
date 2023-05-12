namespace UDK.API.Features.Core.Generic.Collections
{
    /// <summary>
    /// An object which handles two generic types.
    /// </summary>
    /// <typeparam name="T1">The first generic type.</typeparam>
    /// <typeparam name="T2">The second generic type.</typeparam>
    /// <typeparam name="T3">The box type.</typeparam>
    public class TPlainSource<T1, T2, T3> : TSourceObject<T1, T3>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TPlainSource{T1, T2, T3}"/> class.
        /// </summary>
        public TPlainSource()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TPlainSource{T1, T2, T3}"/> class.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <param name="dst">The destination.</param>
        /// <param name="value">The value to store.</param>
        public TPlainSource(T1 src, T2 dst, T3 value)
            : base(src, value) => Destination = dst;

        /// <summary>
        /// Initializes a new instance of the <see cref="TPlainSource{T1, T2, T3}"/> class.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <param name="value">The value to store.</param>
        protected TPlainSource(T1 src, T3 value)
            : base(src, value)
        {
        }

        /// <summary>
        /// Gets or sets the destination.
        /// </summary>
        public T2 Destination { get; set; }
    }
}
