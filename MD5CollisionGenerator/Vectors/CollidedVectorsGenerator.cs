namespace MD5CollisionGenerator.Vectors
{
    /// <summary>
    /// Actually not generator, but returns two vectors which have MD5 collision
    /// </summary>
    public class CollidedVectorsGenerator
    {
        /// <summary>
        /// Taken from stripwire by Dan Kaminsky
        /// <A href="https://eprint.iacr.org/2004/357.pdf">https://eprint.iacr.org/2004/357.pdf</A>
        /// </summary>
        ///
        /// 
        public static byte[] BaseVector =>
            new byte[]
            {
                0xd1, 0x31, 0xdd, 0x02, 0xc5, 0xe6,
                0xee, 0xc4, 0x69, 0x3d, 0x9a, 0x06,
                0x98, 0xaf, 0xf9, 0x5c, 0x2f, 0xca,
                0xb5, /**/0x87, 0x12, 0x46, 0x7e, 0xab,
                0x40, 0x04, 0x58, 0x3e, 0xb8, 0xfb,
                0x7f, 0x89, 0x55, 0xad, 0x34, 0x06,
                0x09, 0xf4, 0xb3, 0x02, 0x83, 0xe4,
                0x88, 0x83, 0x25, 0x71, 0x41, 0x5a,
                0x08, 0x51, 0x25, 0xe8, 0xf7, 0xcd,
                0xc9, 0x9f, 0xd9, 0x1d, 0xbd, 0xf2,
                0x80, 0x37, 0x3c, 0x5b, 0xd8, 0x82,
                0x3e, 0x31, 0x56, 0x34, 0x8f, 0x5b,
                0xae, 0x6d, 0xac, 0xd4, 0x36, 0xc9,
                0x19, 0xc6, 0xdd, 0x53, 0xe2, 0xb4,
                0x87, 0xda, 0x03, 0xfd, 0x02, 0x39,
                0x63, 0x06, 0xd2, 0x48, 0xcd, 0xa0,
                0xe9, 0x9f, 0x33, 0x42, 0x0f, 0x57,
                0x7e, 0xe8, 0xce, 0x54, 0xb6, 0x70,
                0x80, 0xa8, 0x0d, 0x1e, 0xc6, 0x98,
                0x21, 0xbc, 0xb6, 0xa8, 0x83, 0x93,
                0x96, 0xf9, 0x65, 0x2b, 0x6f, 0xf7,
                0x2a, 0x70
            };

        /// <summary>
        /// Taken from stripwire by Dan Kaminsky
        /// <A href="https://eprint.iacr.org/2004/357.pdf">https://eprint.iacr.org/2004/357.pdf</A>
        /// </summary>
        public static byte[] CollidedVector =>
            new byte[]
            {
                0xd1, 0x31, 0xdd, 0x02, 0xc5, 0xe6, 0xee, 0xc4, 0x69, 0x3d, 0x9a, 0x06, 0x98, 0xaf, 0xf9, 0x5c,
                0x2f, 0xca,
                0xb5, /**/0x07, 0x12, 0x46, 0x7e, 0xab, 0x40, 0x04, 0x58, 0x3e, 0xb8, 0xfb, 0x7f, 0x89, 0x55, 0xad,
                0x34,
                0x06, 0x09, 0xf4, 0xb3, 0x02, 0x83, 0xe4, 0x88, 0x83, 0x25, /**/ 0xf1, 0x41, 0x5a, 0x08, 0x51, 0x25,
                0xe8,
                0xf7, 0xcd, 0xc9, 0x9f, 0xd9, 0x1d, 0xbd, /**/0x72, 0x80, 0x37, 0x3c, 0x5b, 0xd8, 0x82, 0x3e, 0x31,
                0x56,
                0x34, 0x8f, 0x5b, 0xae, 0x6d, 0xac, 0xd4, 0x36, 0xc9, 0x19, 0xc6, 0xdd, 0x53, 0xe2, /**/0x34, 0x87,
                0xda,
                0x03, 0xfd, 0x02, 0x39, 0x63, 0x06, 0xd2, 0x48, 0xcd, 0xa0, 0xe9, 0x9f, 0x33, 0x42, 0x0f, 0x57,
                0x7e, 0xe8,
                0xce, 0x54, 0xb6, 0x70, 0x80, /**/ 0x28, 0x0d, 0x1e, 0xc6, 0x98, 0x21, 0xbc, 0xb6, 0xa8, 0x83, 0x93,
                0x96,
                0xf9, 0x65, /* flag byte*/0xab, 0x6f, 0xf7, 0x2a, 0x70
            };
    }
}