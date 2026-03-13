using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
// Scenario: Add three items with different priorities and remove them.
// Expected Result: Items are removed from highest priority to lowest.
// Defect(s) Found:
// 1. The loop failed to check the last item in the queue.
// 2. Dequeue returned the value but did not remove it from the queue.
public void TestPriorityQueue_1()
{
    var priorityQueue = new PriorityQueue();

    priorityQueue.Enqueue("A", 1);
    priorityQueue.Enqueue("B", 5);
    priorityQueue.Enqueue("C", 3);

    Assert.AreEqual("B", priorityQueue.Dequeue());
    Assert.AreEqual("C", priorityQueue.Dequeue());
    Assert.AreEqual("A", priorityQueue.Dequeue());
}

    [TestMethod]
// Scenario: Add multiple items with the same priority.
// Expected Result: Items are removed in FIFO order.
// Defect(s) Found:
// 1. Equal priority items were removed in reverse order due to >= comparison.
public void TestPriorityQueue_2()
{
    var priorityQueue = new PriorityQueue();

    priorityQueue.Enqueue("A", 3);
    priorityQueue.Enqueue("B", 3);
    priorityQueue.Enqueue("C", 3);

    Assert.AreEqual("A", priorityQueue.Dequeue());
    Assert.AreEqual("B", priorityQueue.Dequeue());
    Assert.AreEqual("C", priorityQueue.Dequeue());
}

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: An InvalidOperationException should be thrown with the message "The queue is empty."
    // Defect(s) Found:
    // Confirms that the queue properly throws an exception when empty.
public void TestPriorityQueue_EmptyQueue()
{
    var priorityQueue = new PriorityQueue();

    Assert.ThrowsException<InvalidOperationException>(() =>
    {
        priorityQueue.Dequeue();
    });
}
}