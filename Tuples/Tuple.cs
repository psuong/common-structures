namespace CommonStructures {
    
    /// <summary>
    /// Tuples exists already in C# but as reference based values. This struct provides a value based 
    /// tuple with immutable fields.
    /// </summary>
    public struct Tuple<T1, T2> {

        public readonly T1 item1;
        public readonly T2 item2;

        public Tuple(T1 item1, T2 item2) {
            this.item1 = item1;
            this.item2 = item2;
        }
        
        /// <summary>
        /// Utility method to create a tuple of generic types.
        /// </summary>
        /// <param name="item1">The first element in the pair</param>
        /// <param name="item2">The second element in the pair</param>
        /// <returns>An ordered pair</returns>
        public static Tuple<T1, T2> CreateTuple(T1 item1, T2 item2) {
            return new Tuple<T1, T2>() {
                item1 = item1,
                item2 = item2
            };
        }
    }
}
