namespace CommonStructures {
    
    /// <summary>
    /// Tuples exists already in C# but as reference based values. This struct provides a value based 
    /// tuple with immutable fields.
    /// </summary>
    [System.Serializable]
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
            return new Tuple<T1, T2>(item1, item2);
        }
    }

    /// <summary>
    /// A triple with immutable fields that is value based.
    /// </summary>
    [System.Serializable]
    public struct Tuple<T1, T2, T3> {

        public readonly T1 item1;
        public readonly T2 item2;
        public readonly T3 item3;

        public Tuple(T1 item1, T2 item2, T3 item3) {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }
        
        /// <summary>
        /// Utility method to create a tuple of 3 arguments that are generic types.
        /// </summary>
        /// <param name="item1">The first element in the triple.</param>
        /// <param name="item2">The second element in the triple.</param>
        /// <param name="item3">The third element in the triple.</param>
        /// <returns>An ordered triple.</returns>
        public static Tuple<T1, T2, T3> CreateTuple(T1 item1, T2 item2, T3 item3) {
            return new Tuple<T1, T2, T3>(item1, item2, item3);
        }
    }

    /// <summary>
    /// A four tuple with immutable fields that is value based.
    /// </summary>
    [System.Serializable]
    public struct Tuple<T1, T2, T3, T4> {

        public readonly T1 item1;
        public readonly T2 item2;
        public readonly T3 item3;
        public readonly T4 item4;

        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4) {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
        }
        
        /// <summary>
        /// Utility method to create a tuple of 3 arguments that are generic types.
        /// </summary>
        /// <param name="item1">The first element in the four-tuple.</param>
        /// <param name="item2">The second element in the four-tuple.</param>
        /// <param name="item3">The third element in the four-tuple.</param>
        /// <param name="item4">The fourth element in the four-tuple.</param>
        /// <returns>An ordered four-tuple.</returns>
        public static Tuple<T1, T2, T3, T4> CreateTuple(T1 item1, T2 item2, T3 item3, T4 item4) {
            return new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
        }
    }
}
