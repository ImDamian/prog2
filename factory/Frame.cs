using System;
namespace factory
{
    class Frame {
        public String frameType = "";
        // constructor
        public Frame(String frameType) {
            this.frameType = frameType;
            Console.WriteLine("Een " + frameType + " frame s.v.p.");
        }
    }
}