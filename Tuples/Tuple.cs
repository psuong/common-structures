namespace CommonStructures {

    /// <summary>
    /// An empty struct that contains utility functions.
    /// </summary>
    public struct Tuple {

        /// <summary> /// A utility function to create a pair.  /// </summary>
        public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
            where T1 : System.IEquatable<T1>
            where T2 : System.IEquatable<T2> {
            return new Tuple<T1, T2>(item1, item2);
        }

        /// <summary>
        /// A utility function to create a a triple.
        /// </summary>
        public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3) 
            where T1 : System.IEquatable<T1>
            where T2 : System.IEquatable<T2>
            where T3 : System.IEquatable<T3> {
            return new Tuple<T1, T2, T3>(item1, item2, item3);   
        }

        /// <summary>
        /// A utility function to create a four tuple.
        /// </summary>
        public static Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4) 
            where T1 : System.IEquatable<T1>
            where T2 : System.IEquatable<T2>
            where T3 : System.IEquatable<T3>
            where T4 : System.IEquatable<T4> {
            return new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
        }

        /// <summary>
        /// A utility function to create a five tuple.
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)  
            where T1 : System.IEquatable<T1>
            where T2 : System.IEquatable<T2>
            where T3 : System.IEquatable<T3>
            where T4 : System.IEquatable<T4> 
            where T5 : System.IEquatable<T5> {
            return new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
        }

        /// <summary>
        /// A utility function to create a six tuple.
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) 
            where T1 : System.IEquatable<T1>
            where T2 : System.IEquatable<T2>
            where T3 : System.IEquatable<T3>
            where T4 : System.IEquatable<T4> 
            where T5 : System.IEquatable<T5>
            where T6 : System.IEquatable<T6> {
            return new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
        }

        /// <summary>
        /// A utility function to create a seven tuple.
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) 
            where T1 : System.IEquatable<T1>
            where T2 : System.IEquatable<T2>
            where T3 : System.IEquatable<T3>
            where T4 : System.IEquatable<T4> 
            where T5 : System.IEquatable<T5>
            where T6 : System.IEquatable<T6>
            where T7 : System.IEquatable<T7> {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
        }

        /// <summary>
        /// A utility function to create an octuple.
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, T8> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8) 
            where T1 : System.IEquatable<T1>
            where T2 : System.IEquatable<T2>
            where T3 : System.IEquatable<T3>
            where T4 : System.IEquatable<T4> 
            where T5 : System.IEquatable<T5>
            where T6 : System.IEquatable<T6>
            where T7 : System.IEquatable<T7>
            where T8 : System.IEquatable<T8> {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7, T8>(item1, item2, item3, item4, item5, item6, item7, item8);
        }
    }
    
    /// <summary>
    /// Tuples exists already in C# but as reference based values. This struct provides a value based 
    /// tuple with immutable fields.
    /// </summary>
    [System.Serializable]
    public struct Tuple<T1, T2> : System.IEquatable<Tuple<T1, T2>>
        where T1 : System.IEquatable<T1>
        where T2 : System.IEquatable<T2> {
        
        public readonly T1 item1;
        public readonly T2 item2;

        public Tuple(T1 item1, T2 item2) {
            this.item1 = item1;
            this.item2 = item2;
        }

        public bool Equals(Tuple<T1, T2> other) {
            return item1.Equals(other.item1) && item2.Equals(other.item2);
        }
    }

    /// <summary>
    /// A triple with immutable fields that is value based.
    /// </summary>
    [System.Serializable]
    public struct Tuple<T1, T2, T3> : System.IEquatable<Tuple<T1, T2, T3>>
        where T1 : System.IEquatable<T1>
        where T2 : System.IEquatable<T2>
        where T3 : System.IEquatable<T3> {

        public readonly T1 item1;
        public readonly T2 item2;
        public readonly T3 item3;

        public Tuple(T1 item1, T2 item2, T3 item3) {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public bool Equals(Tuple<T1, T2, T3> other) {
            return item1.Equals(other.item1) && item2.Equals(other.item2) && item3.Equals(other.item3);
        }
    }

    /// <summary>
    /// A four tuple with immutable fields that is value based.
    /// </summary>
    [System.Serializable]
    public struct Tuple<T1, T2, T3, T4> : System.IEquatable<Tuple<T1, T2, T3, T4>>
        where T1 : System.IEquatable<T1>
        where T2 : System.IEquatable<T2> 
        where T3 : System.IEquatable<T3> 
        where T4 : System.IEquatable<T4> {

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

        public bool Equals(Tuple<T1, T2, T3, T4> other) {
            return item1.Equals(other.item1) && item2.Equals(other.item2) && item3.Equals(other.item3) && item4.Equals(other.item4);
        }
    }

    /// <summary>
    /// A five tuple with immutable fields that is value based.
    /// </summary>
    [System.Serializable]
    public struct Tuple<T1, T2, T3, T4, T5> : System.IEquatable<Tuple<T1, T2, T3, T4, T5>> 
        where T1 : System.IEquatable<T1>
        where T2 : System.IEquatable<T2>
        where T3 : System.IEquatable<T3>
        where T4 : System.IEquatable<T4>
        where T5 : System.IEquatable<T5> {

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

        public bool Equals(Tuple<T1, T2, T3, T4, T5> other) {
            return item1.Equals(other.item1) && item2.Equals(other.item2) && item3.Equals(other.item3) && item4.Equals(other.item4) &&
                item5.Equals(other.item5);
        }
    }

    /// <summary>
    /// A six tuple with immutable fields that is value based.
    /// </summary>
    [System.Serializable]
    public struct Tuple<T1, T2, T3, T4, T5, T6> : System.IEquatable<Tuple<T1, T2, T3, T4, T5, T6>> 
        where T1 : System.IEquatable<T1>
        where T2 : System.IEquatable<T2>
        where T3 : System.IEquatable<T3>
        where T4 : System.IEquatable<T4>
        where T5 : System.IEquatable<T5>
        where T6 : System.IEquatable<T6> {

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

        public bool Equals(Tuple<T1, T2, T3, T4, T5, T6> other) {
            return item1.Equals(other.item1) && item2.Equals(other.item2) && item3.Equals(other.item3) && item4.Equals(other.item4) &&
                item5.Equals(other.item5) && item6.Equals(other.item6);
        }
    }

    /// <summary>
    /// A seven tuple with immutable fields that is value based.
    /// </summary>
    [System.Serializable]
    public struct Tuple<T1, T2, T3, T4, T5, T6, T7> : System.IEquatable<Tuple<T1, T2, T3, T4, T5, T6, T7>> 
        where T1 : System.IEquatable<T1>
        where T2 : System.IEquatable<T2>
        where T3 : System.IEquatable<T3>
        where T4 : System.IEquatable<T4>
        where T5 : System.IEquatable<T5>
        where T6 : System.IEquatable<T6>
        where T7 : System.IEquatable<T7> {

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

        public bool Equals(Tuple<T1, T2, T3, T4, T5, T6, T7> other) {
            return item1.Equals(other.item1) && item2.Equals(other.item2) && item3.Equals(other.item3) && item4.Equals(other.item4) &&
                item5.Equals(other.item5) && item6.Equals(other.item6) && item7.Equals(other.item7);
        }
    }

    /// <summary>
    /// An octuple with immutable fields that is value based.
    /// </summary>
    [System.Serializable]
    public struct Tuple<T1, T2, T3, T4, T5, T6, T7, T8> : System.IEquatable<Tuple<T1, T2, T3, T4, T5, T6, T7, T8>> 
        where T1 : System.IEquatable<T1>
        where T2 : System.IEquatable<T2>
        where T3 : System.IEquatable<T3>
        where T4 : System.IEquatable<T4>
        where T5 : System.IEquatable<T5>
        where T6 : System.IEquatable<T6>
        where T7 : System.IEquatable<T7>  {

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

        public bool Equals(Tuple<T1, T2, T3, T4, T5, T6, T7, T8> other) {
            return item1.Equals(other.item1) && item2.Equals(other.item2) && item3.Equals(other.item3) && item4.Equals(other.item4) &&
                item5.Equals(other.item5) && item6.Equals(other.item6) && item7.Equals(other.item7) && item8.Equals(other.item8);
        }
    }
}
