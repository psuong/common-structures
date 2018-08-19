namespace CommonStructures {

    /// <summary>
    /// An empty struct that contains utility functions.
    /// </summary>
    public struct Tuple {

        /// <summary>
        /// A utility function to create a pair.
        /// </summary>
        public static Tuple<T1, T2> CreateTuple<T1, T2>(T1 item1, T2 item2) {
            return new Tuple<T1, T2>(item1, item2);
        }

        /// <summary>
        /// A utility function to create a a triple.
        /// </summary>
        public static Tuple<T1, T2, T3> CreateTuple<T1, T2, T3>(T1 item1, T2 item2, T3 item3) {
            return new Tuple<T1, T2, T3>(item1, item2, item3);   
        }

        /// <summary>
        /// A utility function to create a four tuple.
        /// </summary>
        public static Tuple<T1, T2, T3, T4> CreateTuple<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4) {
            return new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
        }

        /// <summary>
        /// A utility function to create a five tuple.
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5> CreateTuple<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) {
            return new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
        }

        /// <summary>
        /// A utility function to create a six tuple.
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6> CreateTuple<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) {
            return new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
        }

        /// <summary>
        /// A utility function to create a seven tuple.
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7> CreateTuple<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
        }

        /// <summary>
        /// A utility function to create an octuple.
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, T8> CreateTuple<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8) {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7, T8>(item1, item2, item3, item4, item5, item6, item7, item8);
        }
    }
    
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
    }

    /// <summary>
    /// A five tuple with immutable fields that is value based.
    /// </summary>
    [System.Serializable]
    public struct Tuple<T1, T2, T3, T4, T5> {

        public readonly T1 item1;
        public readonly T2 item2;
        public readonly T3 item3;
        public readonly T4 item4;
        public readonly T5 item5;

        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
            this.item5 = item5;
        }
    }

    /// <summary>
    /// A six tuple with immutable fields that is value based.
    /// </summary>
    [System.Serializable]
    public struct Tuple<T1, T2, T3, T4, T5, T6> {

        public readonly T1 item1;
        public readonly T2 item2;
        public readonly T3 item3;
        public readonly T4 item4;
        public readonly T5 item5;
        public readonly T6 item6;

        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
            this.item5 = item5;
            this.item6 = item6;
        }
    }

    /// <summary>
    /// A seven tuple with immutable fields that is value based.
    /// </summary>
    [System.Serializable]
    public struct Tuple<T1, T2, T3, T4, T5, T6, T7> {

        public readonly T1 item1;
        public readonly T2 item2;
        public readonly T3 item3;
        public readonly T4 item4;
        public readonly T5 item5;
        public readonly T6 item6;
        public readonly T7 item7;

        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
            this.item5 = item5;
            this.item6 = item6;
            this.item7 = item7;
        }
    }

    /// <summary>
    /// An octuple with immutable fields that is value based.
    /// </summary>
    [System.Serializable]
    public struct Tuple<T1, T2, T3, T4, T5, T6, T7, T8> {

        public readonly T1 item1;
        public readonly T2 item2;
        public readonly T3 item3;
        public readonly T4 item4;
        public readonly T5 item5;
        public readonly T6 item6;
        public readonly T7 item7;
        public readonly T8 item8;

        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8) {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
            this.item4 = item4;
            this.item5 = item5;
            this.item6 = item6;
            this.item7 = item7;
            this.item8 = item8;
        }
    }

    public struct Tuple<T1, T2, T3> {
        public readonly T1 item1;
        public readonly T2 item2;
        public readonly T3 item3;

        public Tuple(T1 item1, T2 item2, T3 item3) {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public static Tuple<T1, T2, T3> CreateTuple(T1 item1, T2 item2, T3 item3) {
            return new Tuple<T1, T2, T3>(item1, item2, item3);
        }
    }
}
