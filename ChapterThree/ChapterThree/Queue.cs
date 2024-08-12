namespace ChapterThree{
    /*
    * Queue: In c# a Queue<T> is a collections type that represents a first-in, first-out (FIFO) data structure.
    -> Part of System.Collections.Generic namespace and used to manage elements where the first element added is the first element removed.
    -> Useful in handling events, message processing, Scheduling jobs
    * Enqueue(): Adds an element to the end of the Queue<T>
    * Dequeue(): Removes and returns the object at the beginning of the Queue<T>
    * Peek(): Returns the object at the beginning of the Queue<T> without removing it.
        */
    public class Queue{
        static void Main(string[] args)
        {
            Queue<string> queue= new Queue<string>();
            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");
            queue.Enqueue("Four");
            queue.Enqueue("Five");
            queue.Dequeue(); // remove the first element One
            queue.Dequeue(); // remove the second element Two
            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}